using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC180Demo
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
    }
}