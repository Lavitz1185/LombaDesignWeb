using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriOrder
{
    Task<Order?> Get(Guid id);
    Task<Order?> GetWithProduk(Guid id);
    Task<List<Order>> GetAll();
    Task<List<Order>> GetAllWithProduk();
    Task<Order?> GetActiveOrder(Guid idAppUser);

    Task Add(Order item);
    Task Delete(Guid id);
}
