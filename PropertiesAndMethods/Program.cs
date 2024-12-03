using System;
public class Person
{
    // TODO
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value > 0)
            {
                _age = value;
            }
        }
    }

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        Console.ReadKey(); 
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Vaibhav", 26);
        person.Greet();
    }
}
