namespace MazeGameProject
{
    partial class frmMaze2
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
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.label116 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.pnlGameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlGameBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGameBoard.Controls.Add(this.label116);
            this.pnlGameBoard.Controls.Add(this.lblFinish);
            this.pnlGameBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(956, 933);
            this.pnlGameBoard.TabIndex = 1;
            // 
            // label116
            // 
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label116.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label116.Location = new System.Drawing.Point(3, 2);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(35, 20);
            this.label116.TabIndex = 116;
            this.label116.Text = "Start";
            // 
            // lblFinish
            // 
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFinish.Location = new System.Drawing.Point(914, 909);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(35, 20);
            this.lblFinish.TabIndex = 3;
            this.lblFinish.Text = "Finish";
            // 
            // frmMaze2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1071, 957);
            this.Controls.Add(this.pnlGameBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaze2";
            this.Text = "frmMaze2";
            this.pnlGameBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label lblFinish;
    }
}