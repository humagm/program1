using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Clear();

         int number = 0;
         int counter = 10;

         for(int i = 0; i < counter;i++){
         Console.WriteLine("please enter a number");
         int input = int.Parse (Console.ReadLine());

         number += input;
         }
         Console.WriteLine($"Total is {number}");
         Console.WriteLine($"Average is {number / 10}");

 //End the program with blank line and instructions",
			Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}