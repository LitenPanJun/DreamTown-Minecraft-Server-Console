
namespace DTMCSC_DreamTown_Minecraft_Server_Console
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Console = new System.Windows.Forms.TabPage();
            this.BasicSettings = new System.Windows.Forms.TabPage();
            this.OutPut = new System.Windows.Forms.TextBox();
            this.Commands = new System.Windows.Forms.TextBox();
            this.JavaPath = new System.Windows.Forms.TextBox();
            this.Label_JavaPath = new System.Windows.Forms.Label();
            this.Browse_Java = new System.Windows.Forms.Button();
            this.Browse_Core = new System.Windows.Forms.Button();
            this.Label_CorePath = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label_Xms = new System.Windows.Forms.Label();
            this.Text_Xms = new System.Windows.Forms.TextBox();
            this.Text_Xmx = new System.Windows.Forms.TextBox();
            this.Label_Xmx = new System.Windows.Forms.Label();
            this.Save_BasicSettings = new System.Windows.Forms.Button();
            this.NoSave_BasicSettings = new System.Windows.Forms.Button();
            this.StartServer = new System.Windows.Forms.Button();
            this.RestartServer = new System.Windows.Forms.Button();
            this.StopServer = new System.Windows.Forms.Button();
            this.KillServer = new System.Windows.Forms.Button();
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
            this.Console.Controls.Add(this.Commands);
            this.Console.Controls.Add(this.OutPut);
            this.Console.Location = new System.Drawing.Point(4, 26);
            this.Console.Name = "Console";
            this.Console.Padding = new System.Windows.Forms.Padding(3);
            this.Console.Size = new System.Drawing.Size(794, 420);
            this.Console.TabIndex = 0;
            this.Console.Text = "控制台";
            this.Console.UseVisualStyleBackColor = true;
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
            this.BasicSettings.Controls.Add(this.textBox1);
            this.BasicSettings.Controls.Add(this.Browse_Java);
            this.BasicSettings.Controls.Add(this.Label_JavaPath);
            this.BasicSettings.Controls.Add(this.JavaPath);
            this.BasicSettings.Location = new System.Drawing.Point(4, 26);
            this.BasicSettings.Name = "BasicSettings";
            this.BasicSettings.Padding = new System.Windows.Forms.Padding(3);
            this.BasicSettings.Size = new System.Drawing.Size(794, 420);
            this.BasicSettings.TabIndex = 1;
            this.BasicSettings.Text = "基本设置";
            this.BasicSettings.UseVisualStyleBackColor = true;
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
            // Commands
            // 
            this.Commands.ForeColor = System.Drawing.Color.Gray;
            this.Commands.Location = new System.Drawing.Point(8, 389);
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(659, 23);
            this.Commands.TabIndex = 1;
            this.Commands.Text = "输入指令并回车发送至服务端（无需加“/”）";
            this.Commands.Enter += new System.EventHandler(this.Commands_Enter);
            this.Commands.Leave += new System.EventHandler(this.Commands_Leave);
            // 
            // JavaPath
            // 
            this.JavaPath.AllowDrop = true;
            this.JavaPath.Enabled = false;
            this.JavaPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.JavaPath.Location = new System.Drawing.Point(128, 27);
            this.JavaPath.Name = "JavaPath";
            this.JavaPath.ReadOnly = true;
            this.JavaPath.Size = new System.Drawing.Size(498, 23);
            this.JavaPath.TabIndex = 0;
            this.JavaPath.TabStop = false;
            this.JavaPath.Text = "C:\\Program Files\\Java\\jdk-16.0.1\\bin\\java.exe";
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
            // Browse_Java
            // 
            this.Browse_Java.Location = new System.Drawing.Point(632, 27);
            this.Browse_Java.Name = "Browse_Java";
            this.Browse_Java.Size = new System.Drawing.Size(103, 23);
            this.Browse_Java.TabIndex = 2;
            this.Browse_Java.Text = "浏览…";
            this.Browse_Java.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(128, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(498, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "C:\\Users\\Administrator\\Dasktop\\Server\\mincraft_server.jar";
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
            // Text_Xms
            // 
            this.Text_Xms.Location = new System.Drawing.Point(231, 142);
            this.Text_Xms.Name = "Text_Xms";
            this.Text_Xms.Size = new System.Drawing.Size(70, 23);
            this.Text_Xms.TabIndex = 7;
            this.Text_Xms.Text = "512";
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
            // Save_BasicSettings
            // 
            this.Save_BasicSettings.Location = new System.Drawing.Point(530, 389);
            this.Save_BasicSettings.Name = "Save_BasicSettings";
            this.Save_BasicSettings.Size = new System.Drawing.Size(75, 23);
            this.Save_BasicSettings.TabIndex = 10;
            this.Save_BasicSettings.Text = "保存设置";
            this.Save_BasicSettings.UseVisualStyleBackColor = true;
            // 
            // NoSave_BasicSettings
            // 
            this.NoSave_BasicSettings.Location = new System.Drawing.Point(627, 389);
            this.NoSave_BasicSettings.Name = "NoSave_BasicSettings";
            this.NoSave_BasicSettings.Size = new System.Drawing.Size(157, 23);
            this.NoSave_BasicSettings.TabIndex = 11;
            this.NoSave_BasicSettings.Text = "取消保存并回退所有修改";
            this.NoSave_BasicSettings.UseVisualStyleBackColor = true;
            // 
            // StartServer
            // 
            this.StartServer.Location = new System.Drawing.Point(690, 18);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(83, 43);
            this.StartServer.TabIndex = 2;
            this.StartServer.Text = "启动服务器";
            this.StartServer.UseVisualStyleBackColor = true;
            // 
            // RestartServer
            // 
            this.RestartServer.Location = new System.Drawing.Point(690, 104);
            this.RestartServer.Name = "RestartServer";
            this.RestartServer.Size = new System.Drawing.Size(83, 43);
            this.RestartServer.TabIndex = 3;
            this.RestartServer.Text = "重启服务器";
            this.RestartServer.UseVisualStyleBackColor = true;
            // 
            // StopServer
            // 
            this.StopServer.Location = new System.Drawing.Point(690, 186);
            this.StopServer.Name = "StopServer";
            this.StopServer.Size = new System.Drawing.Size(83, 43);
            this.StopServer.TabIndex = 4;
            this.StopServer.Text = "关闭服务器";
            this.StopServer.UseVisualStyleBackColor = true;
            // 
            // KillServer
            // 
            this.KillServer.Location = new System.Drawing.Point(690, 273);
            this.KillServer.Name = "KillServer";
            this.KillServer.Size = new System.Drawing.Size(83, 43);
            this.KillServer.TabIndex = 5;
            this.KillServer.Text = "强制关闭服务器";
            this.KillServer.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "DreamTown Minecraft Server Console";
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
        private System.Windows.Forms.TextBox Commands;
        private System.Windows.Forms.TextBox OutPut;
        private System.Windows.Forms.Button Browse_Java;
        private System.Windows.Forms.Label Label_JavaPath;
        private System.Windows.Forms.TextBox JavaPath;
        private System.Windows.Forms.Button Browse_Core;
        private System.Windows.Forms.Label Label_CorePath;
        private System.Windows.Forms.TextBox textBox1;
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

