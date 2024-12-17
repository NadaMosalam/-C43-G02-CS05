using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    class Program
    {
        #region Question 1

        //Passing by Value :
        ///static void SWAP(int x, int y)
        ///{
        ///    Console.WriteLine("==========SWAPING AFTER==========");
        ///    int Temp = x;
        ///    x = y;
        ///    y = Temp;
        ///} 

        // Passing by Ref :
        ///static void SWAP(ref int x, ref int y)
        ///{
        ///    Console.WriteLine("==========SWAPING AFTER==========");
        ///    int Temp = x;
        ///    x = y;
        ///    y = Temp;
        ///}
        #endregion

        #region Question 2
        //Passing by Value :
        ///static int SumOfArray(int[] Arr)
        ///{
        ///    int Result = 0;
        ///    if (Arr?.Length > 0)
        ///    {
        ///        Arr[0] = 100;
        ///        for (int i = 0; i < Arr.Length; i++)
        ///            Result += Arr[i];
        ///    }
        ///    return Result;
        ///}

        // Passing by Ref :
        ///static int SumOfArray(ref int[] Arr)
        ///{
        ///    int Result = 0;
        ///    if (Arr?.Length > 0)
        ///    {
        ///        Arr[0] = 100;
        ///        for (int i = 0; i < Arr.Length; i++)
        ///            Result += Arr[i];
        ///    }
        ///    return Result;
        ///}
        #endregion

        #region Question 3
        //static int SumSub(int x, int y, int c, int w)
        //{
        //    int Result = 0;
        //    int Sum = x + y;
        //    int Sub = c - w;
        //    return Result;
        //}
        #endregion

        #region Question 4
        //static int Sum(int Num)
        //{
        //    int Sum = 0;
        //    while (Num != 0)
        //    {
        //        Sum += Num % 10;
        //        Num /= 10;     
        //    }
        //    return Sum;
        //}   
        #endregion

        #region Question 5
        //static bool IsPrime(int Num)
        //{
        //    if (Num <= 1)
        //        return false;

        //    for (int i = 2; i <=(Num); i++) 
        //    {
        //        if (Num > 1) 
        //            return true;
        //    }

        //    return true; 
        //}
        #endregion

        #region Question 6
        //static void MinMaxArray(int[] array, ref int Min , ref int Max)
        //{
        //    Min = array[0];
        //    Max = array[0];
        //    foreach (int num in array)
        //    {
        //        if (num < Min) Min = num;
        //        if (num > Max) Max = num;

        //    }
        //}
        #endregion

        static void Main()
        {
            #region Question 1
            //1.Explain the difference between passing(Value type parameters)
            //by value and by reference then write a suitable c# example.

            ///The Explain:
            ///Value Type parameter: Passing by Value: [Input parameter]
            ///There is no change to the value and it will output with the same value.
            ///If you want to output with a different value, use the output parameter.
            ///Value Type parameter: Passing by Ref: [Input Output parameter]
            ///The value will change and will output a different value.

            ///suitable c# example:
            //Passing by value :
            ///int A = 3, B = 5;
            ///Console.WriteLine($"A={A}");
            ///Console.WriteLine($"B= {B}");
            ///SWAP(A, B);
            ///Console.WriteLine($"A={A}");
            ///Console.WriteLine($"B= {B}");

            // Passing by Ref :
            ///int A = 3, B = 5;
            ///Console.WriteLine($"A={A}");
            ///Console.WriteLine($"B= {B}");
            ///SWAP(ref A, ref B); 
            ///Console.WriteLine($"A={A}");
            ///Console.WriteLine($"B= {B}");
            #endregion

            #region Question 2
            //2.Explain the difference between passing (Reference type parameters)
            //by value and by reference then write a suitable c# example.

            ///The Explain:
            ///Reference Type parameter: Passing by Value: [Input parameter]
            ///The value of the reference is the Address.
            ///Reference Type parameter: Passing by Ref: [Input Output parameter]
            ///The same reference is not the same value.

            ///suitable c# example:
            //Passing by Value :
            ///int[] Numbers = { 1, 2, 3, };
            ///SumOfArray(Numbers);
            ///Console.WriteLine(Numbers[0]);

            // Passing by Ref :
            ///int[] Numbers = { 1, 2, 3, };
            ///SumOfArray(ref Numbers);    
            ///Console.WriteLine(Numbers[0]);
            #endregion

            #region Question 3
            //3.Write a c# Function that accept 4 parameters from user and
            //return result of summation and subtracting of two numbers

            //int A = 30, B = 10, R = 30, D = 10;
            //int Sum = A + B;
            //int Sub = R - D;
            //Console.WriteLine($"Result = {Sum}");
            //Console.WriteLine($"Result = {Sub}");
            #endregion

            #region Question 4
            //4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7

            //Console.Write("Please Enter a Number:");
            //int.TryParse(Console.ReadLine(),out int Num);
            //int result = Sum(Num);
            //Console.WriteLine($"The sum of the digits of the number {Num} is: {result}");
            #endregion

            #region Question 5
            //5.Create a function named "IsPrime", which receives an integer number
            //and retuns true if it is prime, or false if it is not:

            //Console.Write("Please Enter an  integer number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //bool result = IsPrime(number);
            //if (result)
            //    Console.WriteLine($"The number {number} is prime.");
            //else
            //    Console.WriteLine($"The number {number} is not prime.");
            #endregion

            #region Question 6
            //6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array,
            //using reference parameters

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80};
            //int min = 0;
            //int max = 0;
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"The minimum value is: {min}");
            //Console.WriteLine($"The maximum value is: {max}");
            #endregion

        }
    }
}
}