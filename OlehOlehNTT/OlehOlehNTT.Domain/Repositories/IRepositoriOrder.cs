using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriOrder
{
    Task<Order?> Get(Guid id);
    Task<Order?> GetWithDetailOrder(Guid id);
    Task<List<Order>> GetAll();
    Task<List<Order>> GetAllWithDetailOrder();
    Task<Order?> GetActiveOrder(Guid idAppUser);

    void Add(Order item);
    void Delete(Order item);
    void Update(Order item);
}
