using System;
using System.Collections.Generic;

namespace Bai4_CacDuongCheoPhu
{
    public class BT4
    {
        // ==================================================
        // Hàm tính tổng lớn nhất của các đường song song
        // với đường chéo phụ.
        //
        // Các đường song song với chéo phụ có:
        // i + j = hằng số
        //
        // Ví dụ:
        // i + j = 0
        // i + j = 1
        // i + j = 2
        // ...
        // i + j = 2n - 2
        // ==================================================
        public static double TinhTongLonNhat(
            double[,] a, int n)
        {
            // Số đường song song với chéo phụ
            // của ma trận n x n là 2n - 1
            double tongLonNhat = double.MinValue;

            // Duyệt từng đường song song với chéo phụ
            for (int tongChiSo = 0;
                 tongChiSo <= 2 * n - 2;
                 tongChiSo++)
            {
                // Tổng các phần tử trên đường hiện tại
                double tong = 0;

                // Duyệt các dòng
                for (int i = 0; i < n; i++)
                {
                    // Vì i + j = tongChiSo
                    // nên j = tongChiSo - i
                    int j = tongChiSo - i;

                    // Kiểm tra cột có nằm trong ma trận không
                    if (j >= 0 && j < n)
                    {
                        tong += a[i, j];
                    }
                }

                // Cập nhật tổng lớn nhất
                if (tong > tongLonNhat)
                {
                    tongLonNhat = tong;
                }
            }

            return tongLonNhat;
        }


        // ==================================================
        // Hàm lấy các phần tử trên từng đường song song
        // với đường chéo phụ.
        //
        // Dùng để in ra giống ví dụ trong đề.
        // ==================================================
        public static List<List<double>> LayCacDuongCheoPhu(
            double[,] a, int n)
        {
            // Danh sách chứa tất cả các đường
            List<List<double>> ketQua =
                new List<List<double>>();

            // Có 2n - 1 đường song song với chéo phụ
            for (int tongChiSo = 0;
                 tongChiSo <= 2 * n - 2;
                 tongChiSo++)
            {
                // Tạo một đường mới
                List<double> duong =
                    new List<double>();

                // Duyệt các dòng
                for (int i = 0; i < n; i++)
                {
                    // Tính cột tương ứng
                    int j = tongChiSo - i;

                    // Nếu vị trí hợp lệ
                    if (j >= 0 && j < n)
                    {
                        duong.Add(a[i, j]);
                    }
                }

                // Thêm đường vào danh sách
                ketQua.Add(duong);
            }

            return ketQua;
        }


        // ==================================================
        // Hàm Main
        // ==================================================
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "===== BAI 4: TONG LON NHAT CAC DUONG SONG SONG CHEO PHU ====="
            );

            // Nhập cấp ma trận
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine()!);

            // Kiểm tra điều kiện
            // 1 <= n <= 100
            if (n < 1 || n > 100)
            {
                Console.WriteLine(
                    "n phai nam trong khoang 1 den 100!"
                );

                return;
            }

            // Khởi tạo ma trận
            double[,] a = new double[n, n];

            // Nhập ma trận
            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] =
                        double.Parse(Console.ReadLine()!);
                }
            }


            // ==================================================
            // Lấy và in các đường song song với chéo phụ
            // ==================================================

            List<List<double>> cacDuong =
                LayCacDuongCheoPhu(a, n);

            Console.WriteLine();
            Console.WriteLine(
                "Cac duong song song cheo phu:"
            );

            foreach (List<double> duong in cacDuong)
            {
                Console.Write("[");

                for (int i = 0; i < duong.Count; i++)
                {
                    Console.Write(duong[i]);

                    if (i < duong.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine("]");
            }


            // ==================================================
            // Tính tổng lớn nhất
            // ==================================================

            double ketQua =
                TinhTongLonNhat(a, n);

            Console.WriteLine();

            Console.WriteLine(
                "Tong lon nhat cua cac duong cheo la {0}.",
                ketQua
            );
        }
    }
}