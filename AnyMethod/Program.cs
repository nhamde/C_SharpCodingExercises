using System;
public class Exercise
{
    public void CheckAny()
    {
        // The list has been declared for you, use it in your solution.
        List<int> myNumbers = new List<int> { 1, 6, 3 };

        // TODO: Check if any number is greater than 5 using the Any method
        bool isGreaterThanFive = myNumbers.Any(num => num > 5);
        // and print the result ("True" or "False") to the console.
        Console.WriteLine(isGreaterThanFive);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.CheckAny();
        Console.ReadKey();
    }
}