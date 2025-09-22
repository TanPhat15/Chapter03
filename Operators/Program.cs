using static System.Console;

namespace Operators
{
    class UnaryOperatorsExample
    {
        public static void Run()
        {
            #region Exploring unary operators

            int a = 3;
            int b = a++; // Postfix means increment c after assigning it.
            WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c; // Prefix means increment c before assigning it.
            WriteLine($"c is {c}, d is {d}");

            #endregion
        }
    }


    class BinaryArithmeticOperatorsExample
    {
        public static void Run()
        {
            #region Exploring binary arithmetic operators

            int e = 11;
            int f = 3;
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}"); // Chia lấy phần nguyên
            WriteLine($"e % f = {e % f}"); // Chia lấy phần dư

            #endregion
        }
    }

    class RealNumberDivisionExample
    {
        public static void Run()
        {
            #region Phép chia số thực

            int e = 11;
            int f = 3;
            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}, e is {e}");
            WriteLine($"g / f = {g / f}");
            WriteLine($"e / f = {e / f}");

            WriteLine();

            #endregion
        }
    }


    class LogicalOperatorsExample
    {
        public static void Run()
        {
            #region Exploring logical operators

            bool p = true;
            bool q = false;
            WriteLine($"AND  | p     | q    ");
            WriteLine($"p    | {p & p,-5} | {p & q,-5} ");
            WriteLine($"q    | {q & p,-5} | {q & q,-5} ");
            WriteLine();
            WriteLine($"OR   | p     | q    ");
            WriteLine($"p    | {p | p,-5} | {p | q,-5} ");
            WriteLine($"q    | {q | p,-5} | {q | q,-5} ");
            WriteLine();
            WriteLine($"XOR  | p     | q    ");
            WriteLine($"p    | {p ^ p,-5} | {p ^ q,-5} ");
            WriteLine($"q    | {q ^ p,-5} | {q ^ q,-5} ");

            #endregion
        }
    }

    class ConditionalLogicalOperatorsExample
    {
        public static void Run()
        {
            #region Exploring conditional logical operators

            bool p = true;
            bool q = false;

            WriteLine();
            WriteLine($"p & DoStuff() = {p & Program.DoStuff()}");
            WriteLine($"q & DoStuff() = {q & Program.DoStuff()}");

            WriteLine();
            WriteLine($"p && DoStuff() = {p && Program.DoStuff()}");
            WriteLine($"q && DoStuff() = {q && Program.DoStuff()}");

            #endregion
        }
    }

    class BitwiseAndShiftOperatorsExample
    {
        public static void Run()
        {
            #region Exploring bitwise and binary shift operators

            WriteLine();

            int x = 10;
            int y = 6;

            WriteLine($"Expression | Decimal |   Binary");
            WriteLine($"-------------------------------");
            WriteLine($"x          | {x,7} | {x:B8}");
            WriteLine($"y          | {y,7} | {y:B8}");
            WriteLine($"x & y      | {x & y,7} | {x & y:B8}");
            WriteLine($"x | y      | {x | y,7} | {x | y:B8}");
            WriteLine($"x ^ y      | {x ^ y,7} | {x ^ y:B8}");

            // Left-shift x by three bit columns.
            WriteLine($"x << 3     | {x << 3,7} | {x << 3:B8}");

            // Multiply x by 8.
            WriteLine($"x * 8      | {x * 8,7} | {x * 8:B8}");

            // Right-shift y by one bit column.
            WriteLine($"y >> 1     | {y >> 1,7} | {y >> 1:B8}");

            #endregion
        }
    }


    #region Operator Overloading

    public class OperatorOverloadingExample
    {
        public struct SoPhuc
        {
            public double Thuc { get; }
            public double Ao { get; }


            public SoPhuc(double thuc, double ao)
            {
                Thuc = thuc;
                Ao = ao;
            }


            public static SoPhuc operator +(SoPhuc a, SoPhuc b)
            {
                return new SoPhuc(a.Thuc + b.Thuc, a.Ao + b.Ao);
            }


            public static SoPhuc operator -(SoPhuc a, SoPhuc b)
            {
                return new SoPhuc(a.Thuc - b.Thuc, a.Ao - b.Ao);
            }


            public override string ToString()
            {
                // Sử dụng toán tử điều kiện để định dạng chuỗi cho đẹp hơn
                return $"{Thuc} {(Ao >= 0 ? "+" : "-")} {Math.Abs(Ao)}i";
            }
        }


        public static void Run()
        {
            Console.WriteLine("--- Ví dụ về Nạp chồng toán tử cho Số Phức ---");

            // Khởi tạo hai đối tượng số phức
            SoPhuc sp1 = new SoPhuc(3, 4); // 3 + 4i
            SoPhuc sp2 = new SoPhuc(1, 2); // 1 + 2i

            Console.WriteLine($"Số phức 1: {sp1}");
            Console.WriteLine($"Số phức 2: {sp2}");
            Console.WriteLine();

            // Sử dụng các toán tử + và - đã được nạp chồng một cách tự nhiên
            // Trình biên dịch sẽ tự động gọi các phương thức operator+ và operator- tương ứng. [2]
            SoPhuc tong = sp1 + sp2;
            SoPhuc hieu = sp1 - sp2;

            // In kết quả ra màn hình
            Console.WriteLine($"Tổng (sp1 + sp2): {tong}"); // Kết quả mong đợi: 4 + 6i
            Console.WriteLine($"Hiệu (sp1 - sp2): {hieu}"); // Kết quả mong đợi: 2 + 2i
            Console.WriteLine("---------------------------------------------");
        }
    }

    #endregion


    class Program
    {
        public static bool DoStuff()
        {
            WriteLine("I am doing some stuff.");
            return true;
        }

        static void Main(string[] args)
        {
            UnaryOperatorsExample.Run();
            BinaryArithmeticOperatorsExample.Run();
            RealNumberDivisionExample.Run();
            LogicalOperatorsExample.Run();
            ConditionalLogicalOperatorsExample.Run();
            BitwiseAndShiftOperatorsExample.Run();
            OperatorOverloadingExample.Run();
        }
    }
}