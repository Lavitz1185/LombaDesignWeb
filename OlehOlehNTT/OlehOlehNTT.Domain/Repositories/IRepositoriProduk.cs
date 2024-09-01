using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriProduk
{
    Task<Produk?> Get(Guid id);
    Task<List<Produk>> GetAll();

    Task Add(Produk produk);
    Task Delete(Guid id);
    Task Update(Produk produk);
}
