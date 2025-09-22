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
        }
    }
}