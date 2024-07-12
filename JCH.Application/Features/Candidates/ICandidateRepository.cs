using JCH.Domain.Modules.Candidates;

namespace JCH.Application.Features.Candidates;

public interface ICandidateRepository : IWriteRepository<Candidate>, IReadRepository<Candidate>;