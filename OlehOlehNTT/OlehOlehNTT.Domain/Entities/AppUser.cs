using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.ValueObjects;

namespace OlehOlehNTT.Domain.Entities;

public class AppUser : Entity
{
    public string Nama { get; set; }
    public Email Email { get; set; }
    public NoHP NoHP { get; set; }
    public string Alamat { get; set; }

    public List<Order> Orders { get; set; } = new();   

    public AppUser(string nama, Email email, NoHP noHP, string alamat)
    {
        Nama = nama;
        Email = email;
        NoHP = noHP;
        Alamat = alamat;
    }
}
