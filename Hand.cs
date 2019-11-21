using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

    public abstract class Hand
    {
        public List<string> moveList = new List<string>{"Rock","Paper","Scissors","Lizard","Spock" };
        public int score = 0; 
        public string move;
        


        public abstract void ChooseMove();

        

    }
}
