using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.Contracts;
using OlehOlehNTT.Domain.DomainErrors;
using OlehOlehNTT.Domain.Enums;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Domain.Shared;

namespace OlehOlehNTT.Domain.Entities;

public class Order : Entity, IAuditableEntity
{
    private readonly List<OrderItem> _orderItems = new();

    public OrderStatus Status { get; private set; }
    public PaymentMethod PaymentMethod { get; set; }
    public DateTime AddedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }

    public double Total => _orderItems.Sum(x => x.Total);

    public IReadOnlyList<OrderItem> OrderItems => _orderItems;
    public AppUser AppUser { get; set; }
    public DeliveryMethod DeliveryMethod { get; set; }

    private Order(
        Guid id,
        OrderStatus status, 
        PaymentMethod paymentMethod)
    {
        Id = id;
        PaymentMethod = paymentMethod;
        Status = status;
    }

    public static async Task<Result<Order>> CreateAsync(
        Guid id,
        AppUser appUser,
        DeliveryMethod deliveryMethod,
        IRepositoriOrder repositoriOrder)
    {
        if (await repositoriOrder.GetActiveOrder(appUser.Id) is not null) return OrderErrors.UserAlreadyHaveActiveOrder;

        return new Order(id, OrderStatus.Active, PaymentMethod.Cash) { AppUser = appUser, DeliveryMethod = deliveryMethod };
    }

    public Result AddItem(OrderItem orderItem)
    {
        if(Status != OrderStatus.Active) return OrderErrors.AddToUnactiveOrder;

        if (orderItem.Jumlah > orderItem.Produk.Stok) return OrderErrors.StokProdukNotEnough;

        var isExist = _orderItems.Any(i => i.Produk.Id == orderItem.Id);

        if(isExist) return OrderErrors.AlreadyHaveProduk;

        _orderItems.Add(orderItem);
        return Result.Success();
    }

    public Result RemoveItem(OrderItem orderItem)
    {
        if(Status != OrderStatus.Active) return OrderErrors.RemoveFromUnactiveOrder;

        var isExist = _orderItems.Any(i => i.Id == orderItem.Id);

        if(!isExist) return OrderErrors.OrderItemNotExist;
        return Result.Success();
    }

    public void ClearItem()
    {
        _orderItems.Clear();
    }

    public Result CheckOut()
    {
        if (Status == OrderStatus.Checkout) return OrderErrors.AlreadyCheckout;

        if (_orderItems.Count == 0) return OrderErrors.CheckoutWithEmptyOrderItems;

        foreach (var item in _orderItems)
            item.Produk.Stok -= item.Jumlah;

        Status = OrderStatus.Checkout;
        return Result.Success();
    }
}
