using System;

namespace CSharpTestailua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa laskimen käyttöön");
            Console.WriteLine("-------------------------");
            string jatka = "kyllä";
            while (jatka == "kyllä")
            {

                Console.Write("Kerro ensimmäinen numero: ");
                double num1 = Convert.ToDouble(Console.ReadLine()); //tai double num1 = double.parse(Console.ReadLine());

                Console.Write("Valitse yksi näist operaattoreista: [+,  -,  /,  *] -> ");
                string operaattori = Console.ReadLine();

                Console.Write("Kerro toinen numero: ");
                double num2 = Convert.ToDouble(Console.ReadLine()); //tai double num1 = double.parse(Console.ReadLine());

                Console.WriteLine("-------------------------");

                if (operaattori == "+")
                {
                    Console.WriteLine("Vastaus on ->", num1 + num2);
                }
                else if (operaattori == "-")
                {
                    Console.WriteLine("Vastaus on ->", num1 - num2);
                }
                else if (operaattori == "/")
                {
                    Console.WriteLine("Vastaus on ->", num1 / num2);
                }
                else if (operaattori == "*")
                {
                    Console.WriteLine("Vastaus on ->", num2 * num2);
                }
                else
                {
                    Console.WriteLine("Väärä operaattori");
                }
                    Console.WriteLine("Haluaisitko tehdä uuden laskun? [kyllä/ei(tai paina Enter)]");
                    jatka = Console.ReadLine();
            }
            Console.WriteLine("Kiitoksia tämän ohjelman käytöstä. Paina Enter poistuaksesi.");
            Console.ReadKey();
        }
    }
}
