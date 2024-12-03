public class Exercise
{
    public void CheckLogin()
    {
        bool isLoggedIn = true;

        // Assign a value to isLoggedIn based on user input or condition

        if (isLoggedIn)
        {
            Console.WriteLine("Welcome back!");
        }
        else
        {
            Console.WriteLine("Please log in.");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.CheckLogin();
        Console.ReadKey();
    }
}