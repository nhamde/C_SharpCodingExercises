using System;

public class Exercise
{
    public void PrintRowSums()
    {
        // TODO
        int[,] arr = new int[3, 3]
                    {
                            {1,2,3},
                            {4,5,6},
                            {7,8,9}
                    };
        for (int i = 0; i < 3; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < 3; j++)
            {
                rowSum += arr[i, j];
            }
            Console.WriteLine(rowSum);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintRowSums();
        Console.ReadKey();
    }
}