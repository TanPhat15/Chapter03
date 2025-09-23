using System;
using static System.Console;

namespace HandlingException
{
    public class TryCatchExample
    {
        public static void Run()
        {
            #region Wrapping error-prone code in a try block

            WriteLine("--- Ví dụ 1: Xử lý lỗi khi ép kiểu với khối try-catch ---");
            WriteLine("Trước khi ép kiểu.");
            Write("Nhập tuổi của bạn: ");
            string? input = ReadLine();

            try
            {
                // Thử ép kiểu chuỗi đầu vào thành số nguyên.
                int age = int.Parse(input!);
                WriteLine($"Bạn {age} tuổi.");
            }
            catch (OverflowException)
            {
                // Bắt lỗi khi số nhập vào hợp lệ nhưng nằm ngoài phạm vi của kiểu int.
                WriteLine("Tuổi của bạn là một định dạng số hợp lệ nhưng nó quá lớn hoặc quá nhỏ.");
            }
            catch (FormatException)
            {
                // Bắt lỗi khi chuỗi nhập vào không phải là định dạng số hợp lệ.
                WriteLine("Tuổi bạn đã nhập không phải là một định dạng số hợp lệ.");
            }
            catch (Exception ex)
            {
                // Bắt tất cả các ngoại lệ khác không được xử lý ở trên.
                WriteLine($"{ex.GetType()} nói rằng: {ex.Message}");
            }

            WriteLine("Sau khi ép kiểu.");
            WriteLine("----------------------------------------------------------");

            #endregion
        }
    }


    public class CheckedStatementExample
    {
        public static void Run()
        {
            #region Throwing overflow exceptions with the checked statement

            WriteLine("--- Ví dụ 2: Ném ngoại lệ tràn số với câu lệnh 'checked' ---");
            try
            {
                // Khối checked sẽ kích hoạt việc kiểm tra tràn số trong thời gian chạy (runtime).
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Giá trị ban đầu: {x}");
                    x++;
                    WriteLine($"Sau khi tăng lần 1: {x}"); // Đạt đến int.MaxValue
                    x++;
                    WriteLine($"Sau khi tăng lần 2: {x}"); // Dòng này sẽ ném ra OverflowException
                    x++;
                    WriteLine($"Sau khi tăng lần 3: {x}");
                }
            }
            catch (OverflowException)
            {
                // Bắt ngoại lệ tràn số được ném ra từ khối checked.
                WriteLine("Phép toán đã gây ra tràn số, nhưng tôi đã bắt được ngoại lệ.");
            }

            WriteLine("----------------------------------------------------------------");

            #endregion
        }
    }


    public class UncheckedStatementExample
    {
        public static void Run()
        {
            #region Disabling compiler overflow checks with the unchecked statement

            WriteLine("--- Ví dụ 3: Vô hiệu hóa kiểm tra tràn số với 'unchecked' ---");
            // Khối unchecked sẽ vô hiệu hóa việc kiểm tra tràn số.
            // Thay vì ném ngoại lệ, giá trị sẽ "quay vòng" (wrap around).
            unchecked
            {
                int y = int.MaxValue + 1; // Tràn số xảy ra, y sẽ trở thành int.MinValue
                WriteLine($"Giá trị ban đầu (sau khi tràn số): {y}");
                y--;
                WriteLine($"Sau khi giảm lần 1: {y}");
                y--;
                WriteLine($"Sau khi giảm lần 2: {y}");
            }

            WriteLine("------------------------------------------------------------------");

            #endregion
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TryCatchExample.Run();
            CheckedStatementExample.Run();
            UncheckedStatementExample.Run();
        }
    }
}