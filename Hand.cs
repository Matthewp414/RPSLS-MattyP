using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

    class Hand
    {
        List<string> moveList;
        public int score = 0; 
        string move;
        


        public Hand()
        {
            moves.Add("Rock");
            moves.Add("Paper");
            moves.Add("Scissors");
            moves.Add("Lizard");
            moves.Add("Spock");
            
            
        }


        public virtual void ChooseMove()
        {
            Console.WriteLine("What Is Your Choice?:");
            foreach (string moves in moveList)
            {
                Console.WriteLine(moves);
            }
            return move = Console.ReadLine();

        }

    }
}
