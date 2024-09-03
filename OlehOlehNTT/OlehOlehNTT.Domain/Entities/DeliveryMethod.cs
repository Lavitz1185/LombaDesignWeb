using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.Contracts;

namespace OlehOlehNTT.Domain.Entities;

public class DeliveryMethod : Entity, IAuditableEntity
{
    public string Nama { get; set; } = string.Empty;
    public TimeSpan EstimasiWaktu { get; set; }
    public decimal EstimasiBiaya { get; set; }

    public DateTime AddedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}
