using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.Contracts;
using OlehOlehNTT.Domain.DomainErrors;
using OlehOlehNTT.Domain.Enums;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Domain.Shared;

namespace OlehOlehNTT.Domain.Entities;

public class Order : Entity, IAuditableEntity
{
    private readonly List<DetailOrder> _daftarDetailOrder = new();

    public OrderStatus Status { get; private set; }
    public MetodePembayaran MetodePembayaran { get; set; }
    public DateTime AddedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }

    public double Total => _daftarDetailOrder.Sum(x => x.Total);

    public IReadOnlyList<DetailOrder> DaftarDetailOrder => _daftarDetailOrder;
    public AppUser AppUser { get; set; }
    public Kurir Kurir { get; set; }

    private Order(
        Guid id,
        OrderStatus status)
    {
        Id = id;
        Status = status;
    }

    public static async Task<Result<Order>> CreateAsync(
        Guid id,
        AppUser appUser,
        Kurir kurir,
        MetodePembayaran metodePembayaran,
        IRepositoriOrder repositoriOrder)
    {
        if (await repositoriOrder.GetActiveOrder(appUser.Id) is not null) return OrderErrors.UserAlreadyHaveActiveOrder;

        return new Order(id, OrderStatus.Active) { AppUser = appUser, Kurir = kurir, MetodePembayaran = metodePembayaran };
    }

    public Result AddItem(DetailOrder orderItem)
    {
        if(Status != OrderStatus.Active) return OrderErrors.AddToUnactiveOrder;

        if (orderItem.Jumlah > orderItem.Produk.Stok) return OrderErrors.StokProdukNotEnough;

        var isExist = _daftarDetailOrder.Any(i => i.Produk.Id == orderItem.Id);

        if(isExist) return OrderErrors.AlreadyHaveProduk;

        _daftarDetailOrder.Add(orderItem);
        return Result.Success();
    }

    public Result RemoveItem(DetailOrder orderItem)
    {
        if(Status != OrderStatus.Active) return OrderErrors.RemoveFromUnactiveOrder;

        var isExist = _daftarDetailOrder.Any(i => i.Id == orderItem.Id);

        if(!isExist) return OrderErrors.OrderItemNotExist;
        return Result.Success();
    }

    public void ClearItem()
    {
        _daftarDetailOrder.Clear();
    }

    public Result CheckOut()
    {
        if (Status == OrderStatus.Checkout) return OrderErrors.AlreadyCheckout;

        if (_daftarDetailOrder.Count == 0) return OrderErrors.CheckoutWithEmptyOrderItems;

        foreach (var item in _daftarDetailOrder)
            item.Produk.Stok -= item.Jumlah;

        Status = OrderStatus.Checkout;
        return Result.Success();
    }
}
