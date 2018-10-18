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

        static int x, y, tailCounter = 0;
        static int counter, tailSpawnAreaX, tailSpawnAreaY;
        static double distanceBetween;

        static int testingCounter = 0;
        static int newTailPieceAdded = 1;








        int score = 0, foodPoints = 10;
        double speed = 1;
        public frmWindow()

        {
            InitializeComponent();
            AddTailPiece(pb_playerHead.Left, pb_playerHead.Top);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Update_Tick(object sender, EventArgs e)
        {


            lbl_currentKeyPressCheck.Text = Convert.ToString(distanceBetween);
            lbl_xy1.Text = Convert.ToString(pb_tail[0].Location.X + "||" + pb_tail[0].Location.Y);
            pb_playerHead.Left += x;
            pb_playerHead.Top += y;

            AppleCheck();

            counter++;
            if (counter == 5)
            {

                tailSpawnAreaX = pb_playerHead.Location.X;
                tailSpawnAreaY = pb_playerHead.Location.Y;
                counter = 0;

            }
            TailMovement();


            DisplayScore();
            lbl_currentKeyPressCheck.Text = Convert.ToString(distanceBetween);
            lbl_xy1.Text = Convert.ToString(pb_playerHead.Location.X + "||" + pb_playerHead.Location.Y);
           
            //AppleCheck();
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
                x =Convert.ToInt32( -speed); // direction
                y = 0; // stops angled direction 
            }
            if (currentKey == "w")
            {
                x = 0;
                y = Convert.ToInt32(-speed);
            }
            if (currentKey == "s")
            {
                x = 0;
                y = Convert.ToInt32(+speed);
            }
            if (currentKey == "d")
            {
                x = Convert.ToInt32(+speed);
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
                speed +=1/2;
                GiveTail();

            }
        }


        private void Death()
        {
            //dying to edges
            if (pb_playerHead.Location.X <= 1)
            {
                Update.Stop();
            }

            //I literally had to get to these numbers by dying over and over again. (trying to get the snake to die just as the edges hit the sides)
            //Doing width minus the snake's width didn't work for some reason, for me anyway...
            if (pb_playerHead.Location.X >= Width - 40)
            {
                Update.Stop();
            }

            if (pb_playerHead.Location.Y <= 1)
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
            newTailPieceAdded++;

        }
        private void AddTailPiece(int X, int Y)
        {
            if (newTailPieceAdded > 0)
            {
                pb_tail[tailCounter] = new PictureBox
                {
                    Height = 18,
                    Width = 18,
                    BackColor = Color.Green,
                    Left = X,
                    Top = Y
                };

                this.Controls.Add(pb_tail[tailCounter]);
                newTailPieceAdded--;
                tailCounter += 1;
            }
        }

        private void TailMovement()
        {

            if (testingCounter == 10)
            {
                int oldX = 0;
                int oldY = 0;
                int newX = tailSpawnAreaX;
                int newY = tailSpawnAreaY;

                for (int i = 0; i < tailCounter; ++i)
                {
                    // Store old XY so you can use them for the next piece
                    oldX = pb_tail[i].Left;
                    oldY = pb_tail[i].Top;

                    // Set tail piece at new XY
                    pb_tail[i].Left = newX;
                    pb_tail[i].Top = newY;

                    // Set New XY = old XY
                    newX = oldX;
                    newY = oldY;

                }
                AddTailPiece(newX, newY); // Will add a new piece if needed
                testingCounter = 0;
            }
            testingCounter++;


        }

    }
}
