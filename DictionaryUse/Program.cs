using System;
public class Exercise
{
    public void PrintDictionaryValues()
    {
        // TODO
        Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
        dictionary.Add("key1", new List<int> { 1, 2, 3 });

        foreach (var item in dictionary)
        {
            if (item.Key == "key1")
            {
                foreach (int val in item.Value)
                {
                    Console.Write($"{val} ");
                }
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintDictionaryValues();
        Console.ReadKey();
    }
}