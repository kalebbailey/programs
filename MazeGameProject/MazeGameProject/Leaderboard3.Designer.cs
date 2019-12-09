namespace MazeGameProject
{
    partial class Leaderboard3
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
            this.leaderboard3DataSet = new MazeGameProject.Leaderboard3DataSet();
            this.leaderboard3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaderboard3TableAdapter = new MazeGameProject.Leaderboard3DataSetTableAdapters.Leaderboard3TableAdapter();
            this.tableAdapterManager = new MazeGameProject.Leaderboard3DataSetTableAdapters.TableAdapterManager();
            this.leaderboard3DataGridView = new System.Windows.Forms.DataGridView();
            this.txtPlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboard3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboard3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboard3DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderboard3DataSet
            // 
            this.leaderboard3DataSet.DataSetName = "Leaderboard3DataSet";
            this.leaderboard3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaderboard3BindingSource
            // 
            this.leaderboard3BindingSource.DataMember = "Leaderboard3";
            this.leaderboard3BindingSource.DataSource = this.leaderboard3DataSet;
            // 
            // leaderboard3TableAdapter
            // 
            this.leaderboard3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Leaderboard3TableAdapter = this.leaderboard3TableAdapter;
            this.tableAdapterManager.UpdateOrder = MazeGameProject.Leaderboard3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // leaderboard3DataGridView
            // 
            this.leaderboard3DataGridView.AllowUserToAddRows = false;
            this.leaderboard3DataGridView.AllowUserToDeleteRows = false;
            this.leaderboard3DataGridView.AutoGenerateColumns = false;
            this.leaderboard3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderboard3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtPlayerID,
            this.txtName,
            this.txtTime});
            this.leaderboard3DataGridView.DataSource = this.leaderboard3BindingSource;
            this.leaderboard3DataGridView.Location = new System.Drawing.Point(12, 59);
            this.leaderboard3DataGridView.Name = "leaderboard3DataGridView";
            this.leaderboard3DataGridView.ReadOnly = true;
            this.leaderboard3DataGridView.Size = new System.Drawing.Size(578, 321);
            this.leaderboard3DataGridView.TabIndex = 1;
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.DataPropertyName = "PlayerID";
            this.txtPlayerID.HeaderText = "PlayerID";
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.ReadOnly = true;
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(163, 413);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 33);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(352, 413);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(145, 33);
            this.btnContinue.TabIndex = 8;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(105, 387);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(475, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "Level 3 Leaderboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Leaderboard3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(605, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaderboard3DataGridView);
            this.Name = "Leaderboard3";
            this.Text = "Leaderboard3";
            this.Load += new System.EventHandler(this.Leaderboard3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaderboard3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboard3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboard3DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Leaderboard3DataSet leaderboard3DataSet;
        private System.Windows.Forms.BindingSource leaderboard3BindingSource;
        private Leaderboard3DataSetTableAdapters.Leaderboard3TableAdapter leaderboard3TableAdapter;
        private Leaderboard3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView leaderboard3DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}