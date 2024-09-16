using System;
class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine(Factorial(21));
        //Console.WriteLine(FactorialRecur(21));
        CountDown(5);
    }

    static void CountDown(int n)
    {
        if (n== 0) Console.WriteLine("blastoff!"); 
        else 
        { 
            Console.WriteLine(n);
            CountDown(n - 1);
        }
    }

    static int Factorial(int n)
    {
        int fact =1;
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    static double FactorialRecur(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * FactorialRecur(n - 1);
    }
}