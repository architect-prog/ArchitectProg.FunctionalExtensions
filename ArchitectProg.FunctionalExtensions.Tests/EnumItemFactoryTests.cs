using ArchitectProg.FunctionalExtensions.Contracts;
using ArchitectProg.FunctionalExtensions.Factories;
using ArchitectProg.FunctionalExtensions.Tests.TestData;
using FluentAssertions;
using NUnit.Framework;

namespace ArchitectProg.FunctionalExtensions.Tests;

[TestFixture]
public class EnumItemFactoryTests
{
    private EnumItemFactory enumItemFactory = null!;

    [SetUp]
    public void Setup()
    {
        enumItemFactory = new EnumItemFactory();
    }

    [Test]
    public void GetEnumItem_When_Item_Is_Valid_Return_Expected()
    {
        var expected = new EnumItem(1, "One");

        var result = enumItemFactory.GetEnumItem(TestEnum.One);

        result.Should().BeEquivalentTo(expected);
    }

    [Test]
    public void CreateFromEnumType_When_Item_Is_Valid_ReturnViewModel()
    {
        var items = new List<EnumItem>()
        {
            new(0, "Zero"),
            new(1, "One"),
            new(2, "2"),
            new(3, "3")
        };

        var expected = new EnumItemsCollection(items);

        var result = enumItemFactory.CreateFromEnumType<TestEnum>();

        result.Should().BeEquivalentTo(expected);
    }
}