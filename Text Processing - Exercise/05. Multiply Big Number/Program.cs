//You are given two lines – the first one can be a really big number (0 to 1050).
//The second one will be a single-digit number (0 to 9). Your task is to display the product of these numbers.
//Note: do not use the BigInteger class.


using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string bigNum = Console.ReadLine();
        int multiplier = int.Parse(Console.ReadLine());

        if (multiplier == 0)
        {
            Console.WriteLine(0);
            return;
        }

        StringBuilder result = new StringBuilder();
                
        int overflowNum = 0;
        for (int i = bigNum.Length - 1; i >= 0; i--)
        {
            int bigNumDigit = int.Parse(bigNum[i].ToString());
            int product = bigNumDigit * multiplier + overflowNum;
            int resultDigit = product % 10;
            overflowNum = product / 10;
            result.Insert(0, resultDigit);
        }

        if (overflowNum != 0) result.Insert(0, overflowNum);        
        Console.WriteLine(result);
    }
}
