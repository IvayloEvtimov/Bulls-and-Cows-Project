using System;

namespace Bulls_and_Cows
{
    //Class used for displaying the rules of the game
    [Serializable] public class GameRules
    {
        private string Description;
        private string Rules;
        
        public String description
        {
            get { return Description; }
            set { Description = value; }
        }

        public String rules
        {
            get { return Rules; }
            set { Rules = value; }
        }

        public override string ToString()
        {
            return Description+'\n'+Rules;
        }
    }
}
