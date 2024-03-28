// Time class
using System;
namespace CSC180
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
        public static void WriteTime(Time t)
        {
            Console.WriteLine(t.Hour + ":" + t.Minute + ":" + t.Second);
        }
        public static void WriteTime2(Time t)
        {   // a version that uses String.Format
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
            t.Hour, t.Minute, (int)t.Second));
        }
        public void WriteTime3()
        {  // a version uses this
            Console.WriteLine(this.Hour + ":" + this.Minute + ":" + this.Second);
        }
        public void WriteTime4(Time t)
        {   // a version takes an argument
            Console.WriteLine(t.Hour + ":" + t.Minute + ":" + t.Second);
        }
    }
}
