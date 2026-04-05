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
            using (var fileDialog = new OpenFileDialog
            {
                Filter = Filter,
                DefaultExt = Extension
            })
            {
                if (fileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var file = fileDialog.FileName;

                try
                {
                    var text = File.ReadAllText(file);
                    var savedCharacter = JsonConvert.DeserializeObject<Character>(text);

                    if (savedCharacter == null)
                    {
                        ShowOpenError(file, "The selected file did not contain a character.");
                        return;
                    }

                    _instance = savedCharacter;
                }
                catch (IOException)
                {
                    ShowOpenError(file, "The selected file could not be read.");
                }
                catch (UnauthorizedAccessException)
                {
                    ShowOpenError(file, "The selected file could not be opened because access was denied.");
                }
                catch (JsonException)
                {
                    ShowOpenError(file, "The selected file is not a valid AD&D character file.");
                }
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

        private static void ShowOpenError(string file, string message)
        {
            MessageBox.Show(
                $"{message}{Environment.NewLine}{Environment.NewLine}{file}",
                "Open Character",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
