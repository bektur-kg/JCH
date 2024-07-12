using JCH.Domain.Abstractions;

namespace JCH.Application.Abstractions;

/// <summary>
/// Represents a read-only repository for entities of type <typeparamref name="TEntity"/>.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
public interface IReadRepository<TEntity>
    where TEntity : Entity
{

    /// <summary>
    /// Asynchronously retrieves an entity of type <typeparamref name="TEntity"/> by its email.
    /// </summary>
    /// <param name="email">The email of the entity to retrieve.</param>
    /// <returns>
    /// A Task that represents the asynchronous operation. The task result contains the entity if found;
    /// otherwise, <c>null</c>.
    /// </returns>
    Task<TEntity?> GetByEmailAsync(string email);
}
