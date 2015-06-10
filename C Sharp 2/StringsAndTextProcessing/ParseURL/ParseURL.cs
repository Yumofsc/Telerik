using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Problem 12. Parse URL

//Write a program that parses an URL address given in the format: 
[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:
URL	                                                      |     Information
http://telerikacademy.com/Courses/Courses/Details/212	  | [protocol] = http 
                                                          | [server] = telerikacademy.com 
                                                          | [resource] = /Courses/Courses/Details/212 */

class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        Console.WriteLine("URL: {0}\n", url);
        string[] urlArray = url.Split(new string[] { "://" }, StringSplitOptions.None);

        string protocol = "";
        string server = "";
        string resource = "";

        protocol = urlArray[0];
        int positionServer = urlArray[1].IndexOf('/');
        server = urlArray[1].Substring(0, positionServer);
        resource = urlArray[1].Substring(positionServer);

        Console.WriteLine("\tInformation:");
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] + {0}", resource);
    }
}

