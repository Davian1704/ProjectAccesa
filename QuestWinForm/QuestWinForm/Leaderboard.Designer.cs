namespace QuestWinForm
{
    partial class Leaderboard
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
            this.listBoxRank = new System.Windows.Forms.ListBox();
            this.picBoxCrown = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picBoxLeaderboard = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxRank
            // 
            this.listBoxRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRank.FormattingEnabled = true;
            this.listBoxRank.ItemHeight = 22;
            this.listBoxRank.Location = new System.Drawing.Point(27, 164);
            this.listBoxRank.Name = "listBoxRank";
            this.listBoxRank.Size = new System.Drawing.Size(678, 334);
            this.listBoxRank.TabIndex = 0;
            // 
            // picBoxCrown
            // 
            this.picBoxCrown.Location = new System.Drawing.Point(711, 164);
            this.picBoxCrown.Name = "picBoxCrown";
            this.picBoxCrown.Size = new System.Drawing.Size(60, 56);
            this.picBoxCrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCrown.TabIndex = 10;
            this.picBoxCrown.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tokens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Badges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(622, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rank";
            // 
            // picBoxLeaderboard
            // 
            this.picBoxLeaderboard.Location = new System.Drawing.Point(45, 12);
            this.picBoxLeaderboard.Name = "picBoxLeaderboard";
            this.picBoxLeaderboard.Size = new System.Drawing.Size(203, 91);
            this.picBoxLeaderboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLeaderboard.TabIndex = 15;
            this.picBoxLeaderboard.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(606, 29);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 39);
            this.homeButton.TabIndex = 19;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.picBoxLeaderboard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxCrown);
            this.Controls.Add(this.listBoxRank);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLeaderboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRank;
        private System.Windows.Forms.PictureBox picBoxCrown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBoxLeaderboard;
        private System.Windows.Forms.Button homeButton;
    }
}