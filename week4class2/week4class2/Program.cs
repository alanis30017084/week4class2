/*Name: Alanis Correa Kriener
  Purpose: Further loop exercises*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4class2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task - Rectangle
            Console.Write("This program will draw a rectangle based on your input.\n\nPlease enter a character/symbol: ");
            string symbol = Console.ReadLine();
            Console.Write("Please enter a width: ");
            int w = int.Parse(Console.ReadLine());
            Console.Write("Please enter a height: ");
            int h = int.Parse(Console.ReadLine());
            
            for(int b = 0; b < h; b++)
            {
                for(int c = 0; c < w; c++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            


            // Task - loop 1-50
            for (int i = 1; i <= 50; i ++)
            {
                Console.Write($"{i} ");
                if(i % 10 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
            
        
            
            // Task - Obtain info with loop
            // note: 'sum += y' is the same as 'sum = sum + y' where y obtains user input.
            double sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. Please enter a number: ");
                sum += double.Parse(Console.ReadLine());
                
            }
            Console.WriteLine($"The sum of all these numbers is: {sum}");
            Console.ReadLine();
            
            // Extension task . . .
            bool check = true;
            double total = 0;
            do
            {
                Console.Write("Please enter a number to add to your total: ");
                total += double.Parse(Console.ReadLine());
                Console.Write("Would you like to enter another number? (y/n) ");
                if (Console.ReadLine().ToLower() == "n")
                {
                    check = false;
                }
            } while (check == true);
            Console.WriteLine($"Your total is {total}");
            Console.ReadLine();
            

            // Task - Even number loop
            Console.Write("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num1; i++)
            {
                if(i % 2 == 0 && i != 0)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
