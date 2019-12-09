using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MazeGameProject
{
    public partial class Leaderboard3 : Form
    {
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MazeGameProject.Properties.Settings.LeaderboardConnectionString"].ConnectionString);

        public Leaderboard3()
        {
            InitializeComponent();
            frmMaze3.frmObj.timer.Stop();
        }

        private void leaderboard3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.leaderboard3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.leaderboard3DataSet);

        }

        private void Leaderboard3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaderboard3DataSet.Leaderboard3' table. You can move, or remove it, as needed.
            this.leaderboard3TableAdapter.Fill(this.leaderboard3DataSet.Leaderboard3);
            btnSubmit.Enabled = true;
            txtUsername.Enabled = true;
            txtUsername.Text = "anon";
        }



        private void AddToLeaderBoard()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Leaderboard3 (Name, Time) VALUES (@Name, @Time);", sqlCon);
                cmd.Parameters.AddWithValue("@Name", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Time", frmMaze3.frmObj.i);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Time successfully submitted! Click on the ''Time'' column to see the best or worst time!", "SUCCESS!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void DisplayLeaderBoard()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Leaderboard3", sqlCon);
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = cmd;
                DataTable newDT = new DataTable();
                sqlDA.Fill(newDT);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = newDT;
                leaderboard3DataGridView.DataSource = bSource;
                sqlDA.Update(newDT);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                AddToLeaderBoard();
                DisplayLeaderBoard();
                btnSubmit.Enabled = false;
                txtUsername.Enabled = false;
                txtUsername.Text = "YOU'VE SUCCESSFULLY SUBMITTED YOUR TIME. PLEASE HIT ''CONTINUE'' TO CONTINUE";
            }
            else
            {
                MessageBox.Show("Make sure to enter a name! If you would not like to submit, click continue.", "Error!");

            }
        }
    }
}
