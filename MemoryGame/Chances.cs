using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class Chances
    {
       public string name;
       public int tiels, lives;
        public Chances(string name, int tiels, int lives)
        {
            this.name = name;
            this.tiels = tiels;
            this.lives = lives;
        }

        public string getName() { return name; }
        public int getTiels() {  return tiels; }
        public int getLives() {  return lives; }
    }
}
