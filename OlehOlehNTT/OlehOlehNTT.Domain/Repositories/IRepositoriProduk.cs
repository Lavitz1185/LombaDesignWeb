using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriProduk
{
    Task<Produk?> Get(Guid id);
    Task<List<Produk>> GetAll();

    void Add(Produk produk);
    void Delete(Produk produk);
    void Update(Produk produk);
}
