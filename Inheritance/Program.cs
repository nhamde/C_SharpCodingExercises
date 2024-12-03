using System;
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }

}

public class Dog : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Dog barks");
    }
}

public class Exercise
{
    public void PrintSounds()
    {
        Dog dog = new Dog();
        dog.MakeSound();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintSounds();
        Console.ReadKey();
    }
}