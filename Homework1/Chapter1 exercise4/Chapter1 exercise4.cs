﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 我的第一个 C# 程序*/
            //string name="chenhongfei";
            //string s = "";
            //int n = 0;
            //double d =0;
            //Console.Write("Hello {0}",name);
            //Console.WriteLine("Please input an int : ");
            //s = Console.ReadLine();
            //n = Int32.Parse(s);
            //Console.Write("Please input a double: ");
            //s = Console.ReadLine();
            //d = Double.Parse(s);
            //Console.WriteLine("You have entered: "+n+" and "+(n+d));
            //Console.WriteLine("You have entered: {0} and {2}",n,d,n+d);
            //Console.WriteLine($"You have entered: {n} and {d}");


            Console.WriteLine("Please input 2 figures: ");
            string figure1, figure2;
            figure1 = Console.ReadLine();
            figure2 = Console.ReadLine();
            try
            {
                Console.WriteLine("The product of {0} and {1} is " + double.Parse(figure1) * double.Parse(figure2), figure1, figure2);
            }
            catch
            {
                Console.WriteLine("Abnormal input,Please try again.");
            }
            Console.ReadKey();
        }
    }
}
