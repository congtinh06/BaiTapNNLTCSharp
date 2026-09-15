using System;

namespace Bai4_GiaiCauLong
{
    // ==============================================================
    // Lớp lưu thông tin thành tích của một thí sinh
    // ==============================================================
    public class ThanhTich
    {
        // Số trận đã thi đấu
        public int SoTran { get; set; }

        // Số trận thắng
        public int Thang { get; set; }

        // Số trận thua
        public int Thua { get; set; }

        // Tổng số bàn thắng
        public int BanThang { get; set; }

        // Tổng số bàn thua
        public int BanThua { get; set; }

        // Hiệu số = bàn thắng - bàn thua
        public int HieuSo { get; set; }

        // Xếp hạng
        public int XepHang { get; set; }
    }


    public class BT4
    {
        // ==========================================================
        // Tính tổng hàng i
        //
        // Tổng hàng chính là tổng số bàn thắng của thí sinh i.
        // ==========================================================
        public static int TinhBanThang(
            int[,] a,
            int n,
            int i)
        {
            int tong = 0;

            for (int j = 0; j < n; j++)
            {
                tong += a[i, j];
            }

            return tong;
        }


        // ==========================================================
        // Tính tổng cột i
        //
        // Tổng cột chính là tổng số bàn thua của thí sinh i.
        // ==========================================================
        public static int TinhBanThua(
            int[,] a,
            int n,
            int i)
        {
            int tong = 0;

            for (int j = 0; j < n; j++)
            {
                tong += a[j, i];
            }

            return tong;
        }


        // ==========================================================
        // Đếm số trận thắng của thí sinh i
        //
        // i thắng j khi:
        //
        // A[i,j] > A[j,i]
        //
        // Ví dụ:
        // A[0,1] = 2
        // A[1,0] = 1
        //
        // => thí sinh 1 thắng thí sinh 2.
        // ==========================================================
        public static int DemTranThang(
            int[,] a,
            int n,
            int i)
        {
            int thang = 0;

            for (int j = 0; j < n; j++)
            {
                // Không xét trận đấu với chính mình
                if (i == j)
                {
                    continue;
                }

                if (a[i, j] > a[j, i])
                {
                    thang++;
                }
            }

            return thang;
        }


        // ==========================================================
        // Đếm số trận thua của thí sinh i
        //
        // i thua j khi:
        //
        // A[i,j] < A[j,i]
        // ==========================================================
        public static int DemTranThua(
            int[,] a,
            int n,
            int i)
        {
            int thua = 0;

            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (a[i, j] < a[j, i])
                {
                    thua++;
                }
            }

            return thua;
        }


        // ==========================================================
        // Tính hiệu số bàn thắng - bàn thua
        // ==========================================================
        public static int TinhHieuSo(
            int[,] a,
            int n,
            int i)
        {
            int banThang = TinhBanThang(a, n, i);
            int banThua = TinhBanThua(a, n, i);

            return banThang - banThua;
        }


        // ==========================================================
        // Tạo bảng thành tích
        // ==========================================================
        public static ThanhTich[] TaoBangThanhTich(
            int[,] a,
            int n)
        {
            ThanhTich[] bang = new ThanhTich[n];

            for (int i = 0; i < n; i++)
            {
                int banThang =
                    TinhBanThang(a, n, i);

                int banThua =
                    TinhBanThua(a, n, i);

                int thang =
                    DemTranThang(a, n, i);

                int thua =
                    DemTranThua(a, n, i);

                int hieuSo =
                    banThang - banThua;

                bang[i] = new ThanhTich
                {
                    SoTran = n - 1,
                    Thang = thang,
                    Thua = thua,
                    BanThang = banThang,
                    BanThua = banThua,
                    HieuSo = hieuSo,
                    XepHang = 0
                };
            }

            return bang;
        }


