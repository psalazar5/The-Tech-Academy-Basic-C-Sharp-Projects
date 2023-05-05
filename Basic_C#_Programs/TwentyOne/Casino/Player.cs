using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        public Player(string name) : this(name, 100)
        {

        }
        public Player(string name, int beginningbalance)
        {
            Hand = new List<Card>();
            Balance = beginningbalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand{ get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            if(Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        public static Game operator +(Game game, Player player) //overloading operator plus, takes the two operands and returns the game and takes the game and adds player to it 
        {
            game.Players.Add(player);
            return game;
        }
        //subtract overload player 
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
