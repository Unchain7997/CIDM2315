﻿using System;

class Program
{
    //*** Do NOT change the code in Main ***
    public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"Sum of 2d array: {ElementSum(array_2d)}");


        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }


    public static void ArraySum(int[] int_array) {
        int sum = 0;
        foreach (int num in int_array) {
            sum += num;
        }
        Console.WriteLine($"The Sum of int_array is: {sum}");
    }

    public static void PrintAllOddNumber(int[,] array_2d) {
        foreach (int num in array_2d) {
            if (num % 2 != 0) {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
    
    public static int ElementSum(int[ , ] array_2d) {
        int sum = 0;
        foreach (int num in array_2d) {
            sum += num;
        }
        return sum;
    }

    public static int[ , ] DoubleArray(int[ , ] array_2d) {
        int[ , ] doubledArray = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
        for (int i = 0; i < array_2d.GetLength(0); i++) {
            for (int j = 0; j < array_2d.GetLength(1); j++) {
                doubledArray[i, j] = array_2d[i, j] * 2;
            }
        }
        return doubledArray;
    }
}
