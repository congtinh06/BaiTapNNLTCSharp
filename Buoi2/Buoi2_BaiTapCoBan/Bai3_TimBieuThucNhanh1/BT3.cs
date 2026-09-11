using System;

namespace BieuThucNhanh1
{
    public class Program
    {
        // Hàm tính toán thuần túy - có thể unit test được
        // f(x) = 1 + 2x + 3x^2 - 4x^3, dùng so do Horner
        public static double TinhBieuThuc(double x)
        {
            double t1 = -4 * x;      // phep toan 1: nhan
            double t2 = 3 + t1;      // phep toan 2: cong
            double t3 = t2 * x;      // phep toan 3: nhan
            double t4 = 2 + t3;      // phep toan 4: cong
            double t5 = t4 * x;      // phep toan 5: nhan
            double t6 = 1 + t5;      // phep toan 6: cong

            return t6;
        }

        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so thuc x: ");
            string? dongNhap = Console.ReadLine();

            if (string.IsNullOrEmpty(dongNhap))
            {
                Console.WriteLine("Ban chua nhap gi ca!");
                return;
            }

            double x = double.Parse(dongNhap);

            double ketQua = TinhBieuThuc(x);

            Console.WriteLine("f({0}) = {1:0.00}", x, ketQua);
        }
    }
}