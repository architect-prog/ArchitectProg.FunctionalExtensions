using System.Text.Json;

namespace ArchitectProg.FunctionalExtensions.Services.Interfaces;

public interface IJsonSerializer
{
    string Serialize<TValue>(TValue source, JsonSerializerOptions? options = null);
    TResult? Deserialize<TResult>(string source, JsonSerializerOptions? options = null);
}
