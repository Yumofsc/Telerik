using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with 
corresponding tags [URL=…]…/URL]. 
 * 
 
 <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
 Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>     
 
 <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
 Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */
class ReplaceTags
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string firtTag = "<a href=\"";
        string secoundTag = "</a>";
        string rightBrecet = "\">";
        string firstCorrection = "[URL=";
        string secoundCorrection = "[/URL]";
        string newRightBrecet = "]";

        string format = text.Replace(firtTag, firstCorrection);
        string secoundFormat = format.Replace(secoundTag, secoundCorrection);
        string finalFormat = secoundFormat.Replace(rightBrecet, newRightBrecet);
        Console.WriteLine(finalFormat);
    }
}

