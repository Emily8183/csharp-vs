// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("Enter a radius: ");

string input = Console.ReadLine();

float radius;

radius = float.Parse(input);

double result = radius * radius * 3.14;

Console.WriteLine("The area of a circle of radius " + radius + " is: " + result);

