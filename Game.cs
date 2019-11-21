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
            Hand player1;
            Hand player2; 

        }

        public void GetPlayersChoice()
        {
            Conosle.WriteLine("Would you like to play with a 'bot' or another 'player' ");
            return Console.ReadLine();
            Console.Clear;

        }
        
        
        public void MakePlayers( string choice)
        {
           switch (choice)
           {

                    case "bot":
                        
                        Console.WriteLine("You Will Be Playing Against A Bot");
                        player1 = new HumanUser();
                        player2 = new BotUser();
                        Console.Clear;                        
                        validWeightChoice = true;
                        break;

                    case "player":
                        
                        Console.WriteLine("You Will Be Plaing Agianst A Freind");
                        player1 = new HumanUser();
                        player2 = new HumanUser();
                        Console.ReadLine();
                        Console.Clear;
                        validChoice = true;


                        break;

                    default:

                       validChoice = false;

                        break;
           }

                
        }

        public void CheckPoint(string move1, string move2)
        {
            if ((move1 == "rock" && move2 == "scissors") || (move1 == "rock" && move2 == "lizard") || (move1 == "spock" && move2 == "scissors") || (move1 == "spock" && move2 == "rock") || (move1 == "scissors" && move2 == "paper") || (move1 == "scissors" && move2 == "lizard") || (move1 == "lizard" && move2 == "spock") || (move1 == "lizard" && move2 == "paper") || (move1 == "paper" && move2 == "rock") || (move1 == "paper" && move2 == "spock"))
            {
                Console.WriteLine("Player 1 wins");
                Console.ReadLine();
                Console.Clear;



            }
            else if ((move1 == "rock" && move2 == "rock") || (move1 == "spock" && move2 == "spock") || (move1 == "scissors" && move2 == "scissors") || (move1 == "paper" && move2 == "paper") || (move1 == "lizard" && move2 == "lizard"))
            { 
                Console.WriteLine("Draw");
                Console.ReadLine();
                Console.Clear;
            }
            else
            {
                Console.WriteLine("Player 2 wins");
                Console.ReadLine();
                Console.Clear;

            }
        }

        public void RunGame()
        {
            SingleOrNot = GetPlayersChoice();
            MakePlayers(SingleOrNot);
            
            while(player1.score < 2 && player2.score < 2 )
            {
                Console.WriteLine("player1 score:" + player1.score + " player2 score:" + player2.score);
                Console.WriteLine("");
                
            }
                
        }
        

    }


}


