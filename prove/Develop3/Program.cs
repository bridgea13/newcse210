
using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture proverbs = new Scripture("Proverbs", 3, 5, 6, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Scripture john = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        proverbs.DisplayScripture();

        Console.WriteLine("\nPress Enter to hide words or type quit to exit.");
        Console.WriteLine(">");
        string input = "";

        while(input != "quit")
        {
            Console.WriteLine("\nPress Enter to hide words or type quit to exit.");
            Console.WriteLine(">");
            input = Console.ReadLine();
        }

    }
   
}