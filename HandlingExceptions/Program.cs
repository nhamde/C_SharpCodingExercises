using System;
public class Exercise
{
    public void HandleMultipleExceptions(string str, int index)
    {
        // TODO
        int[] arr = { 1, 2, 3 };

        try
        {
            int value = int.Parse(str);
            Console.WriteLine(arr[index]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range.");
        }

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.HandleMultipleExceptions("54", 1);
        Console.ReadKey();
    }
}