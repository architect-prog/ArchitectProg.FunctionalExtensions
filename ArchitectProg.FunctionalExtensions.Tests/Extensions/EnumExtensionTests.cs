using ArchitectProg.FunctionalExtensions.Extensions;
using ArchitectProg.FunctionalExtensions.Tests.Factories;
using FluentAssertions;
using NUnit.Framework;

namespace ArchitectProg.FunctionalExtensions.Tests.Extensions;

[TestFixture]
public class EnumExtensionTests
{
    [TestCase(TestEnum.One, 1)]
    [TestCase(TestEnum.Two, 2)]
    public void ToEnumNumber_When_Values_Is_Valid_Should_Return_Expected(TestEnum source, int expected)
    {
        var result = source.ToEnumNumber();

        result.Should().Be(expected);
    }

    [TestCase(0, true)]
    [TestCase(1, true)]
    [TestCase(-1, false)]
    [TestCase(100, false)]
    public void IsDefined_Should_Return_Expected(int number, bool isExist)
    {
        var result = number.IsDefined<TestEnum>();

        result.Should().Be(isExist);
    }

    [TestCase(-1)]
    [TestCase(100)]
    public void ToEnum_When_Value_Is_Not_Defined_Should_Throw_ArgumentException(int number)
    {
        var act = () => number.ToEnum<TestEnum>();

        act.Should().ThrowExactly<ArgumentException>();
    }

    [TestCase(0, TestEnum.Zero)]
    [TestCase(1, TestEnum.One)]
    [TestCase(3, TestEnum.Three)]
    public void ToEnum_When_Value_Is_Defined_Should_Return_Expected(int number, TestEnum expected)
    {
        var result = number.ToEnum<TestEnum>();

        result.Should().Be(expected);
    }

    [TestCase(TestEnum.Zero, "Zero")]
    [TestCase(TestEnum.One, "One")]
    [TestCase(TestEnum.Two, "2")]
    [TestCase(TestEnum.Three, "3")]
    public void GetDescription_Should_Return_Expected(TestEnum enumItem, string expected)
    {
        var result = enumItem.GetDescription();

        result.Should().Be(expected);
    }
}