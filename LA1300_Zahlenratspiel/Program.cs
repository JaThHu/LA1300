namespace LA1300_Zahlenratspiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Titleart titleart = new Titleart();
            titleart.Title();

            Ueberpruefung ueberpruefung = new Ueberpruefung();
            ueberpruefung.begruessung();
            ueberpruefung.kontrollieren();
        }
    }

}