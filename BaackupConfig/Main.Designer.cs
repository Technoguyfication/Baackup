namespace BaackupConfig
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Box_ServerSettings = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Box_ServerPlatform_BackupPlugins = new System.Windows.Forms.CheckBox();
            this.Box_ServerSettings_Platform_Label = new System.Windows.Forms.Label();
            this.Box_ServerSettings_Platform = new System.Windows.Forms.ComboBox();
            this.Box_BackupSettings = new System.Windows.Forms.GroupBox();
            this.Box_BackupMessages = new System.Windows.Forms.GroupBox();
            this.Box_WorkingDirectory = new System.Windows.Forms.GroupBox();
            this.Box_WorldsContainer = new System.Windows.Forms.GroupBox();
            this.Box_RCON = new System.Windows.Forms.GroupBox();
            this.Box_BackupSettings_SaveContainer = new System.Windows.Forms.TextBox();
            this.Box_BackupSettings_SaveContainer_Title = new System.Windows.Forms.Label();
            this.ToolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.Box_BackupSettings_SaveContainer_Browse = new System.Windows.Forms.Button();
            this.Box_BackupSettings_Prefix_Title = new System.Windows.Forms.Label();
            this.Box_BackupSettings_Prefix = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Box_BackupMessages_Started_Title = new System.Windows.Forms.Label();
            this.Box_BackupMessages_Finished_Title = new System.Windows.Forms.Label();
            this.Box_BackupMessages_Finished_Enabled = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Box_RCON_Enabled = new System.Windows.Forms.CheckBox();
            this.Box_RCON_Hostname_Title = new System.Windows.Forms.Label();
            this.Box_RCON_Hostname = new System.Windows.Forms.TextBox();
            this.Box_RCON_Password_Title = new System.Windows.Forms.Label();
            this.Box_RCON_Password = new System.Windows.Forms.TextBox();
            this.Box_RCON_Port_Label = new System.Windows.Forms.Label();
            this.Box_RCON_Port = new System.Windows.Forms.TextBox();
            this.Box_ServerSettings.SuspendLayout();
            this.Box_BackupSettings.SuspendLayout();
            this.Box_BackupMessages.SuspendLayout();
            this.Box_RCON.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box_ServerSettings
            // 
            this.Box_ServerSettings.Controls.Add(this.checkBox2);
            this.Box_ServerSettings.Controls.Add(this.Box_ServerPlatform_BackupPlugins);
            this.Box_ServerSettings.Controls.Add(this.Box_ServerSettings_Platform_Label);
            this.Box_ServerSettings.Controls.Add(this.Box_ServerSettings_Platform);
            this.Box_ServerSettings.Location = new System.Drawing.Point(12, 12);
            this.Box_ServerSettings.Name = "Box_ServerSettings";
            this.Box_ServerSettings.Size = new System.Drawing.Size(227, 80);
            this.Box_ServerSettings.TabIndex = 0;
            this.Box_ServerSettings.TabStop = false;
            this.Box_ServerSettings.Text = "General Server Settings";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(112, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Backup Logs";
            this.ToolTip_Info.SetToolTip(this.checkBox2, "Backup server logs?");
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Box_ServerPlatform_BackupPlugins
            // 
            this.Box_ServerPlatform_BackupPlugins.AutoSize = true;
            this.Box_ServerPlatform_BackupPlugins.Location = new System.Drawing.Point(6, 59);
            this.Box_ServerPlatform_BackupPlugins.Name = "Box_ServerPlatform_BackupPlugins";
            this.Box_ServerPlatform_BackupPlugins.Size = new System.Drawing.Size(100, 17);
            this.Box_ServerPlatform_BackupPlugins.TabIndex = 2;
            this.Box_ServerPlatform_BackupPlugins.Text = "Backup Plugins";
            this.ToolTip_Info.SetToolTip(this.Box_ServerPlatform_BackupPlugins, "Backup the plugins folder?");
            this.Box_ServerPlatform_BackupPlugins.UseVisualStyleBackColor = true;
            // 
            // Box_ServerSettings_Platform_Label
            // 
            this.Box_ServerSettings_Platform_Label.AutoSize = true;
            this.Box_ServerSettings_Platform_Label.Location = new System.Drawing.Point(6, 16);
            this.Box_ServerSettings_Platform_Label.Name = "Box_ServerSettings_Platform_Label";
            this.Box_ServerSettings_Platform_Label.Size = new System.Drawing.Size(79, 13);
            this.Box_ServerSettings_Platform_Label.TabIndex = 1;
            this.Box_ServerSettings_Platform_Label.Text = "Server Platform";
            // 
            // Box_ServerSettings_Platform
            // 
            this.Box_ServerSettings_Platform.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Box_ServerSettings_Platform.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Box_ServerSettings_Platform.FormattingEnabled = true;
            this.Box_ServerSettings_Platform.Items.AddRange(new object[] {
            "Vanilla",
            "CraftBukkit",
            "Spigot"});
            this.Box_ServerSettings_Platform.Location = new System.Drawing.Point(6, 32);
            this.Box_ServerSettings_Platform.Name = "Box_ServerSettings_Platform";
            this.Box_ServerSettings_Platform.Size = new System.Drawing.Size(121, 21);
            this.Box_ServerSettings_Platform.TabIndex = 0;
            this.Box_ServerSettings_Platform.Text = "Vanilla";
            this.ToolTip_Info.SetToolTip(this.Box_ServerSettings_Platform, "What server platform your server runs");
            // 
            // Box_BackupSettings
            // 
            this.Box_BackupSettings.Controls.Add(this.Box_BackupSettings_Prefix);
            this.Box_BackupSettings.Controls.Add(this.Box_BackupSettings_Prefix_Title);
            this.Box_BackupSettings.Controls.Add(this.Box_BackupSettings_SaveContainer_Browse);
            this.Box_BackupSettings.Controls.Add(this.Box_BackupSettings_SaveContainer_Title);
            this.Box_BackupSettings.Controls.Add(this.Box_BackupSettings_SaveContainer);
            this.Box_BackupSettings.Location = new System.Drawing.Point(12, 98);
            this.Box_BackupSettings.Name = "Box_BackupSettings";
            this.Box_BackupSettings.Size = new System.Drawing.Size(227, 108);
            this.Box_BackupSettings.TabIndex = 1;
            this.Box_BackupSettings.TabStop = false;
            this.Box_BackupSettings.Text = "Backup Saving";
            // 
            // Box_BackupMessages
            // 
            this.Box_BackupMessages.Controls.Add(this.textBox2);
            this.Box_BackupMessages.Controls.Add(this.Box_BackupMessages_Finished_Enabled);
            this.Box_BackupMessages.Controls.Add(this.Box_BackupMessages_Finished_Title);
            this.Box_BackupMessages.Controls.Add(this.Box_BackupMessages_Started_Title);
            this.Box_BackupMessages.Controls.Add(this.checkBox1);
            this.Box_BackupMessages.Controls.Add(this.textBox1);
            this.Box_BackupMessages.Location = new System.Drawing.Point(12, 212);
            this.Box_BackupMessages.Name = "Box_BackupMessages";
            this.Box_BackupMessages.Size = new System.Drawing.Size(453, 110);
            this.Box_BackupMessages.TabIndex = 2;
            this.Box_BackupMessages.TabStop = false;
            this.Box_BackupMessages.Text = "Backup Alerts";
            // 
            // Box_WorkingDirectory
            // 
            this.Box_WorkingDirectory.Location = new System.Drawing.Point(471, 190);
            this.Box_WorkingDirectory.Name = "Box_WorkingDirectory";
            this.Box_WorkingDirectory.Size = new System.Drawing.Size(200, 103);
            this.Box_WorkingDirectory.TabIndex = 3;
            this.Box_WorkingDirectory.TabStop = false;
            this.Box_WorkingDirectory.Text = "Working Directory Settings";
            // 
            // Box_WorldsContainer
            // 
            this.Box_WorldsContainer.Location = new System.Drawing.Point(471, 28);
            this.Box_WorldsContainer.Name = "Box_WorldsContainer";
            this.Box_WorldsContainer.Size = new System.Drawing.Size(200, 121);
            this.Box_WorldsContainer.TabIndex = 4;
            this.Box_WorldsContainer.TabStop = false;
            this.Box_WorldsContainer.Text = "Worlds Container Settings";
            // 
            // Box_RCON
            // 
            this.Box_RCON.Controls.Add(this.Box_RCON_Port);
            this.Box_RCON.Controls.Add(this.Box_RCON_Port_Label);
            this.Box_RCON.Controls.Add(this.Box_RCON_Password);
            this.Box_RCON.Controls.Add(this.Box_RCON_Password_Title);
            this.Box_RCON.Controls.Add(this.Box_RCON_Hostname);
            this.Box_RCON.Controls.Add(this.Box_RCON_Hostname_Title);
            this.Box_RCON.Controls.Add(this.Box_RCON_Enabled);
            this.Box_RCON.Location = new System.Drawing.Point(245, 12);
            this.Box_RCON.Name = "Box_RCON";
            this.Box_RCON.Size = new System.Drawing.Size(200, 194);
            this.Box_RCON.TabIndex = 5;
            this.Box_RCON.TabStop = false;
            this.Box_RCON.Text = "RCON Setings";
            // 
            // Box_BackupSettings_SaveContainer
            // 
            this.Box_BackupSettings_SaveContainer.Location = new System.Drawing.Point(6, 36);
            this.Box_BackupSettings_SaveContainer.Name = "Box_BackupSettings_SaveContainer";
            this.Box_BackupSettings_SaveContainer.Size = new System.Drawing.Size(183, 20);
            this.Box_BackupSettings_SaveContainer.TabIndex = 0;
            this.ToolTip_Info.SetToolTip(this.Box_BackupSettings_SaveContainer, "The folder that your finished backups will be saved inside.");
            // 
            // Box_BackupSettings_SaveContainer_Title
            // 
            this.Box_BackupSettings_SaveContainer_Title.AutoSize = true;
            this.Box_BackupSettings_SaveContainer_Title.Location = new System.Drawing.Point(6, 20);
            this.Box_BackupSettings_SaveContainer_Title.Name = "Box_BackupSettings_SaveContainer_Title";
            this.Box_BackupSettings_SaveContainer_Title.Size = new System.Drawing.Size(104, 13);
            this.Box_BackupSettings_SaveContainer_Title.TabIndex = 1;
            this.Box_BackupSettings_SaveContainer_Title.Text = "Backup Save Folder";
            // 
            // Box_BackupSettings_SaveContainer_Browse
            // 
            this.Box_BackupSettings_SaveContainer_Browse.Location = new System.Drawing.Point(195, 34);
            this.Box_BackupSettings_SaveContainer_Browse.Name = "Box_BackupSettings_SaveContainer_Browse";
            this.Box_BackupSettings_SaveContainer_Browse.Size = new System.Drawing.Size(26, 23);
            this.Box_BackupSettings_SaveContainer_Browse.TabIndex = 2;
            this.Box_BackupSettings_SaveContainer_Browse.Text = "...";
            this.ToolTip_Info.SetToolTip(this.Box_BackupSettings_SaveContainer_Browse, "Browse...");
            this.Box_BackupSettings_SaveContainer_Browse.UseVisualStyleBackColor = true;
            // 
            // Box_BackupSettings_Prefix_Title
            // 
            this.Box_BackupSettings_Prefix_Title.AutoSize = true;
            this.Box_BackupSettings_Prefix_Title.Location = new System.Drawing.Point(6, 63);
            this.Box_BackupSettings_Prefix_Title.Name = "Box_BackupSettings_Prefix_Title";
            this.Box_BackupSettings_Prefix_Title.Size = new System.Drawing.Size(73, 13);
            this.Box_BackupSettings_Prefix_Title.TabIndex = 3;
            this.Box_BackupSettings_Prefix_Title.Text = "Backup Prefix";
            // 
            // Box_BackupSettings_Prefix
            // 
            this.Box_BackupSettings_Prefix.Location = new System.Drawing.Point(6, 80);
            this.Box_BackupSettings_Prefix.Name = "Box_BackupSettings_Prefix";
            this.Box_BackupSettings_Prefix.Size = new System.Drawing.Size(215, 20);
            this.Box_BackupSettings_Prefix.TabIndex = 4;
            this.ToolTip_Info.SetToolTip(this.Box_BackupSettings_Prefix, "The prefix for saved backups.\r\n\r\nEx. \"Server01\"");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 0;
            this.ToolTip_Info.SetToolTip(this.textBox1, "A command to be run on the server when the backup process starts");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Box_BackupMessages_Started_Title
            // 
            this.Box_BackupMessages_Started_Title.AutoSize = true;
            this.Box_BackupMessages_Started_Title.Location = new System.Drawing.Point(6, 20);
            this.Box_BackupMessages_Started_Title.Name = "Box_BackupMessages_Started_Title";
            this.Box_BackupMessages_Started_Title.Size = new System.Drawing.Size(81, 13);
            this.Box_BackupMessages_Started_Title.TabIndex = 3;
            this.Box_BackupMessages_Started_Title.Text = "Backup Started";
            // 
            // Box_BackupMessages_Finished_Title
            // 
            this.Box_BackupMessages_Finished_Title.AutoSize = true;
            this.Box_BackupMessages_Finished_Title.Location = new System.Drawing.Point(6, 60);
            this.Box_BackupMessages_Finished_Title.Name = "Box_BackupMessages_Finished_Title";
            this.Box_BackupMessages_Finished_Title.Size = new System.Drawing.Size(97, 13);
            this.Box_BackupMessages_Finished_Title.TabIndex = 4;
            this.Box_BackupMessages_Finished_Title.Text = "Backup Completed";
            // 
            // Box_BackupMessages_Finished_Enabled
            // 
            this.Box_BackupMessages_Finished_Enabled.AutoSize = true;
            this.Box_BackupMessages_Finished_Enabled.Location = new System.Drawing.Point(6, 76);
            this.Box_BackupMessages_Finished_Enabled.Name = "Box_BackupMessages_Finished_Enabled";
            this.Box_BackupMessages_Finished_Enabled.Size = new System.Drawing.Size(65, 17);
            this.Box_BackupMessages_Finished_Enabled.TabIndex = 5;
            this.Box_BackupMessages_Finished_Enabled.Text = "Enabled";
            this.Box_BackupMessages_Finished_Enabled.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(370, 20);
            this.textBox2.TabIndex = 6;
            this.ToolTip_Info.SetToolTip(this.textBox2, "A command to be run on the server when the backup process finishes");
            // 
            // Box_RCON_Enabled
            // 
            this.Box_RCON_Enabled.AutoSize = true;
            this.Box_RCON_Enabled.Location = new System.Drawing.Point(10, 19);
            this.Box_RCON_Enabled.Name = "Box_RCON_Enabled";
            this.Box_RCON_Enabled.Size = new System.Drawing.Size(133, 17);
            this.Box_RCON_Enabled.TabIndex = 0;
            this.Box_RCON_Enabled.Text = "Enable RCON Support";
            this.Box_RCON_Enabled.UseVisualStyleBackColor = true;
            // 
            // Box_RCON_Hostname_Title
            // 
            this.Box_RCON_Hostname_Title.AutoSize = true;
            this.Box_RCON_Hostname_Title.Location = new System.Drawing.Point(10, 41);
            this.Box_RCON_Hostname_Title.Name = "Box_RCON_Hostname_Title";
            this.Box_RCON_Hostname_Title.Size = new System.Drawing.Size(55, 13);
            this.Box_RCON_Hostname_Title.TabIndex = 1;
            this.Box_RCON_Hostname_Title.Text = "Hostname";
            // 
            // Box_RCON_Hostname
            // 
            this.Box_RCON_Hostname.Location = new System.Drawing.Point(10, 56);
            this.Box_RCON_Hostname.Name = "Box_RCON_Hostname";
            this.Box_RCON_Hostname.Size = new System.Drawing.Size(184, 20);
            this.Box_RCON_Hostname.TabIndex = 2;
            // 
            // Box_RCON_Password_Title
            // 
            this.Box_RCON_Password_Title.AutoSize = true;
            this.Box_RCON_Password_Title.Location = new System.Drawing.Point(10, 90);
            this.Box_RCON_Password_Title.Name = "Box_RCON_Password_Title";
            this.Box_RCON_Password_Title.Size = new System.Drawing.Size(53, 13);
            this.Box_RCON_Password_Title.TabIndex = 3;
            this.Box_RCON_Password_Title.Text = "Password";
            // 
            // Box_RCON_Password
            // 
            this.Box_RCON_Password.Location = new System.Drawing.Point(10, 106);
            this.Box_RCON_Password.Name = "Box_RCON_Password";
            this.Box_RCON_Password.Size = new System.Drawing.Size(184, 20);
            this.Box_RCON_Password.TabIndex = 4;
            this.Box_RCON_Password.UseSystemPasswordChar = true;
            // 
            // Box_RCON_Port_Label
            // 
            this.Box_RCON_Port_Label.AutoSize = true;
            this.Box_RCON_Port_Label.Location = new System.Drawing.Point(10, 139);
            this.Box_RCON_Port_Label.Name = "Box_RCON_Port_Label";
            this.Box_RCON_Port_Label.Size = new System.Drawing.Size(26, 13);
            this.Box_RCON_Port_Label.TabIndex = 5;
            this.Box_RCON_Port_Label.Text = "Port";
            // 
            // Box_RCON_Port
            // 
            this.Box_RCON_Port.Location = new System.Drawing.Point(10, 156);
            this.Box_RCON_Port.MaxLength = 5;
            this.Box_RCON_Port.Name = "Box_RCON_Port";
            this.Box_RCON_Port.Size = new System.Drawing.Size(184, 20);
            this.Box_RCON_Port.TabIndex = 6;
            this.Box_RCON_Port.Leave += new System.EventHandler(this.Box_RCON_Port_Leave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 335);
            this.Controls.Add(this.Box_RCON);
            this.Controls.Add(this.Box_WorldsContainer);
            this.Controls.Add(this.Box_WorkingDirectory);
            this.Controls.Add(this.Box_BackupMessages);
            this.Controls.Add(this.Box_BackupSettings);
            this.Controls.Add(this.Box_ServerSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Baackup Configuration Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Box_ServerSettings.ResumeLayout(false);
            this.Box_ServerSettings.PerformLayout();
            this.Box_BackupSettings.ResumeLayout(false);
            this.Box_BackupSettings.PerformLayout();
            this.Box_BackupMessages.ResumeLayout(false);
            this.Box_BackupMessages.PerformLayout();
            this.Box_RCON.ResumeLayout(false);
            this.Box_RCON.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Box_ServerSettings;
        private System.Windows.Forms.GroupBox Box_BackupSettings;
        private System.Windows.Forms.GroupBox Box_BackupMessages;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox Box_ServerPlatform_BackupPlugins;
        private System.Windows.Forms.Label Box_ServerSettings_Platform_Label;
        private System.Windows.Forms.ComboBox Box_ServerSettings_Platform;
        private System.Windows.Forms.GroupBox Box_WorkingDirectory;
        private System.Windows.Forms.GroupBox Box_WorldsContainer;
        private System.Windows.Forms.GroupBox Box_RCON;
        private System.Windows.Forms.TextBox Box_BackupSettings_Prefix;
        private System.Windows.Forms.ToolTip ToolTip_Info;
        private System.Windows.Forms.Label Box_BackupSettings_Prefix_Title;
        private System.Windows.Forms.Button Box_BackupSettings_SaveContainer_Browse;
        private System.Windows.Forms.Label Box_BackupSettings_SaveContainer_Title;
        private System.Windows.Forms.TextBox Box_BackupSettings_SaveContainer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox Box_BackupMessages_Finished_Enabled;
        private System.Windows.Forms.Label Box_BackupMessages_Finished_Title;
        private System.Windows.Forms.Label Box_BackupMessages_Started_Title;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Box_RCON_Port_Label;
        private System.Windows.Forms.TextBox Box_RCON_Password;
        private System.Windows.Forms.Label Box_RCON_Password_Title;
        private System.Windows.Forms.TextBox Box_RCON_Hostname;
        private System.Windows.Forms.Label Box_RCON_Hostname_Title;
        private System.Windows.Forms.CheckBox Box_RCON_Enabled;
        public System.Windows.Forms.TextBox Box_RCON_Port;
    }
}