// See https://aka.ms/new-console-template for more information
using ClassLabs;
using ClassLabs.Lab2;
using ClassLabs.Lab2.INterfaces;
using System.ComponentModel;

Console.WriteLine("Hello, welcome to .net labs!");
Console.WriteLine($"today:{System.DateTime.Now.ToString("ddd MMM yyyy hh:mm:ss tt")}");

//new Lab1();//explicitly

//task4:write a substract function in lab1.cs which accepts two int argument the function shoild substract a from b and return result
//modify program.cs to allow user to either add or sun=bstract 
//ask user to select an option "A" to add and "B" to substract 
//when user enters A it should call Add FUnction and show the result
// when user entersB,it should call substract function and show the result

//task 5: create a constructor in lab1.cs
//create a private function initialize
// the function does not return any value and doess not have any arguments
// move all your code from program.css in to initialize
// call initialize function from constructor
//when application runs, the user experience should be same as before as done in task 3 & 4.


ILab2 lab2 = new Lab2(); //implicitly

int add = lab2.add(3, 2);
Console.WriteLine(add);
Console.WriteLine("select the lab you want to run:");
//switch ()
//{
//    case "1":
//        new Lab1();
//        break;
//    case "2":
//        ILab2 lab2 = new Lab2();
//        break;
//}

