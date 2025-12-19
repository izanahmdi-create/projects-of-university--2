using System;
using System.Collections.Generic;
using System.IO;

namespace UniversityApp
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }

        public override string ToString()
        {
            return $"{Id},{Name},{Major}";
        }

        public static Student FromString(string data)
        {
            string[] parts = data.Split(',');
            return new Student
            {
                Id = int.Parse(parts[0]),
                Name = parts[1],
                Major = parts[2]
            };
        }
    }

    class Program
    {
        static Dictionary<int, Student> students = new Dictionary<int, Student>();
        static string fileName = "UNI.txt";

        static void Main(string[] args)
        {
            LoadFromFile();

            while (true)
            {
                Console.WriteLine("\n--- University System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        DisplayStudents();
                        break;
                    case "3":
                        DeleteStudent();
                        break;
                    case "4":
                        SaveToFile();
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            if (students.ContainsKey(id))
            {
                Console.WriteLine("Student ID already exists!");
                return;
            }

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Major: ");
            string major = Console.ReadLine();

            students.Add(id, new Student { Id = id, Name = name, Major = major });
            Console.WriteLine("Student added successfully.");
        }

        static void DisplayStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n--- Student List ---");
            foreach (var student in students.Values)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Major: {student.Major}");
            }
        }

        static void DeleteStudent()
        {
            Console.Write("Enter Student ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            if (students.Remove(id))
                Console.WriteLine("Student deleted successfully.");
            else
                Console.WriteLine("Student not found.");
        }

        static void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var student in students.Values)
                {
                    writer.WriteLine(student.ToString());
                }
            }
        }

        static void LoadFromFile()
        {
            if (!File.Exists(fileName))
                return;

            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                Student student = Student.FromString(line);
                students[student.Id] = student;
            }
        }
    }
}