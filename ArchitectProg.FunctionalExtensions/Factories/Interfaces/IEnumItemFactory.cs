using ArchitectProg.FunctionalExtensions.Contracts;

namespace ArchitectProg.FunctionalExtensions.Factories.Interfaces;

public interface IEnumItemFactory
{
    EnumItemsCollection CreateFromEnumType<TEnum>() where TEnum : Enum;
    EnumItem GetEnumItem<TEnum>(TEnum item) where TEnum : Enum;
}