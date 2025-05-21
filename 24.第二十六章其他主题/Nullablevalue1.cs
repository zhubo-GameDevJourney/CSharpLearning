using System;


Student[] students = null;
int? studentsCount = 5;

if (students != null)
    studentsCount = students.Length;
Console.WriteLine($"studentCount: {studentsCount}");

studentsCount = students?.Length;
Console.WriteLine($"studentsCount: {studentsCount}");



class Student
{
}
