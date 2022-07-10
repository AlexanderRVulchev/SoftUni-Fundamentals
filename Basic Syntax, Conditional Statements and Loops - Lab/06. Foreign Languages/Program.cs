//Create a program that prints the spoken language in a country. You will receive only the following combinations: 
//•	English is spoken in England and the USA.
//•	Spanish is spoken in Spain, Argentina, and Mexico.
//•	For the others, we should print "unknown".
//Input
//You will receive a single line of input, representing the country name.
//Output
//Print the language spoken in the given country. If the country is unknown for the program, print "unknown".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string country = Console.ReadLine();
        switch (country)
        {
            case "England":
            case "USA":
                Console.WriteLine("English"); break;
            case "Spain":
            case "Argentina":
            case "Mexico":
                Console.WriteLine("Spanish"); break;
            default:
                Console.WriteLine("unknown"); break;
        }
    }
}