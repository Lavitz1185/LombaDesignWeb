using Microsoft.EntityFrameworkCore;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Infrastructure.Data;

namespace OlehOlehNTT.Infrastructure.Repositories;

internal class RepositoriProduk : IRepositoriProduk
{
    private readonly AppDbContext _appDbContext;

    public RepositoriProduk(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Produk?> Get(Guid id) => 
        await _appDbContext.TabelProduk
            .Include(p => p.Kategori)
            .FirstOrDefaultAsync(p => p.Id == id);

    public async Task<List<Produk>> GetAll() => 
        await _appDbContext.TabelProduk
            .Include(p => p.Kategori)
            .ToListAsync();

    public void Add(Produk produk) => _appDbContext.TabelProduk.Add(produk);

    public void Delete(Produk produk) => _appDbContext.TabelProduk.Remove(produk);

    public void Update(Produk produk) => _appDbContext.TabelProduk.Update(produk);
}
