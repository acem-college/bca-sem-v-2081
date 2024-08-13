using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabs
{
    internal class Lab1
    {
        public Lab1()
        {
            Initialize();
        }

        private void Initialize()
        {
            Console.Write("Please enter the value of a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter the value of b: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"You entered a = {a} and b = {b}");

            Console.WriteLine("choose A for Sum and B for sub");
            string o = Console.ReadLine();

            switch (o)
            {
                case "A":
                    int result = Add(a, b);
                    Console.WriteLine($"the sum of number are: {result}");
                    break;
                case "B":
                    result = Sub(a, b);
                    Console.WriteLine($"the sub of number are: {result}");
                    break;
            }
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }


}
