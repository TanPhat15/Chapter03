using System;
using System.Data;
using System.Globalization;
using static System.Convert;

namespace chapter3
{
    class implicitEx
    {
        public static void Run()
        {
            int a = 10;
            double b = a;
            Console.WriteLine($"a is {a}, b is {b}");

            //double c = 9.8;
            //int d = c ;
            //Console.WriteLine($"c is {c}, d is {d}");
        }
    }

    class explicitEx
    {
        public static void Run()
        {
            double a = 9.8;
            int b = (int)a;
            Console.WriteLine($"a is {a}, b is {b}");

            long e = long.MaxValue;
            int f = (int)e;
            Console.WriteLine($"e is {e}, f is {f}");
        }
    }

    class ConvertEx
    {
        public static void Run()
        {
            double a = 9.8;
            int b = ToInt32(a);
            Console.WriteLine($"a is {a}, b is {b}");
        }
    }

    class ToStringEx
    {
        public static void Run()
        {
            int number = 12;
            Console.WriteLine(number.ToString());
            bool boolean = true;
            Console.WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            object me = new();
            Console.WriteLine(me.ToString());
        }
    }

    class RoundingNumbers()
    {
        public static void Run()
        {
            double[,] doubles = {
                                            { 9.49  , 9.5  , 9.51   },
                                            { 10.49 , 10.5 , 10.51  },
                                            { 11.49 , 11.5 , 11.51  },
                                            { 12.49 , 12.5 , 12.51  },
                                            { -12.49, -12.5, -12.51 },
                                            { -11.49, -11.5, -11.51 },
                                };
            foreach (double n in doubles)
            {
                Console.WriteLine(format:
                  "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                  arg0: n,
                  arg1: Math.Round(value: n, digits: 0,
                          mode: MidpointRounding.AwayFromZero));
            }
        }
    }

    class Base64Ex()
    {
        public static void Run()
        {
            // Allocate an array of 128 bytes.
            byte[] binaryObject = new byte[128];

            // Populate the array with random bytes.
            Random.Shared.NextBytes(binaryObject);

            Console.WriteLine("Binary Object as bytes:");
            for (int index = 0; index < binaryObject.Length; index++)
            {
                Console.Write($"{binaryObject[index]:X2} ");
            }
            Console.WriteLine();

            // Convert the array to Base64 string and output as text.
            string encoded = ToBase64String(binaryObject);
            Console.WriteLine($"Binary Object as Base64: {encoded}");
        }
    }

    class ParseEx()
    {
        public static void Run()
        {
            // Set the current culture to make sure date parsing works.
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            int friends = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 June 1980");
            Console.WriteLine($"I have {friends} friends to invite to my party.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");
        }
    }

    class TryParseEx()
    {
        public static void Run()
        {
            Console.Write("How many eggs are there? ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse the input.");
            }
        }
    }

    class checkedEx()
    {
        public static void Run()
        {
            checked
            {
                int x = int.MaxValue - 1;
                Console.WriteLine($"Initial : {x}");
                x++;
                Console.WriteLine($"Initial : {x}");
                x++;
                Console.WriteLine($"Initial : {x}");
            }
        }
    }

    class UncheckedEx()
    {
        public static void Run()
        {
            unchecked
            {
                long x = long.MaxValue + 1;
                Console.WriteLine($"Initial : {x}");
                x--;
                Console.WriteLine($"Initial : {x}");
                x--;
                Console.WriteLine($"Initial : {x}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            implicitEx.Run();
            explicitEx.Run();
            ConvertEx.Run();
            ToStringEx.Run();
            RoundingNumbers.Run();
            Base64Ex.Run();
            ParseEx.Run();
            TryParseEx.Run();
            checkedEx.Run();
            UncheckedEx.Run();
        }
    }
}
