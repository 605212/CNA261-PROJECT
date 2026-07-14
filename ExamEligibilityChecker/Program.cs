using System;
class Program
{
    static double GetMark(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double value) && value >= 0 && value<= 100)
            {
                return value;

            }
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
    static double CalculateWeightedAverage( double test1, double test2, double assignment1, double project)
    {
        return (test1 *0.3) + (test2 * 0.50) + (assignment1 * 0.10) + (project * 0.10);

    }
    static void Main()
    {
        Console.WriteLine("=== Exam Eligibility Checker ===");
        double test1 =GetMark("Enter Test 1 mark (weight 30%): ");
        double test2 = GetMark("Enter Test 2 mark (weight 50%): ");
        double assignment1 = GetMark("Enter Assignment 1 mark (weight 10%): ");
        double project = GetMark("Enter Project mark (weight 10%): ");

        double average = CalculateWeightedAverage(test1, test2, assignment1, project);
        Console.WriteLine($"\nWeighted average: {average:F2}");

        if (average >= 50)
        {
            Console.WriteLine("Result: You QUALIFY to write the exam.");
        }
        else
        {
            Console.WriteLine("Result: You do NOT qualify to write the exam.");
        }
    }
    
}
