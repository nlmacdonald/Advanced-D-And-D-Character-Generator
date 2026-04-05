
namespace ADandD1ECharacterGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AppMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AppStatusStrip = new System.Windows.Forms.StatusStrip();
            this.CharactersTabControl = new System.Windows.Forms.TabControl();
            this.CharacterTabPage = new System.Windows.Forms.TabPage();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BannerPictureBox = new System.Windows.Forms.PictureBox();
            this.AppMenuStrip.SuspendLayout();
            this.CharactersTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AppMenuStrip
            // 
            this.AppMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.AppMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AppMenuStrip.Name = "AppMenuStrip";
            this.AppMenuStrip.Size = new System.Drawing.Size(1236, 24);
            this.AppMenuStrip.TabIndex = 0;
            this.AppMenuStrip.Text = "menuStrip1";
            // 
            // AppStatusStrip
            // 
            this.AppStatusStrip.Location = new System.Drawing.Point(0, 681);
            this.AppStatusStrip.Name = "AppStatusStrip";
            this.AppStatusStrip.Size = new System.Drawing.Size(1236, 22);
            this.AppStatusStrip.TabIndex = 1;
            this.AppStatusStrip.Text = "statusStrip1";
            // 
            // CharactersTabControl
            // 
            this.CharactersTabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.CharactersTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharactersTabControl.Controls.Add(this.CharacterTabPage);
            this.CharactersTabControl.Location = new System.Drawing.Point(0, 121);
            this.CharactersTabControl.Multiline = true;
            this.CharactersTabControl.Name = "CharactersTabControl";
            this.CharactersTabControl.SelectedIndex = 0;
            this.CharactersTabControl.Size = new System.Drawing.Size(1232, 557);
            this.CharactersTabControl.TabIndex = 5;
            // 
            // CharacterTabPage
            // 
            this.CharacterTabPage.Location = new System.Drawing.Point(4, 4);
            this.CharacterTabPage.Name = "CharacterTabPage";
            this.CharacterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterTabPage.Size = new System.Drawing.Size(1205, 549);
            this.CharacterTabPage.TabIndex = 0;
            this.CharacterTabPage.Text = "Character Name";
            this.CharacterTabPage.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.NewToolStripMenuItem.Text = "New";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.SaveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // BannerPictureBox
            // 
            this.BannerPictureBox.BackgroundImage = global::ADandD1ECharacterGenerator.Properties.Resources.Banner;
            this.BannerPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BannerPictureBox.Location = new System.Drawing.Point(0, 24);
            this.BannerPictureBox.Name = "BannerPictureBox";
            this.BannerPictureBox.Size = new System.Drawing.Size(1236, 98);
            this.BannerPictureBox.TabIndex = 4;
            this.BannerPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 703);
            this.Controls.Add(this.CharactersTabControl);
            this.Controls.Add(this.BannerPictureBox);
            this.Controls.Add(this.AppStatusStrip);
            this.Controls.Add(this.AppMenuStrip);
            this.MainMenuStrip = this.AppMenuStrip;
            this.Name = "MainForm";
            this.Text = "1e Character Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.AppMenuStrip.ResumeLayout(false);
            this.AppMenuStrip.PerformLayout();
            this.CharactersTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BannerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AppMenuStrip;
        private System.Windows.Forms.StatusStrip AppStatusStrip;
        private System.Windows.Forms.PictureBox BannerPictureBox;
        private System.Windows.Forms.TabControl CharactersTabControl;
        private System.Windows.Forms.TabPage CharacterTabPage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}

