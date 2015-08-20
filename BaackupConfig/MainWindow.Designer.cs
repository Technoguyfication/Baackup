namespace BaackupConfig
{
    partial class MainWindow
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
            this.Platform_Vanilla = new System.Windows.Forms.RadioButton();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.PlatformPanel = new System.Windows.Forms.Panel();
            this.Platform_CraftBukkit = new System.Windows.Forms.RadioButton();
            this.Platform_Spigot = new System.Windows.Forms.RadioButton();
            this.SaveConfig = new System.Windows.Forms.Button();
            this.ReloadConfig = new System.Windows.Forms.Button();
            this.ModdedOptions = new System.Windows.Forms.Panel();
            this.WorldsContainerPathBrowseButton = new System.Windows.Forms.Button();
            this.WorldsContainerPathTextBox = new System.Windows.Forms.TextBox();
            this.WorldsContainerButton = new System.Windows.Forms.CheckBox();
            this.ModdedServerOptions = new System.Windows.Forms.Label();
            this.BackupPlugins = new System.Windows.Forms.CheckBox();
            this.RCONSettingsPanel = new System.Windows.Forms.Panel();
            this.RCONPortTextBox = new System.Windows.Forms.TextBox();
            this.RCONHostnameTextBox_Label = new System.Windows.Forms.Label();
            this.RCONHostnameTextBox = new System.Windows.Forms.TextBox();
            this.UseRCONBox = new System.Windows.Forms.CheckBox();
            this.RCONLabel = new System.Windows.Forms.Label();
            this.RCONPortTextBox_Label = new System.Windows.Forms.Label();
            this.PlatformPanel.SuspendLayout();
            this.ModdedOptions.SuspendLayout();
            this.RCONSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Platform_Vanilla
            // 
            this.Platform_Vanilla.AutoSize = true;
            this.Platform_Vanilla.Checked = true;
            this.Platform_Vanilla.Location = new System.Drawing.Point(3, 19);
            this.Platform_Vanilla.Name = "Platform_Vanilla";
            this.Platform_Vanilla.Size = new System.Drawing.Size(56, 17);
            this.Platform_Vanilla.TabIndex = 0;
            this.Platform_Vanilla.TabStop = true;
            this.Platform_Vanilla.Text = "Vanilla";
            this.Platform_Vanilla.UseVisualStyleBackColor = true;
            this.Platform_Vanilla.CheckedChanged += new System.EventHandler(this.Platform_Vanilla_CheckedChanged);
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(3, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(132, 13);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Server Software / Platform";
            // 
            // PlatformPanel
            // 
            this.PlatformPanel.Controls.Add(this.Platform_CraftBukkit);
            this.PlatformPanel.Controls.Add(this.Platform_Spigot);
            this.PlatformPanel.Controls.Add(this.PlatformLabel);
            this.PlatformPanel.Controls.Add(this.Platform_Vanilla);
            this.PlatformPanel.Location = new System.Drawing.Point(12, 12);
            this.PlatformPanel.Name = "PlatformPanel";
            this.PlatformPanel.Size = new System.Drawing.Size(140, 100);
            this.PlatformPanel.TabIndex = 2;
            // 
            // Platform_CraftBukkit
            // 
            this.Platform_CraftBukkit.AutoSize = true;
            this.Platform_CraftBukkit.Location = new System.Drawing.Point(3, 67);
            this.Platform_CraftBukkit.Name = "Platform_CraftBukkit";
            this.Platform_CraftBukkit.Size = new System.Drawing.Size(77, 17);
            this.Platform_CraftBukkit.TabIndex = 3;
            this.Platform_CraftBukkit.Text = "CraftBukkit";
            this.Platform_CraftBukkit.UseVisualStyleBackColor = true;
            this.Platform_CraftBukkit.CheckedChanged += new System.EventHandler(this.Platform_CraftBukkit_CheckedChanged);
            // 
            // Platform_Spigot
            // 
            this.Platform_Spigot.AutoSize = true;
            this.Platform_Spigot.Location = new System.Drawing.Point(3, 43);
            this.Platform_Spigot.Name = "Platform_Spigot";
            this.Platform_Spigot.Size = new System.Drawing.Size(55, 17);
            this.Platform_Spigot.TabIndex = 2;
            this.Platform_Spigot.Text = "Spigot";
            this.Platform_Spigot.UseVisualStyleBackColor = true;
            this.Platform_Spigot.CheckedChanged += new System.EventHandler(this.Platform_Spigot_CheckedChanged);
            // 
            // SaveConfig
            // 
            this.SaveConfig.Location = new System.Drawing.Point(495, 13);
            this.SaveConfig.Name = "SaveConfig";
            this.SaveConfig.Size = new System.Drawing.Size(75, 23);
            this.SaveConfig.TabIndex = 3;
            this.SaveConfig.Text = "Save Config";
            this.SaveConfig.UseVisualStyleBackColor = true;
            this.SaveConfig.Click += new System.EventHandler(this.SaveConfig_Click);
            // 
            // ReloadConfig
            // 
            this.ReloadConfig.Location = new System.Drawing.Point(395, 13);
            this.ReloadConfig.Name = "ReloadConfig";
            this.ReloadConfig.Size = new System.Drawing.Size(94, 23);
            this.ReloadConfig.TabIndex = 4;
            this.ReloadConfig.Text = "Reload config";
            this.ReloadConfig.UseVisualStyleBackColor = true;
            this.ReloadConfig.Click += new System.EventHandler(this.ReloadConfig_Click);
            // 
            // ModdedOptions
            // 
            this.ModdedOptions.Controls.Add(this.WorldsContainerPathBrowseButton);
            this.ModdedOptions.Controls.Add(this.WorldsContainerPathTextBox);
            this.ModdedOptions.Controls.Add(this.WorldsContainerButton);
            this.ModdedOptions.Controls.Add(this.ModdedServerOptions);
            this.ModdedOptions.Controls.Add(this.BackupPlugins);
            this.ModdedOptions.Location = new System.Drawing.Point(159, 12);
            this.ModdedOptions.Name = "ModdedOptions";
            this.ModdedOptions.Size = new System.Drawing.Size(200, 100);
            this.ModdedOptions.TabIndex = 5;
            // 
            // WorldsContainerPathBrowseButton
            // 
            this.WorldsContainerPathBrowseButton.Location = new System.Drawing.Point(159, 67);
            this.WorldsContainerPathBrowseButton.Name = "WorldsContainerPathBrowseButton";
            this.WorldsContainerPathBrowseButton.Size = new System.Drawing.Size(27, 19);
            this.WorldsContainerPathBrowseButton.TabIndex = 4;
            this.WorldsContainerPathBrowseButton.Text = "...";
            this.WorldsContainerPathBrowseButton.UseVisualStyleBackColor = true;
            this.WorldsContainerPathBrowseButton.Click += new System.EventHandler(this.WorldsContainerPathBrowseButton_Click);
            // 
            // WorldsContainerPathTextBox
            // 
            this.WorldsContainerPathTextBox.Location = new System.Drawing.Point(3, 66);
            this.WorldsContainerPathTextBox.Name = "WorldsContainerPathTextBox";
            this.WorldsContainerPathTextBox.Size = new System.Drawing.Size(150, 20);
            this.WorldsContainerPathTextBox.TabIndex = 3;
            // 
            // WorldsContainerButton
            // 
            this.WorldsContainerButton.AutoSize = true;
            this.WorldsContainerButton.Location = new System.Drawing.Point(3, 44);
            this.WorldsContainerButton.Name = "WorldsContainerButton";
            this.WorldsContainerButton.Size = new System.Drawing.Size(129, 17);
            this.WorldsContainerButton.TabIndex = 2;
            this.WorldsContainerButton.Text = "Use Worlds Container";
            this.WorldsContainerButton.UseVisualStyleBackColor = true;
            this.WorldsContainerButton.CheckedChanged += new System.EventHandler(this.WorldsContainerButton_CheckedChanged);
            // 
            // ModdedServerOptions
            // 
            this.ModdedServerOptions.AutoSize = true;
            this.ModdedServerOptions.Location = new System.Drawing.Point(-1, 1);
            this.ModdedServerOptions.Name = "ModdedServerOptions";
            this.ModdedServerOptions.Size = new System.Drawing.Size(119, 13);
            this.ModdedServerOptions.TabIndex = 1;
            this.ModdedServerOptions.Text = "Modded Server Options";
            // 
            // BackupPlugins
            // 
            this.BackupPlugins.AutoSize = true;
            this.BackupPlugins.Location = new System.Drawing.Point(3, 20);
            this.BackupPlugins.Name = "BackupPlugins";
            this.BackupPlugins.Size = new System.Drawing.Size(100, 17);
            this.BackupPlugins.TabIndex = 0;
            this.BackupPlugins.Text = "Backup Plugins";
            this.BackupPlugins.UseVisualStyleBackColor = true;
            // 
            // RCONSettingsPanel
            // 
            this.RCONSettingsPanel.Controls.Add(this.RCONPortTextBox_Label);
            this.RCONSettingsPanel.Controls.Add(this.RCONPortTextBox);
            this.RCONSettingsPanel.Controls.Add(this.RCONHostnameTextBox_Label);
            this.RCONSettingsPanel.Controls.Add(this.RCONHostnameTextBox);
            this.RCONSettingsPanel.Controls.Add(this.UseRCONBox);
            this.RCONSettingsPanel.Controls.Add(this.RCONLabel);
            this.RCONSettingsPanel.Location = new System.Drawing.Point(12, 119);
            this.RCONSettingsPanel.Name = "RCONSettingsPanel";
            this.RCONSettingsPanel.Size = new System.Drawing.Size(200, 100);
            this.RCONSettingsPanel.TabIndex = 6;
            // 
            // RCONPortTextBox
            // 
            this.RCONPortTextBox.Location = new System.Drawing.Point(146, 44);
            this.RCONPortTextBox.Name = "RCONPortTextBox";
            this.RCONPortTextBox.Size = new System.Drawing.Size(51, 20);
            this.RCONPortTextBox.TabIndex = 4;
            this.RCONPortTextBox.GotFocus += new System.EventHandler(this.RCONPortTextBox_GotFocus);
            this.RCONPortTextBox.LostFocus += new System.EventHandler(this.RCONPortTextBox_LostFocus);
            // 
            // RCONHostnameTextBox_Label
            // 
            this.RCONHostnameTextBox_Label.AutoSize = true;
            this.RCONHostnameTextBox_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RCONHostnameTextBox_Label.Enabled = false;
            this.RCONHostnameTextBox_Label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RCONHostnameTextBox_Label.Location = new System.Drawing.Point(6, 47);
            this.RCONHostnameTextBox_Label.Name = "RCONHostnameTextBox_Label";
            this.RCONHostnameTextBox_Label.Size = new System.Drawing.Size(89, 13);
            this.RCONHostnameTextBox_Label.TabIndex = 3;
            this.RCONHostnameTextBox_Label.Text = "RCON Hostname";
            // 
            // RCONHostnameTextBox
            // 
            this.RCONHostnameTextBox.Location = new System.Drawing.Point(4, 44);
            this.RCONHostnameTextBox.Name = "RCONHostnameTextBox";
            this.RCONHostnameTextBox.Size = new System.Drawing.Size(136, 20);
            this.RCONHostnameTextBox.TabIndex = 2;
            this.RCONHostnameTextBox.GotFocus += new System.EventHandler(this.RCONHostnameTextBox_GotFocus);
            this.RCONHostnameTextBox.LostFocus += new System.EventHandler(this.RCONHostnameTextBox_LostFocus);
            // 
            // UseRCONBox
            // 
            this.UseRCONBox.AutoSize = true;
            this.UseRCONBox.Location = new System.Drawing.Point(4, 21);
            this.UseRCONBox.Name = "UseRCONBox";
            this.UseRCONBox.Size = new System.Drawing.Size(146, 17);
            this.UseRCONBox.TabIndex = 1;
            this.UseRCONBox.Text = "Enable RCON Integration";
            this.UseRCONBox.UseVisualStyleBackColor = true;
            this.UseRCONBox.CheckedChanged += new System.EventHandler(this.UseRCONBox_CheckedChanged);
            // 
            // RCONLabel
            // 
            this.RCONLabel.AutoSize = true;
            this.RCONLabel.Location = new System.Drawing.Point(0, 5);
            this.RCONLabel.Name = "RCONLabel";
            this.RCONLabel.Size = new System.Drawing.Size(79, 13);
            this.RCONLabel.TabIndex = 0;
            this.RCONLabel.Text = "RCON Settings";
            // 
            // RCONPortTextBox_Label
            // 
            this.RCONPortTextBox_Label.AutoSize = true;
            this.RCONPortTextBox_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RCONPortTextBox_Label.Enabled = false;
            this.RCONPortTextBox_Label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RCONPortTextBox_Label.Location = new System.Drawing.Point(147, 47);
            this.RCONPortTextBox_Label.Name = "RCONPortTextBox_Label";
            this.RCONPortTextBox_Label.Size = new System.Drawing.Size(26, 13);
            this.RCONPortTextBox_Label.TabIndex = 5;
            this.RCONPortTextBox_Label.Text = "Port";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 329);
            this.Controls.Add(this.RCONSettingsPanel);
            this.Controls.Add(this.ModdedOptions);
            this.Controls.Add(this.ReloadConfig);
            this.Controls.Add(this.SaveConfig);
            this.Controls.Add(this.PlatformPanel);
            this.Name = "MainWindow";
            this.Text = "Baackup Configuration Customizer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.PlatformPanel.ResumeLayout(false);
            this.PlatformPanel.PerformLayout();
            this.ModdedOptions.ResumeLayout(false);
            this.ModdedOptions.PerformLayout();
            this.RCONSettingsPanel.ResumeLayout(false);
            this.RCONSettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Platform_Vanilla;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Panel PlatformPanel;
        private System.Windows.Forms.RadioButton Platform_CraftBukkit;
        private System.Windows.Forms.RadioButton Platform_Spigot;
        private System.Windows.Forms.Button SaveConfig;
        private System.Windows.Forms.Button ReloadConfig;
        private System.Windows.Forms.Panel ModdedOptions;
        private System.Windows.Forms.CheckBox BackupPlugins;
        private System.Windows.Forms.Label ModdedServerOptions;
        private System.Windows.Forms.Button WorldsContainerPathBrowseButton;
        public System.Windows.Forms.TextBox WorldsContainerPathTextBox;
        public System.Windows.Forms.CheckBox WorldsContainerButton;
        private System.Windows.Forms.Panel RCONSettingsPanel;
        private System.Windows.Forms.CheckBox UseRCONBox;
        private System.Windows.Forms.Label RCONLabel;
        private System.Windows.Forms.TextBox RCONHostnameTextBox;
        private System.Windows.Forms.Label RCONHostnameTextBox_Label;
        private System.Windows.Forms.TextBox RCONPortTextBox;
        private System.Windows.Forms.Label RCONPortTextBox_Label;
    }
}

