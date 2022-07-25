//You will receive a key (integer) and n characters afterward.
//Add the key to each of the characters and append them to a message.
//At the end print the message, which you decrypted. 
//Input
//•	On the first line, you will receive the key
//•	On the second line, you will receive n – the number of lines, which will follow
//•	On the next n lines – you will receive lower and uppercase characters from the Latin alphabet
//Output
//Print the decrypted message.

using System;

class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string message = string.Empty;
        for (int i = 0; i < n; i++)
        {
            char input = char.Parse(Console.ReadLine());
            int outputIntValue = input + key;
            char outputChar = (char)outputIntValue;
            message += outputChar;
        }
        Console.WriteLine(message);
    }
}