using System;

namespace HaiChuSoCuoi
{
    public class Program
    {
        // Ham luy thua nhanh, lay du de tranh tran so
        public static long LuyThuaModulo(long coSo, long soMu, long m)
        {
            long ketQua = 1;
            coSo = ((coSo % m) + m) % m; // dam bao co so khong am

            while (soMu > 0)
            {
                if (soMu % 2 == 1)
                {
                    ketQua = (ketQua * coSo) % m;
                }
                coSo = (coSo * coSo) % m;
                soMu = soMu / 2;
            }

            return ketQua;
        }

        // Ham tinh toan thuan tuy - co the unit test duoc
        public static int TinhHaiChuSoCuoi(long n)
        {
            return (int)LuyThuaModulo(n, 278, 100);
        }

        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so nguyen n: ");
            string? dongNhap = Console.ReadLine();

            if (string.IsNullOrEmpty(dongNhap))
            {
                Console.WriteLine("Ban chua nhap gi ca!");
                return;
            }

            long n = long.Parse(dongNhap);

            int ketQua = TinhHaiChuSoCuoi(n);

            Console.WriteLine("{0}^278 co 2 chu so cuoi cung la {1:D2}.", n, ketQua);
        }
    }
}