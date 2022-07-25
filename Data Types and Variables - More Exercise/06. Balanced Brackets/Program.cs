//You will receive n lines. On those lines, you will receive one of the following:
//•	Opening bracket – “(“,
//•	Closing bracket – “)” or
//•	Random string
//Your task is to find out if the brackets are balanced.
//That means after every closing bracket should follow an opening one.
//Nested parentheses are not valid, and if two consecutive opening brackets exist, the expression should be marked as unbalanced. 
//Input
//•	On the first line, you will receive n – the number of lines, which will follow
//•	On the next n lines, you will receive "(", ")" or another string
//Output
//You have to print "BALANCED" if the parentheses are balanced and "UNBALANCED" otherwise.


using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isBalanced = true;
        bool openedBracket = false;
        for (int line = 0; line < n; line++)
        {
            string input = Console.ReadLine();
            if (input == "(")
            {
                if (openedBracket) isBalanced = false;
                else openedBracket = true;
            }
            else if (input == ")")
            {
                if (openedBracket) openedBracket = false;
                else isBalanced = false;
            }
        }
        if (openedBracket) isBalanced = false;
        Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");
    }
}