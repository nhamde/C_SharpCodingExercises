using System;
using System.Text.RegularExpressions;
public class Exercise
{
    public void ExtractPatterns(string input)
    {
        string inputPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        Regex reg = new (inputPattern);

        MatchCollection matches = reg.Matches(input);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.ExtractPatterns("nhamde1998@gmail.com");
        Console.ReadKey();
    }
}