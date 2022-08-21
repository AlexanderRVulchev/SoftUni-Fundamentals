//Gabsy is Orgolt's Final Revenge charming drummer.
//She has a drum set but the different drums have different origins – some she bought,
//some are gifts, so they are all of different quality.
//Every day she practices on each of them, so she does damage and reduces the drum`s quality.
//Sometimes a drum breaks, so she needs to buy a new one. Help her keep her drum set organized.
//You will receive Gabsy's savings, the money she can spend on new drums.
//Next, you will receive a sequence of integers, which represents the initial quality of each drum in Gabsy's drum set.
//Until you receive the command "Hit it again, Gabsy!",
//you will be receiving an integer: the hit power Gabsy applies on each drum while practicing.
//When the power is applied, you should decrease the value of the drum's quality with the current power.
//When a certain drum reaches 0 quality, it breaks. Then Gabsy should buy a replacement.
//She needs to buy the same model.
//Therefore, its quality will be the same as the initial quality of the broken drum.
//The price is calculated by the formula: { initialQuality}
//*3.Gabsy will always replace her broken drums until the moment she can no longer afford them.
//If she doesn't have enough money for a replacement, the broken drum is removed from the drum set.
//When you receive the command "Hit it again, Gabsy!",
//the program ends and you should print the current state of the drum set.
//On the second line, you should print the remaining money in Gabsy's savings account.
//Input
//•	On the first line, you will receive the savings – a floating-point number.
//•	On the second line, you will receive the drum set: a sequence of integers, separated by spaces.
//•	Until you receive the command "Hit it again, Gabsy!",
//you will be receiving integers – the hit power Gabsy applies on each drum.
//Output
//•	On the first line, you should print each drum in the drum set, separated by space.
//•	Then you must print the money that is left on the second line in the format
//"Gabsy has {money left}lv.", formatted with two digits after the decimal point.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double gabsysMoney = double.Parse(Console.ReadLine());
        List<int> initialDrumQualities = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> currentDrumQualities = initialDrumQualities.ToList();
        string input;

        while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
        {
            int hitPower = int.Parse(input);
            for (int drum = 0; drum < currentDrumQualities.Count; drum++)
                currentDrumQualities[drum] -= hitPower;

            for (int drum = 0; drum < currentDrumQualities.Count; drum++)
            {
                if (currentDrumQualities[drum] <= 0)
                {
                    int newDrumCost = initialDrumQualities[drum] * 3;
                    if (gabsysMoney - newDrumCost >= 0)
                    {
                        gabsysMoney -= newDrumCost;
                        currentDrumQualities[drum] = initialDrumQualities[drum];
                    }
                    else
                    {
                        currentDrumQualities.RemoveAt(drum);
                        initialDrumQualities.RemoveAt(drum);
                        drum--;
                    }
                }
            }
        }
        Console.WriteLine(String.Join(" ", currentDrumQualities));
        Console.WriteLine($"Gabsy has {gabsysMoney:f2}lv.");
    }
}