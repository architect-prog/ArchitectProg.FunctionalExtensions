using System.Diagnostics.CodeAnalysis;

namespace ArchitectProg.FunctionalExtensions.Extensions;

public static class EnumerableExtensions
{
    public static Task<T[]> WhenAll<T>(this IEnumerable<Task<T>> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        var result = Task.WhenAll(collection);
        return result;
    }

    public static bool IsEmpty<T>(this IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        return !collection.Any();
    }

    public static bool IsNullOrEmpty<T>([NotNullWhen(false)] this IEnumerable<T>? collection)
    {
        return collection is null || collection.IsEmpty();
    }
}