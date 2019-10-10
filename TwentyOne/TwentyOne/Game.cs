using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game // base class or abstract class
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); // any class inheriting this class must have this method

        public virtual void ListPlayers()// adds customization
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
