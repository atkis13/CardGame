namespace CardGame
{
    partial class MainForm
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
            this.pic_aiCard = new System.Windows.Forms.PictureBox();
            this.pic_playerCard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_noOfCards = new System.Windows.Forms.Label();
            this.lbl_palyerCardName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_playerCardStrenght = new System.Windows.Forms.Label();
            this.lbl_aiCardStrenght = new System.Windows.Forms.Label();
            this.lbl_aiCardName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_aiWins = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_wins = new System.Windows.Forms.Label();
            this.btn_playCard = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_win = new System.Windows.Forms.Button();
            this.pic_backgroung = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_aiCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_backgroung)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_aiCard
            // 
            this.pic_aiCard.Location = new System.Drawing.Point(377, 142);
            this.pic_aiCard.Name = "pic_aiCard";
            this.pic_aiCard.Size = new System.Drawing.Size(345, 532);
            this.pic_aiCard.TabIndex = 0;
            this.pic_aiCard.TabStop = false;
            // 
            // pic_playerCard
            // 
            this.pic_playerCard.Location = new System.Drawing.Point(859, 142);
            this.pic_playerCard.Name = "pic_playerCard";
            this.pic_playerCard.Size = new System.Drawing.Size(345, 532);
            this.pic_playerCard.TabIndex = 1;
            this.pic_playerCard.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1434, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cards left";
            // 
            // lbl_noOfCards
            // 
            this.lbl_noOfCards.AutoSize = true;
            this.lbl_noOfCards.BackColor = System.Drawing.Color.Transparent;
            this.lbl_noOfCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noOfCards.Location = new System.Drawing.Point(1453, 435);
            this.lbl_noOfCards.Name = "lbl_noOfCards";
            this.lbl_noOfCards.Size = new System.Drawing.Size(36, 39);
            this.lbl_noOfCards.TabIndex = 3;
            this.lbl_noOfCards.Text = "0";
            // 
            // lbl_palyerCardName
            // 
            this.lbl_palyerCardName.AutoSize = true;
            this.lbl_palyerCardName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_palyerCardName.Location = new System.Drawing.Point(1531, 715);
            this.lbl_palyerCardName.Name = "lbl_palyerCardName";
            this.lbl_palyerCardName.Size = new System.Drawing.Size(35, 13);
            this.lbl_palyerCardName.TabIndex = 4;
            this.lbl_palyerCardName.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1447, 715);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Card Played";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1447, 746);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Card Strenght";
            // 
            // lbl_playerCardStrenght
            // 
            this.lbl_playerCardStrenght.AutoSize = true;
            this.lbl_playerCardStrenght.BackColor = System.Drawing.Color.Transparent;
            this.lbl_playerCardStrenght.Location = new System.Drawing.Point(1531, 746);
            this.lbl_playerCardStrenght.Name = "lbl_playerCardStrenght";
            this.lbl_playerCardStrenght.Size = new System.Drawing.Size(35, 13);
            this.lbl_playerCardStrenght.TabIndex = 7;
            this.lbl_playerCardStrenght.Text = "label6";
            // 
            // lbl_aiCardStrenght
            // 
            this.lbl_aiCardStrenght.AutoSize = true;
            this.lbl_aiCardStrenght.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aiCardStrenght.Location = new System.Drawing.Point(133, 746);
            this.lbl_aiCardStrenght.Name = "lbl_aiCardStrenght";
            this.lbl_aiCardStrenght.Size = new System.Drawing.Size(35, 13);
            this.lbl_aiCardStrenght.TabIndex = 11;
            this.lbl_aiCardStrenght.Text = "label7";
            // 
            // lbl_aiCardName
            // 
            this.lbl_aiCardName.AutoSize = true;
            this.lbl_aiCardName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aiCardName.Location = new System.Drawing.Point(133, 715);
            this.lbl_aiCardName.Name = "lbl_aiCardName";
            this.lbl_aiCardName.Size = new System.Drawing.Size(41, 13);
            this.lbl_aiCardName.TabIndex = 8;
            this.lbl_aiCardName.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(77, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Wins";
            // 
            // lbl_aiWins
            // 
            this.lbl_aiWins.AutoSize = true;
            this.lbl_aiWins.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aiWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aiWins.Location = new System.Drawing.Point(82, 214);
            this.lbl_aiWins.Name = "lbl_aiWins";
            this.lbl_aiWins.Size = new System.Drawing.Size(36, 39);
            this.lbl_aiWins.TabIndex = 13;
            this.lbl_aiWins.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(42, 746);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Card Strenght";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(42, 715);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Card Played";
            // 
            // lbl_wins
            // 
            this.lbl_wins.AutoSize = true;
            this.lbl_wins.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wins.Location = new System.Drawing.Point(1452, 214);
            this.lbl_wins.Name = "lbl_wins";
            this.lbl_wins.Size = new System.Drawing.Size(36, 39);
            this.lbl_wins.TabIndex = 16;
            this.lbl_wins.Text = "0";
            // 
            // btn_playCard
            // 
            this.btn_playCard.Location = new System.Drawing.Point(1395, 288);
            this.btn_playCard.Name = "btn_playCard";
            this.btn_playCard.Size = new System.Drawing.Size(75, 23);
            this.btn_playCard.TabIndex = 18;
            this.btn_playCard.Text = "Play Card";
            this.btn_playCard.UseVisualStyleBackColor = true;
            this.btn_playCard.Click += new System.EventHandler(this.btn_playCard_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(1493, 288);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 19;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_win
            // 
            this.btn_win.Location = new System.Drawing.Point(1395, 342);
            this.btn_win.Name = "btn_win";
            this.btn_win.Size = new System.Drawing.Size(75, 23);
            this.btn_win.TabIndex = 20;
            this.btn_win.Text = "Take Win";
            this.btn_win.UseVisualStyleBackColor = true;
            this.btn_win.Click += new System.EventHandler(this.btn_win_Click);
            // 
            // pic_backgroung
            // 
            this.pic_backgroung.Location = new System.Drawing.Point(228, 24);
            this.pic_backgroung.Name = "pic_backgroung";
            this.pic_backgroung.Size = new System.Drawing.Size(1143, 727);
            this.pic_backgroung.TabIndex = 21;
            this.pic_backgroung.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1392, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 54);
            this.label2.TabIndex = 22;
            this.label2.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 54);
            this.label3.TabIndex = 23;
            this.label3.Text = "AI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1445, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Wins";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1493, 342);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CardGame.Resource1.background;
            this.ClientSize = new System.Drawing.Size(1602, 809);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_win);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_playCard);
            this.Controls.Add(this.lbl_wins);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_aiWins);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_aiCardStrenght);
            this.Controls.Add(this.lbl_aiCardName);
            this.Controls.Add(this.lbl_playerCardStrenght);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_palyerCardName);
            this.Controls.Add(this.lbl_noOfCards);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_playerCard);
            this.Controls.Add(this.pic_aiCard);
            this.Controls.Add(this.pic_backgroung);
            this.Name = "MainForm";
            this.Text = "Card Game TCG";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_aiCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_backgroung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_aiCard;
        private System.Windows.Forms.PictureBox pic_playerCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_noOfCards;
        private System.Windows.Forms.Label lbl_palyerCardName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_playerCardStrenght;
        private System.Windows.Forms.Label lbl_aiCardStrenght;
        private System.Windows.Forms.Label lbl_aiCardName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_aiWins;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_wins;
        private System.Windows.Forms.Button btn_playCard;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_win;
        private System.Windows.Forms.PictureBox pic_backgroung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exit;
    }
}

