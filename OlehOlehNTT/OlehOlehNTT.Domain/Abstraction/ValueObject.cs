namespace OlehOlehNTT.Domain.Abstraction;

public abstract class ValueObject : IEquatable<ValueObject>
{
    protected abstract IEnumerable<object> GetAtomicValues();

    public override bool Equals(object? obj) => obj is not null && obj is ValueObject other && ValueObjectEquals(other);

    public bool Equals(ValueObject? other) => other is not null && ValueObjectEquals(other);

    public override int GetHashCode() => GetAtomicValues().Aggregate(default(int), HashCode.Combine);

    private bool ValueObjectEquals(ValueObject other) => other.GetAtomicValues().SequenceEqual(GetAtomicValues());

    public static bool operator ==(ValueObject? left, ValueObject? right) => left is not null && left.Equals(right);

    public static bool operator !=(ValueObject? left, ValueObject? right) => !(left == right);
}
