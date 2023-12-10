using System.Text;

namespace ArchitectProg.FunctionalExtensions.Extensions;

public static class EncodingExtensions
{
    public static ReadOnlyMemory<byte> ToBytes(this string? source)
    {
        if (source.IsNullOrWhiteSpace())
        {
            return ReadOnlyMemory<byte>.Empty;
        }

        var result = Encoding.UTF8.GetBytes(source);
        return result;
    }

    public static string FromBytes(this ReadOnlyMemory<byte> source)
    {
        var result = Encoding.UTF8.GetString(source.ToArray());
        return result;
    }
}
