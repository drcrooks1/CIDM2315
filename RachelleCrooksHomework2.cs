namespace Homework2;
using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter a letter grade: ");
       char grade = Console.ReadLine().ToUpper()[0];

       int gpaPoints;

       switch (grade)
       {
        case 'A':
        gpaPoints = 4;
        break;
        case 'B':
        gpaPoints = 3;
        break;
        case 'D':
        gpaPoints = 1;
        break;
        case 'F':
        gpaPoints = 0;
        break;
        default:
            Console.WriteLine("Wrong Letter Grade!");
            return;

       }
       Console.WriteLine($"GPA Points: {gpaPoints}");
       //Excersize 2
       {
        int num1 = 12, num2= 11, num3 = 14;

        Console.WriteLine("lowest");
        Console.WriteLine("input 1st number");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("input 2nd number");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Input 3rd number");
        num3 = int.Parse(Console.ReadLine());
       }
       
    }
}
