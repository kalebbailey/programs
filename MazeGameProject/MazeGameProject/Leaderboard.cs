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
namespace MazeGameProject
{

    public partial class Leaderboard : Form
    {
        
        SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Leaderboard.mdf;Integrated Security = True");

        
        public Leaderboard()
        {
            InitializeComponent();
            frmMaze.frmObj.timer1.Stop();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaderboardDataSet.Leaderboard' table. You can move, or remove it, as needed.
            this.leaderboardTableAdapter.Fill(this.leaderboardDataSet.Leaderboard);
            btnSubmit.Enabled = true;
            txtUsername.Enabled = true;
            txtUsername.Text = "anon";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        
        private void AddToLeaderBoard()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Leaderboard (Name, Time) VALUES (@Name, @Time);", sqlCon);
                cmd.Parameters.AddWithValue("@Name", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Time", frmMaze.frmObj.i);
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Leaderboard", sqlCon);
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = cmd;
                DataTable newDT = new DataTable();
                sqlDA.Fill(newDT);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = newDT;
                leaderboardDataGridView.DataSource = bSource;
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
                MessageBox.Show("Make sure to enter a name! If you would not like to submit, click continue.","Error!");

            }
            
        }
    }
}
