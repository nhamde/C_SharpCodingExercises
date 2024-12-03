public class Exercise
{
    public void PrintAverage(double[] temperatures)
    {
        double result = CalculateAverage(temperatures);
        Console.WriteLine($"The average temperature is: {result}");
    }

    public double CalculateAverage(double[] temperatures)
    {
        // TODO
        double tempSum = 0;
        foreach (double temp in temperatures)
        {
            tempSum += temp;
        }
        return tempSum / temperatures.Length;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        double[] temperatures = { 54, 78.5, 95.1 };
        Exercise exercise = new Exercise();
        exercise.PrintAverage(temperatures);
        Console.ReadKey();
    }
}