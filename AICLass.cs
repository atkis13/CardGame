using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    class AIClass : PlayerClass
    {
        public virtual void playCard()
        {
            try
            {
                int cardnum = rd.Next(0, mydeck.cards.Count());
                string path = AppDomain.CurrentDomain.BaseDirectory;

                if (mydeck.cards.Count() > 0)
                {
                    playerCard = mydeck.cards[cardnum];
                    cardName = playerCard.name;
                    cardStrenght = playerCard.strenght;
                    cardLocation = path + @"Deck\" + playerCard.name + ".stx";
                    mydeck.cards.Remove(playerCard);

                }
                else
                {
                    Console.WriteLine("out of cards");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
