//On the first line, you will be given a username, your task is to try to log in the user.
//The user’s password is username reversed. On the next lines, you will receive passwords:
//•	If the password is incorrect print "Incorrect password. Try again."
//•	If the password is correct print: "User {username} logged in." and stop the program
//Keep in mind, on the fourth attempt if the password is still not correct print: "User {username} blocked!"
//Then the program stops.

using System;


class Program
{
    static void Main()
    {
        string username = Console.ReadLine();
        string password = string.Empty;
        for (int i = username.Length - 1; i >= 0; i--)
            password += username[i];
        int failCount = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
                return;
            }
            failCount++;
            if (failCount == 4)
            {
                Console.WriteLine($"User {username} blocked!");
                return;
            }
            Console.WriteLine("Incorrect password. Try again.");
        }
    }
}