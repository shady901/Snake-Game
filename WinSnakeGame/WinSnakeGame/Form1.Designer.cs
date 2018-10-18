namespace WinSnakeGame
{
    partial class frmWindow
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
            this.components = new System.ComponentModel.Container();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.pb_playerHead = new System.Windows.Forms.PictureBox();
            this.lbl_currentKeyPressCheck = new System.Windows.Forms.Label();
            this.pb_apple = new System.Windows.Forms.PictureBox();
            this.lbl_xy1 = new System.Windows.Forms.Label();
            this.lbl_xy2 = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lblWinWidth = new System.Windows.Forms.Label();
            this.lblWinHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_playerHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apple)).BeginInit();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // pb_playerHead
            // 
            this.pb_playerHead.BackColor = System.Drawing.Color.Green;
            this.pb_playerHead.Location = new System.Drawing.Point(800, 460);
            this.pb_playerHead.Margin = new System.Windows.Forms.Padding(0);
            this.pb_playerHead.Name = "pb_playerHead";
            this.pb_playerHead.Size = new System.Drawing.Size(20, 20);
            this.pb_playerHead.TabIndex = 1;
            this.pb_playerHead.TabStop = false;
            // 
            // lbl_currentKeyPressCheck
            // 
            this.lbl_currentKeyPressCheck.AutoSize = true;
            this.lbl_currentKeyPressCheck.Location = new System.Drawing.Point(696, 17);
            this.lbl_currentKeyPressCheck.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_currentKeyPressCheck.Name = "lbl_currentKeyPressCheck";
            this.lbl_currentKeyPressCheck.Size = new System.Drawing.Size(0, 25);
            this.lbl_currentKeyPressCheck.TabIndex = 2;
            // 
            // pb_apple
            // 
            this.pb_apple.BackColor = System.Drawing.Color.Red;
            this.pb_apple.Location = new System.Drawing.Point(800, 420);
            this.pb_apple.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pb_apple.Name = "pb_apple";
            this.pb_apple.Size = new System.Drawing.Size(20, 20);
            this.pb_apple.TabIndex = 4;
            this.pb_apple.TabStop = false;
            // 
            // lbl_xy1
            // 
            this.lbl_xy1.AutoSize = true;
            this.lbl_xy1.Location = new System.Drawing.Point(454, 69);
            this.lbl_xy1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_xy1.Name = "lbl_xy1";
            this.lbl_xy1.Size = new System.Drawing.Size(0, 25);
            this.lbl_xy1.TabIndex = 5;
            // 
            // lbl_xy2
            // 
            this.lbl_xy2.AutoSize = true;
            this.lbl_xy2.Location = new System.Drawing.Point(1010, 69);
            this.lbl_xy2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_xy2.Name = "lbl_xy2";
            this.lbl_xy2.Size = new System.Drawing.Size(0, 25);
            this.lbl_xy2.TabIndex = 6;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Score.Location = new System.Drawing.Point(1334, 35);
            this.lbl_Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(35, 37);
            this.lbl_Score.TabIndex = 7;
            this.lbl_Score.Text = "0";
            // 
            // lblWinWidth
            // 
            this.lblWinWidth.AutoSize = true;
            this.lblWinWidth.Location = new System.Drawing.Point(1222, 996);
            this.lblWinWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinWidth.Name = "lblWinWidth";
            this.lblWinWidth.Size = new System.Drawing.Size(70, 25);
            this.lblWinWidth.TabIndex = 8;
            this.lblWinWidth.Text = "label1";
            // 
            // lblWinHeight
            // 
            this.lblWinHeight.AutoSize = true;
            this.lblWinHeight.Location = new System.Drawing.Point(1300, 996);
            this.lblWinHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinHeight.Name = "lblWinHeight";
            this.lblWinHeight.Size = new System.Drawing.Size(70, 25);
            this.lblWinHeight.TabIndex = 9;
            this.lblWinHeight.Text = "label1";
            // 
            // frmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 849);
            this.Controls.Add(this.lblWinHeight);
            this.Controls.Add(this.lblWinWidth);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_xy2);
            this.Controls.Add(this.lbl_xy1);
            this.Controls.Add(this.pb_apple);
            this.Controls.Add(this.lbl_currentKeyPressCheck);
            this.Controls.Add(this.pb_playerHead);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 920);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1600, 920);
            this.Name = "frmWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb_playerHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private new System.Windows.Forms.Timer Update;
        private System.Windows.Forms.PictureBox pb_playerHead;
        private System.Windows.Forms.Label lbl_currentKeyPressCheck;
        private System.Windows.Forms.PictureBox pb_apple;
        private System.Windows.Forms.Label lbl_xy1;
        private System.Windows.Forms.Label lbl_xy2;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lblWinWidth;
        private System.Windows.Forms.Label lblWinHeight;
    }
}

