class Student{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade() {
        return studentGrade;
    }
    public void PrintStudent(){
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {GetGrade()}");
    }
    public static double CalculateTotalGrade(Student s1, Student s2){
        double totalGrade = (s1.GetGrade() + s2.GetGrade());
        return totalGrade;
    }

}