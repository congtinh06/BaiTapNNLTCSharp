using System;

namespace Bai1_TaoDayTuMaTran
{
    public class BT1
    {
        // ==================================================
        // Hàm tạo dãy B từ ma trận A
        //
        // B gồm n phần tử:
        // b[0], b[1], ..., b[n - 1]
        //
        // b[i] = 1 nếu dòng i có các ký tự không trùng nhau
        // b[i] = 0 nếu dòng i có ít nhất 2 ký tự giống nhau
        // ==================================================
        public static int[] TaoDay(char[,] a, int n)
        {
            // Khởi tạo dãy B gồm n phần tử
            // mặc định tất cả đều bằng 0
            int[] b = new int[n];

            // Duyệt từng dòng của ma trận
            for (int i = 0; i < n; i++)
            {
                // Giả sử ban đầu dòng i
                // có các ký tự không trùng nhau
                bool khongTrung = true;

                // So sánh từng cặp ký tự trong cùng một dòng
                for (int j = 0; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        // Nếu tìm thấy 2 ký tự giống nhau
                        if (a[i, j] == a[i, k])
                        {
                            khongTrung = false;
                            break;
                        }
                    }

                    // Nếu đã tìm thấy ký tự trùng
                    // thì không cần kiểm tra tiếp dòng này
                    if (!khongTrung)
                    {
                        break;
                    }
                }

                // Nếu dòng i không có ký tự nào trùng nhau
                // thì b[i] = 1
                if (khongTrung)
                {
                    b[i] = 1;
                }
            }

            return b;
        }


        // ==================================================
        // Hàm Main
        // ==================================================
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "===== BAI 1: TAO DAY TU MA TRAN ====="
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

            // Khởi tạo ma trận ký tự
            char[,] a = new char[n, n];

            // Nhập ma trận
            Console.WriteLine("Nhap ma tran ky tu:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");

                    // Nhập một ký tự
                    string s = Console.ReadLine()!;

                    // Lấy ký tự đầu tiên
                    a[i, j] = s[0];
                }
            }


            // ==================================================
            // Tạo dãy B
            // ==================================================

            int[] b = TaoDay(a, n);


            // ==================================================
            // In dãy B
            // ==================================================

            Console.Write("Day B: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i]);

                if (i < n - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}