﻿using System;
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
        String username;
        public Form2()
        {
            InitializeComponent();
         
        }

        public Form2(String username)
        {
          this.username = username;
            InitializeComponent();
            usernameBox.Text = username;
            pictureBoxUser.Image = Image.FromFile("adventurer.png");
            pictureBoxTitle.Image = Image.FromFile("quest.png");
            picBoxRank.Image = Image.FromFile("leaderboard.png");

            picBoxBadge.Image = Image.FromFile("badge.png");
            picBoxBadge1.Image = Image.FromFile("badge.png");
            picBoxBadge2.Image = Image.FromFile("badge.png");

            picBoxToken.Image = Image.FromFile("token.png");
            picBoxToken1.Image = Image.FromFile("token.png");
            picBoxToken2.Image = Image.FromFile("token.png");

            tabControl.SelectedTab = Home;


            //add modify username function if time allows for it
            //load user information:
            rankCount.Text = "Rank#"+1;
            badgeCount.Text = "0";
            tokenCount.Text = "0";
        }

        private void Form2_Load(object sender, EventArgs e)
        {  }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 next = new Form1();
            next.Show();
        }

        private void quest_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Quest_Maker;
            badgeBox.Text = "0";
            tokenBox.Text = "0";
            //taskBox.Text
            titleBox.Text = "0";
        }

        private void postQuestButton_Click(object sender, EventArgs e)
        {

            if (int.Parse(badgeBox.Text) >= int.Parse(badgeCount.Text)  && int.Parse(tokenBox.Text) >= int.Parse(tokenCount.Text)) { 
            var result = MessageBox.Show("Are you sure you want to post this Quest? It cannot be deleted afterwards!", "Confirm",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                //function goes here
            }

            }
            else MessageBox.Show("Insufficient resources for reward.", "Warning");
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            Hide();
            Leaderboard next = new Leaderboard(username);
            next.Show();
        }

        private void questboardButton_Click(object sender, EventArgs e)
        {
            Hide();
            Questboard next = new Questboard(username);
            next.Show();
        }
    }
}