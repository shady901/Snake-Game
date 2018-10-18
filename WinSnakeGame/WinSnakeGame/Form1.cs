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
    public partial class frmWindow : Form
    {
        
        static PictureBox[] pb_tail = new PictureBox[1000];
        static string currentKey;
        Random rand = new Random();

        static int x, y,tailCounter = 0;
        static int counter, tailSpawnAreaX,tailSpawnAreaY;
        static double distanceBetween;

        static int testingCounter=0;
       

       
      





        int score = 0, foodPoints = 10, speed = 1;

        public frmWindow()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Update_Tick(object sender, EventArgs e)
        {

           
            lbl_currentKeyPressCheck.Text =Convert.ToString( distanceBetween) ;
            if (score >=10)
            {
                lbl_xy1.Text = Convert.ToString(pb_tail[0].Location.X + "||" + pb_tail[0].Location.Y);

            }
            pb_playerHead.Left += x;
            pb_playerHead.Top += y;
            AppleCheck();
           
            counter++;
            if (counter ==15)
            {
                tailSpawnAreaX = pb_playerHead.Location.X;
                tailSpawnAreaY = pb_playerHead.Location.Y;
                counter = 0;
                
            }
            TailMovement();




            DisplayScore();
            lbl_currentKeyPressCheck.Text = Convert.ToString(distanceBetween);
            lbl_xy1.Text = Convert.ToString(pb_playerHead.Location.X + "||" + pb_playerHead.Location.Y);
            pb_playerHead.Left += x;
            pb_playerHead.Top += y;
            AppleCheck();
           // Death();
            lblWinHeight.Text = Width.ToString() + " " + pb_playerHead.Right;
            lblWinWidth.Text = Height.ToString() + " " + pb_playerHead.Height;
        }

        private void DisplayScore()
        {
            lbl_Score.Text = score.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            currentKey = Convert.ToString(e.KeyChar).ToLower();
            if (currentKey == "a") //using wasd for movement due to arrow keys not working as intended
            {
                x = -speed; // direction
                y = 0; // stops angled direction 
            }
            if (currentKey == "w")
            {
                x = 0;
                y = -speed;
            }
            if (currentKey == "s")
            {
                x = 0;
                y = +speed;
            }
            if (currentKey == "d")
            {
                x = +speed;
                y = 0;
            }
        }
        private void AppleCheck() // checks if player is close enough to apple 
        {
            distanceBetween = Math.Sqrt((Math.Abs(((pb_playerHead.Location.X - pb_apple.Location.X) ^ 2)) + Math.Abs(((pb_playerHead.Location.Y - pb_apple.Location.Y) ^ 2))));

            if (distanceBetween < 4)
            {

                pb_apple.Left = rand.Next(2, 798);
                pb_apple.Top = rand.Next(2, 550);
                score += foodPoints;
                speed += 1/2;
                GiveTail();
                
            }
         }
        

        private void Death()
        {
            //dying to edges
            if(pb_playerHead.Location.X <= 1)
            {
                Update.Stop();
            }

            //I literally had to get to these numbers by dying over and over again. (trying to get the snake to die just as the edges hit the sides)
            //Doing width minus the snake's width didn't work for some reason, for me anyway...
            if (pb_playerHead.Location.X >= Width - 40)
            {
                Update.Stop();
            }

            if(pb_playerHead.Location.Y <= 1)
            {
                Update.Stop();
            }

            if (pb_playerHead.Location.Y >= Height - 70)
            {
                Update.Stop();
            }
        
        }
        private void GiveTail()//gives tail when apple is eaten
        {
          
            pb_tail[tailCounter] = new PictureBox
            {
                Height = 18,
                Width = 18,
                BackColor = Color.Green,
                Left = tailSpawnAreaX,
                Top = tailSpawnAreaY,
               


            };

            this.Controls.Add(pb_tail[tailCounter]);

            tailCounter+=1;
        }
        private void TailMovement()
        {
            if (score >=10)
            {
                pb_tail[0].Left = tailSpawnAreaX;
                pb_tail[0].Top = tailSpawnAreaY;
            }

            if (score>= 20)
            {
               
                if (testingCounter ==25)
                {
                    for (int i = 1; i < pb_tail.Count(); ++i)
                    {
                        pb_tail[i].Left = pb_tail[i-1].Location.X;
                        pb_tail[i].Top = pb_tail[i-1].Location.Y;
                        testingCounter = 0;
                    }
                }
                testingCounter++;
               
            }
            

        }

    }
}
