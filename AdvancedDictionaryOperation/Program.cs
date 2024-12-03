using System;
public class Exercise
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
    }

    public void PrintStudents()
    {
        // TODO
        Dictionary<string, Student> students = new Dictionary<string, Student>();

        students.Add("John", new Student { Id = 1, Name = "John", Grade = 85 });
        students.Add("Alice", new Student { Id = 2, Name = "Alice", Grade = 90 });
        students.Add("Bob", new Student { Id = 3, Name = "Bob", Grade = 78 });

        foreach (var item in students)
        {
            Console.WriteLine($"Name: {item.Value.Name}, Id: {item.Value.Id}, Grade: {item.Value.Grade}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintStudents();
        Console.ReadKey();
    }
}