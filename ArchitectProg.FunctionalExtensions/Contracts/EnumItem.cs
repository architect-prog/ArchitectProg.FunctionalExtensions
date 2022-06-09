namespace ArchitectProg.FunctionalExtensions.Contracts;

public class EnumItem
{
    public int Id { get; }
    public string Name { get; }

    public EnumItem(int id, string name)
    {
        Id = id;
        Name = name;
    }
}