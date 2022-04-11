
using System;

namespace While_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa Laskimeen");
            string Jatka = "yes";
            while (Jatka == "yes")
            {
                Console.WriteLine("Kerro ensimmäinen numero:");
                double num1 = Convert.ToDouble(Console.ReadLine()); //tai double num1 = double.parse(Console.ReadLine());

                Console.WriteLine("Kerro toinen numero:");
                double num2 = Convert.ToDouble(Console.ReadLine()); //tai double num1 = double.parse(Console.ReadLine());

                Console.WriteLine("Valitse yksi näistä operaattoreista:");
                Console.WriteLine("1 - Yhteenlasku");
                Console.WriteLine("2 - Vähennyslasku");
                Console.WriteLine("3 - Jakolasku");
                Console.WriteLine("4 - Kertolasku");

                int option = int.Parse(Console.ReadLine());
                double result = 0;
                switch (option)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 / num2;
                        break;
                    case 4:
                        result = num1 * num2;
                        break;
                }
                if ((option > 0) && (option < 5))
                {
                    Console.WriteLine("Vastaus on: {0}", result);
                }
                else
                {
                    Console.WriteLine("Väärä vaihtoehto");
                }
                Console.WriteLine("Haluaisitko tehdä uuden laskun?[kyllä / ei(tai paina Enter)]");
                Jatka = Console.ReadLine();
            }
            Console.WriteLine("Kiitoksia tämän ohjelman käytöstä. Paina Enter poistuaksesi.");
            Console.ReadKey();
        }
    }
}
