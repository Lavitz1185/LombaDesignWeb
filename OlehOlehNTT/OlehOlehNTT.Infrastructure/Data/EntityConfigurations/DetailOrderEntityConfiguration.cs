using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Infrastructure.Data.EntityConfigurations;

internal class DetailOrderEntityConfiguration : IEntityTypeConfiguration<DetailOrder>
{
    public void Configure(EntityTypeBuilder<DetailOrder> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Produk).WithMany();
        builder.HasOne(x => x.Order).WithMany();
    }
}
