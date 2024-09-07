using Microsoft.EntityFrameworkCore;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Infrastructure.Data;

namespace OlehOlehNTT.Infrastructure.Repositories;

internal class RepositoriMetodePembayaran : IRepositoriMetodePembayaran
{
    private readonly AppDbContext _appDbContext;

    public RepositoriMetodePembayaran(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<MetodePembayaran?> Get(Guid id) => await _appDbContext.TabelMetodePembayaran.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<List<MetodePembayaran>> GetAll() => await _appDbContext.TabelMetodePembayaran.ToListAsync();

    public void Add(MetodePembayaran metodePembayaran) => _appDbContext.TabelMetodePembayaran.Add(metodePembayaran);

    public void Delete(MetodePembayaran metodePembayaran) => _appDbContext.TabelMetodePembayaran.Remove(metodePembayaran);
}
