using ClassLabs.lab2.interfaces;

namespace ClassLabs.lab2
{
    internal class Lab2 : ILab2
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y) {
            return x - y; 
        }

        public int Multiply(int x, int y) { 
            return x * y; 
        }

        public int Divide(int x, int y) { 
             return x / y;
        }
        public Lab2()
        {
            UserInteraction();
        }
        private void UserInteraction()
        {
            Console.WriteLine("Welcome to Lab2 operations: Here we do basic calculations using interface: \n");
            int result;
          
            Console.WriteLine("Choose the operation: ");
            Console.WriteLine("A for Add");
            Console.WriteLine("S for Subtract");
            Console.WriteLine("D for Divide");
            Console.WriteLine("M for Multiply\n");
            string choice = Console.ReadLine();
            Console.WriteLine("Enter the first number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case "A":
                    result = Add(num, num2);
                    Console.WriteLine($"The sum of {num} and {num2} is {result} .\n");
                    break;
                case "S":
                    result = Subtract(num, num2);
                    Console.WriteLine($"The difference between {num} and {num2} is {result} . \n");
                    break;

                case "D":
                    result = Divide(num, num2);
                    Console.WriteLine($"The result of {num} and {num2} is {result} . \n");
                    break;

                case "M":
                    result = Multiply(num, num2);
                    Console.WriteLine($"The result of {num} and {num2} is {result}  . \n");
                    break;

                default:
                    Console.WriteLine("Please enter the valid input.\n");
                    break;
            }
        }

    }
    
   

    
}
