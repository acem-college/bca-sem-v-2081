using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using ClassLabs.Lab3.Interfaces;

namespace ClassLabs.Lab3
{
    internal class Lab3 : BaseLab3, ILab3
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i]; 
            }
            //nums.Sum();
            return sum;
        }
        public Lab3()
        {
            UserInteraction();
        }
        private void UserInteraction()
        {
            Console.WriteLine("Welcome to Lab3");
            Console.WriteLine("Select a option:");
            Console.WriteLine("A for Add 2 numbers");
            Console.WriteLine("A1 for Add with Array");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "A":
                    Console.WriteLine("Enter the 2 number: ");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int result = Add(a, b);
                    Console.WriteLine($"The result is {result} ");
                    break;
                case "A1":
                    ProcessA1();
                    break;
            }
        }

        private void ProcessA1()
        {
            Console.WriteLine("Enter the size of array:");
            int size = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the elements");
            string elements = Console.ReadLine();
            int[] numsArray = elements.Split(' ').Select(int.Parse).ToArray();
           
            if (size != numsArray.Length)
            {
                Console.WriteLine("Size of the number didnot match");
                ProcessA1();
            }
            int result = Add(numsArray);
            Console.WriteLine($"The result is {result} ");
        }
    }
    
}
