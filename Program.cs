/* Name: Alexandra Nieves
   Date: 2/5/2021
   Method assignment
*/

using System;

namespace Nieves_A_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name:");
            string userInput = Console.ReadLine();
            PrintName(userInput);
            Console.ReadKey();
        }
        static void PrintName(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }
    }
}
