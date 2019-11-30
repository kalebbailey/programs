namespace MazeGameProject
{
    partial class Leaderboard
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
            this.leaderboardDataSet = new MazeGameProject.LeaderboardDataSet();
            this.leaderboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaderboardTableAdapter = new MazeGameProject.LeaderboardDataSetTableAdapters.LeaderboardTableAdapter();
            this.tableAdapterManager = new MazeGameProject.LeaderboardDataSetTableAdapters.TableAdapterManager();
            this.leaderboardDataGridView = new System.Windows.Forms.DataGridView();
            this.txtPlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderboardDataSet
            // 
            this.leaderboardDataSet.DataSetName = "LeaderboardDataSet";
            this.leaderboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaderboardBindingSource
            // 
            this.leaderboardBindingSource.DataMember = "Leaderboard";
            this.leaderboardBindingSource.DataSource = this.leaderboardDataSet;
            // 
            // leaderboardTableAdapter
            // 
            this.leaderboardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LeaderboardTableAdapter = this.leaderboardTableAdapter;
            this.tableAdapterManager.UpdateOrder = MazeGameProject.LeaderboardDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // leaderboardDataGridView
            // 
            this.leaderboardDataGridView.AllowUserToAddRows = false;
            this.leaderboardDataGridView.AllowUserToDeleteRows = false;
            this.leaderboardDataGridView.AutoGenerateColumns = false;
            this.leaderboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderboardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtPlayerID,
            this.txtName,
            this.txtTime});
            this.leaderboardDataGridView.DataSource = this.leaderboardBindingSource;
            this.leaderboardDataGridView.Location = new System.Drawing.Point(12, 59);
            this.leaderboardDataGridView.Name = "leaderboardDataGridView";
            this.leaderboardDataGridView.ReadOnly = true;
            this.leaderboardDataGridView.Size = new System.Drawing.Size(578, 321);
            this.leaderboardDataGridView.TabIndex = 1;
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.DataPropertyName = "PlayerID";
            this.txtPlayerID.HeaderText = "PlayerID";
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.ReadOnly = true;
            this.txtPlayerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtPlayerID.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtTime
            // 
            this.txtTime.DataPropertyName = "Time";
            this.txtTime.HeaderText = "Time";
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(105, 385);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(475, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(352, 411);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(145, 33);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(163, 411);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 33);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "Level 1 Leaderboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(605, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaderboardDataGridView);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LeaderboardDataSet leaderboardDataSet;
        private System.Windows.Forms.BindingSource leaderboardBindingSource;
        private LeaderboardDataSetTableAdapters.LeaderboardTableAdapter leaderboardTableAdapter;
        private LeaderboardDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView leaderboardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
    }
}