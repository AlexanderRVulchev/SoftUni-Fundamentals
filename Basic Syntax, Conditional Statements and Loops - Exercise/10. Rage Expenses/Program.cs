//As a MOBA challenger player, Petar has the bad habit to trash his PC when he loses a game and rage quits.
//His gaming setup consists of a headset, mouse, keyboard, and display. You will receive Petar's lost games count. 
//Every second lost game, Petar trashes his headset.
//Every third lost game, Petar trashes his mouse.
//When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
//Every second time, when he trashes his keyboard, he also trashes his display. 
//You will receive the price of each item in his gaming setup.
//Calculate his rage expenses for renewing his gaming equipment. 
//Input / Constraints
//•	On the first input line - lost games count – integer in the range [0, 1000].
//•	On the second line – headset price - the floating-point number in the range [0, 1000]. 
//•	On the third line – mouse price - the floating-point number in the range [0, 1000]. 
//•	On the fourth line – keyboard price - the floating-point number in the range [0, 1000]. 
//•	On the fifth line – display price - the floating-point number in the range [0, 1000]. 
//Output
//•	As output you must print Petar's total expenses: "Rage expenses: {expenses} lv."

using System;


class Program
{
    static void Main()
    {
        int lostGames = int.Parse(Console.ReadLine());

        int headsetsBroken = lostGames / 2;
        int miceBroken = lostGames / 3;
        int keyboardsBroken = lostGames / 6;
        int displaysBroken = lostGames / 12;

        double headsetsCost = headsetsBroken * double.Parse(Console.ReadLine());
        double miceCost = miceBroken * double.Parse(Console.ReadLine());
        double keyboardsCost = keyboardsBroken * double.Parse(Console.ReadLine());
        double displaysCost = displaysBroken * double.Parse(Console.ReadLine());

        double total = headsetsCost + miceCost + keyboardsCost + displaysCost;

        Console.WriteLine($"Rage expenses: {total:f2} lv.");
    }
}