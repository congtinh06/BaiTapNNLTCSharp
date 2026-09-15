using System;

namespace Bai1_TimMaxChanCheoChinh
{
    public class BT1
    {
        // Hàm tìm giá trị chẵn lớn nhất trên đường chéo chính
        public static int? TimMaxChanCheoChinh(int[,] a, int n)
        {
            // Biến lưu giá trị chẵn lớn nhất
            int maxChan = 0;

            // Biến kiểm tra đã tìm thấy số chẵn hay chưa
            bool timThay = false;

            // Đường chéo chính có dạng:
            // a[0,0], a[1,1], a[2,2], ...
            for (int i = 0; i < n; i++)
            {
                // Lấy phần tử trên đường chéo chính
                int giaTri = a[i, i];

                // Kiểm tra giaTri có phải số chẵn không
                if (giaTri % 2 == 0)
                {
                    // Nếu đây là số chẵn đầu tiên
                    if (!timThay)
                    {
                        maxChan = giaTri;
                        timThay = true;
                    }
                    // Nếu tìm được số chẵn lớn hơn
                    else if (giaTri > maxChan)
                    {
                        maxChan = giaTri;
                    }
                }
            }

            // Nếu không có số chẵn trên đường chéo chính
            // thì trả về null
            if (!timThay)
            {
                return null;
            }

            // Trả về giá trị chẵn lớn nhất
            return maxChan;
        }


        // Hàm Main để nhập và xuất ma trận
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "===== BAI 1: TIM GIA TRI CHAN LON NHAT TREN CHEO CHINH ====="
            );

            // Nhập cấp của ma trận
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine()!);

            // Kiểm tra điều kiện đề bài
            // 1 <= n <= 100
            if (n < 1 || n > 100)
            {
                Console.WriteLine("n phai nam trong khoang 1 den 100!");
                return;
            }

            // Khởi tạo ma trận vuông n x n
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

            // Tìm giá trị chẵn lớn nhất trên đường chéo chính
            int? ketQua = TimMaxChanCheoChinh(a, n);

            // Kiểm tra có tìm thấy số chẵn hay không
            if (ketQua == null)
            {
                Console.WriteLine(
                    "Khong co gia tri chan tren cheo chinh."
                );
            }
            else
            {
                Console.WriteLine(
                    "Gia tri chan lon nhat tren cheo chinh la {0}.",
                    ketQua.Value
                );
            }
        }
    }
}