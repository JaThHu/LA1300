using System;

namespace LA1300_Zahlenratspiel
{
    internal class Ueberpruefung
    {
        public void begruessung()
        {
            Console.WriteLine("Willkommen beim Zahlenspiel!");
            Console.WriteLine("Ich habe mir eine Zahl zwischen 1 und 100 ausgedacht. Versuche sie zu erraten.");
        }
        public void kontrollieren()
        {
            bool nochmal;
            do
            {
                nochmal = false;
                Numbergenerator numbergenerator = new Numbergenerator();
                int zufallszahl = numbergenerator.RnmbG();

                int versuche = 0;
                bool geraten = false;

                while (!geraten)
                {
                    Console.Write("Gib deine Vermutung ein: ");

                    if (int.TryParse(Console.ReadLine(), out int vermutung))
                    {
                        versuche++;

                        if (vermutung < zufallszahl)
                        {
                            Console.WriteLine("Die gesuchte Zahl ist größer.");
                        }
                        else if (vermutung > zufallszahl)
                        {
                            Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                        }
                        else
                        {
                            geraten = true;
                            Console.WriteLine($"Glückwunsch! Du hast die Zahl {zufallszahl} in {versuche} Versuchen erraten.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte gib eine ganze Zahl ein.");
                    }

                }

                
                Console.WriteLine("Willst du nochmal spielen? ");
                string nochmalEingabe = Console.ReadLine().ToUpper();
                if( nochmalEingabe == "JA")
                {
                    nochmal = true;
                }

            } while (nochmal == true);
            Environment.Exit(0);
        }

    }
}
