namespace ArchitectProg.FunctionalExtensions.Services.Interfaces;

public interface IAssemblyFileReader
{
    string GetFileFromCurrentAssembly(string path);
}