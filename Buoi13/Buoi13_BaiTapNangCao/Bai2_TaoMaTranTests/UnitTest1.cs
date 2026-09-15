using Bai2_TaoMaTran;

namespace Bai2_TaoMaTranTests
{
    public class UnitTest1
    {
        // ==========================================================
        // Ma trận mẫu:
        //
        // 1  2  3
        // 4  5  6
        // 7  8  9
        // ==========================================================
        private int[,] TaoMaTranMau()
        {
            return new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
        }


        // ==========================================================
        // TEST 1
        // Cách 1: tổng hàng + cột
        //
        // Với i = 0, j = 0:
        //
        // Hàng 0: 1 + 2 + 3 = 6
        // Cột 0: 4 + 7 = 11
        //
        // Tổng = 17
        // ==========================================================
        [Fact]
        public void TongHangVaCot_Test1()
        {
            int[,] a = TaoMaTranMau();

            int ketQua =
                BT2.TongHangVaCot(a, 3, 0, 0);

            Assert.Equal(17, ketQua);
        }


        // ==========================================================
        // TEST 2
        // Cách 1:
        //
        // i = 1, j = 1
        //
        // Hàng 1 = 4 + 5 + 6 = 15
        // Cột 1 = 2 + 8 = 10
        //
        // Tổng = 25
        // ==========================================================
        [Fact]
        public void TongHangVaCot_Test2()
        {
            int[,] a = TaoMaTranMau();

            int ketQua =
                BT2.TongHangVaCot(a, 3, 1, 1);

            Assert.Equal(25, ketQua);
        }


        // ==========================================================
        // TEST 3
        // Cách 2: góc trên trái
        //
        // i = 1, j = 1
        //
        // 1 2
        // 4 5
        //
        // Tổng = 12
        // ==========================================================
        [Fact]
        public void TongGocTrenTrai_Test()
        {
            int[,] a = TaoMaTranMau();

            int ketQua =
                BT2.TongGocTrenTrai(a, 3, 1, 1);

            Assert.Equal(12, ketQua);
        }


        // ==========================================================
        // TEST 4
        // Cách 2:
        //
        // i = 2, j = 2
        //
        // Toàn bộ ma trận:
        //
        // 1 + 2 + ... + 9 = 45
        // ==========================================================
        [Fact]
        public void TongGocTrenTrai_ToanMaTran()
        {
            int[,] a = TaoMaTranMau();

            int ketQua =
                BT2.TongGocTrenTrai(a, 3, 2, 2);

            Assert.Equal(45, ketQua);
        }


        // ==========================================================
        // TEST 5
        // Cách 3: góc dưới phải
        //
        // i = 1, j = 1
        //
        // 5 6
        // 8 9
        //
        // Tổng = 28
        // ==========================================================
        [Fact]
        public void TongGocDuoiPhai_Test()
        {
            int[,] a = TaoMaTranMau();

            int ketQua =
                BT2.TongGocDuoiPhai(a, 3, 1, 1);

            Assert.Equal(28, ketQua);
        }


        // ==========================================================
        // TEST 6
        // Cách 3:
        //
        // i = 0, j = 0
        //
        // Toàn bộ ma trận
        // => 45
        // ==========================================================
        [Fact]
        public void TongGocDuoiPhai_ToanMaTran()
        {
            int[,] a = TaoMaTranMau();

            int ketQua =
                BT2.TongGocDuoiPhai(a, 3, 0, 0);

            Assert.Equal(45, ketQua);
        }


        // ==========================================================
        // TEST 7
        // Cách 3:
        //
        // i = 2, j = 2
        //
        // Chỉ còn:
        // [9]
        //
        // => 9
        // ==========================================================
        [Fact]
        public void TongGocDuoiPhai_O1PhanTu()
        {
            int[,] a = TaoMaTranMau();

            int ketQua =
                BT2.TongGocDuoiPhai(a, 3, 2, 2);

            Assert.Equal(9, ketQua);
        }


        // ==========================================================
        // TEST 8
        // Cách 4
        //
        // i = 0, j = 2
        //
        // Vùng giữa chỉ số 0 -> 2:
        //
        // 1 2 3
        // 4 5 6
        // 7 8 9
        //
        // => 45
        // ==========================================================
        [Fact]
        public void TongVungGiua_Test1()
        {
            int[,] a = TaoMaTranMau();

            int ketQua =
                BT2.TongVungGiua(a, 3, 0, 2);

            Assert.Equal(45, ketQua);
        }


        // ==========================================================
        // TEST 9
        // Cách 4
        //
        // i = 1, j = 1
        //
        // Chỉ lấy:
        // 5
        //
        // => 5
        // ==========================================================
        [Fact]
        public void TongVungGiua_Test2()
        {
            int[,] a = TaoMaTranMau();

            int ketQua =
                BT2.TongVungGiua(a, 3, 1, 1);

            Assert.Equal(5, ketQua);
        }


        // ==========================================================
        // TEST 10
        // Kiểm tra tạo ma trận B cách 2
        //
        // Với:
        //
        // 1 2 3
        // 4 5 6
        // 7 8 9
        //
        // B[0,0] = 1
        // B[0,1] = 1+2 = 3
        // B[1,0] = 1+4 = 5
        // B[1,1] = 1+2+4+5 = 12
        // ==========================================================
        [Fact]
        public void TaoMaTranCach2_Test()
        {
            int[,] a = TaoMaTranMau();

            int[,] b =
                BT2.TaoMaTranCach2(a, 3);

            Assert.Equal(1, b[0, 0]);
            Assert.Equal(3, b[0, 1]);
            Assert.Equal(5, b[1, 0]);
            Assert.Equal(12, b[1, 1]);
        }
    }
}