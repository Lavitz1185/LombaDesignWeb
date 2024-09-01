namespace OlehOlehNTT.Domain.Abstraction;

public abstract class Entity : IEquatable<Entity> 
{
    public Guid Id { get; set; }

    public override bool Equals(object? obj) => obj is not null && obj.GetType() == GetType() && obj is Entity other && other.Id == Id;

    public bool Equals(Entity? other) => other is not null && other.Id == Id;

    public override int GetHashCode() => Id.GetHashCode();

    public static bool operator==(Entity? left, Entity? right) => left is not null && left.Equals(right);

    public static bool operator!=(Entity? left, Entity? right) => !(left == right);
}
