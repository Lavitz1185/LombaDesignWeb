using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Infrastructure.Data.ValueConverters;

namespace OlehOlehNTT.Infrastructure.Data.EntityConfigurations;

internal class AppUserEntityConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.Email).HasConversion<EmailValueConverter>();
        builder.Property(x => x.NoHP).HasConversion<NoHPValueConverter>();
    }
}
