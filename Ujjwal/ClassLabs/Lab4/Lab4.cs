using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabs.Lab4
{
    internal class Lab4 : BaseLab4
    {
       
        public override int Add(int[] x)
        {
            int sum =base.Add(x);
            int result =0;
            if (sum % 2 == 0) 
            {
                for (int i = 0; i < x.Length; i++) 
                {
                    if(x[i]%2 == 0)
                    {
                        result += x[i];
                    }
                }
            }
            else{
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] % 2 != 0)
                    {
                        result += x[i];
                    }
                }
            }
            return result;
        }

        public Lab4()
        {
            Initialize(); 
        }
        private void Initialize()
        {
            Console.WriteLine("Please enter the number of array: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array element");
            string array_elements = Console.ReadLine();
            int[] nums = array_elements.Split(' ').Select(int.Parse).ToArray();

            int result = Add(nums);
            Console.WriteLine($"The result is {result}");

        }
    }
}
