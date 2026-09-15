using Bai5_GiaiBongDa;

namespace Bai5_GiaiBongDaTests
{
    public class UnitTest1
    {
        // ==========================================================
        // Dữ liệu mẫu đúng theo đề
        //
        // A:
        // 0 1 2
        // 2 0 3
        // 3 4 0
        //
        // B:
        // 0 1 1
        // 1 0 5
        // 3 2 0
        // ==========================================================
        private void TaoDuLieuMau(
            out int[,] A,
            out int[,] B)
        {
            A = new int[,]
            {
                { 0, 1, 2 },
                { 2, 0, 3 },
                { 3, 4, 0 }
            };

            B = new int[,]
            {
                { 0, 1, 1 },
                { 1, 0, 5 },
                { 3, 2, 0 }
            };
        }


        // ==========================================================
        // TEST 1
        // Đội 1 có 7 bàn thắng.
        //
        // Sân nhà:
        // A[1,2] = 1
        // A[1,3] = 2
        //
        // Sân khách:
        // B[2,1] = 1
        // B[3,1] = 3
        //
        // Tổng = 1 + 2 + 1 + 3 = 7
        // ==========================================================
        [Fact]
        public void TinhBanThang_Doi1()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            int ketQua =
                BT5.TinhBanThang(A, B, 3, 0);

            Assert.Equal(7, ketQua);
        }


        // ==========================================================
        // TEST 2
        // Đội 2 có 8 bàn thắng.
        // ==========================================================
        [Fact]
        public void TinhBanThang_Doi2()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            int ketQua =
                BT5.TinhBanThang(A, B, 3, 1);

