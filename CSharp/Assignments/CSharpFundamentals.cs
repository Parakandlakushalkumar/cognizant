using System;
using System.Collections.Generic;
using System.Linq;

namespace Upskilling.CSharp.Assignments;

public class CSharpFundamentals
{
    // Topic: variables, data types, and formatted output
    public static void PrintProfile()
    {
        string learnerName = "Student";
        int completedModules = 5;
        double averageScore = 86.5;
        bool isConsistent = true;

        Console.WriteLine($"Learner: {learnerName}");
        Console.WriteLine($"Modules completed: {completedModules}");
        Console.WriteLine($"Average score: {averageScore:F1}");
        Console.WriteLine($"Consistent practice: {isConsistent}");
    }

    // Topic: control flow using if-else and switch expression
    public static string GetGrade(int marks)
    {
        if (marks < 0 || marks > 100)
        {
            return "Invalid marks";
        }

        return marks switch
        {
            >= 90 => "A",
            >= 75 => "B",
            >= 60 => "C",
            >= 40 => "D",
            _ => "Needs improvement"
        };
    }

    // Topic: loops, collections, and LINQ basics
    public static void PrintPassedStudents()
    {
        Dictionary<string, int> scores = new()
        {
            ["HTML5"] = 88,
            ["CSS3"] = 81,
            ["JavaScript"] = 76,
            ["SQL"] = 84,
            ["CSharp"] = 90
        };

        var strongTopics = scores
            .Where(topic => topic.Value >= 80)
            .OrderByDescending(topic => topic.Value);

        foreach (var topic in strongTopics)
        {
            Console.WriteLine($"{topic.Key}: {topic.Value}");
        }
    }

    // Topic: exception handling for safer input
    public static int DivideSafely(int numerator, int denominator)
    {
        try
        {
            return numerator / denominator;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
    }
}
