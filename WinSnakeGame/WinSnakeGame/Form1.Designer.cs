namespace WinSnakeGame
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_playerHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apple)).BeginInit();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Interval = 20;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // pb_playerHead
            // 
            this.pb_playerHead.BackColor = System.Drawing.Color.Green;
            this.pb_playerHead.Location = new System.Drawing.Point(702, 500);
            this.pb_playerHead.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pb_playerHead.Name = "pb_playerHead";
            this.pb_playerHead.Size = new System.Drawing.Size(50, 48);
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
            this.pb_apple.Location = new System.Drawing.Point(504, 283);
            this.pb_apple.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pb_apple.Name = "pb_apple";
            this.pb_apple.Size = new System.Drawing.Size(30, 29);
            this.pb_apple.TabIndex = 4;
            this.pb_apple.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1079);
            this.Controls.Add(this.pb_apple);
            this.Controls.Add(this.lbl_currentKeyPressCheck);
            this.Controls.Add(this.pb_playerHead);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb_playerHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.PictureBox pb_playerHead;
        private System.Windows.Forms.Label lbl_currentKeyPressCheck;
        private System.Windows.Forms.PictureBox pb_apple;
    }
}

