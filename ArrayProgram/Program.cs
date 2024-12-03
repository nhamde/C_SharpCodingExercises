using System;

public class Exercise
{
    public void PrintNumbers()
    {
        // Initialize array and print each number using a foreach loop
        int[] arr = { 1, 2, 3, 4, 5 };

        arr.Any(x => x > 0);

        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise(); 
        exercise.PrintNumbers();
        Console.ReadLine();
    }
}