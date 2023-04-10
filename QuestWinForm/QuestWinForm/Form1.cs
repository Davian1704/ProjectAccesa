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
                Hide();
                Form2 next = new Form2(usernameBox.Text.ToString());
                next.Show();
                }
                else MessageBox.Show("Please enter your password to log in!.", "Warning");
            }
            else MessageBox.Show("Please enter your username to log in!.", "Warning");
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameBox.Text))
            {
                if (!string.IsNullOrEmpty(passwordBox.Text))
                {
                    Hide();
                    Form2 next = new Form2(usernameBox.Text.ToString());
                    next.Show();
                }
                else MessageBox.Show("Please create a password to register!.", "Warning");
            }
            else MessageBox.Show("Please create a username to register!.", "Warning");
        }
    }
}

