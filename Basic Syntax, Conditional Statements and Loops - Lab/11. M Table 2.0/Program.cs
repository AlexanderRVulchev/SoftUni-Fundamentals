//Rewrite the program from the previous task so it can receive the multiplier from the console.
//Print the table from the given multiplier to 10. If the given multiplier is more than 10 -
//print only one row with the integer, the given multiplier, and the product.

using System;


class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if (y < 1 || y > 10) Console.WriteLine($"{x} X {y} = {x * y}");
        for (int i = y; i <= 10; i++)
        {
            Console.WriteLine($"{x} X {i} = {x * i}");
        }
    }
}