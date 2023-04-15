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

    public partial class Leaderboard : Form
    {
        QuestWinForm.ServiceReference1.QuestWebServiceSoapClient service = new QuestWinForm.ServiceReference1.QuestWebServiceSoapClient();
        string username;
        public Leaderboard()
        { }
        public Leaderboard(string username)
        {
            this.username = username;
            InitializeComponent();
          

            picBoxCrown.Image = Image.FromFile("first.png");
            picBoxLeaderboard.Image = Image.FromFile("leaderboard.png");


            //add user rankings
            ArrayOfString leaderboard;
             leaderboard = service.ShowLeaderboard();
            int i=0;
            foreach( string row in leaderboard) {
                i++;
                listBoxRank.Items.Add(row[0]+ "   " + row[1]+" " + row[2]+" " +"  "+ i);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 next = new Form2(username);
            next.Show();
        }
    }
}
