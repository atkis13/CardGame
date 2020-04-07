using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CardGame
{
    [XmlRoot("Deck")]
    public class Deck
    {
        [XmlElement("Card")]
        public List<Card> cards { get; set; }
    }

    public class Card
    {

        public string name { get; set; }

        public int strenght { get; set; }


    }
}
