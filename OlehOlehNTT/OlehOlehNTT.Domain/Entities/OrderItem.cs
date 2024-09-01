using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.Contracts;

namespace OlehOlehNTT.Domain.Entities;

public class OrderItem : Entity, IAuditableEntity
{
    public int Jumlah { get; set; }
    public DateTime AddetAt { get; set; }
    public DateTime? ModifiedAt { get; set; }

    public decimal TotalHarga => Produk.Harga * Jumlah;

    public Order Order { get; set; }
    public Produk Produk { get; set; }

    public OrderItem(Guid id, Order order, Produk produk, int jumlah)
    {
        Id = id;
        Order = order;
        Produk = produk;
        Jumlah = jumlah;
    }
}
