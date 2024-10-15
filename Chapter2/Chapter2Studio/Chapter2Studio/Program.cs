// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

using Chapter2Studio;

Boolean stopLoop = false;

while (!stopLoop)
{
    Console.WriteLine("Enter a radius: ");

    try
    {
        string input = Console.ReadLine();

        float radius = float.Parse(input);

        if (radius > 0)
        {
            double result = Circles.CalculateRadius(radius);
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + result);
            stopLoop = true;
        }
        else
        {
            Console.WriteLine("Enter a valid number for the radius: ");
        }
    }

    catch(FormatException)
    {
        Console.WriteLine("You did not enter a valid format.");
    }


  
}



//basic code to solve the studio problem
//Console.WriteLine("Enter a radius: ");

//string input = Console.ReadLine();

//float radius;

//radius = float.Parse(input);

//double result = radius * radius * 3.14;

//Console.WriteLine("The area of a circle of radius " + radius + " is: " + result);

