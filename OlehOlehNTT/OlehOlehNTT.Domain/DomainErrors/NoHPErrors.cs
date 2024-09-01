using OlehOlehNTT.Domain.Shared;
using OlehOlehNTT.Domain.ValueObjects;

namespace OlehOlehNTT.Domain.DomainErrors;

public static class NoHPErrors
{
    public static readonly Error InvalidLength = new("NoHP.InvalidLength", $"Panjang Nomor HP harus {NoHP.ValidLength}");
    public static readonly Error InvalidPattern = new("NoHP.InvalidPattern", "Nomor HP tidak valid");
}
