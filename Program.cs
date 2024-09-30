using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            char choice;
            do
            {
            int minValue, maxValue;
            Console.WriteLine("Enter start number: ");
            minValue=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nEnter end number: ");
            maxValue = Convert.ToInt16(Console.ReadLine());
            
            GuesstheNumber(minValue,maxValue);

            Console.WriteLine("Do you want to check another number? (y/n): ");
            choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y' || choice == 'Y');

        }

        static void GuesstheNumber(int minValue, int maxValue)
        {
            Random r = new Random();
            int n = r.Next(minValue, maxValue + 1);
            Console.WriteLine($"A number is choosed randomly from {minValue} and {maxValue} . Try to Guess it? ");


            int guess = 0;
            int trials = 0;
            while (guess != n)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("Guess the Number: ");
                guess = Convert.ToInt16(Console.ReadLine());
                trials++;

                if (guess == n)
                    Console.WriteLine($"\nCongrarulations You have guessed the number {n} in {trials} attempts");
                else if (guess < n)
                    Console.WriteLine("The number Guessed is Greater than " + guess);
                else
                    Console.WriteLine("The number Guessed is Less than " + guess);
            }
        }
    }
}
