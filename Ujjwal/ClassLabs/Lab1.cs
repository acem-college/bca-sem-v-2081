using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabs
{
    public class Lab1
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public Lab1()
        {
            Initialize();
        }
        private void Initialize()
        {

            Console.Write("Please enter a first number: ");
            string a = Console.ReadLine();
            Console.Write("Please enter a second number: ");
            string b = Console.ReadLine();
            int ia = int.Parse(a);
            int ib = int.Parse(b);
            Console.Write("Type 'A' to ADD or 'B' to subtract.");
            string c = Console.ReadLine();
            int result = 0;
            switch (c)
            {
                case "A":
                    result = Add(ia, ib);
                    break;
                case "B":
                    result = Sub(ia, ib);
                    break;
            };

            Console.WriteLine($"The result is {result}");

        }
    }

}
