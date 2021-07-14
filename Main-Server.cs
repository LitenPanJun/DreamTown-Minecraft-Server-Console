using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DTMCSC_DreamTown_Minecraft_Server_Console
{
    class Server
    {
        private string FileDir;//决定服务端运行在那个目录
        private string JavaPath;//java.exe路径
        private Process Process;//进程
        private string Cmd;//命令行
        public Server(string FileDir)
        {
            this.FileDir = FileDir;
        }
        public bool Run(string JavaPath, string Cmd)
        {
            Process = new Process();
            Process.StartInfo.FileName = JavaPath;
            Process.StartInfo.Arguments = Cmd;
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.RedirectStandardError = true;
            Process.StartInfo.RedirectStandardInput = true;
            Process.StartInfo.CreateNoWindow = true;
            Process.StartInfo.WorkingDirectory = FileDir;
            try
            {
                Process.Start();
            }
            catch
            {
                Process = null;
                return false;
            }
            this.Cmd = Cmd;
            this.JavaPath = JavaPath;
            return true;
        }//根据设定的Cmd命令行启动服务器
        public bool SendCommand(string Cmd)
        {
            Process.StandardInput.WriteLine(Cmd);
            return true;
        }//发送命令至服务端
        public bool Stop()
        {
            SendCommand("Stop");
            return true;
        }//正常关闭服务器（非BC类）
        public bool Kill()
        {
            Process.Kill();
            return true;
        }
        public bool Restart()
        {
            //等待后期实现（挤牙膏ing）
            return true;
        }
    }
}
