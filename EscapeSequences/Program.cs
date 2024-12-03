using System;
public class Exercise
{
    public void PrintSpecialCharacters()
    {
        // TODO
        Console.WriteLine("Hello\n\tWorld!");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintSpecialCharacters();
        Console.ReadKey();
    }
}