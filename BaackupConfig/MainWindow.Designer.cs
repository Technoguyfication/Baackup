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
            this.BackupPluginsBox = new System.Windows.Forms.CheckBox();
            this.RCONSettingsPanel = new System.Windows.Forms.Panel();
            this.RCONPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RCONPasswordLabel = new System.Windows.Forms.Label();
            this.RCONPortLabel = new System.Windows.Forms.Label();
            this.RCONHostnameLabel = new System.Windows.Forms.Label();
            this.RCONPortTextBox = new System.Windows.Forms.TextBox();
            this.RCONHostnameTextBox = new System.Windows.Forms.TextBox();
            this.UseRCONBox = new System.Windows.Forms.CheckBox();
            this.RCONLabel = new System.Windows.Forms.Label();
            this.BackupSettingsPanel = new System.Windows.Forms.Panel();
            this.TmpSaveLocationBrowse = new System.Windows.Forms.Button();
            this.TmpSaveLocationEnabledBox = new System.Windows.Forms.CheckBox();
            this.TmpSaveLocationTextBox = new System.Windows.Forms.TextBox();
            this.BackupLogsBox = new System.Windows.Forms.CheckBox();
            this.BackupPrefixTextBox = new System.Windows.Forms.TextBox();
            this.BackupPrefixLabel = new System.Windows.Forms.Label();
            this.BackupSavePathLabel = new System.Windows.Forms.Label();
            this.BackupContainerButton = new System.Windows.Forms.Button();
            this.BackupContainerTextBox = new System.Windows.Forms.TextBox();
            this.BackupSettingsLabel = new System.Windows.Forms.Label();
            this.MessagesPanel = new System.Windows.Forms.Panel();
            this.BackupStartedMessageEnabledBox = new System.Windows.Forms.CheckBox();
            this.BackupStartedMessageLabel = new System.Windows.Forms.Label();
            this.BackupStartedMessageTextBox = new System.Windows.Forms.TextBox();
            this.BackupFinishedMessageEnabledBox = new System.Windows.Forms.CheckBox();
            this.BackupFinishedMessageLabel = new System.Windows.Forms.Label();
            this.BackupFinishedMessageTextBox = new System.Windows.Forms.TextBox();
            this.MessagesBoxLabel = new System.Windows.Forms.Label();
            this.CompressBackupsBox = new System.Windows.Forms.CheckBox();
            this.PlatformPanel.SuspendLayout();
            this.ModdedOptions.SuspendLayout();
            this.RCONSettingsPanel.SuspendLayout();
            this.BackupSettingsPanel.SuspendLayout();
            this.MessagesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Platform_Vanilla
            // 
            this.Platform_Vanilla.AutoSize = true;
            this.Platform_Vanilla.Checked = true;
            this.Platform_Vanilla.Location = new System.Drawing.Point(6, 20);
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
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(0, 1);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(94, 13);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Server Platform";
            // 
            // PlatformPanel
            // 
            this.PlatformPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PlatformPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Platform_CraftBukkit.Location = new System.Drawing.Point(6, 68);
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
            this.Platform_Spigot.Location = new System.Drawing.Point(6, 44);
            this.Platform_Spigot.Name = "Platform_Spigot";
            this.Platform_Spigot.Size = new System.Drawing.Size(55, 17);
            this.Platform_Spigot.TabIndex = 2;
            this.Platform_Spigot.Text = "Spigot";
            this.Platform_Spigot.UseVisualStyleBackColor = true;
            this.Platform_Spigot.CheckedChanged += new System.EventHandler(this.Platform_Spigot_CheckedChanged);
            // 
            // SaveConfig
            // 
            this.SaveConfig.Location = new System.Drawing.Point(436, 41);
            this.SaveConfig.Name = "SaveConfig";
            this.SaveConfig.Size = new System.Drawing.Size(75, 23);
            this.SaveConfig.TabIndex = 3;
            this.SaveConfig.Text = "Save Config";
            this.SaveConfig.UseVisualStyleBackColor = true;
            this.SaveConfig.Click += new System.EventHandler(this.SaveConfig_Click);
            // 
            // ReloadConfig
            // 
            this.ReloadConfig.Location = new System.Drawing.Point(417, 12);
            this.ReloadConfig.Name = "ReloadConfig";
            this.ReloadConfig.Size = new System.Drawing.Size(94, 23);
            this.ReloadConfig.TabIndex = 4;
            this.ReloadConfig.Text = "Reload config";
            this.ReloadConfig.UseVisualStyleBackColor = true;
            this.ReloadConfig.Click += new System.EventHandler(this.ReloadConfig_Click);
            // 
            // ModdedOptions
            // 
            this.ModdedOptions.BackColor = System.Drawing.SystemColors.Control;
            this.ModdedOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModdedOptions.Controls.Add(this.WorldsContainerPathBrowseButton);
            this.ModdedOptions.Controls.Add(this.WorldsContainerPathTextBox);
            this.ModdedOptions.Controls.Add(this.WorldsContainerButton);
            this.ModdedOptions.Controls.Add(this.ModdedServerOptions);
            this.ModdedOptions.Controls.Add(this.BackupPluginsBox);
            this.ModdedOptions.Location = new System.Drawing.Point(159, 12);
            this.ModdedOptions.Name = "ModdedOptions";
            this.ModdedOptions.Size = new System.Drawing.Size(200, 100);
            this.ModdedOptions.TabIndex = 5;
            // 
            // WorldsContainerPathBrowseButton
            // 
            this.WorldsContainerPathBrowseButton.Location = new System.Drawing.Point(170, 66);
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
            this.WorldsContainerPathTextBox.ReadOnly = true;
            this.WorldsContainerPathTextBox.Size = new System.Drawing.Size(161, 20);
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
            this.ModdedServerOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModdedServerOptions.Location = new System.Drawing.Point(-1, 1);
            this.ModdedServerOptions.Name = "ModdedServerOptions";
            this.ModdedServerOptions.Size = new System.Drawing.Size(140, 13);
            this.ModdedServerOptions.TabIndex = 1;
            this.ModdedServerOptions.Text = "Modded Server Options";
            // 
            // BackupPluginsBox
            // 
            this.BackupPluginsBox.AutoSize = true;
            this.BackupPluginsBox.Location = new System.Drawing.Point(3, 20);
            this.BackupPluginsBox.Name = "BackupPluginsBox";
            this.BackupPluginsBox.Size = new System.Drawing.Size(100, 17);
            this.BackupPluginsBox.TabIndex = 0;
            this.BackupPluginsBox.Text = "Backup Plugins";
            this.BackupPluginsBox.UseVisualStyleBackColor = true;
            // 
            // RCONSettingsPanel
            // 
            this.RCONSettingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RCONSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RCONSettingsPanel.Controls.Add(this.RCONPasswordTextBox);
            this.RCONSettingsPanel.Controls.Add(this.RCONPasswordLabel);
            this.RCONSettingsPanel.Controls.Add(this.RCONPortLabel);
            this.RCONSettingsPanel.Controls.Add(this.RCONHostnameLabel);
            this.RCONSettingsPanel.Controls.Add(this.RCONPortTextBox);
            this.RCONSettingsPanel.Controls.Add(this.RCONHostnameTextBox);
            this.RCONSettingsPanel.Controls.Add(this.UseRCONBox);
            this.RCONSettingsPanel.Controls.Add(this.RCONLabel);
            this.RCONSettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCONSettingsPanel.Location = new System.Drawing.Point(12, 119);
            this.RCONSettingsPanel.Name = "RCONSettingsPanel";
            this.RCONSettingsPanel.Size = new System.Drawing.Size(200, 141);
            this.RCONSettingsPanel.TabIndex = 6;
            // 
            // RCONPasswordTextBox
            // 
            this.RCONPasswordTextBox.Location = new System.Drawing.Point(3, 106);
            this.RCONPasswordTextBox.Name = "RCONPasswordTextBox";
            this.RCONPasswordTextBox.Size = new System.Drawing.Size(193, 20);
            this.RCONPasswordTextBox.TabIndex = 8;
            this.RCONPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RCONPasswordLabel
            // 
            this.RCONPasswordLabel.AutoSize = true;
            this.RCONPasswordLabel.Location = new System.Drawing.Point(3, 90);
            this.RCONPasswordLabel.Name = "RCONPasswordLabel";
            this.RCONPasswordLabel.Size = new System.Drawing.Size(87, 13);
            this.RCONPasswordLabel.TabIndex = 7;
            this.RCONPasswordLabel.Text = "RCON Password";
            // 
            // RCONPortLabel
            // 
            this.RCONPortLabel.AutoSize = true;
            this.RCONPortLabel.Location = new System.Drawing.Point(145, 44);
            this.RCONPortLabel.Name = "RCONPortLabel";
            this.RCONPortLabel.Size = new System.Drawing.Size(26, 13);
            this.RCONPortLabel.TabIndex = 6;
            this.RCONPortLabel.Text = "Port";
            // 
            // RCONHostnameLabel
            // 
            this.RCONHostnameLabel.AutoSize = true;
            this.RCONHostnameLabel.Location = new System.Drawing.Point(3, 45);
            this.RCONHostnameLabel.Name = "RCONHostnameLabel";
            this.RCONHostnameLabel.Size = new System.Drawing.Size(55, 13);
            this.RCONHostnameLabel.TabIndex = 5;
            this.RCONHostnameLabel.Text = "Hostname";
            // 
            // RCONPortTextBox
            // 
            this.RCONPortTextBox.Location = new System.Drawing.Point(145, 61);
            this.RCONPortTextBox.MaxLength = 10;
            this.RCONPortTextBox.Name = "RCONPortTextBox";
            this.RCONPortTextBox.Size = new System.Drawing.Size(51, 20);
            this.RCONPortTextBox.TabIndex = 4;
            this.RCONPortTextBox.LostFocus += new System.EventHandler(this.RCONPortTextBox_LostFocus);
            // 
            // RCONHostnameTextBox
            // 
            this.RCONHostnameTextBox.Location = new System.Drawing.Point(3, 61);
            this.RCONHostnameTextBox.Name = "RCONHostnameTextBox";
            this.RCONHostnameTextBox.Size = new System.Drawing.Size(136, 20);
            this.RCONHostnameTextBox.TabIndex = 2;
            // 
            // UseRCONBox
            // 
            this.UseRCONBox.AutoSize = true;
            this.UseRCONBox.Location = new System.Drawing.Point(6, 22);
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
            this.RCONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCONLabel.Location = new System.Drawing.Point(0, 5);
            this.RCONLabel.Name = "RCONLabel";
            this.RCONLabel.Size = new System.Drawing.Size(92, 13);
            this.RCONLabel.TabIndex = 0;
            this.RCONLabel.Text = "RCON Settings";
            // 
            // BackupSettingsPanel
            // 
            this.BackupSettingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BackupSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackupSettingsPanel.Controls.Add(this.CompressBackupsBox);
            this.BackupSettingsPanel.Controls.Add(this.TmpSaveLocationBrowse);
            this.BackupSettingsPanel.Controls.Add(this.TmpSaveLocationEnabledBox);
            this.BackupSettingsPanel.Controls.Add(this.TmpSaveLocationTextBox);
            this.BackupSettingsPanel.Controls.Add(this.BackupLogsBox);
            this.BackupSettingsPanel.Controls.Add(this.BackupPrefixTextBox);
            this.BackupSettingsPanel.Controls.Add(this.BackupPrefixLabel);
            this.BackupSettingsPanel.Controls.Add(this.BackupSavePathLabel);
            this.BackupSettingsPanel.Controls.Add(this.BackupContainerButton);
            this.BackupSettingsPanel.Controls.Add(this.BackupContainerTextBox);
            this.BackupSettingsPanel.Controls.Add(this.BackupSettingsLabel);
            this.BackupSettingsPanel.Location = new System.Drawing.Point(219, 119);
            this.BackupSettingsPanel.Name = "BackupSettingsPanel";
            this.BackupSettingsPanel.Size = new System.Drawing.Size(361, 141);
            this.BackupSettingsPanel.TabIndex = 7;
            // 
            // TmpSaveLocationBrowse
            // 
            this.TmpSaveLocationBrowse.Location = new System.Drawing.Point(329, 105);
            this.TmpSaveLocationBrowse.Name = "TmpSaveLocationBrowse";
            this.TmpSaveLocationBrowse.Size = new System.Drawing.Size(27, 19);
            this.TmpSaveLocationBrowse.TabIndex = 12;
            this.TmpSaveLocationBrowse.Text = "...";
            this.TmpSaveLocationBrowse.UseVisualStyleBackColor = true;
            this.TmpSaveLocationBrowse.Click += new System.EventHandler(this.TmpSaveLocationBrowse_Click);
            // 
            // TmpSaveLocationEnabledBox
            // 
            this.TmpSaveLocationEnabledBox.AutoSize = true;
            this.TmpSaveLocationEnabledBox.Location = new System.Drawing.Point(202, 82);
            this.TmpSaveLocationEnabledBox.Name = "TmpSaveLocationEnabledBox";
            this.TmpSaveLocationEnabledBox.Size = new System.Drawing.Size(159, 17);
            this.TmpSaveLocationEnabledBox.TabIndex = 11;
            this.TmpSaveLocationEnabledBox.Text = "Enable Custom Temp Folder";
            this.TmpSaveLocationEnabledBox.UseVisualStyleBackColor = true;
            this.TmpSaveLocationEnabledBox.CheckedChanged += new System.EventHandler(this.TmpSaveLocationEnabledBox_CheckedChanged);
            // 
            // TmpSaveLocationTextBox
            // 
            this.TmpSaveLocationTextBox.Location = new System.Drawing.Point(202, 105);
            this.TmpSaveLocationTextBox.Name = "TmpSaveLocationTextBox";
            this.TmpSaveLocationTextBox.ReadOnly = true;
            this.TmpSaveLocationTextBox.Size = new System.Drawing.Size(121, 20);
            this.TmpSaveLocationTextBox.TabIndex = 10;
            // 
            // BackupLogsBox
            // 
            this.BackupLogsBox.AutoSize = true;
            this.BackupLogsBox.Location = new System.Drawing.Point(9, 22);
            this.BackupLogsBox.Name = "BackupLogsBox";
            this.BackupLogsBox.Size = new System.Drawing.Size(123, 17);
            this.BackupLogsBox.TabIndex = 9;
            this.BackupLogsBox.Text = "Backup Server Logs";
            this.BackupLogsBox.UseVisualStyleBackColor = true;
            this.BackupLogsBox.CheckedChanged += new System.EventHandler(this.BackupLogsBox_CheckedChanged);
            // 
            // BackupPrefixTextBox
            // 
            this.BackupPrefixTextBox.Location = new System.Drawing.Point(3, 106);
            this.BackupPrefixTextBox.MaxLength = 25;
            this.BackupPrefixTextBox.Name = "BackupPrefixTextBox";
            this.BackupPrefixTextBox.Size = new System.Drawing.Size(192, 20);
            this.BackupPrefixTextBox.TabIndex = 8;
            this.BackupPrefixTextBox.LostFocus += new System.EventHandler(this.BackupPrefixTextBox_LostFocus);
            // 
            // BackupPrefixLabel
            // 
            this.BackupPrefixLabel.AutoSize = true;
            this.BackupPrefixLabel.Location = new System.Drawing.Point(9, 88);
            this.BackupPrefixLabel.Name = "BackupPrefixLabel";
            this.BackupPrefixLabel.Size = new System.Drawing.Size(73, 13);
            this.BackupPrefixLabel.TabIndex = 7;
            this.BackupPrefixLabel.Text = "Backup Prefix";
            // 
            // BackupSavePathLabel
            // 
            this.BackupSavePathLabel.AutoSize = true;
            this.BackupSavePathLabel.Location = new System.Drawing.Point(6, 42);
            this.BackupSavePathLabel.Name = "BackupSavePathLabel";
            this.BackupSavePathLabel.Size = new System.Drawing.Size(97, 13);
            this.BackupSavePathLabel.TabIndex = 6;
            this.BackupSavePathLabel.Text = "Backup Save Path";
            // 
            // BackupContainerButton
            // 
            this.BackupContainerButton.Location = new System.Drawing.Point(168, 61);
            this.BackupContainerButton.Name = "BackupContainerButton";
            this.BackupContainerButton.Size = new System.Drawing.Size(27, 19);
            this.BackupContainerButton.TabIndex = 5;
            this.BackupContainerButton.Text = "...";
            this.BackupContainerButton.UseVisualStyleBackColor = true;
            this.BackupContainerButton.Click += new System.EventHandler(this.BackupContainerButton_Click);
            // 
            // BackupContainerTextBox
            // 
            this.BackupContainerTextBox.Location = new System.Drawing.Point(3, 61);
            this.BackupContainerTextBox.Name = "BackupContainerTextBox";
            this.BackupContainerTextBox.ReadOnly = true;
            this.BackupContainerTextBox.Size = new System.Drawing.Size(162, 20);
            this.BackupContainerTextBox.TabIndex = 1;
            // 
            // BackupSettingsLabel
            // 
            this.BackupSettingsLabel.AutoSize = true;
            this.BackupSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupSettingsLabel.Location = new System.Drawing.Point(3, 5);
            this.BackupSettingsLabel.Name = "BackupSettingsLabel";
            this.BackupSettingsLabel.Size = new System.Drawing.Size(100, 13);
            this.BackupSettingsLabel.TabIndex = 0;
            this.BackupSettingsLabel.Text = "Backup Settings";
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessagesPanel.Controls.Add(this.BackupStartedMessageEnabledBox);
            this.MessagesPanel.Controls.Add(this.BackupStartedMessageLabel);
            this.MessagesPanel.Controls.Add(this.BackupStartedMessageTextBox);
            this.MessagesPanel.Controls.Add(this.BackupFinishedMessageEnabledBox);
            this.MessagesPanel.Controls.Add(this.BackupFinishedMessageLabel);
            this.MessagesPanel.Controls.Add(this.BackupFinishedMessageTextBox);
            this.MessagesPanel.Controls.Add(this.MessagesBoxLabel);
            this.MessagesPanel.Location = new System.Drawing.Point(13, 267);
            this.MessagesPanel.Name = "MessagesPanel";
            this.MessagesPanel.Size = new System.Drawing.Size(406, 94);
            this.MessagesPanel.TabIndex = 8;
            // 
            // BackupStartedMessageEnabledBox
            // 
            this.BackupStartedMessageEnabledBox.AutoSize = true;
            this.BackupStartedMessageEnabledBox.Location = new System.Drawing.Point(5, 38);
            this.BackupStartedMessageEnabledBox.Name = "BackupStartedMessageEnabledBox";
            this.BackupStartedMessageEnabledBox.Size = new System.Drawing.Size(65, 17);
            this.BackupStartedMessageEnabledBox.TabIndex = 6;
            this.BackupStartedMessageEnabledBox.Text = "Enabled";
            this.BackupStartedMessageEnabledBox.UseVisualStyleBackColor = true;
            this.BackupStartedMessageEnabledBox.CheckedChanged += new System.EventHandler(this.BackupStartedMessageEnabledBox_CheckedChanged);
            // 
            // BackupStartedMessageLabel
            // 
            this.BackupStartedMessageLabel.AutoSize = true;
            this.BackupStartedMessageLabel.Location = new System.Drawing.Point(2, 22);
            this.BackupStartedMessageLabel.Name = "BackupStartedMessageLabel";
            this.BackupStartedMessageLabel.Size = new System.Drawing.Size(127, 13);
            this.BackupStartedMessageLabel.TabIndex = 5;
            this.BackupStartedMessageLabel.Text = "Backup Started Message";
            // 
            // BackupStartedMessageTextBox
            // 
            this.BackupStartedMessageTextBox.Location = new System.Drawing.Point(5, 61);
            this.BackupStartedMessageTextBox.Name = "BackupStartedMessageTextBox";
            this.BackupStartedMessageTextBox.Size = new System.Drawing.Size(196, 20);
            this.BackupStartedMessageTextBox.TabIndex = 4;
            // 
            // BackupFinishedMessageEnabledBox
            // 
            this.BackupFinishedMessageEnabledBox.AutoSize = true;
            this.BackupFinishedMessageEnabledBox.Location = new System.Drawing.Point(204, 38);
            this.BackupFinishedMessageEnabledBox.Name = "BackupFinishedMessageEnabledBox";
            this.BackupFinishedMessageEnabledBox.Size = new System.Drawing.Size(65, 17);
            this.BackupFinishedMessageEnabledBox.TabIndex = 3;
            this.BackupFinishedMessageEnabledBox.Text = "Enabled";
            this.BackupFinishedMessageEnabledBox.UseVisualStyleBackColor = true;
            this.BackupFinishedMessageEnabledBox.CheckedChanged += new System.EventHandler(this.BackupFinishedMessageEnabledBox_CheckedChanged);
            // 
            // BackupFinishedMessageLabel
            // 
            this.BackupFinishedMessageLabel.AutoSize = true;
            this.BackupFinishedMessageLabel.Location = new System.Drawing.Point(201, 22);
            this.BackupFinishedMessageLabel.Name = "BackupFinishedMessageLabel";
            this.BackupFinishedMessageLabel.Size = new System.Drawing.Size(132, 13);
            this.BackupFinishedMessageLabel.TabIndex = 2;
            this.BackupFinishedMessageLabel.Text = "Backup Finished Message";
            // 
            // BackupFinishedMessageTextBox
            // 
            this.BackupFinishedMessageTextBox.Location = new System.Drawing.Point(204, 61);
            this.BackupFinishedMessageTextBox.Name = "BackupFinishedMessageTextBox";
            this.BackupFinishedMessageTextBox.Size = new System.Drawing.Size(196, 20);
            this.BackupFinishedMessageTextBox.TabIndex = 1;
            // 
            // MessagesBoxLabel
            // 
            this.MessagesBoxLabel.AutoSize = true;
            this.MessagesBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesBoxLabel.Location = new System.Drawing.Point(0, 0);
            this.MessagesBoxLabel.Name = "MessagesBoxLabel";
            this.MessagesBoxLabel.Size = new System.Drawing.Size(165, 13);
            this.MessagesBoxLabel.TabIndex = 0;
            this.MessagesBoxLabel.Text = "Server Broadcast Messages";
            // 
            // CompressBackupsBox
            // 
            this.CompressBackupsBox.AutoSize = true;
            this.CompressBackupsBox.Location = new System.Drawing.Point(202, 22);
            this.CompressBackupsBox.Name = "CompressBackupsBox";
            this.CompressBackupsBox.Size = new System.Drawing.Size(117, 17);
            this.CompressBackupsBox.TabIndex = 13;
            this.CompressBackupsBox.Text = "Compress Backups";
            this.CompressBackupsBox.UseVisualStyleBackColor = true;
            this.CompressBackupsBox.CheckedChanged += new System.EventHandler(this.CompressBackupsBox_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.MessagesPanel);
            this.Controls.Add(this.BackupSettingsPanel);
            this.Controls.Add(this.RCONSettingsPanel);
            this.Controls.Add(this.ModdedOptions);
            this.Controls.Add(this.ReloadConfig);
            this.Controls.Add(this.SaveConfig);
            this.Controls.Add(this.PlatformPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Baackup Configuration Customizer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.PlatformPanel.ResumeLayout(false);
            this.PlatformPanel.PerformLayout();
            this.ModdedOptions.ResumeLayout(false);
            this.ModdedOptions.PerformLayout();
            this.RCONSettingsPanel.ResumeLayout(false);
            this.RCONSettingsPanel.PerformLayout();
            this.BackupSettingsPanel.ResumeLayout(false);
            this.BackupSettingsPanel.PerformLayout();
            this.MessagesPanel.ResumeLayout(false);
            this.MessagesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RadioButton Platform_Vanilla;
        public System.Windows.Forms.Label PlatformLabel;
        public System.Windows.Forms.Panel PlatformPanel;
        public System.Windows.Forms.RadioButton Platform_CraftBukkit;
        public System.Windows.Forms.RadioButton Platform_Spigot;
        public System.Windows.Forms.Button SaveConfig;
        public System.Windows.Forms.Button ReloadConfig;
        public System.Windows.Forms.Panel ModdedOptions;
        public System.Windows.Forms.Button WorldsContainerPathBrowseButton;
        public System.Windows.Forms.TextBox WorldsContainerPathTextBox;
        public System.Windows.Forms.CheckBox WorldsContainerButton;
        public System.Windows.Forms.Label ModdedServerOptions;
        public System.Windows.Forms.CheckBox BackupPluginsBox;
        public System.Windows.Forms.Panel RCONSettingsPanel;
        public System.Windows.Forms.TextBox RCONPasswordTextBox;
        public System.Windows.Forms.Label RCONPasswordLabel;
        public System.Windows.Forms.Label RCONPortLabel;
        public System.Windows.Forms.Label RCONHostnameLabel;
        public System.Windows.Forms.TextBox RCONPortTextBox;
        public System.Windows.Forms.TextBox RCONHostnameTextBox;
        public System.Windows.Forms.CheckBox UseRCONBox;
        public System.Windows.Forms.Label RCONLabel;
        public System.Windows.Forms.Panel BackupSettingsPanel;
        public System.Windows.Forms.CheckBox CompressBackupsBox;
        public System.Windows.Forms.Button TmpSaveLocationBrowse;
        public System.Windows.Forms.CheckBox TmpSaveLocationEnabledBox;
        public System.Windows.Forms.TextBox TmpSaveLocationTextBox;
        public System.Windows.Forms.CheckBox BackupLogsBox;
        public System.Windows.Forms.TextBox BackupPrefixTextBox;
        public System.Windows.Forms.Label BackupPrefixLabel;
        public System.Windows.Forms.Label BackupSavePathLabel;
        public System.Windows.Forms.Button BackupContainerButton;
        public System.Windows.Forms.TextBox BackupContainerTextBox;
        public System.Windows.Forms.Label BackupSettingsLabel;
        public System.Windows.Forms.Panel MessagesPanel;
        public System.Windows.Forms.CheckBox BackupStartedMessageEnabledBox;
        public System.Windows.Forms.Label BackupStartedMessageLabel;
        public System.Windows.Forms.TextBox BackupStartedMessageTextBox;
        public System.Windows.Forms.CheckBox BackupFinishedMessageEnabledBox;
        public System.Windows.Forms.Label BackupFinishedMessageLabel;
        public System.Windows.Forms.TextBox BackupFinishedMessageTextBox;
        public System.Windows.Forms.Label MessagesBoxLabel;
    }
}

