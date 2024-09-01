using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriAppUser
{
    Task<AppUser?> Get(string email);
    Task<bool> IsUnique(string email);

    Task Add(AppUser user);
    Task Delete(AppUser user);
    Task Update(AppUser user);
}
