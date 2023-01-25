using System;

namespace Method
{

    class Calculator
    {

        // method declaration
        static int Zbir(int broj1, int broj2)
        {
            int sumMethod = broj1 + broj2;
            return sumMethod;

        }
        static int Razlika(int broj1, int broj2)
        {
            int razlika = broj1 - broj2;
            return razlika;

        }
        static int Proizvod(int broj1, int broj2)
        {
            int proizvod = broj1 * broj2;
            return proizvod;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi dva broja");
            Console.WriteLine("Broj1: ");
            int broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Broj2: ");
            int broj2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Odberi metod:");
            Console.WriteLine("Zbir vnesi +:");
            Console.WriteLine("Razlika vnesi -:");
            Console.WriteLine("Proizvod vnesi *:");
            Console.WriteLine("Vashiot izbor e: ");
            char metod = char.Parse(Console.ReadLine());


            if (metod == '+')
            {
                int rez = Zbir(broj1, broj2);
                Console.WriteLine("Vashiot rezultat e:");
                Console.WriteLine(rez);

            }
            else if (metod == '-')
            {
                int rez = Razlika(broj1, broj2);
                Console.WriteLine("Vashiot rezultat e:");
                Console.WriteLine(rez);

            }
            else if (metod == '*')
            {
                int rez = Proizvod(broj1, broj2);
                Console.WriteLine("Vashiot rezultat e:");
                Console.WriteLine(rez);

            }
            else {
                Console.WriteLine("Vnesovte nevaliden metod");
            }
            Console.ReadLine();

        }
    }
}
