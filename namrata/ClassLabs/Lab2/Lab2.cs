using ClassLabs.Lab2.INterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabs.Lab2
{
    internal class Lab2 : ILab2
    {
        public int add(int x, int y)
        {
           return x + y;
        }

        public int divide(int x, int y)
        {
            return x / y;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public int substract(int x, int y)
        {
            return x - y;
        }

        private void UserInteraction()
        {
            Console.WriteLine("A for Add");
            Console.WriteLine("S for Substract");
            Console.WriteLine("M for Multiply");
            Console.WriteLine("D for Division");

            Console.WriteLine("Enter Two value of x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Two value of y");
            int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"the ans is:{result}");
        }
    }
    
}
