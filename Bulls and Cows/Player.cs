using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    //Class representing the current Player and his high score
    [Serializable]public class Player
    {
        private string name;
        private int steps;

        public Player()
        {
            this.Name = " ";
            this.Steps = 0;
        }

        public Player(string Name,int steps)
        {
            this.Name = Name;
            this.Steps = steps;
        }

        public string Name { get => name; set => name = value; }
        public int Steps { get => steps; set => steps = value; }
    }
}
