using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Line_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation Program \n ");
            lineUse();
            

        }
        public static void lineUse()
        {
            double one = 0;
            double two = 0;
            for (int i=1;i<=2;i++) 
            {
                if (i==1)
                {
                    Console.WriteLine("enter valuse for first line \n");
                     one = line();
                    Console.WriteLine("\nlength of line one -"+one+"\n");                      
                }
            
                else
                {
                    Console.WriteLine("enter valuse for second line");
                     two= line();
                    Console.WriteLine("\nlength of line two -" + two+"\n");

                }
            }
            if (one==two) 
            {
                Console.WriteLine("lines are equal it is preferable.");
            }
            else
            { Console.WriteLine("lines are not equal it is not preferable.");
            }
        }
       static double line()
        {

            Console.WriteLine("give some input for a line\n");
            Console.WriteLine("Enter first two numbers for x1 and y1\n");
            Console.WriteLine("Enter x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter first two numbers for x2 and y2 \n");
            Console.WriteLine("Enter x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2");
            double y2 = double.Parse(Console.ReadLine());


            double Length_of_Line = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));


            return Length_of_Line;
        }
      

    }
}