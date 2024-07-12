using JCH.Domain.Abstractions;

namespace JCH.Application.Abstractions;

/// <summary>
/// Represents a write-only repository for entities of type <typeparamref name="TEntity"/>.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
public interface IWriteRepository<TEntity>
    where TEntity : Entity
{
    /// <summary>
    /// Adds a new entity of type <typeparamref name="TEntity"/> to the database.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    void Add(TEntity entity);
}
