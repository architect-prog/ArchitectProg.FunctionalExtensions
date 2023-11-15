using ArchitectProg.FunctionalExtensions.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace ArchitectProg.FunctionalExtensions.Tests.Extensions;

[TestFixture]
public class EnumerableExtensionsTests
{
    [TestCase(null)]
    public void WhenAll_When_Collection_Is_Null_Should_Throw_ArgumentNullException(IEnumerable<Task<string>>? collection)
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


    [TestCase(new int[] { 1, 2, 3, 5 }, false)]
    [TestCase(new int[] { }, true)]
    public void IsEmpty_When_Collection_Is_Valid_Should_Return_Expected_Result(IEnumerable<int> collection, bool expected)
    {
        var result = collection.IsEmpty();
        result.Should().Be(expected);
    }

    [TestCase(null)]
    public void IsEmpty_When_Collection_Is_Null_Should_Throw_ArgumentNullException(IEnumerable<int>? collection)
    {
        var act = () => collection.IsEmpty();
        act.Should().ThrowExactly<ArgumentNullException>().WithParameterName(nameof(collection));
    }

    [TestCase(new int[] { 1, 2, 3, 5 }, false)]
    [TestCase(new int[] { }, true)]
    [TestCase(null, true)]
    public void IsNullOrEmpty_When_Collection_Is_Valid_Should_Return_Expected_Result(IEnumerable<int>? collection, bool expected)
    {
        var result = collection.IsNullOrEmpty();
        result.Should().Be(expected);
    }
}