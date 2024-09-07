using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriDetailOrder
{
    void Add(DetailOrder item);
    void Delete(DetailOrder item);
    void Update(DetailOrder item);
}
