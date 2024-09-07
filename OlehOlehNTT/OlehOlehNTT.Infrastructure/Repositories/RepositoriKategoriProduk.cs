using Microsoft.EntityFrameworkCore;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Infrastructure.Data;

namespace OlehOlehNTT.Infrastructure.Repositories;

internal class RepositoriKategoriProduk : IRepositoriKategoriProduk
{
    private readonly AppDbContext _appDbContext;

    public RepositoriKategoriProduk(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<KategoriProduk?> Get(Guid id) => 
        await _appDbContext.TabelKategoriProduk
            .FirstOrDefaultAsync(k => k.Id == id);

    public async Task<KategoriProduk?> GetWithProduk(Guid id) =>
        await _appDbContext.TabelKategoriProduk
            .Include(k => k.DaftarProduk)
            .FirstOrDefaultAsync(k => k.Id == id);

    public async Task<List<KategoriProduk>> GetAll() => await _appDbContext.TabelKategoriProduk.ToListAsync();

    public async Task<List<KategoriProduk>> GetAllWithProduk() => 
        await _appDbContext.TabelKategoriProduk
            .Include(k => k.DaftarProduk)
            .ToListAsync();

    public void Add(KategoriProduk kategori) => _appDbContext.TabelKategoriProduk.Add(kategori);

    public void Delete(KategoriProduk kategori) => _appDbContext.TabelKategoriProduk.Remove(kategori);

    public void Update(KategoriProduk kategori) => _appDbContext.TabelKategoriProduk.Update(kategori);
}
