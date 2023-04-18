namespace QuestWinForm
{
    partial class Questboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxQuest = new System.Windows.Forms.PictureBox();
            this.listBoxQuests = new System.Windows.Forms.ListBox();
            this.pickQuestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BoardPage = new System.Windows.Forms.TabPage();
            this.homeButton = new System.Windows.Forms.Button();
            this.QuestPage = new System.Windows.Forms.TabPage();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.creatorBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.takeQuestButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBoxToken2 = new System.Windows.Forms.PictureBox();
            this.picBoxBadge2 = new System.Windows.Forms.PictureBox();
            this.badgeBox = new System.Windows.Forms.TextBox();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.taskBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuest)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.BoardPage.SuspendLayout();
            this.QuestPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxToken2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBadge2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxQuest
            // 
            this.pictureBoxQuest.Location = new System.Drawing.Point(15, 26);
            this.pictureBoxQuest.Name = "pictureBoxQuest";
            this.pictureBoxQuest.Size = new System.Drawing.Size(298, 336);
            this.pictureBoxQuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuest.TabIndex = 18;
            this.pictureBoxQuest.TabStop = false;
            // 
            // listBoxQuests
            // 
            this.listBoxQuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQuests.FormattingEnabled = true;
            this.listBoxQuests.ItemHeight = 25;
            this.listBoxQuests.Location = new System.Drawing.Point(319, 63);
            this.listBoxQuests.Name = "listBoxQuests";
            this.listBoxQuests.Size = new System.Drawing.Size(655, 404);
            this.listBoxQuests.TabIndex = 19;
            // 
            // pickQuestButton
            // 
            this.pickQuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pickQuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickQuestButton.Location = new System.Drawing.Point(157, 394);
            this.pickQuestButton.Name = "pickQuestButton";
            this.pickQuestButton.Size = new System.Drawing.Size(156, 49);
            this.pickQuestButton.TabIndex = 20;
            this.pickQuestButton.Text = "Pick Quest";
            this.pickQuestButton.UseVisualStyleBackColor = false;
            this.pickQuestButton.Click += new System.EventHandler(this.pickQuestButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Available Quests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(821, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Reward";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BoardPage);
            this.tabControl1.Controls.Add(this.QuestPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 519);
            this.tabControl1.TabIndex = 23;
            // 
            // BoardPage
            // 
            this.BoardPage.Controls.Add(this.label8);
            this.BoardPage.Controls.Add(this.homeButton);
            this.BoardPage.Controls.Add(this.pickQuestButton);
            this.BoardPage.Controls.Add(this.label1);
            this.BoardPage.Controls.Add(this.label2);
            this.BoardPage.Controls.Add(this.pictureBoxQuest);
            this.BoardPage.Controls.Add(this.listBoxQuests);
            this.BoardPage.Location = new System.Drawing.Point(4, 25);
            this.BoardPage.Name = "BoardPage";
            this.BoardPage.Padding = new System.Windows.Forms.Padding(3);
            this.BoardPage.Size = new System.Drawing.Size(983, 490);
            this.BoardPage.TabIndex = 0;
            this.BoardPage.Text = "Questboard";
            this.BoardPage.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(6, 404);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 39);
            this.homeButton.TabIndex = 23;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // QuestPage
            // 
            this.QuestPage.Controls.Add(this.pictureBoxTitle);
            this.QuestPage.Controls.Add(this.creatorBox);
            this.QuestPage.Controls.Add(this.label7);
            this.QuestPage.Controls.Add(this.label4);
            this.QuestPage.Controls.Add(this.label3);
            this.QuestPage.Controls.Add(this.takeQuestButton);
            this.QuestPage.Controls.Add(this.groupBox3);
            this.QuestPage.Controls.Add(this.taskBox);
            this.QuestPage.Controls.Add(this.titleBox);
            this.QuestPage.Location = new System.Drawing.Point(4, 25);
            this.QuestPage.Name = "QuestPage";
            this.QuestPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuestPage.Size = new System.Drawing.Size(983, 490);
            this.QuestPage.TabIndex = 1;
            this.QuestPage.Text = "Quest";
            this.QuestPage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.Location = new System.Drawing.Point(730, 6);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(211, 121);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTitle.TabIndex = 28;
            this.pictureBoxTitle.TabStop = false;
            // 
            // creatorBox
            // 
            this.creatorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorBox.Location = new System.Drawing.Point(720, 253);
            this.creatorBox.Name = "creatorBox";
            this.creatorBox.ReadOnly = true;
            this.creatorBox.Size = new System.Drawing.Size(209, 34);
            this.creatorBox.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(725, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Made by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Title:";
            // 
            // takeQuestButton
            // 
            this.takeQuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.takeQuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeQuestButton.Location = new System.Drawing.Point(730, 339);
            this.takeQuestButton.Name = "takeQuestButton";
            this.takeQuestButton.Size = new System.Drawing.Size(151, 58);
            this.takeQuestButton.TabIndex = 27;
            this.takeQuestButton.Text = "Accept Quest";
            this.takeQuestButton.UseVisualStyleBackColor = false;
            this.takeQuestButton.Click += new System.EventHandler(this.takeQuestButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picBoxToken2);
            this.groupBox3.Controls.Add(this.picBoxBadge2);
            this.groupBox3.Controls.Add(this.badgeBox);
            this.groupBox3.Controls.Add(this.tokenBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(150, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 162);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rewards";
            // 
            // picBoxToken2
            // 
            this.picBoxToken2.Location = new System.Drawing.Point(288, 29);
            this.picBoxToken2.Name = "picBoxToken2";
            this.picBoxToken2.Size = new System.Drawing.Size(56, 44);
            this.picBoxToken2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxToken2.TabIndex = 27;
            this.picBoxToken2.TabStop = false;
            // 
            // picBoxBadge2
            // 
            this.picBoxBadge2.Location = new System.Drawing.Point(288, 79);
            this.picBoxBadge2.Name = "picBoxBadge2";
            this.picBoxBadge2.Size = new System.Drawing.Size(56, 44);
            this.picBoxBadge2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBadge2.TabIndex = 26;
            this.picBoxBadge2.TabStop = false;
            // 
            // badgeBox
            // 
            this.badgeBox.Location = new System.Drawing.Point(132, 82);
            this.badgeBox.Multiline = true;
            this.badgeBox.Name = "badgeBox";
            this.badgeBox.Size = new System.Drawing.Size(127, 39);
            this.badgeBox.TabIndex = 25;
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(132, 29);
            this.tokenBox.Multiline = true;
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(127, 44);
            this.tokenBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Badge:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tokens:";
            // 
            // taskBox
            // 
            this.taskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskBox.Location = new System.Drawing.Point(150, 141);
            this.taskBox.Multiline = true;
            this.taskBox.Name = "taskBox";
            this.taskBox.ReadOnly = true;
            this.taskBox.Size = new System.Drawing.Size(538, 146);
            this.taskBox.TabIndex = 25;
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(219, 87);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(209, 34);
            this.titleBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Title";
            // 
            // Questboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "Questboard";
            this.Text = "Questboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuest)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.BoardPage.ResumeLayout(false);
            this.BoardPage.PerformLayout();
            this.QuestPage.ResumeLayout(false);
            this.QuestPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxToken2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBadge2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQuest;
        private System.Windows.Forms.ListBox listBoxQuests;
        private System.Windows.Forms.Button pickQuestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BoardPage;
        private System.Windows.Forms.TabPage QuestPage;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox taskBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picBoxToken2;
        private System.Windows.Forms.PictureBox picBoxBadge2;
        private System.Windows.Forms.TextBox badgeBox;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button takeQuestButton;
        private System.Windows.Forms.TextBox creatorBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.Label label8;
    }
}