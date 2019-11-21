using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class BotUser : Hand
    {    
       
    
        
        public override void ChooseMove()
        {
            Random random = new Random();  
            move = moveList[random.Next(1,5)];
            
            
           
            ;
              
               
            
            
              

        }
       
    }
}
