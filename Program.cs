using System;
namespace CSC180Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.Hour = 11;
            t1.Minute = 8;
            t1.Second = 3.14;
            Console.WriteLine(t1);

            Time t2 = new Time(11, 8, 3.14);
            Console.WriteLine(t2);

            // test various "WriteTime" methods
            Time.WriteTime(t1);
            Time.WriteTime2(t1);
            t1.WriteTime3();
            t1.WriteTime4(t1);
            t2.WriteTime4(t1);
        }
    }
}
