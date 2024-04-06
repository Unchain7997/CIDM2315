using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework9 {
    public class Student {
        private int studentID;
        private string studentName;
        public static List<Student> studentList = new List<Student>();

        public Student(int id, string name) {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        public string GetStudentName() {
            return studentName;
        }
        public void SetStudentName(string name) {
            studentName = name;
        }

        public void PrintInfo() {
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
    }

    class Program {
        static void Main(string[] args) {
            Student alice = new Student(111, "Alice");
            Student bob = new Student(222, "Bob");
            Student cathy = new Student(333, "Cathy");
            Student david = new Student(444, "David");

            Dictionary<string, double> gradebook = new Dictionary<string, double> {
                {"Alice", 4.0},
                {"Bob", 3.6},
                {"Cathy", 2.5},
                {"David", 1.8}
            };

            if (!gradebook.ContainsKey("Tom")) {
                gradebook.Add("Tom", 3.3);
            }

            double averageGPA = gradebook.Values.Average();
            Console.WriteLine($"The average GPA is: {averageGPA}");

            foreach (var kvp in gradebook) {
                if (kvp.Value > averageGPA) {
                    foreach (var student in Student.studentList) {
                        if (student.GetStudentName() == kvp.Key) {
                            student.PrintInfo();
                            break;
                        }
                    }
                }
            }
        }
    }
}