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

namespace QuestWinForm
{
    public partial class Form1 : Form
    {
        QuestWinForm.ServiceReference1.QuestWebServiceSoapClient service = new QuestWinForm.ServiceReference1.QuestWebServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
            pictureBoxTitle.Image = Image.FromFile("quest.png");
            pictureBoxUser.Image = Image.FromFile("adventurer.png");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameBox.Text))
            {
                if (!string.IsNullOrEmpty(passwordBox.Text)) { 

                int id=service.CheckUser(usernameBox.Text.ToString(), passwordBox.Text.ToString());
                    if (id != 0){
                        Hide();
                        Form2 next = new Form2(id);
                        next.Show();
                    }
                    else MessageBox.Show("Incorrect Login Information!", "Warning");
                }
                else MessageBox.Show("Please enter your password to log in!", "Warning");
            }
            else MessageBox.Show("Please enter your username to log in!", "Warning");
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameBox.Text))
            {
                if (!string.IsNullOrEmpty(passwordBox.Text))
                {
                    int id;
                    service.AddUser(usernameBox.Text.ToString(),passwordBox.Text.ToString(),0,0);
                    id = service.CheckUser(usernameBox.Text.ToString(), passwordBox.Text.ToString());
                    Hide();
                    Form2 next = new Form2(id);
                    next.Show();
                }
                else MessageBox.Show("Please create a password to register!.", "Warning");
            }
            else MessageBox.Show("Please create a username to register!.", "Warning");
        }
    }
}

