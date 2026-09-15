using System;
using System.Collections.Generic;

namespace Bai2_InTamGiacDuoiChinhPhu
{
    public class BT2
    {
        // Hàm lấy các phần tử nằm dưới đường chéo chính
        // Không lấy các phần tử nằm trên đường chéo chính
        //
        // Điều kiện:
        // i > j
        public static List<double> TamGiacDuoiCheoChinh(
            double[,] a, int n)
        {
            // Danh sách lưu các phần tử cần lấy
            List<double> ketQua = new List<double>();

            // Duyệt từng dòng
            for (int i = 0; i < n; i++)
            {
                // Chỉ lấy các phần tử có cột < dòng
                for (int j = 0; j < i; j++)
                {
                    ketQua.Add(a[i, j]);
                }
            }

            return ketQua;
        }


        // Hàm lấy các phần tử nằm dưới đường chéo phụ
        // Không lấy các phần tử nằm trên đường chéo phụ
        //
        // Đường chéo phụ:
        // i + j = n - 1
        //
        // Phía dưới đường chéo phụ:
        // i + j > n - 1
        public static List<double> TamGiacDuoiCheoPhu(
            double[,] a, int n)
        {
            // Danh sách lưu các phần tử cần lấy
            List<double> ketQua = new List<double>();

            // Duyệt toàn bộ ma trận
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Kiểm tra phần tử nằm dưới đường chéo phụ
                    if (i + j > n - 1)
                    {
                        ketQua.Add(a[i, j]);
                    }
                }
            }

            return ketQua;
        }


        // Hàm Main
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "===== BAI 2: IN TAM GIAC DUOI CHEO CHINH, PHU ====="
            );

            // Nhập cấp ma trận
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine()!);

            // Kiểm tra điều kiện đề bài
            // 1 <= n <= 100
            if (n < 1 || n > 100)
            {
                Console.WriteLine(
                    "n phai nam trong khoang 1 den 100!"
                );

                return;
            }

            // Khởi tạo ma trận vuông
            double[,] a = new double[n, n];

            // Nhập ma trận
            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = double.Parse(Console.ReadLine()!);
                }
            }


            // -----------------------------------------
            // Tam giác dưới đường chéo chính
            // -----------------------------------------

            List<double> tamGiacChinh =
                TamGiacDuoiCheoChinh(a, n);

            Console.WriteLine();
            Console.Write("Tam giac duoi cheo chinh: ");

            foreach (double x in tamGiacChinh)
            {
                Console.Write(x + " ");
            }


            // -----------------------------------------
            // Tam giác dưới đường chéo phụ
            // -----------------------------------------

            List<double> tamGiacPhu =
                TamGiacDuoiCheoPhu(a, n);

            Console.WriteLine();
            Console.Write("Tam giac duoi cheo phu: ");

            foreach (double x in tamGiacPhu)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }
    }
}