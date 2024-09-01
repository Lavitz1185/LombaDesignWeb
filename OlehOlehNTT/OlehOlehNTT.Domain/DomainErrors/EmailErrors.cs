using OlehOlehNTT.Domain.Shared;
using OlehOlehNTT.Domain.ValueObjects;

namespace OlehOlehNTT.Domain.DomainErrors;

public static class EmailErrors
{
    public static readonly Error TooShort = new("Email.TooShort", $"Panjang email minimal {Email.MinLength} karakter");
    public static readonly Error TooLong = new("Email.TooLong", $"Panjang email maksimal {Email.MaxLength} karakter");
    public static readonly Error Invalid = new("Email.Invalid", "Email tidak valid");
}
