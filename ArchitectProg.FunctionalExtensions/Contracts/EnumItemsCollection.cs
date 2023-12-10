namespace ArchitectProg.FunctionalExtensions.Contracts;

public class EnumItemsCollection(IEnumerable<EnumItem> items)
{
    public IEnumerable<EnumItem> Items { get; } = items;
}