using System;
using System.Collections.Generic;
using System.Linq;

namespace Upskilling.CSharp.HandsOn;

public record Student(string Name, List<int> Marks);

public class StudentGradeCalculator
{
    // Topic: creating objects with sample data
    private readonly List<Student> _students = new()
    {
        new Student("Anu", new List<int> { 86, 92, 78 }),
        new Student("Bala", new List<int> { 71, 69, 80 }),
        new Student("Charan", new List<int> { 95, 89, 91 })
    };

    // Topic: reusable method for average calculation
    public double CalculateAverage(Student student)
    {
        return student.Marks.Average();
    }

    // Topic: decision making based on business rule
    public string DecideResult(double average)
    {
        return average >= 75 ? "Passed with good performance" : "Passed with practice needed";
    }

    // Topic: combining collection processing and output
    public void PrintReport()
    {
        foreach (Student student in _students)
        {
            double average = CalculateAverage(student);
            Console.WriteLine($"{student.Name} - Average: {average:F2} - {DecideResult(average)}");
        }
    }
}
