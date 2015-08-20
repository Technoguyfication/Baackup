using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaackupConfig
{
    public partial class MainWindow : Form
    {
        // Class vars
        private bool ModdedPlatform;

        public MainWindow()
        {
            InitializeComponent();
        }

        void CheckModded(RadioButton button)
        {
            if ((button.Name == "Platform_Spigot" || button.Name == "Platform_CraftBukkit") && button.Checked)
                ModdedPlatform = true;
            else
                ModdedPlatform = false;

            // Set config option

            if (button.Name == "Platform_Spigot")
                Variables.Platform = "spigot";
            else if (button.Name == "Platform_CraftBukkit")
                Variables.Platform = "craftbukkit";
            else
                Variables.Platform = "vanilla";

            GUIUpdate();
        }

        void CheckUseWorldsContainer()
        {
            if (WorldsContainerButton.Checked == true)
            {
                Variables.WorldsContainerActive = true;
            }
            else
            {
                Variables.WorldsContainerActive = false;
            }

            GUIUpdate();
        }

        public void GUIUpdate()
        {
            // Update modded options
            if (ModdedPlatform)
            {
                BackupPlugins.Enabled = true;

                if (Variables.Platform == "spigot")
                {
                    WorldsContainerButton.Enabled = true;
                    WorldsContainerPathTextBox.Enabled = true;
                    WorldsContainerPathBrowseButton.Enabled = true;
                }
            }
            else
            {
                BackupPlugins.Enabled = false;

                WorldsContainerButton.Enabled = false;
                WorldsContainerPathTextBox.Enabled = false;
                WorldsContainerPathBrowseButton.Enabled = false;
            }

            // Update world container options
            if (Variables.WorldsContainerActive)
            {
                WorldsContainerPathTextBox.Enabled = true;
                WorldsContainerPathBrowseButton.Enabled = true;
            }
            else
            {
                WorldsContainerPathTextBox.Enabled = false;
                WorldsContainerPathBrowseButton.Enabled = false;
            }
        }

        #region Actions

        private void Platform_Spigot_CheckedChanged(object sender, EventArgs e)
        {
            CheckModded(Platform_Spigot);
        }

        private void Platform_CraftBukkit_CheckedChanged(object sender, EventArgs e)
        {
            CheckModded(Platform_CraftBukkit);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            GUIUpdate();
        }

        private void ReloadConfig_Click(object sender, EventArgs e)
        {
            XMLConfig.LoadConfig();
        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {
            XMLConfig.SaveConfig();
        }

        private void WorldsContainerButton_CheckedChanged(object sender, EventArgs e)
        {
            CheckUseWorldsContainer();
        }

        private void WorldsContainerPathBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
            FolderBrowser.Description = "Please select your worlds container folder.";

            if (FolderBrowser.ShowDialog() == DialogResult.OK)
                WorldsContainerPathTextBox.Text = FolderBrowser.SelectedPath;
        }

        private void Platform_Vanilla_CheckedChanged(object sender, EventArgs e)
        {
            CheckModded(Platform_Vanilla);
        }

        #endregion
    }
}
