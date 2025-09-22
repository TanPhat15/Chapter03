using System;

public class CauHoi1
{
    public static void Run()
    {
        int i = 1;
        int j = i++ + ++i;
        Console.WriteLine($"i={i}, j={j}");
    } 
}


public class CauHoi2
{
    public static void Run()
    {
        var list = new List<int> { 1, 2, 3, 4 };
        foreach (var x in list)
        {
            if (x == 2) list.Remove(x);
        }
        Console.WriteLine(string.Join(",", list));
    }
}

public class VanDung
{
    public static void Run()
    {
        int a = 10;
        int b = 3;
        bool condition1 = true;
        bool condition2 = false;

        // Step 1: Arithmetic and Unary Operators
        var chiaDu = a % b;
        var chiaChan = a / b;
        int result1 = chiaChan + chiaDu + (++b);

        // Step 2: Ternary Operator and Logical Operators
        string message = (a > result1 && condition1) ? "Success" : "Failure";

        // Step 3: Bitwise Operator and Assignment Operator
        int c = a << 1;
        c ^= result1;
        // Tng đng với c = c ^ result1 (XOR)

        // Step 4: Switch Expression with Pattern Matching
        string finalStatus = message switch
        {
            "Success" when c > 25 => "High Achievement",
            "Success" => "Moderate Achievement",
            _ => "Low Achievement"
        };
        Console.WriteLine($"Final Status: {finalStatus}");
    }
}





public class Program
{
    public static void Main(string[] args)
    {
        CauHoi1.Run();
        CauHoi2.Run();
        VanDung.Run();
    }
}