using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTMCSC_DreamTown_Minecraft_Server_Console
{
    public partial class Main : Form
    {
        private Server Server;//这个对象负责核心的开服，回显文本等，由于软件是为单核心管理，所以全局用一个即可(之后会支持多核心的吧……)
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            {
                string ConfigFile = Application.StartupPath + @"\Config.ini";
                Text_JavaPath.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "JavaPath", "");
                Text_CorePath.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "CorePath", "");
                Text_Xms.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "MinMemory", "512");
                Text_Xmx.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "MaxMemory", "1024");
            }//读取相关配置并写入相应文本框
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string time = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                OutPut.Text = "[Console]欢迎使用DTMCSC，现在时间：" + time;
            }//在输出框内展示欢迎语
        }
        private void Commands_Enter(object sender, EventArgs e)
        {
            if (Text_Command.Text != "" && Text_Command.ForeColor == Color.Gray)
            {
                Text_Command.Text = "";
                Text_Command.ForeColor = Color.Black;
            }
            else
            {
                //为了语法完整，水一个片段(～￣▽￣)～
            }
        }//指令输入框获取焦点
        private void Commands_Leave(object sender, EventArgs e)
        {
            if(Text_Command.Text == "" && Text_Command.ForeColor == Color.Black)
            {
                Text_Command.Text = "输入指令并回车发送至服务端（无需加“/”）";
                Text_Command.ForeColor = Color.Gray;
            }
        }//指令输入框失去焦点
        private void StartServer_Click(object sender, EventArgs e)
        {
            string ConfigFile = Application.StartupPath + @"\Config.ini";
            string JavaPath;
            string CorePath;
            string Xms;
            string Xmx;
            string Command;
            {
                if (Text_JavaPath.Text != "")
                {
                    JavaPath = Text_JavaPath.Text;
                }
                else
                {
                    if(WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "JavaPath","")!="")
                    {
                        JavaPath = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "JavaPath", "");
                        Text_JavaPath.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "JavaPath", "");
                    }//文本框未读取到，尝试读配置并写入
                    else
                    {
                        //JavaPath = "";
                        Text_JavaPath.Text = "";
                        MessageBox.Show("开服命令行初始化生成失败" + "\n" + "原因：Java路径未设置或设置后未保存配置，请前去设置，设置后别忘保存呀", "初始化错误",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }//错误，返回设置

                }
            }//为Java路径局部变量JavaPath赋值
            {
                {
                    if (Text_CorePath.Text != "")
                    {
                        CorePath = Text_CorePath.Text;
                        Command = JavaPath + " -jar " + CorePath;
                    }
                    else
                    {
                        if (WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "CorePath", "") != "")
                        {
                            CorePath = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "CorePath", "");
                            Text_CorePath.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "CorePath", "");
                            Command = JavaPath + " -jar " + CorePath;
                        }//文本框未读取到，尝试读配置并写入
                        else
                        {
                            //CorePath = "";
                            MessageBox.Show("开服命令行初始化生成失败" + "\n" + "原因：服务器核心路径未设置或设置后未保存设置，请前去设置，设置后别忘保存呀", "初始化错误",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }//出错，则不进行，返回
                    }
                
                }//读取核心路径并赋值至CorePath和Command
                {
                    if(Text_Xms.Text != "" && Text_Xmx.Text != "")
                    {
                        Xms = Text_Xms.Text;
                        Xmx = Text_Xmx.Text;
                        Command = Command + " -Xms " + Xms + "M -Xmx " + Xmx + "M";
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("检测到您未设置服务器可用内存，要使用默认设置嘛？" + "\n" + "默认Xms=512M,Xmx=1024M", "内存设置错误",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if(result == DialogResult.Yes)
                        {
                            Xms = "512";
                            Xmx = "1024";
                            Text_Xms.Text = "512";
                            Text_Xmx.Text = "1024";
                            Command = Command + " -Xms " + Xms + "M -Xmx" + Xmx + "M";
                        }//未设置，询问
                        else
                        {
                            return;
                        }//取消开服，返回修改
                    }
                }//读取Xms和Xmx设置并赋值至Xms和Xmx变量
                {
                    if(Command == JavaPath + " -Jar " + CorePath + " -Xms " + Xms + "M -Xmx " + Xmx + "M")
                    {
                        Command = Command + " nogui";
                        Server.Run(JavaPath, Command);
                    }//正确，开服
                    else
                    {
                        MessageBox.Show("开服命令行初始化生成在最后一步失败了:(" + "\n" + "原因：我也不知道啊:(，最好把服务端跟程序一起打包反馈至xiaopanjun666@163.com吧！",
                            "初始化错误",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }//出现错误，取消开服并报错
                }//验证开服命令行是否正常
            }//初始化开服命令行并执行开服命令
        }//启动服务器按钮.被点击

        private void RestartServer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这个功能还未实装哦！" + "\n" + "想用的话可以先用关服再开替代一下哒！" + "\n" + "实在想方便就去催更叭！", "未实装的功能",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//重启服务器按钮.被点击

        private void StopServer_Click(object sender, EventArgs e)
        {
            Server.Stop();
        }//关闭服务器按钮.被点击

        private void KillServer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这个功能还未实装哦！" + "\n" + "想用的话……我也没辙" + "\n" + "要不任务管理器先凑合一下？" + "\n" + "实在想方便就去催更叭！", "未实装的功能",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//强制关闭服务器按钮.被点击

        private void Text_Command_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))//判断按键
            {
                if (Text_Command.Text == "")
                {
                    MessageBox.Show("不能发送空指令哦！", "指令发送失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //e.Handled = true;//消除系统错误提示
                    OutPut.Text = OutPut.Text + "\r\n" + "[Console]" + Text_Command.Text;//添加注释
                    Server.SendCommand(Text_Command.Text);//发出命令
                    Text_Command.Text = "";//清空编辑框
                }
            }
        }//发送指令相关

        private void Save_BasicSettings_Click(object sender, EventArgs e)
        {
            string ConfigFile = Application.StartupPath + @"\Config.ini";
            WinAPI.WritePrivateProfileString(ConfigFile, "BasicSettings", "JavaPath", Text_JavaPath.Text);
            WinAPI.WritePrivateProfileString(ConfigFile, "BasicSettings", "CorePath", Text_CorePath.Text);
            WinAPI.WritePrivateProfileString(ConfigFile, "BasicSettings", "Xms", Text_Xms.Text);
            WinAPI.WritePrivateProfileString(ConfigFile, "BasicSettings", "Xmx", Text_Xmx.Text);
        }//保存所更改的设置内容

        private void NoSave_BasicSettings_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("你确定要撤销所有更改吗？撤销之后无法挽回的啊！", "点我干啥？？",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.Yes)
            {
                string ConfigFile = Application.StartupPath + @"\Config.ini";
                Text_JavaPath.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "JavaPath", "");
                Text_CorePath.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "CorePath", "");
                Text_Xms.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "MinMemory", "512");
                Text_Xmx.Text = WinAPI.GetPrivateProfileString(ConfigFile, "BasicSettings", "MaxMemory", "1024");
            }
        }//撤销所有更改
    }
}
