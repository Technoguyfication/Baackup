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

        private void Platform_Vanilla_CheckedChanged(object sender, EventArgs e)
        {
            CheckModded(Platform_Vanilla);
        }

        void CheckModded(RadioButton button)
        {
            if ((button.Name == "Platform_Spigot" || button.Name == "Platform_CraftBukkit") && button.Checked)
                ModdedPlatform = true;
            else
                ModdedPlatform = false;

            GUIUpdate();
        }

        public void GUIUpdate()
        {
            // Update modded options
            if (ModdedPlatform)
            {
                BackupPlugins.Enabled = true;
            }
            else
            {
                BackupPlugins.Enabled = false;
            }
        }

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
    }
}
