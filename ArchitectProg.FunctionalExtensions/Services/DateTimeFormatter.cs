using System.Globalization;
using ArchitectProg.FunctionalExtensions.Constants;
using ArchitectProg.FunctionalExtensions.Services.Interfaces;

namespace ArchitectProg.FunctionalExtensions.Services;

public class DateTimeFormatter : IDateTimeFormatter
{
    public string FormatDate(DateTimeOffset dateTime)
    {
        var result = dateTime.ToString(GenericConstants.Formats.DefaultDateTime, CultureInfo.InvariantCulture);
        return result;
    }
}