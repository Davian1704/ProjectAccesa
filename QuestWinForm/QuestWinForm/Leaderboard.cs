using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestWinForm
{
    public partial class Leaderboard : Form
    {
        string username;
        public Leaderboard()
        { }
        public Leaderboard(string username)
        {
            this.username = username;
            InitializeComponent();
            picBoxCrown.Image = Image.FromFile("first.png");
            picBoxLeaderboard.Image = Image.FromFile("leaderboard.png");

            listBoxRank.Items.Add("Soldier X 12 13 1");
            listBoxRank.Items.Add("Knight Y 12 10 2");
            //add user rankings
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 next = new Form2(username);
            next.Show();
        }
    }
}
