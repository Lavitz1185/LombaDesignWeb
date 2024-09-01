using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.DomainErrors;
using OlehOlehNTT.Domain.Shared;
using System.Text.RegularExpressions;

namespace OlehOlehNTT.Domain.ValueObjects;

public partial class NoHP : ValueObject
{
    public const int ValidLength = 12;
    public const string ValidRegex = @"^08[0-9]+$";

    public string Value { get; }

    private NoHP(string value)
    {
        Value = value;
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    public static Result<NoHP> Create(string noHP)
    {
        if (noHP.Length != ValidLength) return NoHPErrors.InvalidLength;

        if (!Regex().IsMatch(noHP)) return NoHPErrors.InvalidLength;

        return new NoHP(noHP);
    }

    [GeneratedRegex(ValidRegex)]
    private static partial Regex Regex();
}
