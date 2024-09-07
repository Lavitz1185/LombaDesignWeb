using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Infrastructure.Data.EntityConfigurations;

internal class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);
        builder.HasOne(o => o.AppUser).WithMany(a => a.Orders);
        builder.HasOne(o => o.MetodePembayaran).WithMany();
        builder.HasOne(o => o.Kurir).WithMany();
        builder.HasMany(o => o.DaftarDetailOrder).WithOne(o => o.Order);
    }
}
