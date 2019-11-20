using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Game()
        {

        }


        public void CheckPoint(string move1, string move2)
        {
            if ((move1 == "rock" && move2 == "scissors") || (move1 == "rock" && move2 == "lizard") || (move1 == "spock" && move2 == "scissors") || (move1 == "spock" && move2 == "rock") || (move1 == "scissors" && move2 == "paper") || (move1 == "scissors" && move2 == "lizard") || (move1 == "lizard" && move2 == "spock") || (move1 == "lizard" && move2 == "paper") || (move1 == "paper" && move2 == "rock") || (move1 == "paper" && move2 == "spock"))
            {
                Console.WriteLine("Player 1 wins");
                Console.ReadLine();

            }
            else if ((move1 == "rock" && move2 == "rock") || (move1 == "spock" && move2 == "spock") || (move1 == "scissors" && move2 == "scissors") || (move1 == "paper" && move2 == "paper") || (move1 == "lizard" && move2 == "lizard")
            Console.WriteLine("Draw");
            Console.ReadLine();
            {



            }



        }


    }

}
