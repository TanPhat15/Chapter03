using System;
using System.Data;
using System.Globalization;
using static System.Convert;

namespace VDNoiDung2
{
    class ConvertQuestion
    {
        public static void Run()
        {
            double g = 9.5;
            int h = Convert.ToInt32(g);
            Console.WriteLine($"g = {g}, h = {h}");
        }
    }

    class CheckedQuestion
    {
        public static void Run()
        {
            checked
            {
                int a = int.MaxValue;
                a++;
                Console.WriteLine(a);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConvertQuestion.Run();
            CheckedQuestion.Run();
        }
    }
}
