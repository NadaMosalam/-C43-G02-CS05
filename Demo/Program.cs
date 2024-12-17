namespace Demo
{
    class Program
    {
        #region Part 01 Functions (Prototype, Calling)
        //static void printshapes(int count = 5, string shape = "#_#")
        //{
        //    for (int i = 1; i <= count; i++)
        //    {
        //        Console.WriteLine($"{shape}");
        //    }
        //}
        #endregion

        #region Part 02 Functions - ValueType Parameters 
        //1.Passing by Value
        ///static void SWAP(int x, int y)  Swap(3,5)
        ///{
        ///    Console.WriteLine("==========SWAPING==========");
        ///    int Temp = x;
        ///    x = y;
        ///    y = Temp;
        ///}

        //2.Passing by Ref
        ///static void SWAP(ref int x, ref int y)  swap(A,B)
        ///{
        ///    Console.WriteLine("==========SWAPING==========");
        ///    int Temp = x;
        ///    x = y;
        ///    y = Temp;
        ///}
        #endregion

        #region Part 03 Functions - ReferenceType Parameters

        //1.Passing by Value 
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

        //2. Passing by Ref
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

        #region Part 05 Functions - Passing By Out
        //static void sumMul(int x, int y, out int sum, out int Mul)
        //{
        //    sum = x + y;
        //    Mul = x * y;
        //}
        #endregion

        #region Part 07 Functions - Params
        //static int SumArray(int x, int y = 0, params int[] Numbers)
        //{
        //    int Result = 0;
        //    if (Numbers?.Length > 0)
        //        for (int i = 0; i < Numbers.Length; i++)
        //            Result += Numbers[i];
        //    return Result;
        //}

        #endregion

        #region Part 08 Functions - Params in C# 13.0
        //static int SumofNumbers(params IEnumerable<int> Numbers)
        //{
        //    int Result = 0;
        //    if (Numbers is not null)
        //        foreach (int Number in Numbers)
        //            Result += Number;
        //    return Result;
        //}
        #endregion

        //Entry point
        static void Main()
        {
            #region Part 01 Functions (Prototype, Calling)
            //Program.printshapes(5, "#_#");                   //passing parameters in the same order 
            //Program.printshapes(shape: "#_#", count: 5);     //Can I send the values ​​in a different order? yes 
            //Program.printshapes(5, @"\*/");                  //give it a default value in the function

            //Console.WriteLine("nada\nabdalla");
            //Console.WriteLine("nada\tabdalla");
            //Console.WriteLine("nada\\abdalla");
            //string folderpath = @"D:\Route\Ahmed Nasr\C# Basics\Session 5\Videos";
            //Console.WriteLine(folderpath);
            #endregion

            #region Part 02 Functions - ValueType Parameters
            //1.Passing by Value
            /// int A = 3, B = 5;
            /// Console.WriteLine($"A={A}");   //3
            /// Console.WriteLine($"B= {B}");  //5
            /// SWAP(A, B);  //Passing by value[Input parameter]
            ///             //swap(3,5)
            /// Console.WriteLine($"A={A}");   //3
            /// Console.WriteLine($"B= {B}");  //5

            //2.Passing by Ref
            ///int A = 3, B = 5;
            ///Console.WriteLine($"A={A}");   //3
            ///Console.WriteLine($"B= {B}");  //5
            ///SWAP(ref A, ref B);  //Passing by Ref[Input Output parameter]
            ///                     //swap(A,B)
            ///Console.WriteLine($"A={A}");   //5
            ///Console.WriteLine($"B= {B}");  //3
            #endregion

            #region Part 03 Functions - ReferenceType Parameters
            //1.Passing by Value
            ///int[] Numbers = { 1, 2, 3, };
            ///SumOfArray(Numbers);
            ///Console.WriteLine(Numbers[0]);

            //2.Passing by Ref
            ///int[] Numbers = { 1, 2, 3, };
            ///SumOfArray(ref Numbers);    
            ///Console.WriteLine(Numbers[0]);

            #endregion

            #region Part 05 Functions - Passing By Out
            //int A = 3, B = 5;
            //sumMul(A, B, out int SumResult, out int MulResult); // Passing by out[output parameter]
            //Console.WriteLine($"Sum Result= {SumResult}");
            //Console.WriteLine($"Mul Result = {MulResult}");

            //Console.WriteLine("please Enter the real Number");
            //int.TryParse( Console.ReadLine(), out _); // (_)Discard Variable:Used when you need to call a function or operation but don't care about the resulting value.
            #endregion

            #region Part 07 Functions - Params
            //int Result = SumArray( 1, 2, 3, 4, 5, 6, 7, 8, 9 );
            //Console.WriteLine($"Sum of Array= {Result}");
            #endregion

            #region Part 08 Functions - Params in C# 13.0
            //int Result = SumofNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9);
            //Console.WriteLine($"Sum of Array= {Result}");
            #endregion

        }

    }
}