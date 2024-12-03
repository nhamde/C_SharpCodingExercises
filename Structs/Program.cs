using System;
public struct Event
{
    // TODO: Add your code here
    public DateTime StartDate;
    public DateTime EndDate;

    public Event(DateTime startDate, DateTime endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
    }
    public double GetDuration()
    {
        return (EndDate - StartDate).TotalDays;
    }

    public bool IsOverlapping(Event otherEvent)
    {
        return StartDate < otherEvent.EndDate && EndDate < otherEvent.StartDate;
    }
}

public class Exercise
{
    public void TestEvents()
    {
        // TODO: Add your code here
        Event event1 = new Event(new DateTime(2024,07,01), new DateTime(2024,07,10));
        Event event2 = new Event(new DateTime(2024,07,05), new DateTime(2024,07,15));

        Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
        Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");
        Console.WriteLine($"Event Overlap {event1.IsOverlapping(event2)}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.TestEvents();
        Console.ReadKey();
    }
}