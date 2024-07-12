using JCH.Application.Features.Candidates;
using JCH.Domain.Modules.Candidates;
using JCH.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace JCH.Infrastructure.Modules.Candidates;

public class CandidateRepository(AppDbContext dbContext) : ICandidateRepository
{
    public void Add(Candidate entity)
    {
        dbContext.Add(entity);
    }

    public Task<Candidate?> GetByEmailAsync(string email)
    {
        return dbContext.Candidates.FirstOrDefaultAsync(c => c.Email == email);
    }
}