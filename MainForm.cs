using System;
using System.Windows.Forms;
using ADandD1ECharacterGenerator.Forms;
using ADandD1ECharacterGenerator.Helpers;
using RoleplayingLibrary.Rules.Helpers;

namespace ADandD1ECharacterGenerator
{
    public partial class MainForm : Form
    {
        private MainPanel _panel;

        public MainForm()
        {
            InitializeComponent();

            ResourceHelper.InitializeSettingImages();

            var panel = new MainPanel
            {
                Dock = DockStyle.Fill
            };

            _panel = panel;

            CharacterTabPage.Controls.Add(panel);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResourceHelper.CloseImages();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharacterHelpers.Open();

            if (CharacterHelpers.Character != null)
            {
                _panel.InitializeFor(CharacterHelpers.Character);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var character = _panel.GetCharacter();
            CharacterHelpers.Save(character);
        }
    }
}
