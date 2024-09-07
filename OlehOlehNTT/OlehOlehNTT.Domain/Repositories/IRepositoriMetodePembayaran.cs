using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriMetodePembayaran
{
    Task<MetodePembayaran?> Get(Guid id);
    Task<List<MetodePembayaran>> GetAll();

    void Add(MetodePembayaran metodePembayaran);
    void Delete(MetodePembayaran metodePembayaran);
}
