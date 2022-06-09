namespace ArchitectProg.FunctionalExtensions.Extensions;

public static class EnumerableExtensions
{
    public static Task<T[]> WhenAll<T>(this IEnumerable<Task<T>> collection)
    {
        if (collection == null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        var result = Task.WhenAll(collection);
        return result;
    }
}