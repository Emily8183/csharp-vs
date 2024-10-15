// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

using Chapter2Studio;

//Solution3: do while

float radius;

do
{
    Console.WriteLine("Please enter a positive radius");
    string input = Console.ReadLine();

    if (Equals(input, "") || !float.TryParse(input, out radius))
    {
        Console.WriteLine("I can't calculate it");
        return;
    }
    //radius = float.Parse(input);

} while (radius < 0);


double result = Circles.CalculateRadius(radius);
Console.WriteLine("The area of a circle of radius " + radius + " is: " + result);

//Solution2: try-catch

//Boolean stopLoop = false;

//while (!stopLoop)
//{
//    Console.WriteLine("Enter a radius: ");

//    try
//    {
//        string input = Console.ReadLine();

//        float radius = float.Parse(input);

//        if (radius > 0)
//        {
//            double result = Circles.CalculateRadius(radius);
//            Console.WriteLine("The area of a circle of radius " + radius + " is: " + result);
//            stopLoop = true;
//        }
//        else
//        {
//            Console.WriteLine("Enter a valid number for the radius: ");
//        }
//    }

//    catch(FormatException)
//    {
//        Console.WriteLine("You did not enter a valid format.");
//    }  
//}



//Solution 1: basic code to solve the studio problem
//Console.WriteLine("Enter a radius: ");

//string input = Console.ReadLine();

//float radius;

//radius = float.Parse(input);

//double result = radius * radius * 3.14;

//Console.WriteLine("The area of a circle of radius " + radius + " is: " + result);

