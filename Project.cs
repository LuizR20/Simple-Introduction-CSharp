using System;

public class Project
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! To get started, please enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine(" ");
        Console.WriteLine("Perfect! And finally, enter your age, so we can create a personalized message introducing you!");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");

        Console.WriteLine("=== Presentation Message ===");
        Console.WriteLine(" ");

        Console.WriteLine($"Hello, nice to meet you. My name is {name} and I'm {age} years old.");
      }
}