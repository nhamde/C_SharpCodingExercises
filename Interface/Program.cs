﻿public interface IVehicle
{
    // TODO: Declare a method Drive
    public void Drive();
}

public class Car : IVehicle
{
    // TODO: Implement the Drive method
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}

public class Exercise
{
    public void TestDrive()
    {
        // TODO: Create an instance of Car and call the Drive method
        Car car = new Car();
        car.Drive();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.TestDrive();
        Console.ReadKey();
    }
}