using JCH.Application.Features.Candidates;
using JCH.Domain.Modules.Candidates;
using JCH.Infrastructure.DbContexts;

namespace JCH.Infrastructure.Modules.Candidates;

public class CandidateRepository(AppDbContext dbContext) : ICandidateRepository
{
    public void Add(Candidate entity)
    {
        dbContext.Add(entity);
    }
}

