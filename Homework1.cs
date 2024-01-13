/*
Author: Diana Benitez
The first C# program for Hello World.
*/
namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        float x = 2.5f;
        float y = 3.3f;
        float z = 4*x*x + 3*y;
        Console.WriteLine("X = " + x + ", Y = " + y);
        Console.WriteLine("The value of Z is: " + z);
    }
}
