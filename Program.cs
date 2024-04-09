namespace TextWriter
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "Hello.txt"; // Default input file name
            string outputFile = "Hello2.txt"; // Default output file name

            // Check if command line arguments are provided for input and output files
            if (args.Length >= 2)
            {
                inputFile = args[0];
                outputFile = args[1];
            }

            try
            {
                // Initialize line counter
                int lineNumber = 1;

                using (StreamReader reader = new StreamReader(inputFile))
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Write the line number and the line to the output file
                        writer.WriteLine($"{lineNumber}: {line}");
                        lineNumber++;
                    }
                }

                Console.WriteLine("File read/write completed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
