using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("This program will display a number that you type in");

          var number = 0;

          Console.WriteLine("please type in number:");

          var isNumber = int.TryParse(Console.ReadLine(), out number);

          if(isNumber) {
               Console.WriteLine($"The number is {number}");

              
          }
          else{
               Console.WriteLine($"you didn't type in a number");
          }
    

          //End the program with blank line and instructions",
			Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        
        }
    }
}
