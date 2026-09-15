using System;

namespace Bai2_TaoMaTran
{
    public class BT2
    {
        // ==========================================================
        // CÁCH 1:
        // Vùng màu xám gồm toàn bộ hàng i và toàn bộ cột j.
        //
        // Để không cộng a[i,j] hai lần, ta cộng:
        // - Các phần tử trên hàng i
        // - Các phần tử trên cột j, trừ a[i,j]
        // ==========================================================
        public static int TongHangVaCot(
            int[,] a, int n, int i, int j)
        {
            int tong = 0;

            // Cộng toàn bộ hàng i
            for (int k = 0; k < n; k++)
            {
                tong += a[i, k];
            }

            // Cộng toàn bộ cột j
            // nhưng bỏ qua a[i,j] vì đã cộng ở trên
            for (int k = 0; k < n; k++)
            {
                if (k != i)
                {
                    tong += a[k, j];
                }
            }

            return tong;
        }


        // ==========================================================
        // CÁCH 2:
        // Vùng màu xám phía trên - bên trái.
        //
        // Gồm các phần tử:
        // hàng 0 -> i
        // cột 0 -> j
        //
        // Tức là:
        // 0 <= k <= i
        // 0 <= l <= j
        // ==========================================================
        public static int TongGocTrenTrai(
            int[,] a, int n, int i, int j)
        {
            int tong = 0;

            for (int k = 0; k <= i; k++)
            {
                for (int l = 0; l <= j; l++)
                {
                    tong += a[k, l];
                }
            }

            return tong;
        }


        // ==========================================================
        // CÁCH 3:
        // Vùng màu xám phía dưới - bên phải.
        //
        // Gồm các phần tử:
        // hàng i -> n-1
        // cột j -> n-1
        //
        // Tức là:
        // i <= k < n
        // j <= l < n
        // ==========================================================
        public static int TongGocDuoiPhai(
            int[,] a, int n, int i, int j)
        {
            int tong = 0;

            for (int k = i; k < n; k++)
            {
                for (int l = j; l < n; l++)
                {
                    tong += a[k, l];
                }
            }

            return tong;
        }


        // ==========================================================
        // CÁCH 4:
        // Vùng hình chữ nhật nằm giữa (i,j) và (j,i).
        //
        // Ta xác định:
        // - hàng từ min(i,j) đến max(i,j)
        // - cột từ min(i,j) đến max(i,j)
        //
        // Sau đó cộng toàn bộ phần tử trong vùng đó.
        // ==========================================================
        public static int TongVungGiua(
            int[,] a, int n, int i, int j)
        {
            int batDau = Math.Min(i, j);
            int ketThuc = Math.Max(i, j);

            int tong = 0;

            for (int k = batDau; k <= ketThuc; k++)
            {
                for (int l = batDau; l <= ketThuc; l++)
                {
                    tong += a[k, l];
                }
            }

            return tong;
        }


        // ==========================================================
        // Hàm tạo ma trận B cho CÁCH 1
        //
        // Mỗi b[i,j] là tổng hàng i và cột j.
        // ==========================================================
        public static int[,] TaoMaTranCach1(
            int[,] a, int n)
        {
            int[,] b = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] =
                        TongHangVaCot(a, n, i, j);
                }
            }

            return b;
        }


        // ==========================================================
        // Hàm tạo ma trận B cho CÁCH 2
        // ==========================================================
        public static int[,] TaoMaTranCach2(
            int[,] a, int n)
        {
            int[,] b = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] =
                        TongGocTrenTrai(a, n, i, j);
                }
            }

            return b;
        }


        // ==========================================================
        // Hàm tạo ma trận B cho CÁCH 3
        // ==========================================================
        public static int[,] TaoMaTranCach3(
            int[,] a, int n)
        {
            int[,] b = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] =
                        TongGocDuoiPhai(a, n, i, j);
                }
            }

            return b;
        }


        // ==========================================================
        // Hàm tạo ma trận B cho CÁCH 4
        // ==========================================================
        public static int[,] TaoMaTranCach4(
            int[,] a, int n)
        {
            int[,] b = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] =
                        TongVungGiua(a, n, i, j);
                }
            }

            return b;
        }


        // ==========================================================
        // Hàm in ma trận
        // ==========================================================
        public static void InMaTran(
            int[,] a, int n)
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
            Console.WriteLine(
                "===== BAI 2: TAO MA TRAN ====="
            );

            // Nhập cấp ma trận
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine()!);

            // Kiểm tra điều kiện
            if (n < 1 || n > 100)
            {
                Console.WriteLine(
                    "n phai nam trong khoang 1 den 100!"
                );

                return;
            }

            // Khởi tạo ma trận A
            int[,] a = new int[n, n];

            // Nhập ma trận
            Console.WriteLine("Nhap ma tran A:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");

                    a[i, j] =
                        int.Parse(Console.ReadLine()!);
                }
            }


            // ======================================================
            // CÁCH 1
            // ======================================================
            Console.WriteLine();
            Console.WriteLine(
                "Ma tran B - Cach 1 (hang + cot):"
            );

            int[,] b1 =
                TaoMaTranCach1(a, n);

            InMaTran(b1, n);


            // ======================================================
            // CÁCH 2
            // ======================================================
            Console.WriteLine();
            Console.WriteLine(
                "Ma tran B - Cach 2 (goc tren trai):"
            );

            int[,] b2 =
                TaoMaTranCach2(a, n);

            InMaTran(b2, n);


            // ======================================================
            // CÁCH 3
            // ======================================================
            Console.WriteLine();
            Console.WriteLine(
                "Ma tran B - Cach 3 (goc duoi phai):"
            );

            int[,] b3 =
                TaoMaTranCach3(a, n);

            InMaTran(b3, n);


            // ======================================================
            // CÁCH 4
            // ======================================================
            Console.WriteLine();
            Console.WriteLine(
                "Ma tran B - Cach 4 (vung giua):"
            );

            int[,] b4 =
                TaoMaTranCach4(a, n);

            InMaTran(b4, n);
        }
    }
}