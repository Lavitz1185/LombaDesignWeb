using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Infrastructure.Data.EntityConfigurations;

internal class ProdukEntityConfiguration : IEntityTypeConfiguration<Produk>
{
    public void Configure(EntityTypeBuilder<Produk> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Kategori).WithMany(x => x.DaftarProduk);
    }
}
