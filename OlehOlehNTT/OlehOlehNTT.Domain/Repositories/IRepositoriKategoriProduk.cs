using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriKategoriProduk
{
    public Task<KategoriProduk?> Get(Guid id);
    public Task<KategoriProduk?> GetWithProduk(Guid id);
    public Task<List<KategoriProduk>> GetAll();
    public Task<List<KategoriProduk>> GetAllWithProduk();

    public Task Add(KategoriProduk kategori);
    public Task Delete(Guid id);
    public Task Update(KategoriProduk kategori);
}
