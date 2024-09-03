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

    public async Task<List<Produk>> GetAll() => await _appDbContext.TabelProduk.ToListAsync();

    public Task Update(Produk produk)
    {
        throw new NotImplementedException();
    }

    public Task Add(Produk produk)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
