namespace RoleplayingLibrary.Models
{
    public interface IResource
    {
        string Id { get; }
        string Name { get; }
        string Description { get; }
        string ComponentSet { get; }
    }
}
