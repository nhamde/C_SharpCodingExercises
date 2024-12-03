using System;
public class Exercise
{
    public void PrintNumbers()
    {
        // TODO
        List<int> integers = new List<int> { 1, 2, 3 };
        foreach (int num in integers)
        {
            Console.Write($"{num} ");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintNumbers();
        Console.ReadKey();
    }
}