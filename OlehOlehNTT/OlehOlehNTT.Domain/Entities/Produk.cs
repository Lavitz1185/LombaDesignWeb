using OlehOlehNTT.Domain.Abstraction;
using OlehOlehNTT.Domain.Contracts;

namespace OlehOlehNTT.Domain.Entities;

public class Produk : Entity, IAuditableEntity
{
    public string Nama { get; set; } = string.Empty;
    public string Dekripsi { get; set; } = string.Empty;
    public double Harga { get; set; }
    public int Stok { get; set; }
    public Uri? UrlGambar { get; set; }
    public string? Ukuran { get; set; }
    public string? Warna { get; set; }
    public DateTime AddedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }

    public KategoriProduk? Kategori { get; set; }
}