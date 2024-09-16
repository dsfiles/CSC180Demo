using System;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(Factorial(4));
        Console.WriteLine(FactorialRecur(4));
    }

    static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    static int FactorialRecur(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * FactorialRecur(n - 1);
    }
}