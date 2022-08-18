//The Anonymous have created a cyber hypervirus, which steals data from the CIA.
//You, as the lead security developer in CIA,
//have been tasked to analyze the software of the virus and observe its actions on the data.
//The virus is known for his innovative and unbeleivably clever technique of merging and dividing data into partitions. 
//You will receive a single input line, containing strings, separated by spaces.
//The strings may contain any ASCII character except whitespace.
//Then you will begin receiving commands in one of the following formats:
//•	merge
//{ startIndex}
//{ endIndex}
//•	divide
//{ index}
//{ partitions}
//Every time you receive the merge command, you must merge all elements from the startIndex,
//till the endIndex. In other words, you should concatenate them. 
//Example: { abc, def, ghi} -> merge 0 1-> { abcdef, ghi}
//If any of the given indexes is out of the array,
//you must take only the range that is inside the array and merge it.
//Every time you receive the divide command,
//you must divide the element at the given index,
//into several small substrings with equal length.
//The count of the substrings should be equal to the given partitions. 
//Example: { abcdef, ghi, jkl} -> divide 0 3-> { ab, cd, ef, ghi, jkl}
//If the string cannot be exactly divided into the given partitions,
//make all partitions except the last with equal lengths, and make the last one – the longest. 
//Example: { abcd, efgh, ijkl} -> divide 0 3-> { a, b, cd, efgh, ijkl}
//The input ends when you receive the command “3:1”.
//At that point you must print the resulting elements, joined by a space.
//Input
//•	The first input line will contain the array of data.
//•	On the next several input lines you will receive commands in the format specified above.
//•	The input ends when you receive the command "3:1".
//Output
//•	As output you must print a single line containing the elements of the array, joined by a space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static List<string> Merge(List<string> list, int start, int end)
    {
        if (start < 0) start = 0;
        if (end >= list.Count) end = list.Count - 1;
        for (int i = start + 1; i <= end; i++)
        {
            list[start] += list[start + 1];
            list.RemoveAt(start + 1);
        }
        return list;
    }

    static List<string> Divide(List<string> list, int index, int partitions)
    {
        string bigChunk = list[index];
        int bigChunkIndex = bigChunk.Length - 1;
        int firstPartitionsSize = bigChunk.Length / partitions;
        int lastPartitionSize = bigChunk.Length % partitions + firstPartitionsSize;
        StringBuilder chunk = new StringBuilder();
        // Split the last string sequence
        for (int i = 0; i < lastPartitionSize; i++)
        {
            chunk.Insert(0, bigChunk[bigChunkIndex]);
            bigChunkIndex--;
        }
        list.Insert(index + 1, chunk.ToString());
        partitions--;
        // Split the first string sequences
        for (int i = 0; i < partitions; i++)
        {
            chunk.Clear();
            for (int j = 0; j < firstPartitionsSize; j++)
            {
                chunk.Insert(0, bigChunk[bigChunkIndex]);
                bigChunkIndex--;
            }
            list.Insert(index + 1, chunk.ToString());
        }
        list.RemoveAt(index);
        return list;
    }

    static void Main()
    {
        List<string> list = Console.ReadLine().Split().ToList();
        string input;
        while ((input = Console.ReadLine()) != "3:1")
        {
            string[] command = input.Split().ToArray();
            if (command[0] == "merge") list = Merge(list, int.Parse(command[1]), int.Parse(command[2]));
            else if (command[0] == "divide") list = Divide(list, int.Parse(command[1]), int.Parse(command[2]));
        }
        Console.WriteLine(String.Join(" ", list));
    }
}