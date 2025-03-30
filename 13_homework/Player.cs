using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _13_homework
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Karta> Cards { get; set;}

        public Player(string name)
        {
            Name = name;
            Cards = new List<Karta>();
        }

        public void AddCards(Karta newCards)   
        {
            Cards.Add(newCards);  
        }

        public Karta PlayCard()
        {
            if (Cards.Count == 0)
                return null;
            Karta playedCard = Cards[0];
            Cards.RemoveAt(0);
            return playedCard;
        }

        public bool HasCards()
        {
            return Cards.Count > 0;
        }
          
        public override string ToString()
        {
            return $"{Name} має {Cards.Count} карт.";
        }

    }
}
