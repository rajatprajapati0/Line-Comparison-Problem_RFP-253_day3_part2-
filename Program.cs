using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Line_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation Program ");
           
            

        
           double one =Program.line();
           
        }

        static double line()
        {
            Console.WriteLine("give some input for a line");
            Console.WriteLine("Enter first two numbers for x1 and y1");
            Console.WriteLine("Enter x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter first two numbers for x2 and y2");
            Console.WriteLine("Enter x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2");
            double y2 = double.Parse(Console.ReadLine());


            double Length_of_Line = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine(Length_of_Line);

            return Length_of_Line;
        }
      

        
    }
}