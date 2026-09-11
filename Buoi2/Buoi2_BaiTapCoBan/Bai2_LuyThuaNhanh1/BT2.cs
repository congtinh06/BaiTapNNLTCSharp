using System;

namespace LuyThuaNhanh1
{
    public class Program
    {
        // Hàm tính toán thuần túy - có thể unit test được
        public static (double aMu2, double aMu5, double aMu17) TinhLuyThua(double a)
        {
            double a2 = a * a;         // phép nhân 1: a^2
            double a4 = a2 * a2;       // phép nhân 2: a^4
            double a5 = a4 * a;        // phép nhân 3: a^5
            double a8 = a4 * a4;       // phép nhân 4: a^8
            double a16 = a8 * a8;      // phép nhân 5: a^16
            double a17 = a16 * a;      // phép nhân 6: a^17

            return (a2, a5, a17);
        }

        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so thuc a: ");
            string? dongNhap = Console.ReadLine();

            if (string.IsNullOrEmpty(dongNhap))
            {
                Console.WriteLine("Ban chua nhap gi ca!");
                return;
            }

            double a = double.Parse(dongNhap);

            var (aMu2, aMu5, aMu17) = TinhLuyThua(a);

            Console.WriteLine("Ket qua: {0}^2={1:0.00}, {0}^5={2:0.00}, {0}^17={3:0.00}.",
                a, aMu2, aMu5, aMu17);
        }
    }
}
