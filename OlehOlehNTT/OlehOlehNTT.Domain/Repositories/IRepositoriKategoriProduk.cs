using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriKategoriProduk
{
    Task<KategoriProduk?> Get(Guid id);
    Task<KategoriProduk?> GetWithProduk(Guid id);
    Task<List<KategoriProduk>> GetAll();
    Task<List<KategoriProduk>> GetAllWithProduk();

    void Add(KategoriProduk kategori);
    void Delete(KategoriProduk kategori);
    void Update(KategoriProduk kategori);
}
