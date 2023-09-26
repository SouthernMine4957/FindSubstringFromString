using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the main string:");
        string mainString = Console.ReadLine();

        Console.WriteLine("Enter the substring to find:");
        string subString = Console.ReadLine();

        int index = mainString.IndexOf(subString);

        if (index != -1)
        {
            Console.WriteLine($"The substring '{subString}' was found at index {index} in the main string.");
        }
        else
        {
            Console.WriteLine($"The substring '{subString}' was not found in the main string.");
        }
    }
}
