//Find online more information about ASCII (American Standard Code for Information Interchange) a
//nd write a program that prints part of the ASCII table of characters at the console.
//On the first line of input, you will receive the char index you should start with,
//and on the second line - the index of the last character you should print.

using System;


class Program
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        for (int i = start; i <= end; i++)
            Console.Write((char)i + " ");
    }
}