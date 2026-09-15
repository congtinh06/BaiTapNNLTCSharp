using System;

namespace Bai3_XoanOc
{
    public class BT3
    {
        // ==========================================================
        // Tạo ma trận xoắn ốc cấp n
        //
        // Các số từ 1 -> n^2 được điền theo thứ tự:
        //
        // 1. Từ trái sang phải
        // 2. Từ trên xuống dưới
        // 3. Từ phải sang trái
        // 4. Từ dưới lên trên
        //
        // Sau đó thu hẹp phạm vi và tiếp tục xoắn vào bên trong.
        // ==========================================================
        public static int[,] XoanOc(int n)
        {
            int[,] a = new int[n, n];

            // Biên của vùng ma trận hiện tại
            int hangTren = 0;
            int hangDuoi = n - 1;
            int cotTrai = 0;
            int cotPhai = n - 1;

            // Giá trị cần điền
            int giaTri = 1;

            while (hangTren <= hangDuoi &&
                   cotTrai <= cotPhai)
            {
                // ==================================================
                // BƯỚC 1:
                // Đi từ trái sang phải trên hàng trên
                // ==================================================
                for (int j = cotTrai; j <= cotPhai; j++)
                {
                    a[hangTren, j] = giaTri;
                    giaTri++;
                }

                hangTren++;


                // ==================================================
                // BƯỚC 2:
                // Đi từ trên xuống dưới ở cột phải
                // ==================================================
                for (int i = hangTren; i <= hangDuoi; i++)
                {
                    a[i, cotPhai] = giaTri;
                    giaTri++;
                }

                cotPhai--;


                // ==================================================
                // BƯỚC 3:
                // Đi từ phải sang trái trên hàng dưới
                // ==================================================
                if (hangTren <= hangDuoi)
                {
                    for (int j = cotPhai; j >= cotTrai; j--)
                    {
                        a[hangDuoi, j] = giaTri;
                        giaTri++;
                    }

                    hangDuoi--;
                }


                // ==================================================
                // BƯỚC 4:
                // Đi từ dưới lên trên ở cột trái
                // ==================================================
                if (cotTrai <= cotPhai)
                {
                    for (int i = hangDuoi; i >= hangTren; i--)
                    {
                        a[i, cotTrai] = giaTri;
                        giaTri++;
                    }

                    cotTrai++;
                }
            }

            return a;
        }


        // ==========================================================
        // In ma trận
        // ==========================================================
        public static void InMaTran(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j],5}");
                }

                Console.WriteLine();
            }
        }


        // ==========================================================
        // MAIN
        // ==========================================================
        public static void Main(string[] args)
        {
            Console.WriteLine("===== BAI 3: XOAN OC =====");

            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine()!);

            // Kiểm tra điều kiện của đề
            if (n < 1 || n > 100)
            {
                Console.WriteLine(
                    "n phai nam trong khoang 1 den 100!"
                );

                return;
            }

            // Tạo ma trận xoắn ốc
            int[,] a = XoanOc(n);

            // In ma trận
            Console.WriteLine();
            Console.WriteLine("Ma tran xoan oc:");

            InMaTran(a, n);
        }
    }
}