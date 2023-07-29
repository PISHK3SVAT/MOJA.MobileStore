using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOJA.MobileStore.Persistence.Converters
{
    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter()
            : base(d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
        { }
    }
}
