using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriProduk
{
    public Task<Produk?> Get(Guid id);
    public Task<List<Produk>> GetAll();

    public Task Add(Produk produk);
    public Task Delete(Guid id);
}
