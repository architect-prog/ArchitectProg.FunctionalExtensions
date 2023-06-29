using ArchitectProg.FunctionalExtensions.Services.Interfaces;

namespace ArchitectProg.FunctionalExtensions.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTimeOffset GetUtcNow()
    {
        var result = DateTimeOffset.UtcNow;
        return result;
    }

    public DateTimeOffset GetNow()
    {
        var result = DateTimeOffset.Now;
        return result;
    }
}