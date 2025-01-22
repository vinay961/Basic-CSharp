// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("What operation to perform(add,sub,mul,div)");
        string op = Console.ReadLine();

        switch (op)
        {
            case "add":
                System.Console.WriteLine(num1+num2);
                break;
            case "sub":
                System.Console.WriteLine(num1-num2);
                break;
            case "mul":
                System.Console.WriteLine(num1*num2);
                break;
            case "div":
                if(num2 != 0){
                    System.Console.WriteLine(num1/num2);
                }
                else
                {
                    System.Console.WriteLine("Division by zero is not possible!!");
                }
                break;
            default:
                System.Console.WriteLine("Enter the correct operation!!");
                break;
        }
    }
}
