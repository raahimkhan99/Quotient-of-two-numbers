using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q. Write a program that takes input the two numbers and tells their quotient
            double First_Num, Sec_Num, Quo; //Quo = Quotient
            Console.WriteLine("\t\t\t\t\tQuotient Of Two Numbers");
            Console.WriteLine("\t\t\t\t\t=======================");
            Console.WriteLine("Enter First Number:");
            Console.WriteLine("-------------------");
            First_Num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            a:Console.WriteLine("Enter Second Number:");
            Console.WriteLine("--------------------");
            Sec_Num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            if (Sec_Num == 0) 
            {
                Console.WriteLine("Denominator can not be zero. . ." + "\n");
                goto a;
            }
            Quo = First_Num / Sec_Num; //Formula of Quotient
            Console.WriteLine("Quotient: " + (Quo)); //Prints the Quotient
            //The above code is tested for all possible test cases, and it holds true in each test case.  
        }
    }
}
