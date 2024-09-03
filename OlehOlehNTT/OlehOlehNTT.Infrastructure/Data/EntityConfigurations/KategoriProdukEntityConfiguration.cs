using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Infrastructure.Data.EntityConfigurations;

internal class KategoriProdukEntityConfiguration : IEntityTypeConfiguration<KategoriProduk>
{
    public void Configure(EntityTypeBuilder<KategoriProduk> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasMany(x => x.DaftarProduk).WithOne(x => x.Kategori);
    }
}
