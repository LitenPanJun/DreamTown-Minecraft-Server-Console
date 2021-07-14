
namespace DTMCSC_DreamTown_Minecraft_Server_Console
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Console = new System.Windows.Forms.TabPage();
            this.KillServer = new System.Windows.Forms.Button();
            this.StopServer = new System.Windows.Forms.Button();
            this.RestartServer = new System.Windows.Forms.Button();
            this.StartServer = new System.Windows.Forms.Button();
            this.Text_Command = new System.Windows.Forms.TextBox();
            this.OutPut = new System.Windows.Forms.TextBox();
            this.BasicSettings = new System.Windows.Forms.TabPage();
            this.NoSave_BasicSettings = new System.Windows.Forms.Button();
            this.Save_BasicSettings = new System.Windows.Forms.Button();
            this.Text_Xmx = new System.Windows.Forms.TextBox();
            this.Label_Xmx = new System.Windows.Forms.Label();
            this.Text_Xms = new System.Windows.Forms.TextBox();
            this.Label_Xms = new System.Windows.Forms.Label();
            this.Browse_Core = new System.Windows.Forms.Button();
            this.Label_CorePath = new System.Windows.Forms.Label();
            this.Text_CorePath = new System.Windows.Forms.TextBox();
            this.Browse_Java = new System.Windows.Forms.Button();
            this.Label_JavaPath = new System.Windows.Forms.Label();
            this.Text_JavaPath = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.Console.SuspendLayout();
            this.BasicSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Console);
            this.TabControl.Controls.Add(this.BasicSettings);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(802, 450);
            this.TabControl.TabIndex = 0;
            // 
            // Console
            // 
            this.Console.Controls.Add(this.KillServer);
            this.Console.Controls.Add(this.StopServer);
            this.Console.Controls.Add(this.RestartServer);
            this.Console.Controls.Add(this.StartServer);
            this.Console.Controls.Add(this.Text_Command);
            this.Console.Controls.Add(this.OutPut);
            this.Console.Location = new System.Drawing.Point(4, 26);
            this.Console.Name = "Console";
            this.Console.Padding = new System.Windows.Forms.Padding(3);
            this.Console.Size = new System.Drawing.Size(794, 420);
            this.Console.TabIndex = 0;
            this.Console.Text = "控制台";
            this.Console.UseVisualStyleBackColor = true;
            // 
            // KillServer
            // 
            this.KillServer.Location = new System.Drawing.Point(690, 273);
            this.KillServer.Name = "KillServer";
            this.KillServer.Size = new System.Drawing.Size(83, 43);
            this.KillServer.TabIndex = 5;
            this.KillServer.Text = "强制关闭服务器";
            this.KillServer.UseVisualStyleBackColor = true;
            this.KillServer.Click += new System.EventHandler(this.KillServer_Click);
            // 
            // StopServer
            // 
            this.StopServer.Location = new System.Drawing.Point(690, 186);
            this.StopServer.Name = "StopServer";
            this.StopServer.Size = new System.Drawing.Size(83, 43);
            this.StopServer.TabIndex = 4;
            this.StopServer.Text = "关闭服务器";
            this.StopServer.UseVisualStyleBackColor = true;
            this.StopServer.Click += new System.EventHandler(this.StopServer_Click);
            // 
            // RestartServer
            // 
            this.RestartServer.Location = new System.Drawing.Point(690, 104);
            this.RestartServer.Name = "RestartServer";
            this.RestartServer.Size = new System.Drawing.Size(83, 43);
            this.RestartServer.TabIndex = 3;
            this.RestartServer.Text = "重启服务器";
            this.RestartServer.UseVisualStyleBackColor = true;
            this.RestartServer.Click += new System.EventHandler(this.RestartServer_Click);
            // 
            // StartServer
            // 
            this.StartServer.Location = new System.Drawing.Point(690, 18);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(83, 43);
            this.StartServer.TabIndex = 2;
            this.StartServer.Text = "启动服务器";
            this.StartServer.UseVisualStyleBackColor = true;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // Text_Command
            // 
            this.Text_Command.ForeColor = System.Drawing.Color.Gray;
            this.Text_Command.Location = new System.Drawing.Point(8, 389);
            this.Text_Command.Name = "Text_Command";
            this.Text_Command.Size = new System.Drawing.Size(659, 23);
            this.Text_Command.TabIndex = 1;
            this.Text_Command.Text = "输入指令并回车发送至服务端（无需加“/”）";
            this.Text_Command.Enter += new System.EventHandler(this.Commands_Enter);
            this.Text_Command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Command_KeyPress);
            this.Text_Command.Leave += new System.EventHandler(this.Commands_Leave);
            // 
            // OutPut
            // 
            this.OutPut.Location = new System.Drawing.Point(8, 9);
            this.OutPut.Multiline = true;
            this.OutPut.Name = "OutPut";
            this.OutPut.ReadOnly = true;
            this.OutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutPut.Size = new System.Drawing.Size(659, 374);
            this.OutPut.TabIndex = 0;
            this.OutPut.TabStop = false;
            this.OutPut.Text = "[Console]欢迎使用DTMCSC，现在时间：YYYY.MM.DD HH:MM";
            // 
            // BasicSettings
            // 
            this.BasicSettings.Controls.Add(this.NoSave_BasicSettings);
            this.BasicSettings.Controls.Add(this.Save_BasicSettings);
            this.BasicSettings.Controls.Add(this.Text_Xmx);
            this.BasicSettings.Controls.Add(this.Label_Xmx);
            this.BasicSettings.Controls.Add(this.Text_Xms);
            this.BasicSettings.Controls.Add(this.Label_Xms);
            this.BasicSettings.Controls.Add(this.Browse_Core);
            this.BasicSettings.Controls.Add(this.Label_CorePath);
            this.BasicSettings.Controls.Add(this.Text_CorePath);
            this.BasicSettings.Controls.Add(this.Browse_Java);
            this.BasicSettings.Controls.Add(this.Label_JavaPath);
            this.BasicSettings.Controls.Add(this.Text_JavaPath);
            this.BasicSettings.Location = new System.Drawing.Point(4, 26);
            this.BasicSettings.Name = "BasicSettings";
            this.BasicSettings.Padding = new System.Windows.Forms.Padding(3);
            this.BasicSettings.Size = new System.Drawing.Size(794, 420);
            this.BasicSettings.TabIndex = 1;
            this.BasicSettings.Text = "基本设置";
            this.BasicSettings.UseVisualStyleBackColor = true;
            // 
            // NoSave_BasicSettings
            // 
            this.NoSave_BasicSettings.Location = new System.Drawing.Point(627, 389);
            this.NoSave_BasicSettings.Name = "NoSave_BasicSettings";
            this.NoSave_BasicSettings.Size = new System.Drawing.Size(157, 23);
            this.NoSave_BasicSettings.TabIndex = 11;
            this.NoSave_BasicSettings.Text = "取消保存并回退所有修改";
            this.NoSave_BasicSettings.UseVisualStyleBackColor = true;
            this.NoSave_BasicSettings.Click += new System.EventHandler(this.NoSave_BasicSettings_Click);
            // 
            // Save_BasicSettings
            // 
            this.Save_BasicSettings.Location = new System.Drawing.Point(530, 389);
            this.Save_BasicSettings.Name = "Save_BasicSettings";
            this.Save_BasicSettings.Size = new System.Drawing.Size(75, 23);
            this.Save_BasicSettings.TabIndex = 10;
            this.Save_BasicSettings.Text = "保存设置";
            this.Save_BasicSettings.UseVisualStyleBackColor = true;
            this.Save_BasicSettings.Click += new System.EventHandler(this.Save_BasicSettings_Click);
            // 
            // Text_Xmx
            // 
            this.Text_Xmx.Location = new System.Drawing.Point(556, 142);
            this.Text_Xmx.Name = "Text_Xmx";
            this.Text_Xmx.Size = new System.Drawing.Size(70, 23);
            this.Text_Xmx.TabIndex = 9;
            this.Text_Xmx.Text = "1024";
            // 
            // Label_Xmx
            // 
            this.Label_Xmx.AutoSize = true;
            this.Label_Xmx.Location = new System.Drawing.Point(378, 145);
            this.Label_Xmx.Name = "Label_Xmx";
            this.Label_Xmx.Size = new System.Drawing.Size(172, 17);
            this.Label_Xmx.TabIndex = 8;
            this.Label_Xmx.Text = "服务器最小可用内存（MB）：";
            // 
            // Text_Xms
            // 
            this.Text_Xms.Location = new System.Drawing.Point(231, 142);
            this.Text_Xms.Name = "Text_Xms";
            this.Text_Xms.Size = new System.Drawing.Size(70, 23);
            this.Text_Xms.TabIndex = 7;
            this.Text_Xms.Text = "512";
            // 
            // Label_Xms
            // 
            this.Label_Xms.AutoSize = true;
            this.Label_Xms.Location = new System.Drawing.Point(53, 145);
            this.Label_Xms.Name = "Label_Xms";
            this.Label_Xms.Size = new System.Drawing.Size(172, 17);
            this.Label_Xms.TabIndex = 6;
            this.Label_Xms.Text = "服务器最小可用内存（MB）：";
            // 
            // Browse_Core
            // 
            this.Browse_Core.Location = new System.Drawing.Point(632, 85);
            this.Browse_Core.Name = "Browse_Core";
            this.Browse_Core.Size = new System.Drawing.Size(103, 23);
            this.Browse_Core.TabIndex = 5;
            this.Browse_Core.Text = "浏览…";
            this.Browse_Core.UseVisualStyleBackColor = true;
            // 
            // Label_CorePath
            // 
            this.Label_CorePath.AutoSize = true;
            this.Label_CorePath.Location = new System.Drawing.Point(53, 88);
            this.Label_CorePath.Name = "Label_CorePath";
            this.Label_CorePath.Size = new System.Drawing.Size(68, 17);
            this.Label_CorePath.TabIndex = 4;
            this.Label_CorePath.Text = "核心路径：";
            // 
            // Text_CorePath
            // 
            this.Text_CorePath.AllowDrop = true;
            this.Text_CorePath.Enabled = false;
            this.Text_CorePath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_CorePath.Location = new System.Drawing.Point(128, 85);
            this.Text_CorePath.Name = "Text_CorePath";
            this.Text_CorePath.ReadOnly = true;
            this.Text_CorePath.Size = new System.Drawing.Size(498, 23);
            this.Text_CorePath.TabIndex = 3;
            this.Text_CorePath.TabStop = false;
            this.Text_CorePath.Text = "C:\\Users\\Administrator\\Dasktop\\Server\\mincraft_server.jar";
            // 
            // Browse_Java
            // 
            this.Browse_Java.Location = new System.Drawing.Point(632, 27);
            this.Browse_Java.Name = "Browse_Java";
            this.Browse_Java.Size = new System.Drawing.Size(103, 23);
            this.Browse_Java.TabIndex = 2;
            this.Browse_Java.Text = "浏览…";
            this.Browse_Java.UseVisualStyleBackColor = true;
            // 
            // Label_JavaPath
            // 
            this.Label_JavaPath.AutoSize = true;
            this.Label_JavaPath.Location = new System.Drawing.Point(53, 30);
            this.Label_JavaPath.Name = "Label_JavaPath";
            this.Label_JavaPath.Size = new System.Drawing.Size(69, 17);
            this.Label_JavaPath.TabIndex = 1;
            this.Label_JavaPath.Text = "Java路径：";
            // 
            // Text_JavaPath
            // 
            this.Text_JavaPath.AllowDrop = true;
            this.Text_JavaPath.Enabled = false;
            this.Text_JavaPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text_JavaPath.Location = new System.Drawing.Point(128, 27);
            this.Text_JavaPath.Name = "Text_JavaPath";
            this.Text_JavaPath.ReadOnly = true;
            this.Text_JavaPath.Size = new System.Drawing.Size(498, 23);
            this.Text_JavaPath.TabIndex = 0;
            this.Text_JavaPath.TabStop = false;
            this.Text_JavaPath.Text = "C:\\Program Files\\Java\\jdk-16.0.1\\bin\\java.exe";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "DreamTown Minecraft Server Console";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TabControl.ResumeLayout(false);
            this.Console.ResumeLayout(false);
            this.Console.PerformLayout();
            this.BasicSettings.ResumeLayout(false);
            this.BasicSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Console;
        private System.Windows.Forms.TabPage BasicSettings;
        private System.Windows.Forms.TextBox Text_Command;
        private System.Windows.Forms.TextBox OutPut;
        private System.Windows.Forms.Button Browse_Java;
        private System.Windows.Forms.Label Label_JavaPath;
        private System.Windows.Forms.TextBox Text_JavaPath;
        private System.Windows.Forms.Button Browse_Core;
        private System.Windows.Forms.Label Label_CorePath;
        private System.Windows.Forms.TextBox Text_CorePath;
        private System.Windows.Forms.Button KillServer;
        private System.Windows.Forms.Button StopServer;
        private System.Windows.Forms.Button RestartServer;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.Button NoSave_BasicSettings;
        private System.Windows.Forms.Button Save_BasicSettings;
        private System.Windows.Forms.TextBox Text_Xmx;
        private System.Windows.Forms.Label Label_Xmx;
        private System.Windows.Forms.TextBox Text_Xms;
        private System.Windows.Forms.Label Label_Xms;
    }
}

