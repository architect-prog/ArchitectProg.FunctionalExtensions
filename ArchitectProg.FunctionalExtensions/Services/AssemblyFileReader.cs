﻿using System.Reflection;
using ArchitectProg.FunctionalExtensions.Extensions;
using ArchitectProg.FunctionalExtensions.Services.Interfaces;

namespace ArchitectProg.FunctionalExtensions.Services;

public class AssemblyFileReader : IAssemblyFileReader
{
    public string GetFileFromCurrentAssembly(string path)
    {
        if (path.IsNullOrWhiteSpace())
        {
            throw new ArgumentNullException(nameof(path));
        }

        var callingAssemblyLocation = Assembly.GetCallingAssembly().Location;

        var assemblyDirectory = Path.GetDirectoryName(callingAssemblyLocation);
        var fileLocation = Path.Join(assemblyDirectory, path);

        using (var stream = new StreamReader(fileLocation))
        {
            var result = stream.ReadToEnd();
            return result;
        }
    }
}