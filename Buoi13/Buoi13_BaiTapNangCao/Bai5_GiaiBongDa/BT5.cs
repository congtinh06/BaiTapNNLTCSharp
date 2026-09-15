using System;

namespace Bai5_GiaiBongDa
{
    // ==============================================================
    // Lớp lưu thành tích của một đội bóng
    // ==============================================================
    public class ThanhTich
    {
        // Tổng số trận đã thi đấu
        public int SoTran { get; set; }

        // Số trận thắng
        public int SoThang { get; set; }

        // Số trận hòa
        public int SoHoa { get; set; }

        // Số trận thua
        public int SoThua { get; set; }

        // Tổng số bàn thắng
        public int BanThang { get; set; }

        // Tổng số bàn thua
        public int BanThua { get; set; }

        // Hiệu số bàn thắng - bàn thua
        public int HieuSo { get; set; }

        // Tổng số điểm
        public int Diem { get; set; }

        // Xếp hạng
        public int XepHang { get; set; }
    }


    public class BT5
    {
        // ==========================================================
        // Tính tổng số bàn thắng của đội i
        //
        // Có 2 loại trận:
        //
        // 1. Đội i đá sân nhà:
        //    A[i,j] là số bàn đội i ghi được.
        //
        // 2. Đội i đá sân khách trước đội j:
        //    B[j,i] là số bàn đội i ghi được.
        // ==========================================================
        public static int TinhBanThang(
            int[,] A,
            int[,] B,
            int n,
            int i)
        {
            int tong = 0;

            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                // Đội i đá sân nhà
                tong += A[i, j];

                // Đội i đá sân khách
                tong += B[j, i];
            }

            return tong;
        }


        // ==========================================================
        // Tính tổng số bàn thua của đội i
        //
        // 1. Đội i sân nhà:
        //    B[i,j] là bàn đội khách ghi vào lưới đội i.
        //
        // 2. Đội i sân khách:
        //    A[j,i] là bàn đội chủ nhà j ghi vào lưới đội i.
        // ==========================================================
        public static int TinhBanThua(
            int[,] A,
            int[,] B,
            int n,
            int i)
        {
            int tong = 0;

            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                // Đội i đá sân nhà
                tong += B[i, j];

                // Đội i đá sân khách
                tong += A[j, i];
            }

