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

            foreach (string face in Faces) //for each of face named string insides faces we do...
            {
                foreach (string suit in Suits) // the foreach(string suit in Suits) loop iterates through each suit in the Suits list.
                {
                    Card card = new Card(); //inside this nested loop Card object is created with the currnt face and suit. This card object is then added to the cards list using the add method
                    card.Suit = suit; // assigns new card from line 32 current loops suit 
                    card.Face = face; // assigns new card from line 32 current loops face 
                    Cards.Add(card); //Finally the cards list is populated with all 52 cards in a standard deck of cards, and the deck is ready to be used in a game 
                }
            }


        }
        public List<Card> Cards { get; set; }

        public void Shuffle( int times = 1) //The Shuffle method is a static method of the Program class that takes a Deck object as input and returns a shuffled version of the deck.
        {
            for (int i = 0; i < times; i++)
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
        }
    }
}
