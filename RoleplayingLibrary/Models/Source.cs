namespace RoleplayingLibrary.Models
{
    public class Source : IResource
    {
        public string System { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ComponentSet => "Source";
    }
}
