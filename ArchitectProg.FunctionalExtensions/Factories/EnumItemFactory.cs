using ArchitectProg.FunctionalExtensions.Contracts;
using ArchitectProg.FunctionalExtensions.Extensions;
using ArchitectProg.FunctionalExtensions.Interfaces;

namespace ArchitectProg.FunctionalExtensions.Factories;

public class EnumItemFactory : IEnumItemFactory
{
    public EnumItemsCollection CreateFromEnumType<TEnum>() where TEnum : Enum
    {
        var items = Enum.GetValues(typeof(TEnum))
            .Cast<TEnum>()
            .Select(x => GetEnumItem(x))
            .ToArray();

        var result = new EnumItemsCollection(items);
        return result;
    }

    public EnumItem GetEnumItem<TEnum>(TEnum item) where TEnum : Enum
    {
        var itemId = item.ToEnumNumber();
        var displayName = item.GetDescription();

        var result = new EnumItem(itemId, displayName);
        return result;
    }
}