using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.Contracts;

namespace OlehOlehNTT.Domain.Entities;

public class OrderItem : Entity, IAuditableEntity
{
    public int Jumlah { get; set; }
    public DateTime AddedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }

    public double Total => Produk.Harga * Jumlah;

    public Order Order { get; set; }
    public Produk Produk { get; set; }
}
