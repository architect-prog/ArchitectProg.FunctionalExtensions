namespace ArchitectProg.FunctionalExtensions.Contracts;

public class EnumItem(int id, string name)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
}