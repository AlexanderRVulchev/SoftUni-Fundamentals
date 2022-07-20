//A Pokemon is a special type of pokemon which likes to Poke others.
//But at the end of the day, the Pokemon wants to keep statistics, about how many pokes it has managed to make.
//The Pokemon pokes his target and then proceeds to poke another target.
//The distance between his targets reduces his poke power.
//You will be given the poke power the Pokemon has, N – an integer.
//Then you will be given the distance between the poke targets, M – an integer.
//Then you will be given the exhaustionFactor Y – an integer.
//Your task is to start subtracting M from N until N becomes less than M, i.e.
//the Pokemon does not have enough power to reach the next target. 
//Every time you subtract M from N that means you’ve reached a target and poked it successfully.
//COUNT how many targets you’ve poked – you’ll need that count.
//The PokeMon becomes gradually more exhausted.
//IF N becomes equal to EXACTLY 50 % of its original value, you must divide N by Y, if it is POSSIBLE.
//This DIVISION is between integers.
//If a division is not possible, you should NOT do it.
//Instead, you should continue subtracting.
//After dividing, you should continue subtracting from N, until it becomes less than M.
//When N becomes less than M, you must take what has remained of N and the count of targets you’ve poked,
//and print them as output.

//NOTE: When you are calculating percentages, you should be PRECISE at maximum.
//Example: 505 is NOT EXACTLY 50 % from 1000, its 50.5 %.
//Input
//•	The input consists of 3 lines.
//•	On the first line, you will receive N – an integer.
//•	On the second line, you will receive M – an integer.
//•	On the third line, you will receive Y – an integer.
//Output
//•	The output consists of 2 lines.
//•	On the first line print what has remained of N, after subtracting from it.
//•	On the second line print the count of targets, you’ve managed to poke.

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int pokeCount = 0;
        int exhaustLine = n % 2 == 0 ? n / 2 : -1;

        while (n >= m)
        {
            if (n == exhaustLine)
            {
                if (y != 0 && y != 1) n /= y;
                else exhaustLine = -1;
                continue;
            }
            n -= m;
            pokeCount++;
        }
        Console.WriteLine(n);
        Console.WriteLine(pokeCount);
    }
}