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
    public partial class frmMaze : Form
    {
        //MainMenu menu = new MainMenu();
        //Leaderboard leaderboard = new Leaderboard();
        public frmMaze()
        {
            InitializeComponent();
            frmObj = this;
            MoveToStart();
            timer1.Enabled = true;
            
        }


        private void MoveToStart()
        {
            Point start = pnlGameBoard.Location;
            start.Offset(10, 10);
            Cursor.Position = PointToScreen(start);
        }

        

        private void wall_MouseEnter(object sender, EventArgs e)
        {

            if (MessageBox.Show("You've hit a wall, try again!", "Uh Oh!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                i = 0;
                MoveToStart();

            }
            else
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Close();
            }
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            timer1.Stop();
            if (MessageBox.Show(string.Format("You won! Would you like to add your time of " + i +  " seconds to the leaderboard?"),"Congratulations!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                leaderboard.ShowDialog();


                if (MessageBox.Show("Would you like to improve your time?","Continue?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    i = 0;
                    timer1.Start();
                    MoveToStart();
                }
                else
                {
                    MainMenu menu = new MainMenu();
                    menu.Show();
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Would you like to restart?","Restart?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    i = 0;
                    timer1.Start();
                    MoveToStart();
                }
                else
                {
                    MainMenu menu = new MainMenu();
                    menu.Show();
                    this.Close();
                }
            }
                
        }

        public int i = 0;
        public void timer_Tick(object sender, EventArgs e)
        {
            i++;
            
            lblTimer.Text = i.ToString();
            
        }

        static frmMaze _frmObj;
        public static frmMaze frmObj
        {
            get { return _frmObj; }
            set { _frmObj = value; }
        }

    }
}
