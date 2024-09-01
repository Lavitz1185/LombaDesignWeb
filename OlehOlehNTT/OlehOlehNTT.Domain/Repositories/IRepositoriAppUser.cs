using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Domain.Repositories;

public interface IRepositoriAppUser
{
    Task<AppUser?> Get(string email);
    Task<bool> IsUnique(string email);
}
