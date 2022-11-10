using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        int[] targets = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            int targetIndex = int.Parse(input);
            if (!TargetIsValid(targets, targetIndex)) continue;
            int targetValue = targets[targetIndex];
            targets[targetIndex] = -1;
            ModifyTargetValuesAfterAShot(targets, targetValue);
        }
        int totalTargetsShot = targets.Where(x => x == -1).Count();
        Console.WriteLine($"Shot targets: {totalTargetsShot} -> {String.Join(" ", targets)}");
    }

    private static void ModifyTargetValuesAfterAShot(int[] targets, int targetValue)
    {
        for (int i = 0; i < targets.Length; i++)
        {
            if (targets[i] == -1) continue;
            if (targets[i] > targetValue)
                targets[i] -= targetValue;
            else targets[i] += targetValue;
        }
    }

    private static bool TargetIsValid(int[] targets, int targetIndex) =>
         (targetIndex >= 0 && targetIndex < targets.Length && targets[targetIndex] != -1);
}