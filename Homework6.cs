namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        
        p1.PrintProfessor();
        p2.PrintProfessor();
        s1.PrintStudent();
        s2.PrintStudent();
        
        double salaryDifference = Professor.CalculateSalaryDifference(p1, p2);
            Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {salaryDifference}");
        double totalGrade = Student.CalculateTotalGrade(s1, s2);
            Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {totalGrade}");
        
        }
    }
