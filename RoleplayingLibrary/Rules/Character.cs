using System.Collections.Generic;

namespace RoleplayingLibrary.Rules
{
    public class Character
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public string Name { get; set; }
        public string Player { get; set; }
        public string Race { get; set; }

        public List<CharacterClass> Classes { get; set; } = new List<CharacterClass>();

        public List<string> Alignment { get; set; } = new List<string>();

        public string Abilities { get; set; }
        public string Saves { get; set; }
        public string Stats { get; set; }
        public string RaceDetails { get; set; }

        public int HitPoints { get; set; }
        public int ArmourClass { get; set; }
        public int Thaco { get; set; }
        public string Attacks { get; set; }
        public string Portrait { get; set; }

        public List<string> Languages { get; set; } = new List<string>();
        public List<string> NonWeaponProficiencies { get; set; } = new List<string>();
        public List<string> WeaponProficiencies { get; set; } = new List<string>();
        public List<string> SecondarySkills { get; set; } = new List<string>();
        public List<string> Equipment { get; set; } = new List<string>();
        public List<string> Weapons { get; set; } = new List<string>();
        public List<string> Armour { get; set; } = new List<string>();
        public List<string> MagicItems { get; set; } = new List<string>();
        public List<string> Spells { get; set; } = new List<string>();

        public static Character New()
        {
            return new Character();
        }
    }
}
