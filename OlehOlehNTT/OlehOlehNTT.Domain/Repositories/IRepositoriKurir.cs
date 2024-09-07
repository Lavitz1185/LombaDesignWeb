using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriKurir
{
    Task<Kurir?> Get(Guid id);
    Task<List<Kurir>> GetAll();

    void Add(Kurir kurir);
    void Delete(Kurir kurir);
    void Update(Kurir kurir);
}
