using System;
using System.Collections.Generic;
using System.IO;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public Student(int id, string name, int age, string grade)
    {
        Id = id;
        Name = name;
        Age = age;
        Grade = grade;
    }
}

public class CSVhandler
{
    public static List<Student> ReadFromCSV(string filePath)
    {
        var students = new List<Student>();

        using (var reader = new StreamReader(filePath))
        {
            // Bỏ qua dòng tiêu đề (header)
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                int id = int.Parse(values[0]);
                string name = values[1];
                int age = int.Parse(values[2]);
                string grade = values[3];

                var student = new Student(id, name, age, grade);
                students.Add(student);
            }
        }

        return students;
    }
}
public class CSVHandler
{
    public static void WriteToCSV(string filePath, List<Student> students)
    {
        using (var writer = new StreamWriter(filePath))
        {
            // Ghi dòng tiêu đề (header)
            writer.WriteLine("Id,Name,Age,Grade");

            foreach (var student in students)
            {
                writer.WriteLine($"{student.Id},{student.Name},{student.Age},{student.Grade}");
            }
        }
    }
}
public class StudentInput
{
    public static List<Student> GetStudentsFromUser()
    {
        var students = new List<Student>();

        while (true)
        {
            Console.Write("Enter Student Id (or type 'exit' to finish): ");
            string idInput = Console.ReadLine();
            if (idInput.ToLower() == "exit")
            {
                break;
            }

            int id = int.Parse(idInput);

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Grade: ");
            string grade = Console.ReadLine();

            var student = new Student(id, name, age, grade);
            students.Add(student);

            Console.WriteLine("Student added.\n");
        }

        return students;
    }
}
class Program
{
    private const string FilePath = "students.csv";

    static void Main()
    {
        // Nhập thông tin học sinh từ người dùng
        var students = StudentInput.GetStudentsFromUser();

        // Ghi danh sách sinh viên vào tệp CSV
        CSVHandler.WriteToCSV(FilePath, students);

        // Đọc danh sách sinh viên từ tệp CSV
        var readStudents = CSVhandler.ReadFromCSV(FilePath);

        // Hiển thị thông tin sinh viên đọc từ tệp CSV
        Console.WriteLine("\nStudents read from CSV:");
        foreach (var student in readStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }
    }
}
