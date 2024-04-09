using System;
using System.IO;

namespace Homework_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if the correct number of command-line arguments are provided
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Program.exe Hello.cs Hello.cs2");
                return;
            }

            // Read input file line by line, add line numbers, and write to output file
            using (StreamReader reader = new StreamReader(args[0]))
            using (StreamWriter writer = new StreamWriter(args[1]))
            {
                int lineNumber = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine($"{lineNumber}: {line}");
                    lineNumber++;
                }
            }
        }
    }
}
