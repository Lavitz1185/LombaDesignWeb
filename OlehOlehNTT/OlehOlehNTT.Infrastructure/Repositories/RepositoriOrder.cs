using Microsoft.EntityFrameworkCore;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Enums;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Infrastructure.Data;

namespace OlehOlehNTT.Infrastructure.Repositories;

internal class RepositoriOrder : IRepositoriOrder
{
    private readonly AppDbContext _appDbContext;

    public RepositoriOrder(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Order?> Get(Guid id) => await _appDbContext.TabelOrder.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<Order?> GetWithDetailOrder(Guid id) => 
        await _appDbContext.TabelOrder
            .Include(x => x.DaftarDetailOrder)
            .FirstOrDefaultAsync(x => x.Id == id);

    public async Task<Order?> GetActiveOrder(Guid idAppUser) =>
        await _appDbContext.TabelOrder
            .Include(x => x.DaftarDetailOrder)
            .FirstOrDefaultAsync(x => x.Status == OrderStatus.Active && x.AppUser.Id == idAppUser);

    public async Task<List<Order>> GetAll() => await _appDbContext.TabelOrder.ToListAsync();

    public async Task<List<Order>> GetAllWithDetailOrder() => 
        await _appDbContext.TabelOrder
            .Include(x => x.DaftarDetailOrder)
            .ToListAsync();

    public void Add(Order item) => _appDbContext.TabelOrder.Add(item);

    public void Delete(Order item) => _appDbContext.TabelOrder.Remove(item);

    public void Update(Order item) => _appDbContext.TabelOrder.Update(item);
}
