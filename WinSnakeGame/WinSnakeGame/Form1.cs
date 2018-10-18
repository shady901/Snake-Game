using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSnakeGame
{
    public partial class Form1 : Form
    {
        public event KeyPressEventHandler KeysPress;
        static string currentKey;
        static int MovementAngle; //90,180,270,360
        static int x, y;
        public Form1()
        {
            InitializeComponent();
        }





        private void Btn_start_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            lbl_currentKeyPressCheck.Text = currentKey ;
            pb_playerHead.Left += x;
            pb_playerHead.Top += y;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            currentKey =Convert.ToString( e.KeyChar).ToLower();
            if (currentKey == "a")
            {
                x = -2;
                y = 0;
            }
            if (currentKey == "w")
            {
                x = 0;
                y = -2;
            }
            if (currentKey == "s")
            {
                x = 0;
                y = +2;
            }
            if (currentKey == "d")
            {
                x = +2;
                y = 0;
            }
        }
    }
}
