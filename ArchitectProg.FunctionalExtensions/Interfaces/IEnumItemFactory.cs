using ArchitectProg.FunctionalExtensions.Contracts;

namespace ArchitectProg.FunctionalExtensions.Interfaces;

public interface IEnumItemFactory
{
    EnumItemsCollection CreateFromEnumType<TEnum>() where TEnum : Enum;
    EnumItem GetEnumItem<TEnum>(TEnum item) where TEnum : Enum;
}