namespace ArchitectProg.FunctionalExtensions.Services.Interfaces;

public interface IDateTimeFormatter
{
    string FormatDate(DateTimeOffset dateTime);
}