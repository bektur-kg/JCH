namespace JCH.Domain.Abstractions;

/// <summary>
/// Represents a base class for entities with an identifier.
/// </summary>
public abstract class Entity
{
    public long Id { get; set; }
}