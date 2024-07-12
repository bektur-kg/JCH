using JCH.Application.Abstractions;
using JCH.Application.Contracts.Candidates;

namespace JCH.Application.Features.Candidates.CreateOrUpdate;

public record CreateOrUpdateCommand(CreateCandidateRequest dto) : ICommand<Result>;