using System;
using static System.Console;

namespace Arrays;

public class SingleDimensionalArrayExample
{
    public static void Run()
    {
        #region Working with single-dimensional arrays

        WriteLine("--- Ví dụ 1: Mảng một chiều ---");

        // Khai báo và cấp phát bộ nhớ cho mảng 4 chuỗi.
        string[] names = new string[4];
        names[0] = "Kate";
        names[1] = "Jack";
        names[2] = "Rebecca";
        names[3] = "Tom";

        // Cú pháp thay thế để tạo và khởi tạo giá trị cho mảng.
        string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" };

        // Duyệt qua các phần tử của mảng và in ra.
        for (int i = 0; i < names2.Length; i++)
        {
            WriteLine($"{names2[i]} ở vị trí {i}.");
        }

        WriteLine("---------------------------------");
        WriteLine();

        #endregion
    }
}

public class MultiDimensionalArrayExample
{
    public static void Run()
    {
        #region Working with multi-dimensional arrays

        WriteLine("--- Ví dụ 2: Mảng đa chiều ---");

        // Khai báo và khởi tạo một mảng hai chiều.
        string[,] grid1 =
        {
            { "Alpha", "Beta", "Gamma", "Delta" },
            { "Anne", "Ben", "Charlie", "Doug" },
            { "Aardvark", "Bear", "Cat", "Dog" }
        };

        // Lấy giới hạn dưới và trên của mỗi chiều.
        WriteLine($"Chiều 1, giới hạn dưới: {grid1.GetLowerBound(0)}");
        WriteLine($"Chiều 1, giới hạn trên: {grid1.GetUpperBound(0)}");
        WriteLine($"Chiều 2, giới hạn dưới: {grid1.GetLowerBound(1)}");
        WriteLine($"Chiều 2, giới hạn trên: {grid1.GetUpperBound(1)}");
        WriteLine();

        // Duyệt qua từng hàng và cột để in ra giá trị.
        for (int row = 0; row <= grid1.GetUpperBound(0); row++)
        {
            for (int col = 0; col <= grid1.GetUpperBound(1); col++)
            {
                WriteLine($"Hàng {row}, Cột {col}: {grid1[row, col]}");
            }
        }

        WriteLine("--------------------------------");
        WriteLine();

        #endregion
    }
}

public class JaggedArrayExample
{
    public static void Run()
    {
        #region Working with jagged arrays

        WriteLine("--- Ví dụ 3: Mảng lởm chởm (Jagged Arrays) ---");

        // Mảng lởm chởm là một mảng chứa các mảng khác, mỗi mảng con có thể có độ dài khác nhau.
        string[][] jagged =
        {
            new[] { "Alpha", "Beta", "Gamma" },
            new[] { "Anne", "Ben", "Charlie", "Doug" },
            new[] { "Aardvark", "Bear" }
        };

        WriteLine("Giới hạn trên của mảng của các mảng là: {0}", jagged.GetUpperBound(0));
        WriteLine();

        // Duyệt qua từng mảng con để xem độ dài của chúng.
        for (int array = 0; array <= jagged.GetUpperBound(0); array++)
        {
            WriteLine("Giới hạn trên của mảng con {0} là: {1}",
                arg0: array,
                arg1: jagged[array].GetUpperBound(0));
        }

        WriteLine();

        // Duyệt qua từng phần tử trong mảng lởm chởm.
        for (int row = 0; row <= jagged.GetUpperBound(0); row++)
        {
            for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
            {
                WriteLine($"Hàng {row}, Cột {col}: {jagged[row][col]}");
            }
        }

        WriteLine("---------------------------------------------");
        WriteLine();

        #endregion
    }
}

public class ListPatternMatchingExample
{
    public static void Run()
    {
        #region List pattern matching with arrays

        WriteLine("--- Ví dụ 4: Đối sánh mẫu danh sách với mảng ---");

        // Khai báo các mảng để kiểm tra.
        int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] oneTwoNumbers = { 1, 2 };
        int[] oneTwoTenNumbers = { 1, 2, 10 };
        int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
        int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
        int[] emptyNumbers = { };
        int[] threeNumbers = { 9, 7, 5 };
        int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };

        // Gọi phương thức CheckSwitch cho từng mảng và in kết quả.
        WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
        WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
        WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
        WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
        WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
        WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
        WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
        WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
        WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

        WriteLine("-------------------------------------------------");

        #endregion
    }

    /// <summary>
    /// Sử dụng biểu thức switch để thực hiện đối sánh mẫu trên một mảng số nguyên.
    /// </summary>
    private static string CheckSwitch(int[] values) => values switch
    {
        [] => "Mảng rỗng",
        [1, 2, _, 10] => "Chứa 1, 2, một số bất kỳ, 10.",
        [1, 2, .., 10] => "Chứa 1, 2, một khoảng bất kỳ (có thể rỗng), 10.",
        [1, 2] => "Chứa 1 rồi đến 2.",
        [int item1, int item2, int item3] => $"Chứa {item1} rồi đến {item2} rồi đến {item3}.",
        [0, _] => "Bắt đầu bằng 0, theo sau là một số khác.",
        [0, ..] => "Bắt đầu bằng 0, theo sau là một khoảng số bất kỳ.",
        [2, .. int[] others] => $"Bắt đầu bằng 2, theo sau là {others.Length} số khác.",
        [..] => "Chứa các mục bất kỳ theo thứ tự bất kỳ.",
    };
}

class Program
{
    static void Main(string[] args)
    {
        SingleDimensionalArrayExample.Run();
        MultiDimensionalArrayExample.Run();
        JaggedArrayExample.Run();
        ListPatternMatchingExample.Run();
    }
}