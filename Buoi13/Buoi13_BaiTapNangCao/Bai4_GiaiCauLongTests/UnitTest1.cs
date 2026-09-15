using Bai4_GiaiCauLong;

namespace Bai4_GiaiCauLongTests
{
    public class UnitTest1
    {
        // ==========================================================
        // Ma trận thành tích mẫu
        //
        //       SV1 SV2 SV3 SV4
        // SV1    0   2   1   3
        // SV2    1   0   1   0
        // SV3    2   2   0   2
        // SV4    0   3   1   0
        // ==========================================================
        private int[,] TaoMaTranMau()
        {
            return new int[,]
            {
                { 0, 2, 1, 3 },
                { 1, 0, 1, 0 },
                { 2, 2, 0, 2 },
                { 0, 3, 1, 0 }
            };
        }


        // ==========================================================
        // TEST 1
        // SV1 có tổng bàn thắng:
        // 0 + 2 + 1 + 3 = 6
        // ==========================================================
        [Fact]
        public void TinhBanThang_SV1()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.TinhBanThang(a, 4, 0);

            Assert.Equal(6, ketQua);
        }


        // ==========================================================
        // TEST 2
        // SV2:
        // 1 + 0 + 1 + 0 = 2
        // ==========================================================
        [Fact]
        public void TinhBanThang_SV2()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.TinhBanThang(a, 4, 1);