            Assert.Equal(8, ketQua);
        }


        // ==========================================================
        // TEST 3
        // Đội 3 có 13 bàn thắng.
        // ==========================================================
        [Fact]
        public void TinhBanThang_Doi3()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            int ketQua =
                BT5.TinhBanThang(A, B, 3, 2);

            Assert.Equal(13, ketQua);
        }


        // ==========================================================
        // TEST 4
        // Đội 1 có 7 bàn thua.
        // ==========================================================
        [Fact]
        public void TinhBanThua_Doi1()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            int ketQua =
                BT5.TinhBanThua(A, B, 3, 0);

            Assert.Equal(7, ketQua);
        }


        // ==========================================================
        // TEST 5
        // Đội 2 có 11 bàn thua.
        // ==========================================================
        [Fact]
        public void TinhBanThua_Doi2()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            int ketQua =
                BT5.TinhBanThua(A, B, 3, 1);

            Assert.Equal(11, ketQua);
        }


        // ==========================================================
        // TEST 6
        // Đội 3 có 10 bàn thua.
        // ==========================================================
        [Fact]
        public void TinhBanThua_Doi3()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            int ketQua =
                BT5.TinhBanThua(A, B, 3, 2);

            Assert.Equal(10, ketQua);
        }


        // ==========================================================
        // TEST 7
        // Đội 1:
        //
        // Trận 1:
        // Đội 1 - Đội 2 = 1 - 1 => hòa
        //
        // Trận 2:
        // Đội 1 - Đội 3 = 2 - 1 => thắng
        //
        // Lượt về:
        // Đội 2 - Đội 1 = 2 - 1 => thua
        //
        // Đội 3 - Đội 1 = 3 - 3 => hòa
        //
        // => 1 thắng
        // ==========================================================
        [Fact]
        public void DemTranThang_Doi1()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            int ketQua =
                BT5.DemTranThang(A, B, 3, 0);

            Assert.Equal(1, ketQua);
        }


        // ==========================================================
        // TEST 8
        // Đội 2 có 1 trận thắng.
        // ==========================================================
        [Fact]
        public void DemTranThang_Doi2()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            int ketQua =
                BT5.DemTranThang(A, B, 3, 1);

            Assert.Equal(1, ketQua);
        }


        // ==========================================================
        // TEST 9
        // Đội 3 có 2 trận thắng.
        // ==========================================================
        [Fact]
        public void DemTranThang_Doi3()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            int ketQua =
                BT5.DemTranThang(A, B, 3, 2);

            Assert.Equal(2, ketQua);
        }


        // ==========================================================
        // TEST 10
        // Số trận hòa:
        //
        // Đội 1 = 2
        // Đội 2 = 1
        // Đội 3 = 1
        // ==========================================================
        [Fact]
        public void DemTranHoa()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            Assert.Equal(
                2,
                BT5.DemTranHoa(A, B, 3, 0)
            );

            Assert.Equal(
                1,
                BT5.DemTranHoa(A, B, 3, 1)
            );

            Assert.Equal(
                1,
                BT5.DemTranHoa(A, B, 3, 2)
            );
        }


        // ==========================================================
        // TEST 11
        // Số trận thua:
        //
        // Đội 1 = 1
        // Đội 2 = 2
        // Đội 3 = 1
        // ==========================================================
        [Fact]
        public void DemTranThua()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            Assert.Equal(
                1,
                BT5.DemTranThua(A, B, 3, 0)
            );

            Assert.Equal(
                2,
                BT5.DemTranThua(A, B, 3, 1)
            );

            Assert.Equal(
                1,
                BT5.DemTranThua(A, B, 3, 2)
            );
        }


        // ==========================================================
        // TEST 12
        // Tính điểm:
        //
        // Đội 1:
        // 1 thắng * 3 + 2 hòa * 1 = 5
        //
        // Đội 2:
        // 1 thắng * 3 + 1 hòa = 4
        //
        // Đội 3:
        // 2 thắng * 3 + 1 hòa = 7
        // ==========================================================
        [Fact]
        public void TinhDiem()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            Assert.Equal(
                5,
                BT5.TinhDiem(A, B, 3, 0)
            );

            Assert.Equal(
                4,
                BT5.TinhDiem(A, B, 3, 1)
            );

            Assert.Equal(
                7,
                BT5.TinhDiem(A, B, 3, 2)
            );
        }


        // ==========================================================
        // TEST 13
        // Kiểm tra hiệu số:
        //
        // Đội 1: 7 - 7 = 0
        // Đội 2: 8 - 11 = -3
        // Đội 3: 13 - 10 = 3
        // ==========================================================
        [Fact]
        public void TinhHieuSo()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            ThanhTich[] bang =
                BT5.TaoBangThanhTich(A, B, 3);

            Assert.Equal(
                0,
                bang[0].HieuSo
            );

            Assert.Equal(
                -3,
                bang[1].HieuSo
            );

            Assert.Equal(
                3,
                bang[2].HieuSo
            );
        }


        // ==========================================================
        // TEST 14
        // Kiểm tra toàn bộ bảng thành tích.
        // ==========================================================
        [Fact]
        public void TaoBangThanhTich()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            ThanhTich[] bang =
                BT5.TaoBangThanhTich(A, B, 3);

            // --------------------------
            // Đội 1
            // --------------------------
            Assert.Equal(4, bang[0].SoTran);
            Assert.Equal(1, bang[0].SoThang);
            Assert.Equal(2, bang[0].SoHoa);
            Assert.Equal(1, bang[0].SoThua);
            Assert.Equal(7, bang[0].BanThang);
            Assert.Equal(7, bang[0].BanThua);
            Assert.Equal(0, bang[0].HieuSo);
            Assert.Equal(5, bang[0].Diem);

            // --------------------------
            // Đội 2
            // --------------------------
            Assert.Equal(4, bang[1].SoTran);
            Assert.Equal(1, bang[1].SoThang);
            Assert.Equal(1, bang[1].SoHoa);
            Assert.Equal(2, bang[1].SoThua);
            Assert.Equal(8, bang[1].BanThang);
            Assert.Equal(11, bang[1].BanThua);
            Assert.Equal(-3, bang[1].HieuSo);
            Assert.Equal(4, bang[1].Diem);

            // --------------------------
            // Đội 3
            // --------------------------
            Assert.Equal(4, bang[2].SoTran);
            Assert.Equal(2, bang[2].SoThang);
            Assert.Equal(1, bang[2].SoHoa);
            Assert.Equal(1, bang[2].SoThua);
            Assert.Equal(13, bang[2].BanThang);
            Assert.Equal(10, bang[2].BanThua);
            Assert.Equal(3, bang[2].HieuSo);
            Assert.Equal(7, bang[2].Diem);
        }


        // ==========================================================
        // TEST 15
        // Đội vô địch phải là đội 3.
        //
        // Đội 3 có 7 điểm.
        // ==========================================================
        [Fact]
        public void TimDoiVoDich()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            ThanhTich[] bang =
                BT5.TaoBangXepHang(A, B, 3);

            int ketQua =
                BT5.TimDoiVoDich(bang);

            // Chỉ số 2 tương ứng đội số 3
            Assert.Equal(2, ketQua);
        }


        // ==========================================================
        // TEST 16
        // Kiểm tra xếp hạng.
        //
        // Đội 3: 7 điểm => hạng 1
        // Đội 1: 5 điểm => hạng 2
        // Đội 2: 4 điểm => hạng 3
        // ==========================================================
        [Fact]
        public void XepHang()
        {
            TaoDuLieuMau(out int[,] A, out int[,] B);

            ThanhTich[] bang =
                BT5.TaoBangXepHang(A, B, 3);

            Assert.Equal(
                2,
                bang[0].XepHang
            );

            Assert.Equal(
                3,
                bang[1].XepHang
            );

            Assert.Equal(
                1,
                bang[2].XepHang
            );
        }


        // ==========================================================
        // TEST 17
        // Trường hợp 2 đội.
        //
        // Đội 1 thắng đội 2 ở lượt đi:
        // 3 - 1
        //
        // Đội 2 thắng đội 1 ở lượt về:
        // 2 - 0
        //
        // Mỗi đội 1 thắng, 1 thua => 3 điểm.
        // ==========================================================
        [Fact]
        public void HaiDoi()
        {
            int[,] A =
            {
                { 0, 3 },
                { 2, 0 }
            };

            int[,] B =
            {
                { 0, 1 },
                { 0, 0 }
            };

            ThanhTich[] bang =
                BT5.TaoBangXepHang(A, B, 2);

            // --------------------------
            // Đội 1
            //
            // Lượt đi: 3 - 1 => thắng
            // Lượt về: 2 - 0 => thua
            // --------------------------
            Assert.Equal(1, bang[0].SoThang);
            Assert.Equal(0, bang[0].SoHoa);
            Assert.Equal(1, bang[0].SoThua);
            Assert.Equal(3, bang[0].Diem);

            // --------------------------
            // Đội 2
            // --------------------------
            Assert.Equal(1, bang[1].SoThang);
            Assert.Equal(0, bang[1].SoHoa);
            Assert.Equal(1, bang[1].SoThua);
            Assert.Equal(3, bang[1].Diem);
        }


        // ==========================================================
        // TEST 18
        // Kiểm tra trường hợp hòa cả hai lượt.
        // ==========================================================
        [Fact]
        public void HaiDoi_HoaCaHaiLuot()
        {
            int[,] A =
            {
                { 0, 2 },
                { 1, 0 }
            };

            int[,] B =
            {
                { 0, 2 },
                { 1, 0 }
            };

            ThanhTich[] bang =
                BT5.TaoBangThanhTich(A, B, 2);

            // Mỗi đội có 2 trận hòa
            Assert.Equal(0, bang[0].SoThang);
            Assert.Equal(2, bang[0].SoHoa);
            Assert.Equal(0, bang[0].SoThua);
            Assert.Equal(2, bang[0].Diem);

            Assert.Equal(0, bang[1].SoThang);
            Assert.Equal(2, bang[1].SoHoa);
            Assert.Equal(0, bang[1].SoThua);
            Assert.Equal(2, bang[1].Diem);
        }
    }
}