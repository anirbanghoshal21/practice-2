﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine()
       );
            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}", num1, num2, num3, result);
            Console.ReadLine();
        }
    }
}
