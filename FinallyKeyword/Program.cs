using System;
public class Exercise
{
    public void PrintWithFinally()
    {
        // TODO
        try
        {
            Console.WriteLine("Trying...");
        }
        finally
        {
            Console.WriteLine("Finally executed.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintWithFinally();
        Console.ReadKey();
    }
}