using System;
using System.Collections.Generic;

namespace Bai5_InCacCheoTheoHinh
{
    public class BT5
    {
        // ==================================================
        // Lấy các đường chéo phụ theo đúng thứ tự trong hình
        //
        // Các phần tử trên cùng một đường chéo phụ có:
        // i + j = hằng số
        //
        // Thứ tự các phần tử được in xen kẽ:
        // đường 0: trái -> phải
        // đường 1: trái -> phải
        // đường 2: phải -> trái
        // đường 3: trái -> phải
        // ...
        // ==================================================
        public static List<List<int>> LayCacCheoPhu(
            int[,] a, int n)
        {
            // Danh sách chứa các đường chéo phụ
            List<List<int>> ketQua =
                new List<List<int>>();

            // Có 2n - 1 đường chéo
            for (int tong = 0;
                 tong <= 2 * n - 2;
                 tong++)
            {
                // Tạo một đường chéo
                List<int> duong =
                    new List<int>();

                // Tìm các phần tử trên đường chéo
                for (int i = 0; i < n; i++)
                {
                    int j = tong - i;

                    // Kiểm tra vị trí hợp lệ
                    if (j >= 0 && j < n)
                    {
                        duong.Add(a[i, j]);
                    }
                }

                // Đổi chiều ở các đường chéo có chỉ số chẵn
                // từ đường thứ 3 trở đi
                //
                // Ví dụ:
                // [3, 7, 11] -> [11, 7, 3]
                // [5, 9, 13, 17, 21]
                // -> [21, 17, 13, 9, 5]
                if (tong >= 2 && tong % 2 == 0)
                {
                    duong.Reverse();
                }

                ketQua.Add(duong);
            }

            return ketQua;
        }


        // ==================================================
        // Lấy các đường chéo chính theo đúng thứ tự trong hình
        //
        // Các phần tử trên cùng một đường chéo chính có:
        // i - j = hằng số
        //
        // Bắt đầu từ:
        // hàng đầu tiên: từ phải -> trái
        // sau đó cột đầu tiên: từ trên -> dưới
        //
        // Thứ tự trong từng đường cũng được đổi chiều xen kẽ.
        // ==================================================
        public static List<List<int>> LayCacCheoChinh(
            int[,] a, int n)
        {
            // Danh sách chứa các đường chéo chính
            List<List<int>> ketQua =
                new List<List<int>>();

            // Biến đánh số đường chéo
            int soDuong = 0;


            // --------------------------------------------------
            // Bắt đầu từ hàng đầu tiên
            // Đi từ phải sang trái
            // --------------------------------------------------
            for (int cotBatDau = n - 1;
                 cotBatDau >= 0;
                 cotBatDau--)
            {
                List<int> duong =
                    new List<int>();

                int i = 0;
                int j = cotBatDau;

                // Đi xuống và sang phải
                while (i < n && j < n)
                {
                    duong.Add(a[i, j]);

                    i++;
                    j++;
                }

                // Các đường có số thứ tự lẻ
                // thì đảo chiều
                if (soDuong % 2 == 1)
                {
                    duong.Reverse();
                }

                ketQua.Add(duong);

                soDuong++;
            }


            // --------------------------------------------------
            // Tiếp tục từ cột đầu tiên
            // Bắt đầu từ dòng thứ 2
            // --------------------------------------------------
            for (int dongBatDau = 1;
                 dongBatDau < n;
                 dongBatDau++)
            {
                List<int> duong =
                    new List<int>();

                int i = dongBatDau;
                int j = 0;

                // Đi xuống và sang phải
                while (i < n && j < n)
                {
                    duong.Add(a[i, j]);

                    i++;
                    j++;
                }

                // Đảo chiều ở đường có số thứ tự lẻ
                if (soDuong % 2 == 1)
                {
                    duong.Reverse();
                }

                ketQua.Add(duong);

                soDuong++;
            }

            return ketQua;
        }


        // ==================================================
        // Hàm in danh sách các đường chéo
        // ==================================================
        public static void InCacDuongCheo(
            List<List<int>> cacDuong)
        {
            for (int i = 0; i < cacDuong.Count; i++)
            {
                Console.Write("[");

                for (int j = 0;
                     j < cacDuong[i].Count;
                     j++)
                {
                    Console.Write(cacDuong[i][j]);

                    if (j < cacDuong[i].Count - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.Write("]");

                // Nếu chưa phải đường cuối
                // thì in dấu phẩy
                if (i < cacDuong.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }


        // ==================================================
        // Hàm Main
        // ==================================================
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "===== BAI 5: IN CAC CHEO THEO HINH ====="
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
            int[,] a = new int[n, n];

            // Nhập ma trận
            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");

                    a[i, j] =
                        int.Parse(Console.ReadLine()!);
                }
            }


            // ==================================================
            // In các đường chéo phụ
            // ==================================================

            List<List<int>> cheoPhu =
                LayCacCheoPhu(a, n);

            Console.WriteLine();

            Console.Write("Cac duong cheo phu: ");

            InCacDuongCheo(cheoPhu);


            // ==================================================
            // In các đường chéo chính
            // ==================================================

            List<List<int>> cheoChinh =
                LayCacCheoChinh(a, n);

            Console.Write("Cac duong cheo chinh: ");

            InCacDuongCheo(cheoChinh);
        }
    }
}