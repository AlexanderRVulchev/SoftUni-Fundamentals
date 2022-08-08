//Create a program that checks if a given password is valid.
//The password validation rules are:
//•	It should contain 6 – 10 characters (inclusive)
//•	It should contain only letters and digits
//•	It should contain at least 2 digits 
//If it is not valid, for any unfulfilled rule print the corresponding message:
//•	"Password must be between 6 and 10 characters"
//•	"Password must consist only of letters and digits"
//•	"Password must have at least 2 digits"

using System;


class Program
{
    static bool IsBetweenSixAndTenCharacters(string pass)
    {
        if (pass.Length >= 6 && pass.Length <= 10) return true;
        Console.WriteLine("Password must be between 6 and 10 characters");
        return false;
    }

    static bool ConsistsOnlyOfLettersAndDigits(string pass)
    {
        for (int i = 0; i < pass.Length; i++)
        {
            if (pass[i] > 47 && pass[i] < 58 || pass[i] > 64 && pass[i] < 91 || pass[i] > 96 && pass[i] < 123) continue;
            Console.WriteLine("Password must consist only of letters and digits");
            return false;
        }
        return true;
    }

    static bool HasAtLeastTwoDigits(string pass)
    {
        int digitsCount = 0;
        for (int i = 0; i < pass.Length; i++)
            if (pass[i] > 47 && pass[i] < 58) digitsCount++;
        if (digitsCount >= 2) return true;
        Console.WriteLine("Password must have at least 2 digits");
        return false;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        bool passwordIsValid = true;
        if (!IsBetweenSixAndTenCharacters(input)) passwordIsValid = false;
        if (!ConsistsOnlyOfLettersAndDigits(input)) passwordIsValid = false;
        if (!HasAtLeastTwoDigits(input)) passwordIsValid = false;

        if (passwordIsValid) Console.WriteLine("Password is valid");
    }
}