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
            this.BackupPlugins = new System.Windows.Forms.CheckBox();
            this.ModdedServerOptions = new System.Windows.Forms.Label();
            this.PlatformPanel.SuspendLayout();
            this.ModdedOptions.SuspendLayout();
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
            // 
            // ReloadConfig
            // 
            this.ReloadConfig.Location = new System.Drawing.Point(395, 13);
            this.ReloadConfig.Name = "ReloadConfig";
            this.ReloadConfig.Size = new System.Drawing.Size(94, 23);
            this.ReloadConfig.TabIndex = 4;
            this.ReloadConfig.Text = "Reload config";
            this.ReloadConfig.UseVisualStyleBackColor = true;
            // 
            // ModdedOptions
            // 
            this.ModdedOptions.Controls.Add(this.ModdedServerOptions);
            this.ModdedOptions.Controls.Add(this.BackupPlugins);
            this.ModdedOptions.Location = new System.Drawing.Point(159, 12);
            this.ModdedOptions.Name = "ModdedOptions";
            this.ModdedOptions.Size = new System.Drawing.Size(200, 100);
            this.ModdedOptions.TabIndex = 5;
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
            // ModdedServerOptions
            // 
            this.ModdedServerOptions.AutoSize = true;
            this.ModdedServerOptions.Location = new System.Drawing.Point(-1, 1);
            this.ModdedServerOptions.Name = "ModdedServerOptions";
            this.ModdedServerOptions.Size = new System.Drawing.Size(119, 13);
            this.ModdedServerOptions.TabIndex = 1;
            this.ModdedServerOptions.Text = "Modded Server Options";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 329);
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

    }
}

