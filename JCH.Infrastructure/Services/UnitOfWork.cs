using JCH.Application.Abstractions;
using JCH.Infrastructure.DbContexts;

namespace JCH.Infrastructure.Services;

public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
{
    public Task<int> SaveChangesAsync() => dbContext.SaveChangesAsync();
}

