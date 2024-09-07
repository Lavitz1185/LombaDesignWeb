using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlehOlehNTT.Domain.Entities;

namespace OlehOlehNTT.Infrastructure.Data.EntityConfigurations;

internal class KurirEntityConfiguration : IEntityTypeConfiguration<Kurir>
{
    public void Configure(EntityTypeBuilder<Kurir> builder)
    {
        builder.HasKey(e => e.Id);
    }
}
