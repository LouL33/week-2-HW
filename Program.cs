using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string helloWorld = "HelloWorld";
            int theseNumbersAre = 1492;
            bool iHaveADog = true;
            DateTime todaysDate = DateTime.Now;
            double theDecimal = 5.45;
            char theLetter = 'X';



            Console.WriteLine(helloWorld);
            Console.WriteLine(theseNumbersAre);
            Console.WriteLine(todaysDate);
            Console.WriteLine(theDecimal);
            Console.WriteLine(theLetter);
            */

            /*
            Console.WriteLine("input random number?");
            string answers = Console.ReadLine();
            int thisIsTheNumber = int.Parse(answers);
            Console.WriteLine($"the number you picked is {thisIsTheNumber}");
            Console.ReadLine();
            */

            Console.WriteLine("How much have you gain?");
            string rawinput = Console.ReadLine();
            Decimal value = 0;
            bool areYouSureItRIght = Decimal . TryParse(rawinput, out value);
            if (areYouSureItRIght) ;  

        }

        

    }
}
