using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    int moveChoice;
    class BotUser : Hand
    {
        
        public override void ChooseMove()
        {
           return moveChoice = Roll(1, 5);
            

        }
        public int Roll(int min, int max)  
            {  
                Random random = new Random();  
                return random.Next(min,max );  
            }  
    }
}
