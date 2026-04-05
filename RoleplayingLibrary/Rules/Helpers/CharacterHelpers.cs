using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RoleplayingLibrary.Rules.Helpers
{
    public class CharacterHelpers
    {
        private static Character _instance;
        private const string Filter = "D&D character files (*.1edndchar)|*.1edndchar|All files (*.*)|*.*";
        private const string Extension = "1edndchar";

        public static Character Character => _instance;

        private CharacterHelpers()
        {
        }

        public static void Initialize(Character character)
        {
            _instance = character;
        }

        public static void New()
        {
            _instance = Character.New();
        }

        public static void Open()
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = Filter,
                DefaultExt = Extension
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = fileDialog.FileName;
                var text = File.ReadAllText(file);

                try
                {
                    var savedCharacter = JsonConvert.DeserializeObject<Character>(text);
                    _instance = savedCharacter;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                if (_instance == null) return;

            }
        }

        public static void Save(Character character)
        {
            var dialog = new SaveFileDialog
            {
                Filter = Filter,
                DefaultExt = Extension,
                FileName = character.Name
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var file = dialog.FileName;
                file = Path.ChangeExtension(file, "1edndchar");


                var text = JsonConvert.SerializeObject(character,
                    Formatting.Indented,
                    new StringEnumConverter());

                File.WriteAllText(path: file, contents: text);
            }
        }
    }
}
