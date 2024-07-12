using JCH.Domain.Abstractions;

namespace JCH.Application.Abstractions;

public interface IWriteRepository<TEntity>
    where TEntity : Entity
{
    /// <summary>
    /// Adds a new entity of type <typeparamref name="TEntity"/> to the database.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    void Add(TEntity entity);
}
