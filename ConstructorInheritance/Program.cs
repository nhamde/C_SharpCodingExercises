public class Person
{
    public string Name { get; private set; }
    // TODO: Declare a constructor that takes a name and prints a message
    public Person(string _name)
    {
        Name = _name;
        Console.WriteLine($"Person constructor: {Name}");
    }
}

public class Employee : Person
{
    public int ID { get; private set; }
    // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
    public Employee(string _name, int _id) : base(_name)
    {
        ID = _id;
        Console.WriteLine($"Employee constructor: {Name}, ID: {ID}");
    }

}

public class Exercise
{
    public void PrintMessages()
    {
        // TODO: Create an instance of Employee and print the messages
        Employee emp = new Employee("John Doe", 123);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintMessages();
        Console.ReadKey();
    }
}