using System;

namespace GitTraining
{
    public class GitTraining
    {
       public static void Main(string[] args)
        {
           // Git Training
           Console.WriteLine("Welcome to Git!");
           
           Console.WriteLine("Enter a number: ");
           var num1 = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Enter a second number: ");
           var numTwo = Convert.ToInt32(Console.ReadLine());

           int sum = num1 + numTwo;
           Console.WriteLine("The sum of {0} and {1} is {2}", num1, numTwo, sum);
           Console.ReadLine();
        }
    }
}
