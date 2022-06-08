using DotNet.FunctionalExtensions.Interfaces;

namespace DotNet.FunctionalExtensions.Services;

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