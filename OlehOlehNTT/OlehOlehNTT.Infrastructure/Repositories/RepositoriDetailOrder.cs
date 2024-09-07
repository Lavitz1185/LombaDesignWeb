using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Infrastructure.Data;

namespace OlehOlehNTT.Infrastructure.Repositories;

internal class RepositoriDetailOrder : IRepositoriDetailOrder
{
    private readonly AppDbContext _appDbContext;

    public RepositoriDetailOrder(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void Add(DetailOrder item) => _appDbContext.TabelDetailOrder.Add(item);

    public void Delete(DetailOrder item) => _appDbContext.TabelDetailOrder.Remove(item);

    public void Update(DetailOrder item) => _appDbContext.TabelDetailOrder.Update(item);
}
