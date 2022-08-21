//Write a program, which reads a string and skips through it, extracting a hidden message.
//The algorithm you have to implement is as follows:
//Let’s take the string "skipTest_String044170" as an example.
//Take every digit from the string and store it somewhere.
//After that, remove all the digits from the string.
//After this operation, you should have two lists of items: the numbers list and the non-numbers list:
//•	Numbers list: [0, 4, 4, 1, 7, 0]
//•	Non - numbers: [s, k, i, p, T, e, s, t, _, S, t, r, i, n, g]
//After that, take every digit in the numbers list and split it up into a take list and a skip list,
//depending on whether the digit is in an even or an odd index:
//•	Numbers list: [0, 4, 4, 1, 7, 0]
//•	Take list: [0, 4, 7]
//•	Skip list: [4, 1, 0]
//Afterward, iterate over both lists and skip {skipCount} characters from the non-numbers list,
//then take {takeCount} characters and store it in a result string.
//Note that the skipped characters are summed up as they go.
//The process would look like this on the aforementioned non-numbers list:
//1.Take 0 characters  Taken: "", skip 4 characters(total 0)  Skipped: "skipTest_String" Result: ""
//2.Take 4 characters Taken: "Test", skip 1 character(total 4)  Skipped: "skip"  Result: "Test"
//3.Take 7 characters Taken: "String", skip 0 characters(total 9) Skipped: ""  Result: "TestString"
//After that, just print the result string on the console.
//Input
//•	First line: The encrypted message as a string
//Output
//•	First line: The decrypted message as a string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static (List<char>, List<int>) ExtractNumbersListFromMainList(List<char> list)
    {
        List<int> numbersList = new List<int>();
        int index = 0;
        while (index < list.Count)
        {
            if (list[index] >= 48 && list[index] <= 57)
            {
                numbersList.Add(int.Parse(list[index].ToString()));
                list.RemoveAt(index);
            }
            else index++;
        }
        return (list, numbersList);
    }

    static (List<int>, List<int>) SplitNumbersListIntoTakeAndSkipLists(List<int> numbers)
    {
        List<int> take = new List<int>();
        List<int> skip = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
            if (i % 2 == 0) take.Add(numbers[i]);
            else skip.Add(numbers[i]);
        return (take, skip);
    }

    static void Main()
    {
        List<char> mainList = Console.ReadLine().ToList();
        List<int> numbersList = new List<int>();
        (mainList, numbersList) = ExtractNumbersListFromMainList(mainList);

        List<int> takeList = new List<int>();
        List<int> skipList = new List<int>();
        (takeList, skipList) = SplitNumbersListIntoTakeAndSkipLists(numbersList);

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < takeList.Count; i++)
        {
            // Taking chars from main list to result string
            for (int j = 0; j < takeList[i]; j++)
                if (mainList.Count > 0)
                {
                    result.Append(mainList[0]);
                    mainList.RemoveAt(0);
                }

            if (i >= skipList.Count) break;

            // Skipping chars from main list
            for (int j = 0; j < skipList[i]; j++)
            {
                if (mainList.Count > 0) mainList.RemoveAt(0);
            }
        }
        Console.WriteLine(result.ToString());
    }
}