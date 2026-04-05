namespace RoleplayingLibrary.Rules
{
    public class CharacterClass
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"{Name} {Level}";
        }
    }
}
