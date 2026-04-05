using System.Collections.Generic;

namespace RoleplayingLibrary.Models
{
    public sealed class ResourceRule
    {
        public string RuleType { get; set; }
        public string Phase { get; set; }
        public int Priority { get; set; }
        public List<Tag> Conditions { get; set; } = new List<Tag>();
        public Dictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();
    }
}
