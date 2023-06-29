namespace ArchitectProg.FunctionalExtensions.Services.Interfaces;

public interface IDateTimeProvider
{
    DateTimeOffset GetUtcNow();
    DateTimeOffset GetNow();
}