using QuestWinForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QuestWinForm
{
    public partial class Form2 : Form
    {
        QuestWinForm.ServiceReference1.QuestWebServiceSoapClient service = new QuestWinForm.ServiceReference1.QuestWebServiceSoapClient();
        int id;
        public Form2()
        {
            InitializeComponent();
         
        }

        public Form2(int id)
        {
            this.id = id;
            InitializeComponent();
          
            pictureBoxUser.Image = Image.FromFile("adventurer.png");
            pictureBoxTitle.Image = Image.FromFile("quest.png");
          //  picBoxRank.Image = Image.FromFile("leaderboard.png");

            picBoxBadge.Image = Image.FromFile("badge.png");
            picBoxBadge1.Image = Image.FromFile("badge.png");
            picBoxBadge2.Image = Image.FromFile("badge.png");

            picBoxToken.Image = Image.FromFile("token.png");
            picBoxToken1.Image = Image.FromFile("token.png");
            picBoxToken2.Image = Image.FromFile("token.png");

            tabControl.SelectedTab = Home;

            ArrayOfString userInfo;
            userInfo = service.ShowUser(id);
             usernameBox.Text = userInfo[1];
            badgeCount.Text = userInfo[3];
            tokenCount.Text = userInfo[4];
        }

        private void Form2_Load(object sender, EventArgs e)
        {  }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            Login next = new Login();
            next.Show();
        }

        private void quest_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Quest_Maker;
            badgeBox.Text = "0";
            tokenBox.Text = "0";
            titleBox.Text = "0";
        }

        private void postQuestButton_Click(object sender, EventArgs e)
        {

            if (int.Parse(badgeBox.Text) <= int.Parse(badgeCount.Text)  && int.Parse(tokenBox.Text) <= int.Parse(tokenCount.Text)) { 
            var result = MessageBox.Show("Are you sure you want to post this Quest? It cannot be deleted afterwards!", "Confirm",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                    service.AddQuest(titleBox.Text.ToString(), taskBox.Text.ToString(),int.Parse(tokenBox.Text),int.Parse(badgeBox.Text),id); 
            }

            }
            else MessageBox.Show("Insufficient resources for reward.", "Warning");
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            Hide();
            Leaderboard next = new Leaderboard(id);
            next.Show();
        }

        private void questboardButton_Click(object sender, EventArgs e)
        {
            Hide();
            Questboard next = new Questboard(id);
            next.Show();
        }
    }
}
