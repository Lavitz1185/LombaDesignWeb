using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlehOlehNTT.Domain.ValueObjects;

namespace OlehOlehNTT.Infrastructure.Data.ValueConverters;

public class NoHPValueConverter : ValueConverter<NoHP, string>
{
    public NoHPValueConverter()
        :base(n => n.Value, s => NoHP.Create(s).Value)
    {
        
    }
}
