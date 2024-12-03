using System;

public class Exercise
{
    public void PrintNumber()
    {
        // TODO
        int x = 10;
        Console.WriteLine(x);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintNumber();
        Console.ReadKey();
    }
}