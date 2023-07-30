using System.Diagnostics.CodeAnalysis;

namespace ArchitectProg.FunctionalExtensions.Extensions;

public static class StringExtensions
{
    public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? source)
    {
        var result = string.IsNullOrWhiteSpace(source);
        return result;
    }

    public static bool EqualsIgnoreCase(this string? first, string? second)
    {
        if (first is null && second is null)
        {
            return true;
        }

        if (first is null || second is null)
        {
            return false;
        }

        var result = first.Equals(second, StringComparison.InvariantCultureIgnoreCase);
        return result;
    }
}