using System.Collections.Generic;

namespace RoleplayingLibrary.Models
{
    public sealed class ResourceConnection
    {
        public string ConnectionType { get; set; }
        public string ResourceId { get; set; }
        public List<Tag> Conditions { get; set; } = new List<Tag>();
        public int Priority { get; set; }
    }
}
