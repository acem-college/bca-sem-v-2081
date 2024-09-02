using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabs
{
    internal class Lab1
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
            Console.WriteLine("Welcome to Lab1 operations: Here we do basic calculations:\n");
          //  while(true)
           // {
            
            Console.WriteLine("Which operation do you want to perform? \n 1. Add \n 2. Subtract");

            int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //modify pprogram.cs to call add function in lab.cs
                        int result = Add(number1, number2);
                        Console.WriteLine($"The sum of two numbers is : {result}\n");
                        break;
                    case 2:
                        int difference = Sub(number1, number2);
                        Console.WriteLine($"The difference of two number is : {difference}\n");
                        break;

                    default:
                        Console.WriteLine("Please enter valid number:\n ");
                        break;

                }
               // Console.WriteLine("Would you like to continue ? y? or n? ");
                //string abc = Console.ReadLine();

//            }
            

        }
       

        }

    }


// constructor


