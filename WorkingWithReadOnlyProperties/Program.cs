using System;
public class MyClass
{
    public string MyReadOnlyProperty { get; }

    public MyClass(string value)
    {
        MyReadOnlyProperty = value;
    }
}

public class Exercise
{
    public void PrintReadOnlyProperty()
    {
        var myObject = new MyClass("Read-Only Property Value");
        Console.WriteLine(myObject.MyReadOnlyProperty);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintReadOnlyProperty();
        Console.ReadKey();
    }
}