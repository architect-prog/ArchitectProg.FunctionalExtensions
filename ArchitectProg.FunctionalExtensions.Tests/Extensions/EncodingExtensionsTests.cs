using ArchitectProg.FunctionalExtensions.Extensions;
using FluentAssertions;
using NUnit.Framework;
using System.Text;

namespace ArchitectProg.FunctionalExtensions.Tests.Extensions;

[TestFixture]
public sealed class EncodingExtensionsTests
{
    [TestCase("", new byte[0])]
    [TestCase(" ", new byte[0])]
    [TestCase(null, new byte[0])]
    [TestCase("some text", new byte[] { 0x73, 0x6F, 0x6D, 0x65, 0x20, 0x74, 0x65, 0x78, 0x74 })]
    public void ToBytes_When_Argument_Is_Valid_Should_Return_Expected_Result(string? source, byte[] expected)
    {
        var result = source.ToBytes().ToArray();

        result.Should().BeEquivalentTo(expected);
    }

    [Test]
    public void FromBytes_When_Argument_Is_Valid_Should_Return_Expected_Result()
    {
        var expected = "test 1";
        ReadOnlyMemory<byte> encodedString = Encoding.UTF8.GetBytes(expected);

        var result = encodedString.FromBytes();

        result.Should().Be(expected);
    }
}