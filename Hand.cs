using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

    class Hand 
    {
        List<string> moves;
        int score = 0;

        public Hand()
        {
            moves.Add("Rock");
            moves.Add("Paper");
            moves.Add("Scissors");
            moves.Add("Lizard");
            moves.Add("Spock");
            

        }




    }
}
