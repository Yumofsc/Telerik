using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with
the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first. */
class EncodeAndDecode
{
    static void Main()
    {
        Console.WriteLine("Enter text you want to encode:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter cipher to encode with");
        string cipher = Console.ReadLine();
        string encodedText = EncodingText(text, cipher);
        Console.Write("The encoded text is:");
        Console.WriteLine(encodedText);
        Console.Write("The decoded text is:");
        Console.WriteLine(DecodingText(encodedText, cipher));
        
    }
    static string EncodingText(string text, string cipher)
    {
        StringBuilder encodeText = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            char encrypt = ((char)(text[i] ^ cipher[i % cipher.Length]));
            encodeText.Append(encrypt);
        }
        return encodeText.ToString();
    }
    static string DecodingText(string text, string cipher)
    {
        StringBuilder decodeText = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            char decrypt = ((char)(text[i] ^ cipher[i % cipher.Length]));
            decodeText.Append(decrypt);
        }
        return decodeText.ToString();
    }
}

