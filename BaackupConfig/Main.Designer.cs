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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Box_ServerSettings = new System.Windows.Forms.GroupBox();
            this.Box_BackupSettings = new System.Windows.Forms.GroupBox();
            this.Box_BackupMessages = new System.Windows.Forms.GroupBox();
            this.Box_WorkingDirectory = new System.Windows.Forms.GroupBox();
            this.Box_WorldsContainer = new System.Windows.Forms.GroupBox();
            this.Box_ServerSettings_Platform = new System.Windows.Forms.ComboBox();
            this.Box_ServerSettings_Platform_Label = new System.Windows.Forms.Label();
            this.Box_RCONSettings = new System.Windows.Forms.GroupBox();
            this.Box_ServerPlatform_BackupPlugins = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Box_ServerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box_ServerSettings
            // 
            this.Box_ServerSettings.Controls.Add(this.checkBox2);
            this.Box_ServerSettings.Controls.Add(this.Box_ServerPlatform_BackupPlugins);
            this.Box_ServerSettings.Controls.Add(this.Box_ServerSettings_Platform_Label);
            this.Box_ServerSettings.Controls.Add(this.Box_ServerSettings_Platform);
            this.Box_ServerSettings.Location = new System.Drawing.Point(13, 13);
            this.Box_ServerSettings.Name = "Box_ServerSettings";
            this.Box_ServerSettings.Size = new System.Drawing.Size(227, 92);
            this.Box_ServerSettings.TabIndex = 0;
            this.Box_ServerSettings.TabStop = false;
            this.Box_ServerSettings.Text = "General Server Settings";
            // 
            // Box_BackupSettings
            // 
            this.Box_BackupSettings.Location = new System.Drawing.Point(13, 126);
            this.Box_BackupSettings.Name = "Box_BackupSettings";
            this.Box_BackupSettings.Size = new System.Drawing.Size(227, 114);
            this.Box_BackupSettings.TabIndex = 1;
            this.Box_BackupSettings.TabStop = false;
            this.Box_BackupSettings.Text = "Backup Location Settings";
            // 
            // Box_BackupMessages
            // 
            this.Box_BackupMessages.Location = new System.Drawing.Point(13, 246);
            this.Box_BackupMessages.Name = "Box_BackupMessages";
            this.Box_BackupMessages.Size = new System.Drawing.Size(453, 103);
            this.Box_BackupMessages.TabIndex = 2;
            this.Box_BackupMessages.TabStop = false;
            this.Box_BackupMessages.Text = "Backup Messages";
            // 
            // Box_WorkingDirectory
            // 
            this.Box_WorkingDirectory.Location = new System.Drawing.Point(472, 246);
            this.Box_WorkingDirectory.Name = "Box_WorkingDirectory";
            this.Box_WorkingDirectory.Size = new System.Drawing.Size(200, 103);
            this.Box_WorkingDirectory.TabIndex = 3;
            this.Box_WorkingDirectory.TabStop = false;
            this.Box_WorkingDirectory.Text = "Working Directory Settings";
            // 
            // Box_WorldsContainer
            // 
            this.Box_WorldsContainer.Location = new System.Drawing.Point(247, 13);
            this.Box_WorldsContainer.Name = "Box_WorldsContainer";
            this.Box_WorldsContainer.Size = new System.Drawing.Size(200, 121);
            this.Box_WorldsContainer.TabIndex = 4;
            this.Box_WorldsContainer.TabStop = false;
            this.Box_WorldsContainer.Text = "Worlds Container Settings";
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
            this.Box_ServerSettings_Platform.Location = new System.Drawing.Point(6, 36);
            this.Box_ServerSettings_Platform.Name = "Box_ServerSettings_Platform";
            this.Box_ServerSettings_Platform.Size = new System.Drawing.Size(121, 21);
            this.Box_ServerSettings_Platform.TabIndex = 0;
            this.Box_ServerSettings_Platform.Text = "Vanilla";
            // 
            // Box_ServerSettings_Platform_Label
            // 
            this.Box_ServerSettings_Platform_Label.AutoSize = true;
            this.Box_ServerSettings_Platform_Label.Location = new System.Drawing.Point(7, 20);
            this.Box_ServerSettings_Platform_Label.Name = "Box_ServerSettings_Platform_Label";
            this.Box_ServerSettings_Platform_Label.Size = new System.Drawing.Size(79, 13);
            this.Box_ServerSettings_Platform_Label.TabIndex = 1;
            this.Box_ServerSettings_Platform_Label.Text = "Server Platform";
            // 
            // Box_RCONSettings
            // 
            this.Box_RCONSettings.Location = new System.Drawing.Point(247, 141);
            this.Box_RCONSettings.Name = "Box_RCONSettings";
            this.Box_RCONSettings.Size = new System.Drawing.Size(200, 100);
            this.Box_RCONSettings.TabIndex = 5;
            this.Box_RCONSettings.TabStop = false;
            this.Box_RCONSettings.Text = "RCON Setings";
            // 
            // Box_ServerPlatform_BackupPlugins
            // 
            this.Box_ServerPlatform_BackupPlugins.AutoSize = true;
            this.Box_ServerPlatform_BackupPlugins.Location = new System.Drawing.Point(6, 63);
            this.Box_ServerPlatform_BackupPlugins.Name = "Box_ServerPlatform_BackupPlugins";
            this.Box_ServerPlatform_BackupPlugins.Size = new System.Drawing.Size(100, 17);
            this.Box_ServerPlatform_BackupPlugins.TabIndex = 2;
            this.Box_ServerPlatform_BackupPlugins.Text = "Backup Plugins";
            this.Box_ServerPlatform_BackupPlugins.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(112, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Backup Logs";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.Box_RCONSettings);
            this.Controls.Add(this.Box_WorldsContainer);
            this.Controls.Add(this.Box_WorkingDirectory);
            this.Controls.Add(this.Box_BackupMessages);
            this.Controls.Add(this.Box_BackupSettings);
            this.Controls.Add(this.Box_ServerSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Baackup Configuration Tool";
            this.Box_ServerSettings.ResumeLayout(false);
            this.Box_ServerSettings.PerformLayout();
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
        private System.Windows.Forms.GroupBox Box_RCONSettings;
    }
}