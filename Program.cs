using System;

public class Student
{
    public string Name { get; set; }
    public int GradeLevel { get; set; }
    public List<string> Courses { get; set; }

    public Student(string name, int gradeLevel)
    {
        Name = name;
        GradeLevel = gradeLevel;
        Courses = new List<string>();
    }

    public void AddCourse(string course)
    {
        Courses.Add(course);
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Grade Level: " + GradeLevel);
        Console.WriteLine("Courses:");
        foreach (var course in Courses)
        {
            Console.WriteLine("- " + course);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Додавання нового студента
        Student student1 = new Student("John Doe", 10);
        student1.AddCourse("Mathematics");
        student1.AddCourse("Science");

        // Виведення інформації про студента
        student1.PrintStudentInfo();

        // Додавання ще одного студента
        Student student2 = new Student("Jane Smith", 9);
        student2.AddCourse("English");
        student2.AddCourse("History");
        student2.AddCourse("Art");

        // Виведення інформації про другого студента
        student2.PrintStudentInfo();

        Console.ReadLine();
    }
}