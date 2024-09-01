using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriOrderItem
{
    Task Add(OrderItem item);
    Task Delete(OrderItem item);
    Task Update(OrderItem item);
}
