// See https://aka.ms/new-console-template for more information

//task 1: display Hello! Welcome to DOT NET LAB
/*using ClassLabs;
using System.ComponentModel;

Console.WriteLine("Hello! Welcome to DOT NET LAB");

//task 2:
display todays datetime
Console.WriteLine($"Today is {System.DateTime.Now}");


display todays full datetime
Console.WriteLine($"Today is {System.DateTime.Now.ToLongDateString()}");


display datetime format
Console.WriteLine($"Today is {System.DateTime.Now.ToString("dddd, MMMM/yyyy hh:mm:ss tt")}");


// task 3: 
// create new class lab1.cs (file)


// write a function add which has two int arguments . function should return the sum of two numbers

// ask user to input numbers
Console.WriteLine("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Which operation do you want to perform? \n 1. Add \n 2. Subtract");
int choice = int.Parse(Console.ReadLine());
Lab1 sum = new Lab1();
switch (choice)
{
    case 1:
        //modify pprogram.cs to call add function in lab.cs
        int result = sum.Add(number1, number2);
        Console.WriteLine($"The sum of two numbers is : {result}");
        break;
    case 2:
        int difference = sum.Sub(number1, number2);
        Console.WriteLine($"The difference of two number is : {difference}");
        break;
    default:
        Console.WriteLine("Please enter valid number: ");
        break;

} */



// task 4:
// subtract and switch case application

// task 5:
// create a constructor in lab1.cs
/* create a private function Initialize */

// new Lab1();


/* ----------------------------------------------------------------------------------------------------------------------------- */
//lab2 task:  interface 


using ClassLabs;
using ClassLabs.lab2;
using ClassLabs.lab2.interfaces;
using ClassLabs.Lab3;
using ClassLabs.Lab4;

//ILab2 l2 = new Lab2(); //implicit object declaration in interface

//Lab2 lab2 = new Lab2();  -- explicit object declaration in class-- 

//int c = l2.Add(8, 4);
//Console.WriteLine($"The sum of two numbers is : {c}");


//new Lab2();

Console.WriteLine("Which program you want to run? ");
Console.WriteLine("L1 for lab1");
Console.WriteLine("L2 for lab2");
Console.WriteLine("L3 for lab3");
Console.WriteLine("L4 for lab4 \n");
string option = Console.ReadLine();
switch (option)
{
    case "L1":
        new Lab1();
        break;
    case "L2":
        new Lab2();
        break;
    case "L3":
        new Lab3();
        break;
    case "L4":
        new Lab4();
        break;
    default:
        Console.WriteLine("Please enter valid input");
        break;
}



