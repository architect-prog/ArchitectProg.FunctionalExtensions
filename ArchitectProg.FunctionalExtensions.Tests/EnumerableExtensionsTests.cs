using ArchitectProg.FunctionalExtensions.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace ArchitectProg.FunctionalExtensions.Tests;

[TestFixture]
public class EnumerableExtensionsTests
{
    [TestCase(null)]
    public void WhenAll_When_Collection_Is_Null_Should_Throw_ArgumentNullException(IEnumerable<Task<string>> collection)
    {
        var act = () => collection.WhenAll();

        act.Should().ThrowAsync<ArgumentNullException>().WithParameterName(nameof(collection));
    }

    [Test]
    public async Task WhenAll_When_Collection_Is_Valid_Should_Return_Expected()
    {
        var collection = new List<Task<bool>>
        {
            Task.Run(() => true)
        };

        var expected = await Task.WhenAll(collection);

        var result = await collection.WhenAll();

        result.Should().BeEquivalentTo(expected);
    }
}