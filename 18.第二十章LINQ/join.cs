using System;

class Program
{
    public class Student
    {
        public int StID;
        public string LastName;
    }

    public class CourseStudent
    {
        public string CourseName;
        public int StID;
    }


    static Student[] students = new Student[]
    {
        new Student {StID = 1, LastName = "Carson"},
        new Student {StID = 2, LastName = "Klassen"},
        new Student {StID = 3, LastName = "dick"}
    };

    static CourseStudent[] StudentsinCourses = new CourseStudent[]
    {
        new CourseStudent { CourseName = "Art", StID = 1 },
        new CourseStudent { CourseName = "Art", StID = 2},
        new CourseStudent { CourseName = "History", StID = 1},
        new CourseStudent { CourseName = "History", StID = 3},
        new CourseStudent { CourseName = "Physics", StID = 3}
    };

    static void Main()
    {
        //查询所有选择历史课的学生姓氏
        var query = from s in students
                    join t in StudentsinCourses on s.StID equals t.StID
                    where t.CourseName == "History"
                    select s.LastName;

        foreach (var q in query)
            Console.WriteLine($"Student taking History : {q}");
    }
}
