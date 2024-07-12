namespace JCH.Application.Abstractions;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
