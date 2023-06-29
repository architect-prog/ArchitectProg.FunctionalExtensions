using ArchitectProg.FunctionalExtensions.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace ArchitectProg.FunctionalExtensions.Tests.Extensions;

public class StringExtensionsTests
{
    [TestCase(null, null)]
    [TestCase("", "")]
    [TestCase(" ", " ")]
    [TestCase("Some text", "Some text")]
    [TestCase("Some text", "some text")]
    public void EqualsIgnoreCase_When_Strings_Are_Equal_Should_Return_True(string first, string second)
    {
        var actual = first.EqualsIgnoreCase(second);

        actual.Should().BeTrue();
    }

    [TestCase(null, "")]
    [TestCase(null, "")]
    [TestCase(" ", "")]
    [TestCase("Some text", "Some text1")]
    [TestCase("Some text", "some text1")]
    public void EqualsIgnoreCase_When_Strings_Are_Not_Equal_Should_Return_False(string first, string second)
    {
        var actual = first.EqualsIgnoreCase(second);

        actual.Should().BeFalse();
    }
}