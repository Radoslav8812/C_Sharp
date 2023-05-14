using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        long factorial1 = Factorial(num1);
        int num2 = int.Parse(Console.ReadLine());
        long factorial2 = Factorial(num2);

        double divisionResult = (double)factorial1 / factorial2;

        Console.WriteLine(divisionResult);
    }

    static long Factorial(int n)
    {
        long result = 1;

        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}