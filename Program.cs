using System;
public class Program
{
    unsafe static void Main(string[] args)
    {
        int i = 1;
        int* p = &i;
        Console.WriteLine((int)p);
        Console.WriteLine(*p);
        p++; // this is really unsafe
        Console.WriteLine((int)p);
        Console.WriteLine(*p); // oops
    }
}
