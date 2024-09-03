using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlehOlehNTT.Domain.ValueObjects;

namespace OlehOlehNTT.Infrastructure.Data.ValueConverters;

public class EmailValueConverter : ValueConverter<Email, string>
{
    public EmailValueConverter()
        :base(e => e.Value, s => Email.Create(s).Value)
    {
        
    }
}
