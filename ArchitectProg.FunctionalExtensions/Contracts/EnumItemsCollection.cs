namespace ArchitectProg.FunctionalExtensions.Contracts;

public class EnumItemsCollection
{
    public IEnumerable<EnumItem> Items { get; }

    public EnumItemsCollection(IEnumerable<EnumItem> items)
    {
        Items = items;
    }
}