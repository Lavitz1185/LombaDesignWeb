using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.DomainErrors;
using OlehOlehNTT.Domain.Shared;
using System.Text.RegularExpressions;

namespace OlehOlehNTT.Domain.ValueObjects;

public partial class Email : ValueObject
{
    public const int MinLength = 5;
    public const int MaxLength = 15;
    public const string ValidRegex = @"^[a-zA-Z]+@[a-zA-Z]+\.[a-z]+$";

    public string Value { get; }

    private Email(string value)
    {
        Value = value;
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    public static Result<Email> Create(string email)
    {
        if (email.Length < MinLength) return EmailErrors.TooShort;

        if (email.Length > MaxLength) return EmailErrors.TooLong;

        if (!Regex().IsMatch(email)) return EmailErrors.Invalid;

        return new Email(email);
    }

    [GeneratedRegex(ValidRegex)]
    private static partial Regex Regex();
}
