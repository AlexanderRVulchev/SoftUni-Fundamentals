//Write a password reset program that performs a series of commands upon a predefined string.
//First, you will receive a string, and afterward, until the command "Done" is given,
//you will be receiving strings with commands split by a single space. The commands will be the following:
//•	"TakeOdd"
//o Takes only the characters at odd indices and concatenates them to obtain the new raw password and then prints it.
//•	"Cut {index} {length}"
//o	Gets the substring with the given length starting from the given index from the password
//and removes its first occurrence, then prints the password on the console.
//o	The given index and the length will always be valid.
//•	"Substitute {substring} {substitute}"
//o	If the raw password contains the given substring,
//replaces all of its occurrences with the substitute text given and prints the result.
//o	If it doesn't, prints "Nothing to replace!".
//Input
//•	You will be receiving strings until the "Done" command is given.
//Output
//•	After the "Done" command is received, print:
//o "Your password is: {password}"
//Constraints
//•	The indexes from the "Cut {index} {length}" command will always be valid.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string pass = Console.ReadLine();
        string input;
        while ((input = Console.ReadLine()) != "Done")
        {
            string[] cmd = input.Split();
            switch (cmd[0])
            {
                case "TakeOdd":
                    pass = TakeOdd(pass);
                    Console.WriteLine(pass);
                    break;
                case "Cut":
                    pass = Cut(pass, int.Parse(cmd[1]), int.Parse(cmd[2]));
                    Console.WriteLine(pass);
                    break;
                case "Substitute":
                    pass = Substitute(pass, cmd[1], cmd[2]); break;
            }
        }
        Console.WriteLine($"Your password is: {pass}");
    }

    private static string Substitute(string pass, string subString, string replacement)
    {
        if (!pass.Contains(subString))
        {
            Console.WriteLine($"Nothing to replace!");
            return pass;
        }
        string newPass = pass.Replace(subString, replacement);
        Console.WriteLine(newPass);
        return newPass;
    }

    private static string Cut(string pass, int index, int length)
    {
        string subString = pass.Substring(index, length);
        int position = pass.IndexOf(subString);
        return pass.Remove(position, length);
    }

    private static string TakeOdd(string pass)
    {
        StringBuilder newPass = new StringBuilder();
        for (int i = 1; i < pass.Length; i += 2)
            newPass.Append(pass[i]);
        return newPass.ToString();
    }
}