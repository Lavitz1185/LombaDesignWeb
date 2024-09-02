using Microsoft.AspNetCore.Identity;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;

namespace OlehOlehNTT.Infrastructure.Repositories;

internal class RepositoriAppUser : IRepositoriAppUser
{
    public static readonly List<AppUser> DaftarAppUser = new();

    public Task<AppUser?> Get(string email) => Task.FromResult(DaftarAppUser.FirstOrDefault(x => x.Email.Value == email));

    public Task<bool> IsUnique(string email) => Task.FromResult(DaftarAppUser.All(x => x.Email.Value != email));


    public Task Add(AppUser user)
    {
        throw new NotImplementedException();
    }

    public Task Delete(AppUser user)
    {
        throw new NotImplementedException();
    }

    public Task Update(AppUser user)
    {
        throw new NotImplementedException();
    }
}
