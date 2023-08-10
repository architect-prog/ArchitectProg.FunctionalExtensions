using ArchitectProg.FunctionalExtensions.Extensions;
using FluentAssertions;
using NUnit.Framework;
using System.Text;

namespace ArchitectProg.FunctionalExtensions.Tests.Extensions;

[TestFixture]
public sealed class EncodingExtensionsTests
{
    [TestCase(null)]
    public void ToBytes_When_Argument_Is_Null_Should_Throw_ArgumentNullException(string source)
    {
        var act = source.ToBytes;
        
        act.Should().ThrowExactly<ArgumentNullException>().WithParameterName(nameof(source));
    }

    [Test]
    public void ToBytes_When_Argument_Is_Valid_Should_Return_Expected_Result()
    {
        var source = "test 1";
        byte[] expected = Encoding.UTF8.GetBytes(source);
        
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
