namespace Homework5;

class Program
{
    /*//Homework 5 - Q1
    static void Main(string[] args){
    int inputNum1, inputNum2;
    GetNumbers(out inputNum1, out inputNum2);
    int largest = LargestNumber(inputNum1, inputNum2);
    Console.WriteLine($"a = {inputNum1}; b={inputNum2}");
    Console.WriteLine($"The largest number is:{largest}");
    }

    static int LargestNumber(int inputNum1, int inputNum2){
    int largest = inputNum1 > inputNum2 ? inputNum1 : inputNum2;
    return largest;
    }    

    static void GetNumbers(out int num1, out int num2){
        Console.WriteLine("Please input two integers: ");
        num1 = Convert.ToInt16(Console.ReadLine());
        num2 = Convert.ToInt16(Console.ReadLine());
    }*/
    
    
    /*//Homework 5 - Q2
    static void Main(string[] args){
    int inputNum1, inputNum2, inputNum3, inputNum4;
    GetNumbers(out inputNum1, out inputNum2, out inputNum3, out inputNum4);
    int largest = LargestNumber(inputNum1, inputNum2, inputNum3, inputNum4);
    Console.WriteLine($"a = {inputNum1}; b={inputNum2}; c = {inputNum3}; d={inputNum4}");
    Console.WriteLine($"The largest number is:{largest}");
    }
    static int LargestNumber(int inputNum1, int inputNum2, int inputNum3, int inputNum4){
    int max1 = inputNum1 > inputNum2 ? inputNum1 : inputNum2;
    int max2 = inputNum3 > inputNum4 ? inputNum3 : inputNum4;
    int largest = max1 > max2 ? max1 : max2;
    return largest;
    }    
    static void GetNumbers(out int num1, out int num2, out int num3, out int num4){
        Console.WriteLine("Please input four integers: ");
        num1 = Convert.ToInt16(Console.ReadLine());
        num2 = Convert.ToInt16(Console.ReadLine());
        num3 = Convert.ToInt16(Console.ReadLine());
        num4 = Convert.ToInt16(Console.ReadLine());
    }*/


    /*//Homework 5 - Q3
    static void Main(string[] args){
        string userName, password1, password2;
        int birth_year;
        createAccount(out userName, out password1, out password2, out birth_year);
    }
    
    static bool checkAge(int birth_year){
    int currentYear = DateTime.Now.Year;
        int age = currentYear - birth_year;
        return age >= 18;
    }
   
    static void createAccount(out string userName, out string password1, out string password2, out int birth_year){
    Console.WriteLine("Enter your Username: ");
    userName = Console.ReadLine();
    Console.WriteLine("Enter your Password: ");
    password1 = Console.ReadLine();
    Console.WriteLine("Enter your Password Again: ");
    password2 = Console.ReadLine();
    Console.WriteLine("Enter your Birthyear: ");
    birth_year = Convert.ToInt32(Console.ReadLine());

    if (checkAge(birth_year)) {
        if (password1 == password2) {
            Console.WriteLine("Account is created successfully");
            }
        else {
            Console.WriteLine("Wrong password");
            }
    }
    else {
        Console.WriteLine("Could not create an account");
        }
    }*/
}
