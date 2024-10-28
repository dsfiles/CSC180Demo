using System;
namespace ThinkSharp
{
    public class Time
    {
        public int Hour, Minute;
        public double Second;
        public Time()
        {   // Default constructor
            this.Hour = 0;
            this.Minute = 0;
            this.Second = 0.0;
        }
        public Time(int hour, int minute, double second)
        {   // Parametric constructor
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public static void Main(string[] args)
        {   // one way to create and initialize a Time object
            Time t1 = new Time();
            t1.Hour = 11;
            t1.Minute = 8;
            t1.Second = 3.14;
            Console.WriteLine(t1); // what's the output?
            // another way to do the same thing
            Time t2 = new Time(11, 8, 3.14);
            Console.WriteLine(t2); // what's the output again?
        }
    }
}
