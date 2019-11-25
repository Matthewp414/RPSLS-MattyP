using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanUser : Hand 
    {
        public bool validChoice;

        public HumanUser()
        {

        }
        public override void ChooseMove()
        {
            Console.WriteLine("What Is Your Choice?:");
            
            foreach (string moves in moveList)
            {
                Console.WriteLine(moves);
            }
            
            move = Console.ReadLine();
            switch (move)

            {   

                    case "rock":                                     
                        validChoice = true;
                        break;
                    case "paper":
                        validChoice = true;
                        break;
                    case "lizard":                                     
                        validChoice = true;
                        break;
                    case "spock":                                     
                        validChoice = true;
                        break;
                    case "scissors":                                     
                        validChoice = true;
                        break;
                    default:
                        Console.Clear();
                        ChooseMove();
                        break;
            }
        
               
            

        }
    }
}
