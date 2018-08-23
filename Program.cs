using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_project
{
    class Program
    {
        static void Main(string[] args)
        {                      /*example of branching*/
                               //int currentTemp = 70;
                               //int roomTemp = 70;

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("Is it not exactly room temp.");
            //}
            //Console.ReadLine();


            //branching example 2
            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the tempature where you is?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("Is it exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("Something is broken...badly");
            //}
            //Console.ReadLine();

            int packageWeight = 50;
            int packDimension = 50;
            

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight: ");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight <= packageWeight)
            {
                Console.WriteLine("The package meets our weight requirements.");
            }
            else if (packWeight > packageWeight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();


            Console.WriteLine("Please enter the package width: ");
            int packWidth = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();

            Console.WriteLine("Please enter the package height: ");
            int packHeight = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();

            Console.WriteLine("Please enter the package length: ");
            int packLength = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();

            if (packWidth + packHeight + packLength <= packDimension)
            {
                Console.WriteLine("Package meets the shipping dimension");
            }
            else if (packWidth + packHeight + packLength > packDimension)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();

            int totalSum = packHeight + packLength + packWidth * packWeight / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + totalSum );
            Console.ReadLine();



        }
    }
}
