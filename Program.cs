using System;
using System.ComponentModel.Design;


namespace programming_assignment_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to be coded:");
            string input = Console.ReadLine();
            string output = CodedOutput(input);
            string decodedOutput = DecodedOutput(output);

            Console.WriteLine("Please enter a number between 0-25 to be used with coding:");
            int Number = Console.Read();

            //if (Number < 0 || Number > 25)
            //{
            //    Console.WriteLine("Invalid input. Please enter a number between 0 and 25:");
            //}

            string UserCoded = UserCodedOutput(input, Number);

            Console.WriteLine("Your string is coded with default key as follows:\n" + output);
            Console.WriteLine("Your string is decoded with default key as follows:\n" + decodedOutput);

            Console.WriteLine("Your string is coded with your key number as follow:\n" + UserCoded);

        }

        static string CodedOutput(string input)
        {
            char[] original = input.ToCharArray();
            char[] coded = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if ((Convert.ToInt32(original[i]) >= 65 && Convert.ToInt32(original[i]) <= 90) || (Convert.ToInt32(original[i]) >= 97 && Convert.ToInt32(original[i]) <= 122))
                {
                    int asciiValue = (int)original[i] + 13;
                    if ((Convert.ToInt32(original[i]) >= 65 && Convert.ToInt32(original[i]) <= 90) && asciiValue > 90)
                        asciiValue -= 26;
                    else if ((Convert.ToInt32(original[i]) >= 97 && Convert.ToInt32(original[i]) <= 122) && asciiValue > 122)
                        asciiValue -= 26;
                    coded[i] = (char)asciiValue;
                }
                else
                {
                    coded[i] = original[i];
                }
            }
            return new string(coded);
        }

        static string DecodedOutput(string output)
        {
            char[] original = output.ToCharArray();
            char[] coded = new char[output.Length];

            for (int i = 0; i < output.Length; i++)
            {
                if ((Convert.ToInt32(original[i]) >= 65 && Convert.ToInt32(original[i]) <= 90) || (Convert.ToInt32(original[i]) >= 97 && Convert.ToInt32(original[i]) <= 122))
                {
                    int asciiValue = (int)original[i] - 13;
                    if ((Convert.ToInt32(original[i]) >= 65 && Convert.ToInt32(original[i]) <= 90) && asciiValue < 65)
                        asciiValue += 26;
                    else if ((Convert.ToInt32(original[i]) >= 97 && Convert.ToInt32(original[i]) <= 122) && asciiValue < 97)
                        asciiValue += 26;
                    coded[i] = (char)asciiValue;
                }
                else
                {
                    coded[i] = original[i];
                }
            }
            return new string(coded);
        }

        static string UserCodedOutput(string input, int Number)
        {
            char[] original = input.ToCharArray();
            char[] coded = new char[input.Length];
            int UsethisNumber = Number;

            for (int i = 0; i < input.Length; i++)
            {
                if ((Convert.ToInt32(original[i]) >= 65 && Convert.ToInt32(original[i]) <= 90) || (Convert.ToInt32(original[i]) >= 97 && Convert.ToInt32(original[i]) <= 122))
                {
                    int asciiValue = (int)original[i] + UsethisNumber;
                    if ((Convert.ToInt32(original[i]) >= 65 && Convert.ToInt32(original[i]) <= 90) && asciiValue > 90)
                        asciiValue -= 26;
                    else if ((Convert.ToInt32(original[i]) >= 97 && Convert.ToInt32(original[i]) <= 122) && asciiValue > 122)
                        asciiValue -= 26;
                    coded[i] = (char)asciiValue;
                }
                else
                {
                    coded[i] = original[i];
                }
            }
            return new string(coded);
        }

    }
}
