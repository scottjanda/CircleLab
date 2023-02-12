using CircleObjects;
using System.Diagnostics.Metrics;

Circle circle = new Circle(userRadius);
string userContinue;

do
{

Console.WriteLine("Welcome to the circle tester");
Console.Write("Enter radius:  ");
bool validRadius = double.TryParse(Console.ReadLine(), out double userRadius);



Console.WriteLine(circle.CalculateFormattedCircumference());
Console.WriteLine(circle.CalculateFormattedArea());

Console.Write("Continue? (y/n):");
    userContinue = Console.ReadLine();

} while (userContinue.ToLower() == "y");

Console.WriteLine($"Goodby! You created {counter} circle objects!");