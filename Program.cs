// https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections?WT.mc_id=Educationalcsharp-c9-scottha
using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        var fibonacciNumbers = new List<int> { 1, 1 };
        while (fibonacciNumbers.Count < 10)
        {
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            fibonacciNumbers.Add(previous + previous2);
        }

        foreach (var number in fibonacciNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
