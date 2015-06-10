using System;
class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime inputDate = new DateTime(year, month, day);
        
        inputDate = inputDate.AddDays(1);
        
        Console.WriteLine(inputDate.Day + "." + inputDate.Month + "." + inputDate.Year);

    }
}
