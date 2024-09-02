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
            //int sum = nums.Sum();
            return sum;
        }
        public Lab3()
        {
            Initialize();
        }
        private void Initialize()
        {
            Console.WriteLine("Welcome to Lab3 operations: Here we learn about polymorphism: \n");
            int result;


            Console.WriteLine("Choose the operation: ");
            Console.WriteLine("A for Adding two numbers");
            Console.WriteLine("A1 for Adding numbers in array");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "A":
                    Console.WriteLine("\n Enter the first number: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    int num2 = int.Parse(Console.ReadLine());
                    result = Add(num, num2);
                    Console.WriteLine($"The sum of {num} and {num2} is {result} .\n");
                    break;

                case "A1":
                    ProcessA1();
                    break;

                default:
                    Console.WriteLine("Please enter the valid input.\n");
                    break;
            }

        }
        private void ProcessA1()
        {
            Console.WriteLine("\n  Enter the size of array of integers: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array elements in CSV (comma separated value) ");
            string elements = Console.ReadLine();
            int[] nums = elements.Split(',').Select(int.Parse).ToArray();
            if (size != nums.Length)
            {
                Console.WriteLine("Size of elements is not matched.");
                ProcessA1();
            }
            int arrResult = Add(nums);
            Console.WriteLine($"The sum of array elements is {arrResult} .\n");
        }
    }
}

