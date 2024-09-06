namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour, minute, second;
            hour = 13; minute = 48; second = 55;
            int intSecondSinceMidnight = hour*60*60 + minute*60 + second;
            Console.WriteLine(intSecondSinceMidnight);
        }
    }
}
