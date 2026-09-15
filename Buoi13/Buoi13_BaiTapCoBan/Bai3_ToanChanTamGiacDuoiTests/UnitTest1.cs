using Bai3_ToanChanTamGiacDuoi;

namespace Bai3_ToanChanTamGiacDuoiTests
{
    public class UnitTest1
    {
        // ==================================================
        // TEST 1
        // Ma trận đúng theo ví dụ đề
        //
        // Tam giác dưới chéo phụ:
        // 1 0 0 0 2 3 1 1 4 7
        //
        // Có số lẻ => FALSE
        // ==================================================
        [Fact]
        public void ToanChan_TheoViDuDe_TraVeFalse()
        {
            int[,] a =
            {
                { 5, 5, 5, 0, 0 },
                { 0, 5, 0, 1, 1 },
                { 0, 5, 0, 0, 0 },
                { 0, 0, 0, 2, 3 },
                { 1, 1, 1, 4, 7 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 5);

            Assert.False(ketQua);
        }


        // ==================================================
        // TEST 2
        // Tất cả phần tử dưới chéo phụ đều chẵn
        //
        // 1  2  3
        // 4  5  6
        // 8  10 12
        //
        // Dưới chéo phụ:
        // 6 8 10 12
        //
        // Tất cả đều chẵn
        // ==================================================
        [Fact]
        public void ToanChan_TatCaChan_TraVeTrue()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 8, 10, 12 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 3);

            Assert.True(ketQua);
        }


        // ==================================================
        // TEST 3
        // Có một số lẻ dưới chéo phụ
        //
        // 1 2 3
        // 4 5 6
        // 8 10 11
        //
        // 11 là số lẻ
        // ==================================================
        [Fact]
        public void ToanChan_CoMotSoLe_TraVeFalse()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 8, 10, 11 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 3);

            Assert.False(ketQua);
        }


        // ==================================================
        // TEST 4
        // Các phần tử trên đường chéo phụ là số lẻ
        //
        // Nhưng KHÔNG được tính.
        //
        // 1 1 9
        // 2 8 3
        // 4 6 5
        //
        // Đường chéo phụ:
        // 9 8 4
        //
        // Dưới chéo phụ:
        // 3 6 5
        //
        // Có 3 và 5 => FALSE
        // ==================================================
        [Fact]
        public void ToanChan_KhongTinhCheoPhu()
        {
            int[,] a =
            {
                { 1, 1, 9 },
                { 2, 8, 3 },
                { 4, 6, 5 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 3);

            Assert.False(ketQua);
        }


        // ==================================================
        // TEST 5
        // Kiểm tra ma trận 2x2
        //
        // 1 2
        // 4 6
        //
        // Đường chéo phụ: 2 4
        // Dưới chéo phụ: 6
        //
        // 6 là số chẵn
        // ==================================================
        [Fact]
        public void ToanChan_MaTran2x2_TraVeTrue()
        {
            int[,] a =
            {
                { 1, 2 },
                { 4, 6 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 2);

            Assert.True(ketQua);
        }


        // ==================================================
        // TEST 6
        // Ma trận 2x2
        //
        // 1 2
        // 4 7
        //
        // Dưới chéo phụ chỉ có 7
        //
        // 7 là số lẻ
        // ==================================================
        [Fact]
        public void ToanChan_MaTran2x2_CoSoLe()
        {
            int[,] a =
            {
                { 1, 2 },
                { 4, 7 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 2);

            Assert.False(ketQua);
        }


        // ==================================================
        // TEST 7
        // Ma trận cấp 1
        //
        // 8
        //
        // Không có phần tử nằm dưới chéo phụ.
        // Hàm trả về TRUE vì không tìm thấy số lẻ.
        // ==================================================
        [Fact]
        public void ToanChan_MaTran1x1()
        {
            int[,] a =
            {
                { 8 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 1);

            Assert.True(ketQua);
        }


        // ==================================================
        // TEST 8
        // Tất cả số dưới chéo phụ là số âm chẵn
        //
        // -2 -4 -6
        // -8 -10 -12
        // -14 -16 -18
        //
        // Dưới chéo phụ:
        // -12 -14 -16 -18
        //
        // Tất cả đều chẵn
        // ==================================================
        [Fact]
        public void ToanChan_SoAmChan()
        {
            int[,] a =
            {
                { -2, -4, -6 },
                { -8, -10, -12 },
                { -14, -16, -18 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 3);

            Assert.True(ketQua);
        }


        // ==================================================
        // TEST 9
        // Số 0 được xem là số chẵn
        //
        // 1 2 3
        // 4 5 0
        // 0 0 0
        //
        // Dưới chéo phụ đều là 0
        // ==================================================
        [Fact]
        public void ToanChan_So0LaSoChan()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 0 },
                { 0, 0, 0 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 3);

            Assert.True(ketQua);
        }


        // ==================================================
        // TEST 10
        // Kiểm tra số lẻ nằm đúng trong vùng cần kiểm tra
        //
        // 2 4 6 8
        // 10 12 14 16
        // 18 20 22 24
        // 26 28 30 31
        //
        // 31 nằm dưới chéo phụ
        // => FALSE
        // ==================================================
        [Fact]
        public void ToanChan_SoLeNamDuoiCheoPhu()
        {
            int[,] a =
            {
                { 2, 4, 6, 8 },
                { 10, 12, 14, 16 },
                { 18, 20, 22, 24 },
                { 26, 28, 30, 31 }
            };

            bool ketQua =
                BT3.KiemTraToanChan(a, 4);

            Assert.False(ketQua);
        }
    }
}