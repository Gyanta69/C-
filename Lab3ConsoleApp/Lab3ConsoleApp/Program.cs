// See https://aka.ms/new-console-template for more information
// write a console program that asks the user for their age as a string and then calculates and displays what their age will be in5 years.
using Lab3ConsoleApp;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;



void PrintHeader(string title)
{
    Console.WriteLine();
    Console.WriteLine(new string('=', 60));
    Console.WriteLine(title);
    Console.WriteLine(new string('-', 60));
}

// Task1: Age in5 Years
PrintHeader("Task1: Age in 5 Years");
Console.Write("Enter your age: ");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
 Console.WriteLine("No input provided. Skipping Task1.");
}
else if (!int.TryParse(input.Trim(), out int age))
{
 Console.WriteLine("Invalid age input. Skipping Task1.");
}
else
{
 int futureAge = age +5;
 Console.WriteLine($"In5 years, you will be {futureAge} years old.");
}

// Task2: Arithmetic Expressions and Blocks
PrintHeader("Task2: Arithmetic Expressions and Blocks");
double price =120.50; // price per unit
int quantity =9; // number of units

double total = price * quantity; // calculate total as double
double discountedTotal = total >1000 ? total *0.9 : total; // apply discount if applicable

Console.WriteLine($"Price: {price:0.00}, Quantity: {quantity}");
Console.WriteLine($"Total: {total:0.00}");
Console.WriteLine($"Discounted total: {discountedTotal:0.00}");

// Task3: String manipulations
PrintHeader("Task3: String Manipulations");
string sentence = "C# is Powerful and Fun!";
string lower = sentence.ToLower();
string upper = sentence.ToUpper();
int length = sentence.Length;

Console.WriteLine($"Original: {sentence}");
Console.WriteLine($"Uppercase: {upper}");
Console.WriteLine($"Lowercase: {lower}");
Console.WriteLine($"Length: {length}");

// Task4: Guid, DateTime, and TimeSpan Challenge
PrintHeader("Task4: Guid, DateTime, and TimeSpan");
Guid orderId = Guid.NewGuid();
DateTime orderDate = DateTime.Now;
TimeSpan deliveryTime = TimeSpan.FromHours(48);
DateTime expectedDeliveryDate = orderDate.Add(deliveryTime);
Console.WriteLine($"Order ID: {orderId}");
Console.WriteLine($"Order Date: {orderDate}");
Console.WriteLine($"Expected Delivery Date: {expectedDeliveryDate}");

// Task5: Working with Reference Types
PrintHeader("Task5: Working with Reference Types");
Book book1 = new Book("The Alchemist", "Paulo Coelho",15.99);
Book book2 = book1; // both variables reference the same object
book2.Price =9.99; // modify via book2

Console.WriteLine("Book1 Details:");
book1.PrintDetails();
Console.WriteLine("Book2 Details:");
book2.PrintDetails();
Console.WriteLine("Note: Both Book1 and Book2 show the updated price because they reference the same object.");

// Task6: Nullable Type Use Case
PrintHeader("Task6: Nullable Type Use Case");
double? temperature = null;
if (temperature == null)
{
 Console.WriteLine("Temperature not recorded");
}
else
{
 Console.WriteLine($"Temperature: {temperature}");
}

temperature =36.6;
Console.WriteLine($"Temperature: {temperature}");

// Task7: Generic Collection Mini App
PrintHeader("Task7: Generic Collection Mini App");
List<string> products = new List<string>
{
 "Laptop",
 "Smartphone",
 "Tablet",
 "Headphones"
};

Console.WriteLine("Products in Inventory:");
foreach (var product in products)
{
 Console.WriteLine("- " + product);
}

products.Remove("Tablet");
Console.WriteLine("\nProducts after removal:");
foreach (var product in products)
{
 Console.WriteLine("- " + product);
}

Console.WriteLine("\nProduct Stock Counts:");
Dictionary<string, int> productStock = new Dictionary<string, int>
{
 ["Laptop"] =10,
 ["Smartphone"] =25
};

foreach (var kvp in productStock)
{
 Console.WriteLine($"Product: {kvp.Key}, Stock: {kvp.Value}");
}





