namespace MazeGameProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLevel1 = new System.Windows.Forms.Label();
            this.lblLevel2 = new System.Windows.Forms.Label();
            this.lblLevel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(-9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(826, 457);
            this.label2.TabIndex = 7;
            this.label2.Text = "MAZE GAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Location = new System.Drawing.Point(354, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLevel1
            // 
            this.lblLevel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblLevel1.ForeColor = System.Drawing.Color.White;
            this.lblLevel1.Location = new System.Drawing.Point(351, 279);
            this.lblLevel1.Name = "lblLevel1";
            this.lblLevel1.Size = new System.Drawing.Size(100, 23);
            this.lblLevel1.TabIndex = 9;
            this.lblLevel1.Text = "Level 1";
            this.lblLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel1.Click += new System.EventHandler(this.lblLevel1_Click);
            // 
            // lblLevel2
            // 
            this.lblLevel2.BackColor = System.Drawing.Color.Green;
            this.lblLevel2.ForeColor = System.Drawing.Color.White;
            this.lblLevel2.Location = new System.Drawing.Point(351, 322);
            this.lblLevel2.Name = "lblLevel2";
            this.lblLevel2.Size = new System.Drawing.Size(100, 23);
            this.lblLevel2.TabIndex = 10;
            this.lblLevel2.Text = "Level 2 [SOON]";
            this.lblLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel2.Click += new System.EventHandler(this.lblLevel2_Click);
            // 
            // lblLevel3
            // 
            this.lblLevel3.BackColor = System.Drawing.Color.DarkRed;
            this.lblLevel3.ForeColor = System.Drawing.Color.White;
            this.lblLevel3.Location = new System.Drawing.Point(351, 367);
            this.lblLevel3.Name = "lblLevel3";
            this.lblLevel3.Size = new System.Drawing.Size(100, 23);
            this.lblLevel3.TabIndex = 11;
            this.lblLevel3.Text = "Level 3 [SOON]";
            this.lblLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel3.Click += new System.EventHandler(this.lblLevel3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLevel3);
            this.Controls.Add(this.lblLevel2);
            this.Controls.Add(this.lblLevel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLevel1;
        private System.Windows.Forms.Label lblLevel2;
        private System.Windows.Forms.Label lblLevel3;
    }
}