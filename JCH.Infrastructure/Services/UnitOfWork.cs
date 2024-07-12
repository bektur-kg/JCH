namespace JCH.Infrastructure.Services;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _dbContext;

    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    ///<inheritdoc/>
    public Task<int> SaveChangesAsync() => _dbContext.SaveChangesAsync();
}