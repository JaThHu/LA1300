using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA1300_Zahlenratspiel
{
    internal class Numbergenerator
    {    
        public int RnmbG()
        {

            int ranu;
            Random random = new Random();
            ranu = random.Next(1, 101);
            
            return ranu; 
        }
        
    }
}
