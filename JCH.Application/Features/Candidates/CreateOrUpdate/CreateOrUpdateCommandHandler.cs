using JCH.Application.Abstractions;

namespace JCH.Application.Features.Candidates.CreateOrUpdate;

public class CreateOrUpdateCommandHandler : ICommandHandler<CreateOrUpdateCommand, Result>
{
    private readonly ICandidateRepository _candidateRepository;

    public CreateOrUpdateCommandHandler(ICandidateRepository candidateRepository)
    {
        _candidateRepository = candidateRepository;
    }

    public Task<Result> Handle(CreateOrUpdateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

