/* Kyle Stackpole
 * Week 12 homework
 */

namespace Week_10_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Abc yz---";
            int shiftAmount = 13;

            string encoded = CaptainCrunch(input, shiftAmount);
            Console.WriteLine("Encoded: " + encoded);

            string decoded = CaptainCrunch(encoded, -shiftAmount);
            Console.WriteLine("Decoded: " + decoded);
        }

        static string CaptainCrunch(string input, int shiftAmount)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsLetter(currentChar))
                {
                    bool isUpper = char.IsUpper(currentChar);
                    char baseChar = isUpper ? 'A' : 'a';

                    int shiftedChar = (currentChar - baseChar + shiftAmount) % 26;
                    if (shiftedChar < 0) shiftedChar += 26;

                    result[i] = (char)(shiftedChar + baseChar);
                }
                else
                {
                    result[i] = currentChar;
                }
            }
            return new string(result);
        }
    }
}
