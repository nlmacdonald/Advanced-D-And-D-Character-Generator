using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ADandD1ECharacterGenerator.Helpers;
using RoleplayingLibrary;
using RoleplayingLibrary.Rules;

namespace ADandD1ECharacterGenerator.Forms
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
            InitializeComponent();

            ImagesPictureBox.BackgroundImage = ResourceHelper.GetCurrentSettingImage();
        }

        public Character GetCharacter()
        {
            var character = Character.New();
            character.Strength = Convert.ToInt32(StrengthTextBox.Text);
            character.Dexterity = Convert.ToInt32(DexterityTextBox.Text);
            character.Constitution = Convert.ToInt32(ConstitutionTextBox.Text);
            character.Intelligence = Convert.ToInt32(IntelligenceTextBox.Text);
            character.Wisdom = Convert.ToInt32(WisdomTextBox.Text);
            character.Charisma = Convert.ToInt32(CharismaTextBox.Text);

            character.Name = CharacterNameTextBox.Text;
            character.Player = PlayerNameTextBox.Text;

            character.Race = GetComboValue(RaceComboBox);
            character.Languages = GetCollectionFrom(LanguageListBox);

            character.NonWeaponProficiencies = GetCollectionFrom(NonWeaponListBox);
            character.WeaponProficiencies = GetCollectionFrom(WeaponProficiencyListBox);
            // character.SecondarySkills = GetCollectionFrom(LanguageListBox);
            character.Equipment = GetCollectionFrom(GearListBox);
            character.Weapons = GetCollectionFrom(WeaponListBox);
            character.Armour = GetCollectionFrom(ArmourListBox);
            character.MagicItems = GetCollectionFrom(MagicListBox);
            character.Spells = GetCollectionFrom(SpellsListBox);

            character.Abilities = ClassAbilitiesTextBox.Text;
            character.Saves = SavesTextBox.Text;
            character.Stats = StatBlockTextBox.Text;

            character.RaceDetails = RaceDetailsTextBox.Text;
            character.HitPoints = Convert.ToInt32(HitPointTextBox.Text);
            character.ArmourClass = Convert.ToInt32(ArmourClassTextBox.Text);
            character.Thaco = Convert.ToInt32(ThacoTextBox.Text);
            character.Attacks = AttacksTextBox.Text;

            var alignment = GetComboValue(AlignmentComboBox);
            character.Alignment = alignment.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            character.Classes = GetCharacterClasses();

            if (PortraitPictureBox.BackgroundImage != null)
            {
                character.Portrait = JsonImage.ToBase64String(PortraitPictureBox);
            }

            return character;
        }

        public void InitializeFor(Character character)
        {
            StrengthTextBox.Text = $@"{character.Strength}";
            DexterityTextBox.Text = $@"{character.Dexterity}";
            ConstitutionTextBox.Text = $@"{character.Constitution}";
            IntelligenceTextBox.Text = $@"{character.Intelligence}";
            WisdomTextBox.Text = $@"{character.Wisdom}";
            CharismaTextBox.Text = $@"{character.Charisma}";


            RaceDetailsTextBox.Text = character.RaceDetails;
            HitPointTextBox.Text = $@"{character.HitPoints}";
            ArmourClassTextBox.Text = $@"{character.ArmourClass}";
            ThacoTextBox.Text = $@"{character.Thaco}";
            AttacksTextBox.Text = character.Attacks;

            CharacterNameTextBox.Text = character.Name;
            PlayerNameTextBox.Text = character.Player;

            var alignment = string.Join(" ", character.Alignment);

            AssignComboValue(AlignmentComboBox, alignment);
            AssignComboValue(RaceComboBox, character.Race);
            AssignCollectionTo(LanguageListBox, character.Languages);

            AssignCollectionTo(NonWeaponListBox, character.NonWeaponProficiencies);
            AssignCollectionTo(WeaponProficiencyListBox, character.WeaponProficiencies);
            // AssignCollectionTo(LanguageListBox, character.SecondarySkills);
            AssignCollectionTo(GearListBox, character.Equipment);
            AssignCollectionTo(WeaponListBox, character.Weapons);
            AssignCollectionTo(ArmourListBox, character.Armour);
            AssignCollectionTo(MagicListBox, character.MagicItems);
            AssignCollectionTo(SpellsListBox, character.Spells);

            ClassAbilitiesTextBox.Text = character.Abilities;
            SavesTextBox.Text = character.Saves;
            StatBlockTextBox.Text = character.Stats;

            character.Classes.ForEach(m => ClassesListBox.Items.Add(m));

            PortraitPictureBox.BackgroundImage = JsonImage.ToImage(character.Portrait);

            StatsRichTextBox.Text = StatBlockTextBox.Text;
        }

        private List<CharacterClass> GetCharacterClasses()
        {
            var list = new List<CharacterClass>();

            foreach (var item in ClassesListBox.Items)
            {
                list.Add((CharacterClass) item);
            }

            return list;
        }

        private List<string> GetCollectionFrom(ListBox list)
        {
            var values = new List<string>();

            foreach (var item in list.Items)
            {
                values.Add(item.ToString());
            }

            return values;
        }

        private void AssignCollectionTo(ListBox list, List<string> values)
        {
            values.ForEach(m => list.Items.Add(m));
        }

        private string GetComboValue(ComboBox combo)
        {
            var index = combo.SelectedIndex;
            if (index == -1) return "";
            return combo.Items[index].ToString();
        }

        private void AssignComboValue(ComboBox combo, string value)
        {
            var index = -1;

            for (var number = 0; number < combo.Items.Count; number++)
            {
                var text = combo.Items[number].ToString();
                if (text.Equals(value))
                {
                    index = number;
                    break;
                }
            }

            combo.SelectedIndex = index;
        }

        private void MoveLeftButton_Click(object sender, System.EventArgs e)
        {
            ImagesPictureBox.BackgroundImage = ResourceHelper.PreviousSettingImage();
        }

        private void MoveRightButton_Click(object sender, System.EventArgs e)
        {
            ImagesPictureBox.BackgroundImage = ResourceHelper.NextSettingImage();
        }

        private void AddClassButton_Click(object sender, System.EventArgs e)
        {
            var index = ClassComboBox.SelectedIndex;
            if (index == -1) return;
            var @class = ClassComboBox.Items[index].ToString();

            int.TryParse(ClassLevelTextBox.Text, out int level);

            var newClass = new CharacterClass { Level = level, Name = @class };

            ClassesListBox.Items.Add(newClass);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var text = NonWeaponTextBox.Text;
            if (text == null) return;
            NonWeaponListBox.Items.Add(text);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            var text = WeaponProficiencyTextBox.Text;
            if (text == null) return;
            WeaponProficiencyListBox.Items.Add(text);
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            var text = WeaponTextBox.Text;
            if (text == null) return;
            WeaponListBox.Items.Add(text);
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            var text = ArmourTextBox.Text;
            if (text == null) return;
            ArmourListBox.Items.Add(text);
        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            var text = MagicTextBox.Text;
            if (text == null) return;
            MagicListBox.Items.Add(text);
        }

        private void button14_Click(object sender, System.EventArgs e)
        {
            var text = LanguageTextBox.Text;
            if (text == null) return;
            LanguageListBox.Items.Add(text);
        }

        private void button16_Click(object sender, System.EventArgs e)
        {
            var text = SpellTextBox.Text;
            if (text == null) return;
            SpellsListBox.Items.Add(text);
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            ImageHelper.LoadPortrait(PortraitPictureBox);
        }
    }
}
