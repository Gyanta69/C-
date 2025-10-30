// See https://aka.ms/new-console-template for more information
using Lab2ConsoleApp;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

// Task 1: Declare variables and print a formatted string
String userName ="Pragyan";
int luckyNumebr = 7;
Console.WriteLine($"Hello, {userName}. Your lucky number is {luckyNumebr}.");


// Task 2: Accessing constant from Circle class
// The following line will cause a compilation/build error because PI is a constant
//Circle.PI = 2.3333;
//Console.WriteLine($"Value of PI is {Circle.PI}");

byte byteVar = 255; // maximum value for byte
short shortVar = 32767; // maximum value for short
int intVar = 2147483647; // maximum value for int
long longVar = 9223372036854775807; // maximum value for long
float floatVar = 3.40282347E+38F; // maximum value for float
double doubleVar = 1.7976931348623157E+308; // maximum value for double
decimal decimalVar = 79228162514264337593543950335M; // maximum value for decimal
char charVar = 'A'; // character variable
bool boolVar = true; // boolean variable

// convert int value to string and store it in new variable
int intValue = 123;
string stringValue = intValue.ToString();
Console.WriteLine($"Converted string value: {stringValue}");

// convert string value "3.14" to double and store it in new variable
string strValue = "3.14";
double doubleValue = Convert.ToDouble(strValue);
Console.WriteLine($"Converted double value: {doubleValue}");

//print all variables to the console with appropriate lables showing their types and values
Console.WriteLine($"byteVar (byte): {byteVar}");
Console.WriteLine($"shortVar (short): {shortVar}");
Console.WriteLine($"intVar (int): {intVar}");
Console.WriteLine($"longVar (long): {longVar}");
Console.WriteLine($"floatVar (float): {floatVar}");
Console.WriteLine($"doubleVar (double): {doubleVar}");
Console.WriteLine($"decimalVar (decimal): {decimalVar}");
Console.WriteLine($"charVar (char): {charVar}");
Console.WriteLine($"boolVar (bool): {boolVar}");
Console.WriteLine($"intValue (int): {intValue}");
Console.WriteLine($"stringValue (string): {stringValue}");
Console.WriteLine($"strValue (string): {strValue}");
Console.WriteLine($"doubleValue (double): {doubleValue}");

// Task 4 : Array and Arrary Methods
// create a single dimensional array of integers with 5 elements
int[] intArray = { 10, 20, 30, 40, 50 };

// use Array.Sort() method to sort the array in ascending order
Array.Sort(intArray);
Console.WriteLine("Sorted array in ascending order:");
for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine(intArray[i]);
}

// use Array.Reverse() method to reverse the array
Array.Reverse(intArray);
Console.WriteLine("Reversed array:");
for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine(intArray[i]);
}

// Use Array.IndexOf() method to find the index of a specific element in the array
// Note: if the index is not found, it returns -1
int index = Array.IndexOf(intArray, 30);
Console.WriteLine($"Index of element 30 in the array: {index}");



// Task 5: Date Time and TimeSpan

// create a var with date time
DateTime myBirthDay = new DateTime(2006, 1, 7);


// create another var with current date and time
DateTime currentDateTime =  DateTime.Now;    
Console.WriteLine($"Current Date and Time: {currentDateTime}");

// calculate your age using TimeSpan
TimeSpan ageSpan = currentDateTime - myBirthDay;
int ageInYears = (int)(ageSpan.TotalDays / 365.25);
Console.WriteLine($"Your age in years: {ageInYears}");

// print both date time variables and age to the console
Console.WriteLine($"My Birthday: {myBirthDay}");
Console.WriteLine($"Current Date and Time: {currentDateTime}");
Console.WriteLine($"Age in Years: {ageInYears}");

//Add 10 days to your birthday and print the new date
DateTime newBirthday = myBirthDay.AddDays(10);
Console.WriteLine($"My Birthday after adding 10 days: {newBirthday}");

// Task 6 : Generic Collections(List and Dictionary)

// Create a list<string> constaining the names of 3 different fruits
List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };


// Add another fruit to the list
fruits.Add("Date");
Console.WriteLine("Fruits in the list:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}   

// Remove one fruit from the list
fruits.Remove("Banana");
Console.WriteLine("Fruits after removal:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
// Create a dictionary<int, string> containing 3 key-value pairs representing fruit IDs and values as their names
Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Banana" },
    { 3, "Cherry" }
};
// Add another key-value pair to the dictionary
fruitDictionary.Add(4, "Date");
Console.WriteLine("Fruits in the dictionary:");
foreach (var kvp in fruitDictionary)
{
    Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
}
 