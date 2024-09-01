using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriDeliveryMethod
{
    Task<DeliveryMethod?> Get(Guid id);
    Task<List<DeliveryMethod>> GetAll();

    Task Add(DeliveryMethod deliveryMethod);
    Task Delete(Guid id);
    Task Update(DeliveryMethod deliveryMethod);
}
