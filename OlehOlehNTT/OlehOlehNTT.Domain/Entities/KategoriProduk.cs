using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.Contracts;

namespace OlehOlehNTT.Domain.Entities;

public class KategoriProduk : Entity, IAuditableEntity
{
    public string Nama { get; set; } = string.Empty;
    public DateTime AddetAt { get ; set; }
    public DateTime? ModifiedAt { get; set; }

    public List<Produk> DaftarProduk { get; set; } = new();
}
