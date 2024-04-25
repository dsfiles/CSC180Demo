using System.ComponentModel.Design;
using System.Diagnostics;

namespace CapCrunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press 1 to use Encode Talker (Regular Capitan Crunch) or press 2 to use Decode Talker (add any number)");
                string check = Console.ReadLine();
                if (check == "1")
                {
                    Link.EncodeTalker();
                    break;
                }
                else if (check == "2")
                {
                    Link.DecodeTalker();
                    break;
                }
                else
                {
                    Console.WriteLine("Please follow the rules");
                    Console.WriteLine();
                }
            }
        }
        public class Link
        {
            public static void EncodeTalker()
            {
                Console.WriteLine("Please provide a word, no numbers nor special characters maybe used");
                string Talker = Console.ReadLine();
                string EncodedTalker = "";
                foreach (char character in Talker)
                {
                    if (char.IsLetter(character))
                    {
                        bool MaybeUpper = char.IsUpper(character);

                        int ascii = (int)character;

                        ascii += 13;

                        if (MaybeUpper)
                        {
                            if (ascii > (int)'Z')
                                ascii -= 26;
                        }
                        else
                        {
                            if (ascii > (int)'z')
                                ascii -= 26;
                        }
                        EncodedTalker += (char)ascii;
                    }
                    else
                    {
                        EncodedTalker += character;
                    }
                }
                Console.WriteLine(EncodedTalker);
            }
            public static void DecodeTalker()
            {
                Console.WriteLine("please provide the desired number for Decoding/Encoding");
                string DecodeEncode = Console.ReadLine();
                if (int.TryParse(DecodeEncode, out int code)) ;
                else
                {
                    Console.WriteLine("Please provide a valid number");
                }

                Console.WriteLine("Please provide a word, no numbers nor special characters maybe used");
                string DTalker = Console.ReadLine();
                string DecodedTalker = "";
                foreach (char character in DTalker)
                {
                    if (char.IsLetter(character))
                    {
                        bool MaybeUpper = char.IsUpper(character);

                        int ascii = (int)character;

                        ascii += code;

                        if (MaybeUpper)
                        {
                            if (ascii > (int)'Z')
                                ascii -= 26;
                            else if (ascii < (int)'A')
                                ascii += 26;
                        }
                        else
                        {
                            if (ascii > (int)'z')
                                ascii -= 26;
                            else if (ascii < (int)'a')
                                ascii += 26;
                        }
                        DecodedTalker += (char)ascii;
                    }
                    else
                    {
                        DecodedTalker += character;
                    }
                }
                Console.WriteLine(DecodedTalker);
            }
        }
    }
}

