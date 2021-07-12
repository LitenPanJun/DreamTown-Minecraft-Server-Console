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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Commands_Enter(object sender, EventArgs e)
        {
            if (Commands.Text != "" && Commands.ForeColor == Color.Gray)
            {
                Commands.Text = "";
                Commands.ForeColor = Color.Black;
            }
            else
            {

            }
        }//输入框获取焦点

        private void Commands_Leave(object sender, EventArgs e)
        {
            if(Commands.Text == "" && Commands.ForeColor == Color.Black)
            {
                Commands.Text = "输入指令并回车发送至服务端（无需加“/”）";
                Commands.ForeColor = Color.Gray;
            }
        }//输入框失去焦点
    }
}
