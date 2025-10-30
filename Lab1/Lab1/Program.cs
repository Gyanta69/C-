// See https://aka.ms/new-console-template for more information
using Lab1;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        // Main class for personal details
        // Personal details
        string name = "Pragyan Khadka";
        string address = "Bhangal, Budhanilkantha";
        string contactNumber = "9876543210";
        string college = "Islington College";

        // Printing details
        Console.WriteLine("=== Personal Details ===");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Contact Number: " + contactNumber);
        Console.WriteLine("College: " + college);

        Console.WriteLine("\n=== Motivational Quote ===");

        // Create instance of Quote class
        var quote = new Quote();
        quote.PrintQuote();

        Console.ReadLine(); // Keeps console open
    }
}