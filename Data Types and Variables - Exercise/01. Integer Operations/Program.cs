//Create a program that receives four integer numbers.
//You should perform the following operations:
//•	Add first to the second.
//•	Divide (integer) the result of the first operation by the third number.
//•	Multiply the result of the second operation by the fourth number. 
//Print the result after the last operation.

using System;


class Program
{
    static void Main()
    {
        int[] nums = { int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()) };
        int result = nums[0] + nums[1];
        result /= nums[2];
        result *= nums[3];
        Console.WriteLine(result);
    }
}