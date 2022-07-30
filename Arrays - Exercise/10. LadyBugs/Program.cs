//You are given a field size and the indexes where ladybugs can be found on the field.
//On every new line, until the "end" command is given,
//a ladybug changes its position either to its left or to its right by a given fly length.
//A movement description command looks like this: "0 right 1".
//This means that the little insect placed on index 0 should fly one index to its right.
//If the ladybug lands on another ladybug, it continues to fly in the same direction repeating the specified flight length.
//If the ladybug flies out of the field, it is gone.
//For example, you are given a field of size 3 there are ladybugs on indexes 0 and 1.
//If the ladybug on index 0 needs to fly to its right by the length of 1 (0 right 1)
//it will attempt to land on index 1 but as there is another ladybug there,
//so it will continue further to the right passing 1 index in length, landing on index 2.
//After that, if the same ladybug needs to fly to its right passing 1 index (2 right 1),
//it will land somewhere outside of the field, so it flies away:


//If we receive an initial index that does not contain a ladybug nothing happens.
//If you are given a ladybug index that is outside the field, nothing happens.
//In the end, print all cells of the field separated by blank spaces.
//For each cell that has a ladybug in it print '1' and for each empty cell print '0'.
//The output of the example above should be '0 1 0'.
//Input
//•	On the first line, you will receive an integer - the size of the field
//•	On the second line, you will receive the initial indexes of all ladybugs separated by a blank space
//•	On the next lines, until you get the "end" command you will receive commands in the format:
//"{ladybug index} {direction} {fly length}"

//Output
//•	Print all field cells in format: "{cell} {cell} … {cell}"
//o If a cell has a ladybug in it, print '1'
//o	If a cell is empty, print '0'

using System;
using System.Linq;


class Program
{
    static void Main()
    {
        // Declaring variables
        int size = int.Parse(Console.ReadLine());
        int[] field = new int[size];
        int[] firstLocations = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Placing initial ladybug locations in the array
        for (int i = 0; i < firstLocations.Length; i++)
            if (firstLocations[i] >= 0 && firstLocations[i] < size)
                field[firstLocations[i]] = 1;

        // Loop for each line entered in the console
        string input = Console.ReadLine();
        while (input != "end")
        {
            // Splitting the input into an array and reading the selected ladybug, direction and fly length
            string[] inputArray = input.Split().ToArray();
            int selectedLadybug = int.Parse(inputArray[0]);
            bool directionRight = inputArray[1] == "right";
            int flyLength = int.Parse(inputArray[2]);

            // Checking if the ladybug selection is valid
            if (selectedLadybug < 0 || selectedLadybug >= size || field[selectedLadybug] == 0 || flyLength == 0)
            {
                input = Console.ReadLine();
                continue;
            }

            // Determining the new index for the ladybug
            int newLadybugLocation = selectedLadybug;
            if (directionRight) newLadybugLocation += flyLength;
            else newLadybugLocation -= flyLength;

            while (true)
            {
                if (newLadybugLocation < 0 || newLadybugLocation >= size) // Ladybug flies off the field
                {
                    field[selectedLadybug] = 0;
                    break;
                }

                else if (field[newLadybugLocation] == 0) // Swap old ladybug index with the new one
                {
                    field[newLadybugLocation] = 1;
                    field[selectedLadybug] = 0;
                    break;
                }

                // Determining new ladybug target index if this index is already occupied
                if (directionRight) newLadybugLocation += flyLength;
                else newLadybugLocation -= flyLength;
            }

            input = Console.ReadLine();
        }

        // Output
        for (int i = 0; i < size; i++)
        {
            Console.Write(field[i] + " ");
        }
        Console.WriteLine();
    }
}