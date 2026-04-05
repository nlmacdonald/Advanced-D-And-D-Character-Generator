namespace RoleplayingLibrary.Models
{
    public sealed class ResourceScript
    {
        public string ScriptType { get; set; }
        public string Phase { get; set; }
        public int Priority { get; set; }
        public string Code { get; set; }
    }
}
