using AutoMapper;
using JCH.Domain.Modules.Candidates;
using Microsoft.Extensions.Logging;

namespace JCH.Application.Features.Candidates.CreateOrUpdate;

public class CreateOrUpdateCommandHandler : ICommandHandler<CreateOrUpdateCommand, Result>
{
    private readonly ICandidateRepository _candidateRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CreateOrUpdateCommandHandler> _logger;

    public CreateOrUpdateCommandHandler(
        ICandidateRepository candidateRepository,
        IMapper mapper,
        IUnitOfWork unitOfWork,
        ILogger<CreateOrUpdateCommandHandler> logger)
    {
        _candidateRepository = candidateRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    /// <summary>
    /// Handles the creation or updating of a candidate based on the specified command.
    /// </summary>
    /// <param name="request">The create or update command.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the result of the operation.</returns>
    public async Task<Result> Handle(CreateOrUpdateCommand request, CancellationToken cancellationToken)
    {
        if ((request.Dto.PreferredCallStartDate is not null) ^ (request.Dto.PreferredCallEndDate is not null))
        {
            return Result.Failure(CandidateErrors.NotProvidedBothDates);
        }
        
        if (request.Dto.PreferredCallStartDate >= request.Dto.PreferredCallEndDate)
        {
            return Result.Failure(CandidateErrors.IncorrectTimeInterval);
        }


        var foundCandidate = await _candidateRepository.GetByEmailAsync(request.Dto.Email);

        if (foundCandidate is null)
        {
            var candidate = _mapper.Map<Candidate>(request.Dto);

            _candidateRepository.Add(candidate);
            await _unitOfWork.SaveChangesAsync();

            _logger.LogInformation("Candidate with email: {Email} has been created", request.Dto.Email);

            return Result.Success();
        }

        _mapper.Map(request.Dto, foundCandidate);
        await _unitOfWork.SaveChangesAsync();

        _logger.LogInformation("Candidate with email: {Email} has been updated", request.Dto.Email);


        return Result.Success();
    }
}