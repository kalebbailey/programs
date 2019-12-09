using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGameProject
{
    public partial class frmMaze3 : Form
    {
        public frmMaze3()
        {
            InitializeComponent();
            frmObj = this;
            MoveToStart();
            timer.Enabled = true;
        }

        private void MoveToStart()
        {
            Point start = pnlGameBoard.Location;
            start.Offset(5, 5);
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

        public int i = 0;
        public void timer_Tick(object sender, EventArgs e)
        {
            i++;

            lblTimer.Text = i.ToString();
        }

        static frmMaze3 _frmObj;
        public static frmMaze3 frmObj
        {
            get { return _frmObj; }
            set { _frmObj = value; }
        }

        private void lblFin_MouseEnter(object sender, EventArgs e)
        {
            Leaderboard3 leaderboard3 = new Leaderboard3();
            timer.Stop();
            if (MessageBox.Show(string.Format("You won! Would you like to add your time of " + i + " seconds to the leaderboard?"), "Congratulations!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                leaderboard3.ShowDialog();


                if (MessageBox.Show("Would you like to improve your time?", "Continue?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    i = 0;
                    timer.Start();
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
                if (MessageBox.Show("Would you like to restart?", "Restart?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    i = 0;
                    timer.Start();
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
    }
}
