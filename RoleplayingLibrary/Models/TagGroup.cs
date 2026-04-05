using System.Collections.Generic;

namespace RoleplayingLibrary.Models
{
    public sealed class TagGroup
    {
        public string Group { get; set; }
        public string SubGroup { get; set; }
        public List<Effect> Effects { get; set; } = new List<Effect>();
        public List<MetaData> MetaData { get; set; } = new List<MetaData>();
        public List<Condition> Conditions { get; set; } = new List<Condition>();
    }
}