        // ==========================================================
        // Xếp hạng
        //
        // Quy tắc:
        //
        // 1. Nhiều trận thắng hơn -> hạng cao hơn.
        //
        // 2. Nếu số trận thắng bằng nhau:
        //    hiệu số lớn hơn -> hạng cao hơn.
        //
        // 3. Nếu cả hai tiêu chí bằng nhau:
        //    cùng hạng.
        //
        // Ví dụ:
        //
        // SV1: thắng 2, hiệu số +3
        // SV3: thắng 2, hiệu số +3
        //
        // => cả hai cùng hạng 1.
        // ==========================================================
        public static void XepHang(
            ThanhTich[] bang)
        {
            for (int i = 0; i < bang.Length; i++)
            {
                int hang = 1;

                for (int j = 0; j < bang.Length; j++)
                {
                    // Người j có nhiều trận thắng hơn
                    if (bang[j].Thang > bang[i].Thang)
                    {
                        hang++;
                    }
                    // Hoặc cùng số trận thắng nhưng
                    // có hiệu số cao hơn
                    else if (
                        bang[j].Thang == bang[i].Thang &&
                        bang[j].HieuSo > bang[i].HieuSo)
                    {
                        hang++;
                    }
                }

                bang[i].XepHang = hang;
            }
        }


        // ==========================================================
        // Tạo bảng xếp hạng hoàn chỉnh
        // ==========================================================
        public static ThanhTich[] TaoBangXepHang(
            int[,] a,
            int n)
        {
            ThanhTich[] bang =
                TaoBangThanhTich(a, n);

            XepHang(bang);

            return bang;
        }


        // ==========================================================
        // In bảng xếp hạng
        // ==========================================================
        public static void InBangXepHang(
            ThanhTich[] bang)
        {
            Console.WriteLine();

            Console.WriteLine(
                "=========================================================================================="
            );

            Console.WriteLine(
                "Thi sinh | So tran | Thang | Thua | Ban thang | Ban thua | Hieu so | He so/Tran thang | Xep hang"
            );

            Console.WriteLine(
                "=========================================================================================="
            );

            for (int i = 0; i < bang.Length; i++)
            {
                ThanhTich t = bang[i];

                // Hệ số / trận thắng theo đúng cách
                // trình bày của đề:
                // 3/2, -5/0, 3/2, -1/1
                string heSoTranThang =
                    $"{t.HieuSo}/{t.Thang}";

                Console.WriteLine(
                    $"{i + 1,8} | " +
                    $"{t.SoTran,7} | " +
                    $"{t.Thang,5} | " +
                    $"{t.Thua,4} | " +
                    $"{t.BanThang,10} | " +
                    $"{t.BanThua,9} | " +
                    $"{t.HieuSo,8} | " +
                    $"{heSoTranThang,16} | " +
                    $"{t.XepHang,9}"
                );
            }

            Console.WriteLine(
                "=========================================================================================="
            );
        }


        // ==========================================================
        // MAIN
        // ==========================================================
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "===== BAI 4: GIAI CAU LONG ====="
            );

            // ------------------------------------------------------
            // Nhập số thí sinh
            // ------------------------------------------------------
            Console.Write("Nhap so thi sinh n: ");

            int n =
                int.Parse(Console.ReadLine()!);

            // ------------------------------------------------------
            // Kiểm tra điều kiện
            // ------------------------------------------------------
            if (n < 1 || n > 100)
            {
                Console.WriteLine(
                    "n phai nam trong khoang 1 den 100!"
                );

                return;
            }

            // ------------------------------------------------------
            // Khởi tạo ma trận thành tích
            // ------------------------------------------------------
            int[,] a =
                new int[n, n];

            // ------------------------------------------------------
            // Nhập ma trận A
            // ------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine(
                "Nhap ma tran thanh tich A:"
            );

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(
                        $"A[{i + 1},{j + 1}] = "
                    );

                    a[i, j] =
                        int.Parse(
                            Console.ReadLine()!
                        );
                }
            }

            // ------------------------------------------------------
            // Tạo bảng xếp hạng
            // ------------------------------------------------------
            ThanhTich[] bang =
                TaoBangXepHang(a, n);

            // ------------------------------------------------------
            // In bảng
            // ------------------------------------------------------
            InBangXepHang(bang);
        }
    }
}