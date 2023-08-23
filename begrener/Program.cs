using begrener;

using System;

class Program
{
    static void HastighedsKonvertering()
    {
        KlasseB klasseB = new KlasseB();

        while (true)
        {
            Console.Clear(); 
            Console.WriteLine("Hastighedskonvertering");
            Console.WriteLine("Vælg en mulighed:");
            Console.WriteLine("1. Konverter knob til km/t");
            Console.WriteLine("2. Konverter km/t til knob");
            Console.WriteLine("3. Tilbage til hovedmenu");
            Console.Write("Indtast dit valg: ");

            int valg;
            if (int.TryParse(Console.ReadLine(), out valg))
            {
                switch (valg)
                {
                    case 1:
                        Console.Clear(); 
                        Console.WriteLine("Konverter knob til km/t");
                        Console.Write("Indtast hastighed i knob: ");
                        double knob = double.Parse(Console.ReadLine());
                        double kmT = klasseB.KonverterKnotTilKmT(knob);
                        Console.WriteLine($"{knob} knob er {kmT} km/t.");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Konverter km/t til knob");
                        Console.Write("Indtast hastighed i km/t: ");
                        double kmT2 = double.Parse(Console.ReadLine());
                        double knob2 = klasseB.KonverterKmTTilKnot(kmT2);
                        Console.WriteLine($"{kmT2} km/t er {knob2} knob.");
                        break;

                    case 3:
                        return; 

                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ugyldig indtastning. Indtast et gyldigt tal.");
            }

            Console.WriteLine("Tryk på Enter for at fortsætte.");
            Console.ReadLine();
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear(); 
            Console.WriteLine("Hovedmenu");
            Console.WriteLine("Vælg en mulighed:");
            Console.WriteLine("1. Hastigheds konvertering");
            Console.WriteLine("2. kommer snart");
            Console.WriteLine("3. Afslut");
            Console.Write("Indtast dit valg: ");

            int valg;
            if (int.TryParse(Console.ReadLine(), out valg))
            {
                switch (valg)
                {
                    case 1:
                        HastighedsKonvertering(); 
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        return; 

                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ugyldig indtastning. Indtast et gyldigt tal.");
            }

            Console.WriteLine("Tryk på Enter for at fortsætte.");
            Console.ReadLine();
        }
    }
}
