using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.Contracts;
using OlehOlehNTT.Domain.DomainErrors;
using OlehOlehNTT.Domain.Enums;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Domain.Shared;

namespace OlehOlehNTT.Domain.Entities;

public class Order : Entity, IAuditableEntity
{
    private OrderStatus _status;
    private readonly AppUser _appUser;
    private readonly List<OrderItem> _orderItems = new();

    public OrderStatus Status => _status; 
    public PaymentMethod PaymentMethod { get; set; }
    public DateTime AddetAt { get; set; }
    public DateTime? ModifiedAt { get; set; }

    public AppUser AppUser => _appUser;
    public IReadOnlyList<OrderItem> OrderItems => _orderItems;
    public DeliveryMethod DeliveryMethod { get; set; }

    private Order(
        Guid id,
        OrderStatus status, 
        AppUser appUser, 
        PaymentMethod paymentMethod, 
        DeliveryMethod deliveryMethod)
    {
        Id = id;
        PaymentMethod = paymentMethod;
        DeliveryMethod = deliveryMethod;
        _status = status;
        _appUser = appUser;
    }

    public static async Task<Result<Order>> CreateAsync(
        Guid id,
        AppUser appUser, 
        DeliveryMethod deliveryMethod, 
        IRepositoriAppUser repositoriAppUser)
    {
        if (await repositoriAppUser.GetActiveOrder(appUser.Id) is not null) return OrderErrors.UserAlreadyHaveActiveOrder;

        return new Order(id, OrderStatus.Active, appUser, PaymentMethod.Cash, deliveryMethod);
    }
}
