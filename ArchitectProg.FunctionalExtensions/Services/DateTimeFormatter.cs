using System.Globalization;
using ArchitectProg.FunctionalExtensions.Constants;
using ArchitectProg.FunctionalExtensions.Services.Interfaces;

namespace ArchitectProg.FunctionalExtensions.Services;

public class DateTimeFormatter : IDateTimeFormatter
{
    public string FormatDate(DateTimeOffset dateTime)
    {
        var result = FormatDate(dateTime, GenericConstants.Formats.DefaultDateTime);
        return result;
    }

    public string FormatDate(DateTimeOffset dateTime, string dateFormat)
    {
        var result = dateTime.ToString(dateFormat, CultureInfo.InvariantCulture);
        return result;
    }
}