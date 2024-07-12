using JCH.Application.Features.Candidates;
using JCH.Domain.Modules.Candidates;

namespace JCH.Infrastructure.Modules.Candidates;

public class CandidateRepository : ICandidateRepository
{
    private readonly AppDbContext _dbContext;

    public CandidateRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    /// <summary>
    /// Adds a new <see cref="Candidate"/> entity to the database.
    /// </summary>
    /// <param name="entity">The candidate entity to add.</param>
    public void Add(Candidate entity)
    {
        _dbContext.Add(entity);
    }

    /// <summary>
    /// Asynchronously retrieves a <see cref="Candidate"/> entity by its email address.
    /// </summary>
    /// <param name="email">The email address of the candidate to retrieve.</param>
    public Task<Candidate?> GetByEmailAsync(string email)
    {
        return _dbContext.Candidates.FirstOrDefaultAsync(c => c.Email == email);
    }
}