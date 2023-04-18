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
        int id;
        public Leaderboard()
        { }
        public Leaderboard(int id)
        {
            this.id= id;
            InitializeComponent();
          

            picBoxCrown.Image = Image.FromFile("first.png");
            picBoxLeaderboard.Image = Image.FromFile("leaderboard.png");


            //add user rankings
            ArrayOfString leaderboard;
             leaderboard = service.ShowLeaderboard();
            int i=0; string space;
            foreach ( string row in leaderboard) {
               string[] splitrow = row.Split(';');
                i++;
               space = new String(' ',29-splitrow[0].Trim().Length );
                listBoxRank.Items.Add(splitrow[0].Trim()+ space+ splitrow[2].Trim() + space +splitrow[1].Trim() +" " +i);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 next = new Form2(id);
            next.Show();
        }
    }
}
