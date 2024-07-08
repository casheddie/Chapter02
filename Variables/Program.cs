using System.Xml;

object height = 1.88; // Storing a double in an object.
object name = "Amir"; //Storing a string in an object.
Console.WriteLine($"{name} is {height} meters tall.");
//int length1 = name.Length;
int length2 = ((string)name).Length; // Cast name to a string.
Console.WriteLine(($"{name} has {length2} characters."));

dynamic something;
// Storing an array of int values in a dynamic object.
// Any array of any type has a Length property.
something = new[] {3,5,7};
//Storing an int in a dynamic object.
// It does not have a Length property
//something = 12;
// Storing a string ina dynamic object.
// string has a Length property.
//something = "Ahmed";
// This compiles but might throw an exception at run-time.
Console.WriteLine($"The length of something is {something.Length}");
//output the type of the something variables.
Console.WriteLine($"something is a {something.GetType()}");

var population = 67_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "Apples";
var letter = 'Z';
var happy = true;

// Good use of var because it avoids the repeated type
// as shown in the more verbose second statement.
var xml1 = new XmlDocument(); // Works with C# 3 and later.
XmlDocument xml2 = new XmlDocument(); // works with all C# versions.

// Bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in the second statement.
var file1 = File.CreateText("something.txt");
StreamWriter file2 = File.CreateText("somthing2.txt");

Console.WriteLine();
Console.WriteLine("test");
Console.WriteLine(2+12);