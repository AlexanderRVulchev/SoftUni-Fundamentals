//Explosions are marked with '>'. Immediately after the mark, there will be an integer, which signifies the strength of the explosion.
//You should remove x characters (where x is the strength of the explosion), starting after the punched character ('>').
//If you find another explosion mark ('>') while you're deleting characters, you should add the strength to your previous explosion.
//When all characters are processed, print the string without the deleted characters. 
//You should not delete the explosion character – '>', but you should delete the integers, which represent the strength. 
//Input
//You will receive a single line with the string.
//Output
//Print what is left from the string after the explosions.
//Constraints
//•	You will always receive strength for the punches.
//•	The path will consist only of letters from the Latin alphabet, integers and the char '>'.
//•	The strength of the punches will be in the interval [0…9].


using System;
using System.Text;

internal class Program
{
    static StringBuilder sb = new StringBuilder();

    static void Main()
    {
        sb.Append(Console.ReadLine());
        int index = 0;
        while (index < sb.Length - 1)
        {
            if (sb[index] == '>' && char.IsDigit(sb[index + 1]))
                StringBoom(index, int.Parse(sb[index + 1].ToString()));
            index++;
        }
        Console.WriteLine(sb);
    }

    static void StringBoom(int index, int strength)
    {
        index++;
        for (int i = strength; i > 0; i--)
        {
            if (index >= sb.Length) return;
            if (sb[index] != '>')
                sb.Remove(index, 1);
            else
            {
                i += int.Parse(sb[index + 1].ToString()) + 1;
                index++;               
            }
        }
    }
}
