using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Infrastructure.Data.EntityConfigurations;

internal class MetodePembayaranEntityConfiguration : IEntityTypeConfiguration<MetodePembayaran>
{
    public void Configure(EntityTypeBuilder<MetodePembayaran> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
