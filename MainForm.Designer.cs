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
            this.label14 = new System.Windows.Forms.Label();
            this.btn_playCard = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_win = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_aiCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playerCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_aiCard
            // 
            this.pic_aiCard.Location = new System.Drawing.Point(40, 25);
            this.pic_aiCard.Name = "pic_aiCard";
            this.pic_aiCard.Size = new System.Drawing.Size(345, 532);
            this.pic_aiCard.TabIndex = 0;
            this.pic_aiCard.TabStop = false;
            // 
            // pic_playerCard
            // 
            this.pic_playerCard.Location = new System.Drawing.Point(455, 25);
            this.pic_playerCard.Name = "pic_playerCard";
            this.pic_playerCard.Size = new System.Drawing.Size(345, 532);
            this.pic_playerCard.TabIndex = 1;
            this.pic_playerCard.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cards in Deck";
            // 
            // lbl_noOfCards
            // 
            this.lbl_noOfCards.AutoSize = true;
            this.lbl_noOfCards.Location = new System.Drawing.Point(968, 79);
            this.lbl_noOfCards.Name = "lbl_noOfCards";
            this.lbl_noOfCards.Size = new System.Drawing.Size(35, 13);
            this.lbl_noOfCards.TabIndex = 3;
            this.lbl_noOfCards.Text = "label2";
            // 
            // lbl_palyerCardName
            // 
            this.lbl_palyerCardName.AutoSize = true;
            this.lbl_palyerCardName.Location = new System.Drawing.Point(960, 422);
            this.lbl_palyerCardName.Name = "lbl_palyerCardName";
            this.lbl_palyerCardName.Size = new System.Drawing.Size(35, 13);
            this.lbl_palyerCardName.TabIndex = 4;
            this.lbl_palyerCardName.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Card Played";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(876, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Card Strenght";
            // 
            // lbl_playerCardStrenght
            // 
            this.lbl_playerCardStrenght.AutoSize = true;
            this.lbl_playerCardStrenght.Location = new System.Drawing.Point(960, 453);
            this.lbl_playerCardStrenght.Name = "lbl_playerCardStrenght";
            this.lbl_playerCardStrenght.Size = new System.Drawing.Size(35, 13);
            this.lbl_playerCardStrenght.TabIndex = 7;
            this.lbl_playerCardStrenght.Text = "label6";
            // 
            // lbl_aiCardStrenght
            // 
            this.lbl_aiCardStrenght.AutoSize = true;
            this.lbl_aiCardStrenght.Location = new System.Drawing.Point(145, 617);
            this.lbl_aiCardStrenght.Name = "lbl_aiCardStrenght";
            this.lbl_aiCardStrenght.Size = new System.Drawing.Size(35, 13);
            this.lbl_aiCardStrenght.TabIndex = 11;
            this.lbl_aiCardStrenght.Text = "label7";
            // 
            // lbl_aiCardName
            // 
            this.lbl_aiCardName.AutoSize = true;
            this.lbl_aiCardName.Location = new System.Drawing.Point(145, 586);
            this.lbl_aiCardName.Name = "lbl_aiCardName";
            this.lbl_aiCardName.Size = new System.Drawing.Size(41, 13);
            this.lbl_aiCardName.TabIndex = 8;
            this.lbl_aiCardName.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 586);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Wins";
            // 
            // lbl_aiWins
            // 
            this.lbl_aiWins.AutoSize = true;
            this.lbl_aiWins.Location = new System.Drawing.Point(314, 586);
            this.lbl_aiWins.Name = "lbl_aiWins";
            this.lbl_aiWins.Size = new System.Drawing.Size(41, 13);
            this.lbl_aiWins.TabIndex = 13;
            this.lbl_aiWins.Text = "label12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 617);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Card Strenght";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 586);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Card Played";
            // 
            // lbl_wins
            // 
            this.lbl_wins.AutoSize = true;
            this.lbl_wins.Location = new System.Drawing.Point(954, 367);
            this.lbl_wins.Name = "lbl_wins";
            this.lbl_wins.Size = new System.Drawing.Size(41, 13);
            this.lbl_wins.TabIndex = 16;
            this.lbl_wins.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(884, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Wins";
            // 
            // btn_playCard
            // 
            this.btn_playCard.Location = new System.Drawing.Point(850, 204);
            this.btn_playCard.Name = "btn_playCard";
            this.btn_playCard.Size = new System.Drawing.Size(75, 23);
            this.btn_playCard.TabIndex = 18;
            this.btn_playCard.Text = "Play Card";
            this.btn_playCard.UseVisualStyleBackColor = true;
            this.btn_playCard.Click += new System.EventHandler(this.btn_playCard_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(948, 204);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 19;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_win
            // 
            this.btn_win.Location = new System.Drawing.Point(850, 258);
            this.btn_win.Name = "btn_win";
            this.btn_win.Size = new System.Drawing.Size(75, 23);
            this.btn_win.TabIndex = 20;
            this.btn_win.Text = "Take Win";
            this.btn_win.UseVisualStyleBackColor = true;
            this.btn_win.Click += new System.EventHandler(this.btn_win_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 653);
            this.Controls.Add(this.btn_win);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_playCard);
            this.Controls.Add(this.label14);
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
            this.Name = "MainForm";
            this.Text = "Card Game TCG";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_aiCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playerCard)).EndInit();
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_playCard;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_win;
    }
}

