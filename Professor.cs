class Professor{
    public string profName;
    public string classTeach;
    private double salary;
    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary() {
        return salary;
    }
    public void PrintProfessor(){
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {GetSalary()}");
    }
    public static double CalculateSalaryDifference(Professor p1, Professor p2){
        double salaryDifference = (p1.GetSalary() - p2.GetSalary());
        return salaryDifference;
    }

}