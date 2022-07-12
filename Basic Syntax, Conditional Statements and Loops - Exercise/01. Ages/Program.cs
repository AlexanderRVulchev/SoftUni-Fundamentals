//Write a program that determines if a person is baby, child, teenager, adult, elder based on the given age. The bounders are:
//•	0 - 2 – baby
//•	3 - 13 – child
//•	14 - 19 – teenager
//•	20 - 65 – adult
//•	>= 66 – elder
//•	All the values are inclusive.

using System;


class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string output = "elder";
        int[] age = { 2, 13, 19, 65 };
        string[] category = { "baby", "child", "teenager", "adult" };

        for (int i = 0; i < 4; i++)
            if (num <= age[i])
            {
                output = category[i];
                break;
            }
        Console.WriteLine(output);
    }
}