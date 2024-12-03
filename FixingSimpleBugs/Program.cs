using System.Security.Cryptography.X509Certificates;

public class Exercise
{
    public void CalculateAverage()
    {
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;
        int average = (num1 + num2 + num3) / 3;
        Console.WriteLine("The average is: " + average);
    }
}
public Program
{
    Public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.CalculateAverage();
        Console.ReadKey();
    }
}