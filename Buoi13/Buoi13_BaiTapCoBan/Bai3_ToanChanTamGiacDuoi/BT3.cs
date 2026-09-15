using System;

namespace Bai3_ToanChanTamGiacDuoi
{
    public class BT3
    {
        // ==================================================
        // Hàm kiểm tra tam giác dưới đường chéo phụ
        // có chứa toàn số chẵn hay không.
        //
        // Không tính các phần tử nằm trên đường chéo phụ.
        //
        // Điều kiện tam giác dưới chéo phụ:
        // i + j > n - 1
        // ==================================================
        public static bool KiemTraToanChan(
            int[,] a, int n)
        {
            // Duyệt toàn bộ ma trận
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Kiểm tra phần tử có nằm dưới
                    // đường chéo phụ hay không
                    if (i + j > n - 1)
                    {
                        // Nếu phần tử là số lẻ
                        // thì không thể là toàn số chẵn
                        if (a[i, j] % 2 != 0)
                        {
                            return false;
                        }
                    }
                }
            }

            // Không tìm thấy số lẻ
            // => tất cả đều là số chẵn
            return true;
        }


        // ==================================================
        // Hàm Main
        // ==================================================
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "===== BAI 3: KIEM TRA TOAN CHAN TAM GIAC DUOI CHEO PHU ====="
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

            // Khởi tạo ma trận
            int[,] a = new int[n, n];

            // Nhập ma trận
            Console.WriteLine("Nhap ma tran:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }


            // ==================================================
            // In các phần tử dưới đường chéo phụ
            // ==================================================

            Console.Write("Tam giac duoi cheo phu: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Không lấy đường chéo phụ
                    if (i + j > n - 1)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();


            // ==================================================
            // Kiểm tra toàn chẵn
            // ==================================================

            bool ketQua = KiemTraToanChan(a, n);

            if (ketQua)
            {
                Console.WriteLine(
                    "Tam giac duoi cheo phu chua toan so chan."
                );
            }
            else
            {
                Console.WriteLine(
                    "Tam giac duoi cheo phu khong chua toan so chan."
                );
            }
        }
    }
}