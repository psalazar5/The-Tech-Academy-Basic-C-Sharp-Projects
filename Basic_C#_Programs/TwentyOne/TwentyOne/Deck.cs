using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck //The public class Deck statement declares a public class called Deck within the TwentyOne namespace.
                      // This means that the class can be used by code outside of the TwentyOne namespace.
    { //The code inside the constructor generates a standard deck of cards with 52 cards, which are stored in a List<Card> called Cards.
        public Deck() //The public Deck() constructor initializes a new instance of the Deck class. 
        {  
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
          
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach(string face in Faces) //for each of face named string insides faces we do...
            {
                foreach(string suit in Suits) // the foreach(string suit in Suits) loop iterates through each suit in the Suits list.
                {
                    Card card = new Card(); //inside this nested loop Card object is created with the currnt face and suit. This card object is then added to the cards list using the add method
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card); //Finally the cards list is populated with all 52 cards in a standard deck of cards, and the deck is ready to be used in a game 
                }
            }
                

        }
        public List<Card> Cards { get; set; }
    }
}
