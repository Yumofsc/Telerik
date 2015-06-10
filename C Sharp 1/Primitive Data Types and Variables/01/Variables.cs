//Problem 1. Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//using System;
class Variables
{
    static void Main()
    {
        sbyte sByte = 115;
        byte bYte = 97;
        ushort uShort = 52130;
        short sHort = -10000;
        int iNt = 4825932;
        Console.WriteLine("The Data Types and Variables are:");
        Console.WriteLine(" sbyte {0} \n byte {1} \n ushort {2} \n short {3} \n int {4}", -sByte, bYte, uShort, sHort, iNt);
    }
}