            return tong;
        }


        // ==========================================================
        // Đếm số trận thắng của đội i
        // ==========================================================
        public static int DemTranThang(
            int[,] A,
            int[,] B,
            int n,
            int i)
        {
            int thang = 0;

            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                // --------------------------------------------------
                // Trận lượt đi:
                // đội i đá sân nhà
                // --------------------------------------------------
                if (A[i, j] > B[i, j])
                {
                    thang++;
                }

                // --------------------------------------------------
                // Trận lượt về:
                // đội i đá sân khách
                // --------------------------------------------------
                if (B[j, i] > A[j, i])
                {
                    thang++;
                }
            }

            return thang;
        }


        // ==========================================================
        // Đếm số trận hòa của đội i
        // ==========================================================
        public static int DemTranHoa(
            int[,] A,
            int[,] B,
            int n,
            int i)
        {
            int hoa = 0;

            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                // Trận lượt đi
                if (A[i, j] == B[i, j])
                {
                    hoa++;
                }

                // Trận lượt về
                if (A[j, i] == B[j, i])
                {
                    hoa++;
                }
            }

            return hoa;
        }


        // ==========================================================
        // Đếm số trận thua của đội i
        // ==========================================================
        public static int DemTranThua(
            int[,] A,
            int[,] B,
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

                // Trận lượt đi:
                // đội i đá sân nhà
                if (A[i, j] < B[i, j])
                {
                    thua++;
                }

                // Trận lượt về:
                // đội i đá sân khách
                if (B[j, i] < A[j, i])
                {
                    thua++;
                }
            }

            return thua;
        }


        // ==========================================================
        // Tính điểm
        //
        // Thắng = 3 điểm
        // Hòa   = 1 điểm
        // Thua  = 0 điểm
        // ==========================================================
        public static int TinhDiem(
            int[,] A,
            int[,] B,
            int n,
            int i)
        {
            int thang =
                DemTranThang(A, B, n, i);

            int hoa =
                DemTranHoa(A, B, n, i);

            return thang * 3 + hoa;
        }


        // ==========================================================
        // Tạo bảng thành tích
        // ==========================================================
        public static ThanhTich[] TaoBangThanhTich(
            int[,] A,
            int[,] B,
            int n)
        {
            ThanhTich[] bang =
                new ThanhTich[n];

            for (int i = 0; i < n; i++)
            {
                int banThang =
                    TinhBanThang(A, B, n, i);

                int banThua =
                    TinhBanThua(A, B, n, i);

                int thang =
                    DemTranThang(A, B, n, i);

                int hoa =
                    DemTranHoa(A, B, n, i);

                int thua =
                    DemTranThua(A, B, n, i);

                int diem =
                    TinhDiem(A, B, n, i);

                bang[i] = new ThanhTich
                {
                    // Với n đội đá vòng tròn lượt đi và về:
                    // mỗi đội gặp n - 1 đội, mỗi đội 2 trận.
                    SoTran = (n - 1) * 2,

                    SoThang = thang,

                    SoHoa = hoa,

                    SoThua = thua,

                    BanThang = banThang,

                    BanThua = banThua,

                    HieuSo = banThang - banThua,

                    Diem = diem,

                    XepHang = 0
                };
            }

            return bang;
        }


        // ==========================================================
        // Xếp hạng
        //
        // Ưu tiên:
        //
        // 1. Điểm cao hơn.
        // 2. Nếu bằng điểm -> bàn thắng cao hơn.
        // 3. Nếu tiếp tục bằng nhau -> hiệu số cao hơn.
        //
        // Nếu tất cả bằng nhau thì cùng hạng.
        // ==========================================================
        public static void XepHang(
            ThanhTich[] bang)
        {
            for (int i = 0; i < bang.Length; i++)
            {
                int hang = 1;

                for (int j = 0; j < bang.Length; j++)
                {
                    if (bang[j].Diem > bang[i].Diem)
                    {
                        hang++;
                    }
                    else if (
                        bang[j].Diem == bang[i].Diem &&
                        bang[j].BanThang > bang[i].BanThang)
                    {
                        hang++;
                    }
                    else if (
                        bang[j].Diem == bang[i].Diem &&
                        bang[j].BanThang == bang[i].BanThang &&
                        bang[j].HieuSo > bang[i].HieuSo)
                    {
                        hang++;
                    }
                }

                bang[i].XepHang = hang;
            }
        }


        // ==========================================================
        // Tạo bảng xếp hạng
        // ==========================================================
        public static ThanhTich[] TaoBangXepHang(
            int[,] A,
            int[,] B,
            int n)
        {
            ThanhTich[] bang =
                TaoBangThanhTich(A, B, n);

            XepHang(bang);

            return bang;
        }


        // ==========================================================
        // Tìm đội vô địch
        //
        // Theo đề:
        // - Điểm cao nhất là ưu tiên.
        // - Nếu bằng điểm thì xét số bàn thắng.
        // - Nếu tiếp tục bằng thì xét hiệu số.
        //
        // Trả về chỉ số đội (0-based).
        // ==========================================================
        public static int TimDoiVoDich(
            ThanhTich[] bang)
        {
            int viTriVoDich = 0;

            for (int i = 1; i < bang.Length; i++)
            {
                if (bang[i].Diem > bang[viTriVoDich].Diem)
                {
                    viTriVoDich = i;
                }
                else if (
                    bang[i].Diem ==
                    bang[viTriVoDich].Diem &&
                    bang[i].BanThang >
                    bang[viTriVoDich].BanThang)
                {
                    viTriVoDich = i;
                }
                else if (
                    bang[i].Diem ==
                    bang[viTriVoDich].Diem &&
                    bang[i].BanThang ==
                    bang[viTriVoDich].BanThang &&
                    bang[i].HieuSo >
                    bang[viTriVoDich].HieuSo)
                {
                    viTriVoDich = i;
                }
            }

            return viTriVoDich;
        }


        // ==========================================================
        // In bảng thành tích
        // ==========================================================
        public static void InBangThanhTich(
            ThanhTich[] bang)
        {
            Console.WriteLine();

            Console.WriteLine(
                "============================================================================================"
            );

            Console.WriteLine(
                "Doi | So tran | Thang | Hoa | Thua | Ban thang | Ban thua | Hieu so / Diem | Xep hang"
            );

            Console.WriteLine(
                "============================================================================================"
            );

            for (int i = 0; i < bang.Length; i++)
            {
                ThanhTich t = bang[i];

                Console.WriteLine(
                    $"{i + 1,3} | " +
                    $"{t.SoTran,7} | " +
                    $"{t.SoThang,5} | " +
                    $"{t.SoHoa,3} | " +
                    $"{t.SoThua,4} | " +
                    $"{t.BanThang,10} | " +
                    $"{t.BanThua,9} | " +
                    $"{t.HieuSo,7} / {t.Diem,-4} | " +
                    $"{t.XepHang,8}"
                );
            }

            Console.WriteLine(
                "============================================================================================"
            );
        }


        // ==========================================================
        // MAIN
        // ==========================================================
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "===== BAI 5: GIAI BONG DA ====="
            );

            // ------------------------------------------------------
            // Nhập số đội
            // ------------------------------------------------------
            Console.Write("Nhap so doi n: ");

            int n =
                int.Parse(Console.ReadLine()!);

            if (n < 1 || n > 100)
            {
                Console.WriteLine(
                    "n phai nam trong khoang 1 den 100!"
                );

                return;
            }


            // ------------------------------------------------------
            // Ma trận A
            // ------------------------------------------------------
            int[,] A =
                new int[n, n];

            Console.WriteLine();
            Console.WriteLine(
                "Nhap bang thanh tich A:"
            );

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(
                        $"A[{i + 1},{j + 1}] = "
                    );

                    A[i, j] =
                        int.Parse(
                            Console.ReadLine()!
                        );
                }
            }


            // ------------------------------------------------------
            // Ma trận B
            // ------------------------------------------------------
            int[,] B =
                new int[n, n];

            Console.WriteLine();
            Console.WriteLine(
                "Nhap bang thanh tich B:"
            );

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(
                        $"B[{i + 1},{j + 1}] = "
                    );

                    B[i, j] =
                        int.Parse(
                            Console.ReadLine()!
                        );
                }
            }


            // ------------------------------------------------------
            // Tạo bảng xếp hạng
            // ------------------------------------------------------
            ThanhTich[] bang =
                TaoBangXepHang(A, B, n);


            // ------------------------------------------------------
            // In bảng
            // ------------------------------------------------------
            InBangThanhTich(bang);


            // ------------------------------------------------------
            // Tìm đội vô địch
            // ------------------------------------------------------
            int doiVoDich =
                TimDoiVoDich(bang);

            Console.WriteLine();

            Console.WriteLine(
                $"DOI VO DICH: DOI {doiVoDich + 1}"
            );
        }
    }
}