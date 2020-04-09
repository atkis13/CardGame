using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class MainForm : Form
    { 

        PlayerClass player = new PlayerClass();
        AIClass aiPlayer = new AIClass();
    
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            pic_backgroung.Image = Resource1.table;
            lbl_noOfCards.Text = player.getcardNumber().ToString();
            pic_aiCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_aiCard.Visible = false;
            pic_playerCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_playerCard.Visible = false;
            btn_win.Enabled = false;
        }

        private void btn_playCard_Click(object sender, EventArgs e)
        {
            PlayGame();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btn_win_Click(object sender, EventArgs e)
        {
            TakeWin();
        }
        
        //Play the hame
        //Both player play a card, the card is displayed to the user
        private void PlayGame()
        {
            pic_aiCard.Visible = true;
            pic_playerCard.Visible = true;


            if (player.getcardNumber() > 0)
            {
                lbl_wins.Text = player.wins.ToString();
                lbl_aiWins.Text = aiPlayer.wins.ToString();
                btn_win.Enabled = false;
                player.playCard();
                lbl_palyerCardName.Text = player.cardName;
                lbl_playerCardStrenght.Text = player.cardStrenght.ToString();
                pic_playerCard.ImageLocation = player.cardLocation;
                lbl_noOfCards.Text = player.getcardNumber().ToString();

                aiPlayer.playCard();
                lbl_aiCardName.Text = aiPlayer.cardName;
                lbl_aiCardStrenght.Text = aiPlayer.cardStrenght.ToString();
                pic_aiCard.ImageLocation = aiPlayer.cardLocation;

                if (player.cardStrenght > aiPlayer.cardStrenght)
                {
                    btn_win.Enabled = true;
                    btn_playCard.Enabled = false;
                   
                }
                else if (player.cardStrenght < aiPlayer.cardStrenght)
                {
                    aiPlayer.getWins();                    
                    lbl_aiWins.Text = aiPlayer.wins.ToString();
                    if (player.getcardNumber() != 0)
                        btn_playCard.Enabled = true;
                }
                else
                {
                    MessageBox.Show("DRAW");
                    if (player.getcardNumber() != 0)
                        btn_playCard.Enabled = true;
                }
            }
            else if(player.getcardNumber() == 0)
            {
                btn_playCard.Enabled = false;
                MessageBox.Show("out of cards");
            }
        }

        private void ResetGame()
        {
            pic_aiCard.Visible = false;
            pic_playerCard.Visible = false;
            player.reset();
            lbl_noOfCards.Text = player.getcardNumber().ToString();
            lbl_palyerCardName.Text = "";
            lbl_playerCardStrenght.Text = "";
            btn_playCard.Enabled = true;
            lbl_wins.Text = player.wins.ToString();
            pic_playerCard.Image = null;
            aiPlayer.reset();
            lbl_palyerCardName.Text = "";
            lbl_playerCardStrenght.Text = "";
            lbl_aiWins.Text = aiPlayer.wins.ToString();
            pic_aiCard.Image = null;
        }

        private void TakeWin()
        {
            player.getWins();
            lbl_wins.Text = player.wins.ToString();
            btn_win.Enabled = false;

            if(player.getcardNumber() != 0)
            btn_playCard.Enabled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }  
        
}
