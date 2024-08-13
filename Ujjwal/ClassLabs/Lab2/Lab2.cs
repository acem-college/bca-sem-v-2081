using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLabs.Lab2.Interface;



namespace ClassLabs.Lab2
{
    internal class Lab2 : ILab2
    {

        public int Add(int x, int y)
        {
            return x + y;
            ;
        }

        public int Divide(int x, int y)
        {
            return x / y;

        }

        public int Multiply(int x, int y)
        {
            return x * y;

        }

        public int Subtract(int x, int y)
        {
            return x - y;

        }
        public Lab2()
        {
            UserInteraction();
        }
        private void UserInteraction()
        {
            Console.WriteLine("     Option:");
            Console.WriteLine("A for Addition");
            Console.WriteLine("S for Subtraction");
            Console.WriteLine("D for divide");
            Console.WriteLine("M for multiply");
            Console.WriteLine("Enter the option:");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter the 2 number:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case "A":
                    Console.WriteLine($"The result is {Add(x, y)}");
                    break;
                case "S":
                    Console.WriteLine($"The result is {Subtract(x, y)}");
                    break;
                case "B":
                    Console.WriteLine($"The result is {Multiply(x, y)}");
                    break;
                case "D":
                    Console.WriteLine($"The result is {Divide(x, y)}");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
}
