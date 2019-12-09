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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void lblLevel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After clicking ''OK'', the mouse cursor will be moved to the starting position. Your objective is to move through the maze without touching a wall. During completion, a timer will be running. If you would like to submit your time to a leaderboard, you will be prompted to do so. Enjoy!", "Instructions");
            frmMaze level1 = new frmMaze();
            level1.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lblLevel2_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("After clicking ''OK'', the mouse cursor will be moved to the starting position. Your objective is to move through the maze without touching a wall. During completion, a timer will be running. If you would like to submit your time to a leaderboard, you will be prompted to do so. Enjoy!", "Instructions");
            frmMaze2 level2 = new frmMaze2();
            level2.Show();
            this.Hide();*/
        }

        private void lblLevel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After clicking ''OK'', the mouse cursor will be moved to the starting position. Your objective is to move through the maze without touching a wall. During completion, a timer will be running. If you would like to submit your time to a leaderboard, you will be prompted to do so. Enjoy!", "Instructions");
            frmMaze3 level3 = new frmMaze3();
            level3.Show();
            this.Hide();
        }
    }
}
