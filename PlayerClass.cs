using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace CardGame
{
    public class PlayerClass
    {
        public Deck mydeck = new Deck();
        public Card playerCard = new Card();
        public Random rd = new Random();
        public string cardName;
        public int cardStrenght;
        public string cardLocation;
        public int totalCards;
        public int wins = 0;
        string path = AppDomain.CurrentDomain.BaseDirectory;

        public PlayerClass()
        {
            LoadDeck();
        }

        public void LoadDeck()
        {
            
            StreamReader sr = null;
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Deck), new XmlRootAttribute("Deck"));
                sr = new StreamReader(path +@"Deck\cards.xml");
                mydeck = (Deck)deserializer.Deserialize(sr);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sr.Close();
            }
        }

        public void playCard()
        {
            try
            {
                int cardnum = rd.Next(0, mydeck.cards.Count());                

                if (mydeck.cards.Count() > 0)
                {
                    playerCard = mydeck.cards[cardnum];
                    cardName = playerCard.name;
                    cardStrenght = playerCard.strenght; ;
                    cardLocation = path + @"Deck\" + playerCard.name + ".stx";
                    mydeck.cards.Remove(playerCard);

                }
                else
                {
                    Console.WriteLine("no more cards");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public int getcardNumber()
        {
            totalCards = mydeck.cards.Count;
            return totalCards;
        }

        public void reset()
        {
            LoadDeck();
            wins = 0;
        }

        public void getWins()
        {
            wins++;

        }


    }
}

