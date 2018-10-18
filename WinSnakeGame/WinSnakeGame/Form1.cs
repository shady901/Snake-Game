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
        static string currentKey;
        Random rand = new Random();
        static int x, y;
        double distanceBetween;
        public Form1()
        {
            InitializeComponent();
        }





        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Update_Tick(object sender, EventArgs e)
        {
           
            lbl_currentKeyPressCheck.Text =Convert.ToString( distanceBetween) ;
            lbl_xy1.Text = Convert.ToString(pb_playerHead.Location.X+"||"+pb_playerHead.Location.Y);
            pb_playerHead.Left += x;
            pb_playerHead.Top += y;
            AppleCheck();
           // Death();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            currentKey = Convert.ToString(e.KeyChar).ToLower();
            if (currentKey == "a") //using wasd for movement due to arrow keys not working as intended
            {
                x = -1; // direction
                y = 0; // stops angled direction 
            }
            if (currentKey == "w")
            {
                x = 0;
                y = -1;
            }
            if (currentKey == "s")
            {
                x = 0;
                y = +1;
            }
            if (currentKey == "d")
            {
                x = +1;
                y = 0;
            }
            
        }
        private void AppleCheck() // checks if player is close enough to apple 
        {
            distanceBetween = Math.Sqrt((Math.Abs(((pb_playerHead.Location.X - pb_apple.Location.X) ^ 2)) + Math.Abs(((pb_playerHead.Location.Y - pb_apple.Location.Y) ^ 2))));
        
            if (distanceBetween <4)
            {
                pb_apple.Left = rand.Next(2,798);
                pb_apple.Top = rand.Next(2, 598);
                GiveTail();
            }
        }

        

        private void Death()
        {
            
        
        }
        private void GiveTail()//gives tail when apple is eaten
        {
            PictureBox pb_tail = new PictureBox();
            pb_tail.Height = 20;
            pb_tail.Width = 20;
          
            pb_tail.BackColor = Color.Green;

        }
    }
}
