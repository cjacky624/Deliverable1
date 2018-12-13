using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _12_5CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3;

            Console.WriteLine("Please enter a dollar amount: (ie. 50 for 50 dollars).");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please another number.");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter one last number.");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            //Get average
            double result = (number1 + number2 + number3) / 3;
            Console.WriteLine("The average of {0}, {1}, and {2} is: {3}", number1, number2, number3, result);


            //Get smallest number
            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine("The smallest amount: {0}", number1);
            }
            else if (number2 < number1 && number2 < number3)
            {
                Console.WriteLine("The smallest amount: {0}", number2);
            }
            else if (number3 < number1 && number3 < number2)
            {
                Console.WriteLine("The smallest amount: {0}", number3);
            }

            //Get largest number
            if (number1 > number2 && number1 > number3) 
            {
                Console.WriteLine("Largest amount: {0}", number1 );
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("The largest amount: {0}", number2);
            }
            else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine("The largest amount: {0}", number3);
            }

            Console.WriteLine();
            Console.WriteLine();

            double total = (result * 3);
            Console.WriteLine("Total: {0}", total);

            var us = CultureInfo.GetCultureInfo("en-US");
            var outputUS = total.ToString("c", us);
            Console.WriteLine(outputUS);

            var sv = CultureInfo.GetCultureInfo("sv");
            var outputSV = total.ToString("c", sv);
            Console.WriteLine(outputSV);

            var ja = CultureInfo.GetCultureInfo("ja");
            var outputJA = total.ToString("c", ja);
            Console.WriteLine(outputJA);

            var th = CultureInfo.GetCultureInfo("th-TH");
            var outputTH = total.ToString("c", th);
            Console.WriteLine(outputTH);





            //Console.WriteLine("US: ${0}", total);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

        }
    }
}
