using System;
using Coding.Exercise;

namespace Coding.Exercise
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        double rad;
        public Circle(double radius)
        {
            rad = radius;
        }

        public double GetArea()
        {
            return 3.141592653589793 * rad * rad;
        }
    }
    public class Rectangle : IShape
    {
        double length;
        double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }
    }

    public class Exercise
    {
        public void PrintAreas()
        {
            // TODO: Add your code here
            Circle c = new Circle(5);
            Rectangle r = new Rectangle(6, 4);
            IShape[] shapes = new IShape[] { c, r };
            foreach (IShape shape in shapes)
            {
                double area = shape.GetArea();
                Console.WriteLine($"Area: {area}");
            }
        }
    }
}

public class Program
    public static void Main(string[] args)
{
    Exercise exercise = new Exercise();
    exercise.PrintAreas();
    Console.ReadKey();
}