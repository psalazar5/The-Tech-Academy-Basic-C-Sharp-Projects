using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player<T>
    {
        public List<T> Hand{ get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

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
