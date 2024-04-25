using System;

class Program
{
    static void Main(string[] args)
    {
        string plainText = "#Abc yz";
        Console.WriteLine(plainText + " (original text)");
        string encodedText = CaptainCrunch(plainText, 13);
        Console.WriteLine(encodedText + " (encoded text)");
        string decodedText = CaptainCrunch(encodedText, 13);
        Console.WriteLine(decodedText + " (decoded text)");
    }

    public static string CaptainCrunch(string str, int n)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            int letter = (int)str[i];
            if (str[i] >= 'A' && str[i] <= 'Z')
            {
                letter = (letter + n - (int)'A') % 26 + (int)'A';
            }
            if (str[i] >= 'a' && str[i] <= 'z')
            {
                letter = (letter + n - (int)'a') % 26 + (int)'a';
            }
            result += (char)letter;
        }
        return result;
    }
}

