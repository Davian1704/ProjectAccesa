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

namespace QuestWinForm
{

    public partial class Questboard : Form
    {
        QuestWinForm.ServiceReference1.QuestWebServiceSoapClient service = new QuestWinForm.ServiceReference1.QuestWebServiceSoapClient();
        int id;
        ArrayOfString questboard;
        int questId;
        public Questboard()
        {
            InitializeComponent();
        }

        public Questboard(int id)
        {
            this.id = id;
            InitializeComponent();
            pictureBoxQuest.Image = Image.FromFile("questboard.png");

          
            questboard = service.ShowQuestBoard();
             string space;
            foreach (string row in questboard)
            {
                string[] splitrow = row.Split(';');
                space = new String(' ', 60- splitrow[1].Trim().Length);
                listBoxQuests.Items.Add(splitrow[1].Trim() + space+ splitrow[3].Trim() + " Tokens " + splitrow[4].Trim()+" Badges");
            }

                pictureBoxTitle.Image = Image.FromFile("quest.png");
            picBoxBadge2.Image = Image.FromFile("badge.png");
            picBoxToken2.Image = Image.FromFile("token.png");

        }

        private void pickQuestButton_Click(object sender, EventArgs e)
        {
                string[] splitrow = questboard[listBoxQuests.SelectedIndex].Split(';');
            questId = int.Parse(splitrow[0]);
            tabControl1.SelectedTab = QuestPage;
            
            ArrayOfString questInfo;
           questInfo= service.ShowQuest(questId);
            titleBox.Text = questInfo[1];
            taskBox.Text = questInfo[2];
            tokenBox.Text = questInfo[3];
            badgeBox.Text = questInfo[4];
            creatorBox.Text = questInfo[5];

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 next = new Form2(id);
            next.Show();
        }

        private void takeQuestButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to accept this Quest?", "Confirm",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                service.Reward(id, int.Parse(tokenBox.Text), int.Parse(badgeBox.Text));
                service.AcceptQuest(questId);
                tabControl1.SelectedTab = BoardPage;
            }
        }
    }
}
