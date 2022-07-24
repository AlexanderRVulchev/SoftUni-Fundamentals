//You will receive input until you receive "END". Find what data type is the input. Possible data types are:
//•	Integer 
//•	Floating point 
//•	Characters
//•	Boolean
//•	Strings
//Print the result in the following format: "{input} is {data type} type"

using System;

class Program
{
    static void Main()
    {
        string input;
        int typeInt;
        double typeDouble;
        bool typeBool;
        char typeChar;
        while ((input = Console.ReadLine()) != "END")
        {
            if (int.TryParse(input, out typeInt)) Console.WriteLine($"{input} is integer type");
            else if (double.TryParse(input, out typeDouble)) Console.WriteLine($"{input} is floating point type");
            else if (bool.TryParse(input, out typeBool)) Console.WriteLine($"{input} is boolean type");
            else if (char.TryParse(input, out typeChar)) Console.WriteLine($"{input} is character type");
            else Console.WriteLine($"{input} is string type");
        }
    }
}