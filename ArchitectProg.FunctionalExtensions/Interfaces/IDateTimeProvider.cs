namespace DotNet.FunctionalExtensions.Interfaces;

public interface IDateTimeProvider
{
    DateTimeOffset GetUtcNow();
    DateTimeOffset GetNow();
}