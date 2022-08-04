//Create a method that receives two parameters:
//•	A string 
//•	A number n (integer) represents how many times the string will be repeated
// The method should return a new string, containing the initial one, repeated n times without space. 

using System;
using System.Text;

class Program
{
    static string RepeatString(string str, int count)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            sb.Append(str);
        }
        return sb.ToString();
    }

    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(RepeatString(input, n));
    }
}