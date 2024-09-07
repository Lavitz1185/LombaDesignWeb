using Microsoft.EntityFrameworkCore;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Infrastructure.Data;

namespace OlehOlehNTT.Infrastructure.Repositories;

internal class RepositoriAppUser : IRepositoriAppUser
{
    private readonly AppDbContext _appDbContext;

    public RepositoriAppUser(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public Task<AppUser?> Get(string email) => _appDbContext.TabelAppUser.FirstOrDefaultAsync(x => x.Email.Value == email);

    public Task<bool> IsUnique(string email) => _appDbContext.TabelAppUser.AnyAsync(x => x.Email.Value == email)!;

    public void Add(AppUser user)
    {
        _appDbContext.TabelAppUser.Add(user);
    }

    public void Delete(AppUser user)
    {
        _appDbContext.TabelAppUser.Remove(user);
    }

    public void Update(AppUser user)
    {
        _appDbContext.TabelAppUser.Update(user);
    }
}
