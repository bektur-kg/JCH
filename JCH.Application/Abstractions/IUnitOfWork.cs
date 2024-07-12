namespace JCH.Application.Abstractions;

/// <summary>
/// Represents a unit of work that coordinates the writing of changes to the database.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Asynchronously saves all changes made in this unit of work to the database.
    /// </summary>
    Task<int> SaveChangesAsync();
}