            Assert.Equal(2, ketQua);
        }


        // ==========================================================
        // TEST 3
        // SV3:
        // 2 + 2 + 0 + 2 = 6
        // ==========================================================
        [Fact]
        public void TinhBanThang_SV3()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.TinhBanThang(a, 4, 2);

            Assert.Equal(6, ketQua);
        }


        // ==========================================================
        // TEST 4
        // SV4:
        // 0 + 3 + 1 + 0 = 4
        // ==========================================================
        [Fact]
        public void TinhBanThang_SV4()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.TinhBanThang(a, 4, 3);

            Assert.Equal(4, ketQua);
        }


        // ==========================================================
        // TEST 5
        // SV1 có tổng bàn thua:
        // 0 + 1 + 2 + 0 = 3
        // ==========================================================
        [Fact]
        public void TinhBanThua_SV1()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.TinhBanThua(a, 4, 0);

            Assert.Equal(3, ketQua);
        }


        // ==========================================================
        // TEST 6
        // SV2 có tổng bàn thua:
        // 2 + 0 + 2 + 3 = 7
        // ==========================================================
        [Fact]
        public void TinhBanThua_SV2()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.TinhBanThua(a, 4, 1);

            Assert.Equal(7, ketQua);
        }


        // ==========================================================
        // TEST 7
        // SV3 có tổng bàn thua:
        // 1 + 1 + 0 + 1 = 3
        // ==========================================================
        [Fact]
        public void TinhBanThua_SV3()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.TinhBanThua(a, 4, 2);

            Assert.Equal(3, ketQua);
        }


        // ==========================================================
        // TEST 8
        // SV4 có tổng bàn thua:
        // 3 + 0 + 2 + 0 = 5
        // ==========================================================
        [Fact]
        public void TinhBanThua_SV4()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.TinhBanThua(a, 4, 3);

            Assert.Equal(5, ketQua);
        }


        // ==========================================================
        // TEST 9
        // SV1:
        //
        // Gặp SV2: 2 > 1 => thắng
        // Gặp SV3: 1 < 2 => thua
        // Gặp SV4: 3 > 0 => thắng
        //
        // => 2 trận thắng
        // ==========================================================
        [Fact]
        public void DemTranThang_SV1()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.DemTranThang(a, 4, 0);

            Assert.Equal(2, ketQua);
        }


        // ==========================================================
        // TEST 10
        // SV2:
        //
        // Gặp SV1: 1 < 2 => thua
        // Gặp SV3: 1 < 2 => thua
        // Gặp SV4: 0 < 3 => thua
        //
        // => 0 trận thắng
        // ==========================================================
        [Fact]
        public void DemTranThang_SV2()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.DemTranThang(a, 4, 1);

            Assert.Equal(0, ketQua);
        }


        // ==========================================================
        // TEST 11
        // SV3:
        //
        // Gặp SV1: 2 > 1 => thắng
        // Gặp SV2: 2 > 1 => thắng
        // Gặp SV4: 2 > 1 => thắng
        //
        // => 3 trận thắng
        // ==========================================================
        [Fact]
        public void DemTranThang_SV3()
        {
            int[,] a = TaoMaTranMau();

            int ketQua = BT4.DemTranThang(a, 4, 2);

            Assert.Equal(3, ketQua);
        }


        // ==========================================================
        // TEST 12
        // Kiểm tra số trận thua của toàn bộ sinh viên.
        //
        // SV1 = 1
        // SV2 = 3
        // SV3 = 0
        // SV4 = 2
        // ==========================================================
        [Fact]
        public void DemTranThua_ToanBo()
        {
            int[,] a = TaoMaTranMau();

            Assert.Equal(
                1,
                BT4.DemTranThua(a, 4, 0)
            );

            Assert.Equal(
                3,
                BT4.DemTranThua(a, 4, 1)
            );

            Assert.Equal(
                0,
                BT4.DemTranThua(a, 4, 2)
            );

            Assert.Equal(
                2,
                BT4.DemTranThua(a, 4, 3)
            );
        }


        // ==========================================================
        // TEST 13
        // Kiểm tra hiệu số:
        //
        // SV1: 6 - 3 = +3
        // SV2: 2 - 7 = -5
        // SV3: 6 - 3 = +3
        // SV4: 4 - 5 = -1
        // ==========================================================
        [Fact]
        public void TinhHieuSo_ToanBo()
        {
            int[,] a = TaoMaTranMau();

            Assert.Equal(
                3,
                BT4.TinhHieuSo(a, 4, 0)
            );

            Assert.Equal(
                -5,
                BT4.TinhHieuSo(a, 4, 1)
            );

            Assert.Equal(
                3,
                BT4.TinhHieuSo(a, 4, 2)
            );

            Assert.Equal(
                -1,
                BT4.TinhHieuSo(a, 4, 3)
            );
        }


        // ==========================================================
        // TEST 14
        // Kiểm tra toàn bộ bảng thành tích.
        //
        // Theo đúng ma trận hiện tại:
        //
        // SV1: 3 trận, 2 thắng, 1 thua, 6-3, +3
        // SV2: 3 trận, 0 thắng, 3 thua, 2-7, -5
        // SV3: 3 trận, 3 thắng, 0 thua, 6-3, +3
        // SV4: 3 trận, 1 thắng, 2 thua, 4-5, -1
        // ==========================================================
        [Fact]
        public void TaoBangThanhTich_Test()
        {
            int[,] a = TaoMaTranMau();

            ThanhTich[] bang =
                BT4.TaoBangThanhTich(a, 4);

            // --------------------------
            // SV1
            // --------------------------
            Assert.Equal(3, bang[0].SoTran);
            Assert.Equal(2, bang[0].Thang);
            Assert.Equal(1, bang[0].Thua);
            Assert.Equal(6, bang[0].BanThang);
            Assert.Equal(3, bang[0].BanThua);
            Assert.Equal(3, bang[0].HieuSo);

            // --------------------------
            // SV2
            // --------------------------
            Assert.Equal(3, bang[1].SoTran);
            Assert.Equal(0, bang[1].Thang);
            Assert.Equal(3, bang[1].Thua);
            Assert.Equal(2, bang[1].BanThang);
            Assert.Equal(7, bang[1].BanThua);
            Assert.Equal(-5, bang[1].HieuSo);

            // --------------------------
            // SV3
            // --------------------------
            Assert.Equal(3, bang[2].SoTran);
            Assert.Equal(3, bang[2].Thang);
            Assert.Equal(0, bang[2].Thua);
            Assert.Equal(6, bang[2].BanThang);
            Assert.Equal(3, bang[2].BanThua);
            Assert.Equal(3, bang[2].HieuSo);

            // --------------------------
            // SV4
            // --------------------------
            Assert.Equal(3, bang[3].SoTran);
            Assert.Equal(1, bang[3].Thang);
            Assert.Equal(2, bang[3].Thua);
            Assert.Equal(4, bang[3].BanThang);
            Assert.Equal(5, bang[3].BanThua);
            Assert.Equal(-1, bang[3].HieuSo);
        }


        // ==========================================================
        // TEST 15
        // Kiểm tra xếp hạng.
        //
        // Theo đúng ma trận:
        //
        // SV3: 3 thắng, +3 => hạng 1
        // SV1: 2 thắng, +3 => hạng 2
        // SV4: 1 thắng, -1 => hạng 3
        // SV2: 0 thắng, -5 => hạng 4
        // ==========================================================
        [Fact]
        public void XepHang_Test()
        {
            int[,] a = TaoMaTranMau();

            ThanhTich[] bang =
                BT4.TaoBangXepHang(a, 4);

            Assert.Equal(2, bang[0].XepHang);
            Assert.Equal(4, bang[1].XepHang);
            Assert.Equal(1, bang[2].XepHang);
            Assert.Equal(3, bang[3].XepHang);
        }


        // ==========================================================
        // TEST 16
        // Trường hợp chỉ có 1 thí sinh.
        // ==========================================================
        [Fact]
        public void MotThiSinh()
        {
            int[,] a =
            {
                { 0 }
            };

            ThanhTich[] bang =
                BT4.TaoBangXepHang(a, 1);

            Assert.Equal(0, bang[0].SoTran);
            Assert.Equal(0, bang[0].Thang);
            Assert.Equal(0, bang[0].Thua);
            Assert.Equal(0, bang[0].BanThang);
            Assert.Equal(0, bang[0].BanThua);
            Assert.Equal(0, bang[0].HieuSo);
            Assert.Equal(1, bang[0].XepHang);
        }


        // ==========================================================
        // TEST 17
        // Trường hợp 2 thí sinh.
        //
        // SV1 thắng SV2: 3 - 1
        //
        //     0 3
        //     1 0
        // ==========================================================
        [Fact]
        public void HaiThiSinh()
        {
            int[,] a =
            {
                { 0, 3 },
                { 1, 0 }
            };

            ThanhTich[] bang =
                BT4.TaoBangXepHang(a, 2);

            // SV1
            Assert.Equal(1, bang[0].SoTran);
            Assert.Equal(1, bang[0].Thang);
            Assert.Equal(0, bang[0].Thua);
            Assert.Equal(3, bang[0].BanThang);
            Assert.Equal(1, bang[0].BanThua);
            Assert.Equal(2, bang[0].HieuSo);
            Assert.Equal(1, bang[0].XepHang);

            // SV2
            Assert.Equal(1, bang[1].SoTran);
            Assert.Equal(0, bang[1].Thang);
            Assert.Equal(1, bang[1].Thua);
            Assert.Equal(1, bang[1].BanThang);
            Assert.Equal(3, bang[1].BanThua);
            Assert.Equal(-2, bang[1].HieuSo);
            Assert.Equal(2, bang[1].XepHang);
        }
    }
}