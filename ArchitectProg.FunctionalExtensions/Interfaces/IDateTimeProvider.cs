namespace ArchitectProg.FunctionalExtensions.Interfaces;

public interface IDateTimeProvider
{
    DateTimeOffset GetUtcNow();
    DateTimeOffset GetNow();
}