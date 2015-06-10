namespace StringBuilder.Substring
{
/*Problem 1. StringBuilder.Substring
Implement an extension method Substring(int index, int length) for the class StringBuilder
that returns new StringBuilder and has the same functionality as Substring in the class String.*/ 

    using System;
    using System.Text;
    class StringBuilderMain
    {
        public static void Main()
        {
            var test = new StringBuilder();
            test.Append("Testing extension method Substring for Telerik homework");
            var result = test.Substring(3, 15);
            Console.WriteLine("The text SubString part of the text \"Testing extension method Substring for Telerik homework\" is \"{0}\"",result);
        }
    }
}
