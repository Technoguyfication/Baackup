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

        public void GUIUpdate()
        {
            #region Modded Server Options

            if (ModdedPlatform)
            {
                // Get all the controls in the box.
                List<Control> list = new List<Control>();
                GetAllControl(ModdedOptions, list);

                // For every element in the box, enable it.
                foreach (Control control in list)
                {
                    control.Enabled = true;
                }

                // Bukkit
                if (Variables.Platform == "craftbukkit")
                {
                    WorldsContainerButton.Enabled = false;
                    WorldsContainerPathTextBox.Enabled = false;
                    WorldsContainerPathBrowseButton.Enabled = false;
                }

                // Spigot
                if (Variables.Platform == "spigot")
                {
                    WorldsContainerButton.Enabled = true;
                    WorldsContainerPathTextBox.Enabled = true;
                    WorldsContainerPathBrowseButton.Enabled = true;
                }
            }
            else
            {
                // Get all the controls in the box.
                List<Control> list = new List<Control>();
                GetAllControl(ModdedOptions, list);

                // For every element in the box, disable it
                foreach (Control control in list)
                {
                    control.Enabled = false;
                }
            }

            #region Worlds Container

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

            #endregion

            #endregion

            #region RCON

            if (Variables.UseRCON)
            {
                RCONHostnameTextBox.Enabled = true;
                RCONPortTextBox.Enabled = true;
            }
            else
            {
                RCONHostnameTextBox.Enabled = false;
                RCONPortTextBox.Enabled = false;
            }

            #endregion
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

        private void RCONHostnameTextBox_GotFocus(object sender, EventArgs e)
        {
            HideTemplateText(RCONHostnameTextBox_Label);
        }

        private void RCONHostnameTextBox_LostFocus(object sender, EventArgs e)
        {
            if (RCONHostnameTextBox.Text == "")
                ShowTemplateText(RCONHostnameTextBox_Label);
        }

        private void RCONPortTextBox_GotFocus(object sender, EventArgs e)
        {
            HideTemplateText(RCONPortTextBox_Label);
        }

        private void RCONPortTextBox_LostFocus(object sender, EventArgs e)
        {
            if (RCONPortTextBox.Text == "")
                ShowTemplateText(RCONPortTextBox_Label);

            // Validate
            bool valid = true;

            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach (char character in RCONPortTextBox.Text.ToCharArray())
            {
                int pos = Array.IndexOf(numbers, character);

                if (!(pos > -1))
                    valid = false;
            }

            if (!valid)
            {
                RCONPortTextBox.Text = "";
                MessageBox.Show("Port number cannot contain anything but numbers.", "Input Error");
            }
        }

        private void UseRCONBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseRCONBox.Checked)
                Variables.UseRCON = true;
            else
                Variables.UseRCON = false;

            GUIUpdate();
        }

        #endregion

        #region Other Stuff That Makes The Program Do Stuff

        #region Checks

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

        #endregion

        #region Functional Things

        private void GetAllControl(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);

                if (control.GetType() == typeof(Panel))
                    GetAllControl(control, list);
            }
        }

        private void HideTemplateText(Label item)
        {
            item.Visible = false;
        }

        private void ShowTemplateText(Label item)
        {
            item.Visible = true;
        }

        #endregion

        #endregion

    }
}
