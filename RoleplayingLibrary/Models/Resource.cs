using System.Collections.Generic;

namespace RoleplayingLibrary.Models
{
    public sealed class Resource : IResource
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ComponentSet { get; set; }
        public List<TagGroup> Tags { get; set; } = new List<TagGroup>();
        public List<Resource> Bootstraps { get; set; } = new List<Resource>();
        public List<ResourceRule> Rules { get; set; } = new List<ResourceRule>();
        public List<ResourceScript> Scripts { get; set; } = new List<ResourceScript>();
        public List<SourceInfo> SourceIds { get; set; } = new List<SourceInfo>();
    }
}