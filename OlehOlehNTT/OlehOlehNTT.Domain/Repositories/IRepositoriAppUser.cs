using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriAppUser
{
    public Task<Order?> GetActiveOrder(Guid id);
}
