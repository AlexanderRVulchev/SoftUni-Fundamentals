//The triangle may be constructed in the following manner: In row 0 (the topmost row), there is a unique nonzero entry 1. Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, treating blank entries as 0. For example, the initial number in the first (or any other) row is 1(the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to produce the number 4 in the fourth row.
//Print each row element separated with whitespace.

using System;


class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] newArray = new int[num + 1];
        int[] oldArray = new int[num + 1];

        newArray[1] = 1;
        Console.WriteLine(newArray[1]);

        for (int row = 1; row < num; row++)
        {
            for (int i = 1; i <= num; i++) oldArray[i] = newArray[i];

            for (int i = 1; i <= row + 1; i++)
            {
                newArray[i] = oldArray[i - 1] + oldArray[i];
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}