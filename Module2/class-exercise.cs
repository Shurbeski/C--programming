using System;

namespace Method
{

    class Calculator
    {

        // method declaration
        static void PocnhiPerenje(string tipAlishta, int brojNaVrtezi = 400, bool sushi = false)
        { 
            Console.WriteLine("Peram " + tipAlishta);
            Console.WriteLine("Broj na vrtezi " + brojNaVrtezi);
            if (sushi == true)
            {
                Console.WriteLine("I na kraj ke susham");
            }
            else {
                Console.WriteLine("Nema da susham na kraj");
            
            }

        }

        static void PocnhiPerenje(string tipAlishta, string plaknenje, int brojNaVrtezi = 400, bool sushi = false)
        {
            Console.WriteLine("Peram " + tipAlishta);
            Console.WriteLine("Broj na vrtezi " + brojNaVrtezi);
            Console.WriteLine("Ke gi plaknam alishtata " + plaknenje);
            if (sushi == true)
            {
                Console.WriteLine("I na kraj ke susham");
            }
            else
            {
                Console.WriteLine("Nema da susham na kraj");

            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi tri opcii za perenje alishta");
            Console.WriteLine("Opcija 1 - Kakvi alishta?: ");
            string tipAlishta = Console.ReadLine();
            Console.WriteLine("Opcija 2 - Broj za centrifuga?: ");
            int brojNaVrtezi = int.Parse(Console.ReadLine());
            Console.WriteLine("Opcija 3 - Ke sushish alishta ili ne?: ");
            bool sushenje = bool.Parse(Console.ReadLine());
            PocnhiPerenje(tipAlishta,"Plakniii",brojNaVrtezi, sushenje);
            //PocnhiPerenje(tipAlishta, brojNaVrtezi, sushenje);
            //PocnhiPerenje(tipAlishta, "plakni shareni");



        }
    }
}
