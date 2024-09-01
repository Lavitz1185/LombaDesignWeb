using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.DomainErrors;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Domain.Shared;
using OlehOlehNTT.Domain.ValueObjects;

namespace OlehOlehNTT.Domain.Entities;

public class AppUser : Entity
{
    public string Nama { get; set; }
    public Email Email { get; set; }
    public string PasswordHash { get; set; }
    public NoHP NoHP { get; set; }
    public string Alamat { get; set; }

    public List<Order> Orders { get; set; } = new();

    private AppUser(Guid id, string nama, Email email, NoHP noHP, string alamat, string passwordHash)
    {
        Id = id;
        Nama = nama;
        Email = email;
        PasswordHash = passwordHash;
        NoHP = noHP;
        Alamat = alamat;
    }

    public static async Task<Result<AppUser>> Create(
        Guid id, 
        string nama, 
        Email email, 
        NoHP noHP, 
        string alamat, 
        string passwordHash, 
        IRepositoriAppUser repositoriAppUser)
    {
        if (!await repositoriAppUser.IsUnique(email.Value))
            return EmailErrors.NotUnique;

        return new AppUser(id, nama, email, noHP, alamat, passwordHash);
    }
}
