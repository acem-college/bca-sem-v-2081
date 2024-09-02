using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabs.Lab4
{
    internal class Lab4 : BaseLab4
    {
        public override int Add(int[] nums)
        {
            int sum = base.Add(nums);
            Console.WriteLine($"The original answer before testing even and odd was {sum} .\n");
            if (sum % 2 == 0)
            {
                sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        sum += nums[i];
                    }
                }
                return sum;
            }
            else
            {
                sum= 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 != 0)
                    {
                        sum += nums[i];
                    }
                }
                return sum;
            }
        }
        public Lab4()
        {
            Initialize();
        }

        private void Initialize()
        {
            Console.WriteLine("\n  Enter the size of array of integers: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array elements in CSV (comma separated value) ");
            string elements = Console.ReadLine();
            int[] nums = elements.Split(',').Select(int.Parse).ToArray();
            if (size != nums.Length)
            {
                Console.WriteLine("Size of elements is not matched.");
            }
            int arrResult = Add(nums);
            Console.WriteLine($"The sum of array elements after testing the sum is even or odd is {arrResult} .\n");
        }
    }
}
