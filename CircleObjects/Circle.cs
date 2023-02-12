using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    public class Circle
    {
        public double radius { get; set; }

        public static int counter = 0;

        public Circle(double Radius)
        {
            radius = Radius;
            counter++;
        }
        public double CalculateCircumference()
        {
            return 2 * radius * Math.PI;
        }
        public string CalculateFormattedCircumference() { return $"Circumference: {Math.Round(CalculateCircumference(), 2)}"; }
        public double CalculateArea() { return Math.PI * Math.Pow(radius, 2); }
        public string CalculateFormattedArea() { return $"Area:          {Math.Round(CalculateArea(), 2)}"; }
        private string FormatNumber(double x) { return $"Goodby! You created {counter} circle objects!"; }
    }
}
