using ArchitectProg.FunctionalExtensions.Services.Interfaces;
using System.Text.Json;
using DotnetJsonSerializer = System.Text.Json.JsonSerializer;

namespace ArchitectProg.FunctionalExtensions.Services;

public class JsonSerializer : IJsonSerializer
{
    private static readonly JsonSerializerOptions jsonSerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public TResult? Deserialize<TResult>(string source, JsonSerializerOptions? options = null)
    {
        var result = DotnetJsonSerializer.Deserialize<TResult>(source, options ?? jsonSerializerOptions);
        return result;
    }

    public string Serialize<TValue>(TValue source, JsonSerializerOptions? options = null)
    {
        var result = DotnetJsonSerializer.Serialize(source, options ?? jsonSerializerOptions);
        return result;
    }
}
