using System;
using System.Text.RegularExpressions;
using System.Linq;

public class Exercise
{
    public static int NotHungryCats(string kitchen)
    {
        string[] cats = kitchen.Split('F');

        int leftCount = cats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
        int rightCount = cats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');

        return leftCount + rightCount;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Exercise.NotHungryCats("~OO~~O F ~O~OO~O~"));
        Console.ReadKey();
    }
}