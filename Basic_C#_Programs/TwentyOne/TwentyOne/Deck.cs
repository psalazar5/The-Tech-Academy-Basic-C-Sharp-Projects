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
            Cards = new List<Card>();

            for(int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1) //The Shuffle method is a static method of the Program class that takes a Deck object as input and returns a shuffled version of the deck.
        {
            for (int i = 0; i < times; i++)//goes thru the deck of cards 
            { 
                List<Card> TempList = new List<Card>(); //It works by creating a temporary list (TempList) and a new Random object, and then repeatedly selecting a random card from the deck and adding it to the temporary list. 
                Random random = new Random(); //instantiation
                                              //Once all the cards have been removed from the original deck and added to the temporary list, the temporary list becomes the new deck and is returned.
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); // a random index between 0 and the number of cards remaining in the deck object is generated using the random.Next(0, deck.Cards.Count) method. 
                    TempList.Add(Cards[randomIndex]); //This index is used to select a random card from the deck
                    Cards.RemoveAt(randomIndex); //The selected card is then removed from the deck object using the deck.Cards.RemoveAt(randomIndex) method, which reduces the number of cards remaining in the deck.
                }
                Cards = TempList; //Once the while loop completes, the deck.Cards property is set equal to the TempList. This replaces the original unshuffled cards in deck with the shuffled cards in TempList.
            }
            //public static Deck Shuffle(deck, int times)
            //{
            //    for(int i = 0; i < times; i++)
            //    {
            //        deck = Shuffle(deck);
            //    }
            //    return deck;
            //}
        }
    }
}
