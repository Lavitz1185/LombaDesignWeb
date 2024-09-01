using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;

namespace OlehOlehNTT.Infrastructure.Repositories;

internal class RepositoriDeliveryMethod : IRepositoriDeliveryMethod
{
    public static readonly List<DeliveryMethod> DaftarDeliveryMethod = new();

    public Task<DeliveryMethod?> Get(Guid id) => Task.FromResult(DaftarDeliveryMethod.FirstOrDefault(x => x.Id == id));

    public Task<List<DeliveryMethod>> GetAll() => Task.FromResult(DaftarDeliveryMethod);

    public Task Add(DeliveryMethod deliveryMethod)
    {
        DaftarDeliveryMethod.Add(deliveryMethod);
        return Task.CompletedTask;
    }

    public Task Delete(Guid id)
    {
        var item = DaftarDeliveryMethod.FirstOrDefault(x => x.Id == id);

        if (item != null)
            DaftarDeliveryMethod.Remove(item);

        return Task.CompletedTask;
    }
}
