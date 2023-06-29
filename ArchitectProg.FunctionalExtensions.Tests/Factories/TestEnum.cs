using System.ComponentModel;

namespace ArchitectProg.FunctionalExtensions.Tests.Factories;

public enum TestEnum
{
    Zero,
    One,
    [Description("2")]
    Two,
    [Description("3")]
    Three
}