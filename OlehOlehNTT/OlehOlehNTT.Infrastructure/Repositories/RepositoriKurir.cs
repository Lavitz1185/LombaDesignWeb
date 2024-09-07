using Microsoft.EntityFrameworkCore;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Infrastructure.Data;

namespace OlehOlehNTT.Infrastructure.Repositories;

internal class RepositoriKurir : IRepositoriKurir
{
    private readonly AppDbContext _appDbContext;

    public RepositoriKurir(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public Task<Kurir?> Get(Guid id) => _appDbContext.TabelKurir.FirstOrDefaultAsync(x => x.Id == id);

    public Task<List<Kurir>> GetAll() => _appDbContext.TabelKurir.ToListAsync();

    public void Add(Kurir kurir) => _appDbContext.TabelKurir.Add(kurir);

    public void Delete(Kurir kurir) => _appDbContext.TabelKurir.Remove(kurir);

    public void Update(Kurir kurir) => _appDbContext.TabelKurir.Update(kurir);
}
