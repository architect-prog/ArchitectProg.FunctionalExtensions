using System.ComponentModel;

namespace ArchitectProg.FunctionalExtensions.Extensions;

public static class EnumExtensions
{
    public static TEnum ToEnum<TEnum>(this int source) where TEnum : Enum
    {
        if (!source.IsDefined<TEnum>())
        {
            throw new ArgumentException($"Item with number {source} not defined in enum of type: {typeof(TEnum)}");
        }

        var result = (TEnum)Enum.ToObject(typeof(TEnum), source);
        return result;
    }

    public static int ToEnumNumber<TEnum>(this TEnum source) where TEnum : Enum
    {
        var result = (int)Enum.Parse(typeof(TEnum), source.ToString());
        return result;
    }

    public static bool IsDefined<TEnum>(this int source) where TEnum : Enum
    {
        var result = Enum.IsDefined(typeof(TEnum), source);
        return result;
    }

    public static string GetDescription<TEnum>(this TEnum enumItem) where TEnum : Enum
    {
        var selectedType = typeof(TEnum).GetField(enumItem.ToString());

        var descriptionAttribute = selectedType?
            .GetCustomAttributes(typeof(DescriptionAttribute), false)
            .FirstOrDefault() as DescriptionAttribute;

        var result = descriptionAttribute?.Description ?? enumItem.ToString();
        return result;
    }
}