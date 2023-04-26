using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck = Shuffle(deck); ////the shuffled deck object is returned from the Shuffle method.


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            
            Console.ReadLine();
        }
        public static Deck Shuffle(Deck deck) //The Shuffle method is a static method of the Program class that takes a Deck object as input and returns a shuffled version of the deck.
        {
            List<Card> TempList = new List<Card>(); //It works by creating a temporary list (TempList) and a new Random object, and then repeatedly selecting a random card from the deck and adding it to the temporary list. 
            Random random = new Random();
            //Once all the cards have been removed from the original deck and added to the temporary list, the temporary list becomes the new deck and is returned.
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count); // a random index between 0 and the number of cards remaining in the deck object is generated using the random.Next(0, deck.Cards.Count) method. 
                TempList.Add(deck.Cards[randomIndex]); //This index is used to select a random card from the deck
                deck.Cards.RemoveAt(randomIndex); //The selected card is then removed from the deck object using the deck.Cards.RemoveAt(randomIndex) method, which reduces the number of cards remaining in the deck.
            }
            deck.Cards = TempList; //Once the while loop completes, the deck.Cards property is set equal to the TempList. This replaces the original unshuffled cards in deck with the shuffled cards in TempList.
            return deck; 
        }
    }
}
