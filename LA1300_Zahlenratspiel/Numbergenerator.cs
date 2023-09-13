using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA1300_Zahlenratspiel
{
    internal class Numbergenerator
    {    
        public int FrageNachRange()
        {
            Console.WriteLine("Mit welcher Zahl soll das Spiel beginnen? ");
            int.TryParse(Console.ReadLine(), out int von);
            Console.WriteLine("Was soll die höchste Zahl sein? ");
            int.TryParse(Console.ReadLine(), out int bis);

            int RandomNumber = RnmbG(von, bis);
            Console.WriteLine("Ich habe mit eine Zahl zwischen " + von + " und " + bis + " ausgedacht.");
            return RandomNumber;
        }
        public int RnmbG(int von, int bis)
        {

            int ranu;
            Random random = new Random();
            ranu = random.Next(von, bis);
            
            return ranu; 
        }
        
    }
    
}
