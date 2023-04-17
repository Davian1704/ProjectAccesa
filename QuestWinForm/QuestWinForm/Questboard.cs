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
        public Questboard()
        {
            InitializeComponent();
        }

        public Questboard(int id)
        {
            this.id = id;
            InitializeComponent();
            pictureBoxQuest.Image = Image.FromFile("questboard.png");

            ArrayOfString questboard;
            questboard = service.ShowQuestBoard();
            int i = 0;
            foreach (string row in questboard)
            {
                i++;
                listBoxQuests.Items.Add(row[0] + "   " + row[1] + " " + row[2] + " " + "  " + i);
            }
            //listBoxQuests.Items.Add("Slay Dragon  30");

            pictureBoxTitle.Image = Image.FromFile("quest.png");
            picBoxBadge2.Image = Image.FromFile("badge.png");
            picBoxToken2.Image = Image.FromFile("token.png");

        }

        private void pickQuestButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = QuestPage;


            //code to give quest id and post it
            badgeBox.Text = "0";
            tokenBox.Text = "0";
            creatorBox.Text = "Soldier X";
            //taskBox.Text
            titleBox.Text = "0";
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
                service.AcceptQuest(id);
                tabControl1.SelectedTab = BoardPage;
            }
        }
    }
}
