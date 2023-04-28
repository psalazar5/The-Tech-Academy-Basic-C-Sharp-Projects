using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); 
        public virtual void ListPlayers() //virtual method inside in abstract class means this method gets inherited by an inheriting vlass by has ability to overwrite it.
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
