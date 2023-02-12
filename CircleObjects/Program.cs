using CircleObjects;
using System.Diagnostics.Metrics;


string userContinue = "y";
Console.WriteLine("Welcome to the circle tester");

do
{

    Console.Write("Enter radius:  ");
    if (double.TryParse(Console.ReadLine(), out double userRadius) && userRadius > 0)
    {
        Circle circle = new Circle(userRadius);

        Console.WriteLine(circle.CalculateFormattedCircumference());
        Console.WriteLine(circle.CalculateFormattedArea());
    }
    else
    {
        Console.WriteLine("Please enter a positive number for the radius.\n");
        continue;
    }

    Console.Write("Continue? (y/n):");
    userContinue = Console.ReadLine();

} while (userContinue.ToLower() == "y");

Console.WriteLine($"Goodby! You created {Circle.counter} circle objects!");