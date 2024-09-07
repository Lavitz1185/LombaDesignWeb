using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriAppUser
{
    Task<AppUser?> Get(string email);
    Task<bool> IsUnique(string email);

    void Add(AppUser user);
    void Delete(AppUser user);
    void Update(AppUser user);
}
