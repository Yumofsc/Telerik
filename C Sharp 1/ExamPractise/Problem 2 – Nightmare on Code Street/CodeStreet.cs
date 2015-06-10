using System;
class CodeStreet
{
    static void Main()
    {
        string digits = Console.ReadLine();
        int counter = 0;
        int sum = 0;
        int oddCounter = 0;
        int result = 0;
        
        
        {
            foreach (char symbol in digits)
            {
                sum = symbol - '0';
                if (sum % 2 == 0)
                {
                    oddCounter++;
                    result += sum ;
                    
                }
                counter++;

            }
        }
        Console.WriteLine(result + " " + counter);
    }
}
