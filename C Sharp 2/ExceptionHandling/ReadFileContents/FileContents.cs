//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages

using System;
using System.IO;
using System.Text;

class FileContents

{
    static void Main(string[] args)
    {
        try
        {
            using (StreamReader sr = new StreamReader(@"C:\Windows\win.ini", Encoding.UTF8))
            {
                string fileContents = sr.ReadToEnd();
                Console.WriteLine(fileContents);
            }
        }

        catch (ArgumentException)
        {
            Console.WriteLine("StreamReader invoked with wrong or null arguments");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This method or functionality is not supported");
        }
    }
}