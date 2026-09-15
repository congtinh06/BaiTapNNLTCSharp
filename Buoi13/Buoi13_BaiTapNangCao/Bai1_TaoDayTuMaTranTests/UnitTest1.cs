using Bai1_TaoDayTuMaTran;

namespace Bai1_TaoDayTuMaTranTests
{
    public class UnitTest1
    {
        // ==================================================
        // TEST 1
        //
        // Mỗi dòng đều không có ký tự trùng nhau
        //
        // A:
        // a b c
        // d e f
        // g h i
        //
        // => B = 1 1 1
        // ==================================================
        [Fact]
        public void TaoDay_TatCaDongKhongTrung()
        {
            char[,] a =
            {
                { 'a', 'b', 'c' },
                { 'd', 'e', 'f' },
                { 'g', 'h', 'i' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 3);

            Assert.Equal(
                new int[] { 1, 1, 1 },
                ketQua
            );
        }


        // ==================================================
        // TEST 2
        //
        // Dòng 0: a b a => có trùng => 0
        // Dòng 1: d e f => không trùng => 1
        // Dòng 2: g g h => có trùng => 0
        //
        // => B = 0 1 0
        // ==================================================
        [Fact]
        public void TaoDay_CoDongBiTrung()
        {
            char[,] a =
            {
                { 'a', 'b', 'a' },
                { 'd', 'e', 'f' },
                { 'g', 'g', 'h' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 3);

            Assert.Equal(
                new int[] { 0, 1, 0 },
                ketQua
            );
        }


        // ==================================================
        // TEST 3
        //
        // Ma trận 1x1
        //
        // a
        //
        // Chỉ có một ký tự nên chắc chắn không trùng
        // => B = 1
        // ==================================================
        [Fact]
        public void TaoDay_MaTran1x1()
        {
            char[,] a =
            {
                { 'a' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 1);

            Assert.Equal(
                new int[] { 1 },
                ketQua
            );
        }


        // ==================================================
        // TEST 4
        //
        // Mỗi dòng toàn cùng một ký tự
        //
        // a a a
        // b b b
        // c c c
        //
        // => B = 0 0 0
        // ==================================================
        [Fact]
        public void TaoDay_TatCaDongBiTrung()
        {
            char[,] a =
            {
                { 'a', 'a', 'a' },
                { 'b', 'b', 'b' },
                { 'c', 'c', 'c' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 3);

            Assert.Equal(
                new int[] { 0, 0, 0 },
                ketQua
            );
        }


        // ==================================================
        // TEST 5
        //
        // Kiểm tra ký tự xuất hiện ở đầu và cuối dòng
        //
        // a b c a
        //
        // Ký tự 'a' bị trùng
        // => b[0] = 0
        // ==================================================
        [Fact]
        public void TaoDay_TrungDauVaCuoiDong()
        {
            char[,] a =
            {
                { 'a', 'b', 'c', 'a' },
                { 'd', 'e', 'f', 'g' },
                { 'h', 'i', 'j', 'k' },
                { 'l', 'm', 'n', 'o' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 4);

            Assert.Equal(
                new int[] { 0, 1, 1, 1 },
                ketQua
            );
        }


        // ==================================================
        // TEST 6
        //
        // Chữ hoa và chữ thường được xem là khác nhau
        //
        // A a B
        //
        // 'A' khác 'a'
        // => không trùng
        // ==================================================
        [Fact]
        public void TaoDay_ChuHoaVaChuThuong()
        {
            char[,] a =
            {
                { 'A', 'a', 'B' },
                { 'C', 'D', 'E' },
                { 'F', 'G', 'H' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 3);

            Assert.Equal(
                new int[] { 1, 1, 1 },
                ketQua
            );
        }


        // ==================================================
        // TEST 7
        //
        // Kiểm tra số ký tự lớn hơn 3
        //
        // a b c d
        // a b c a
        // x y z w
        // p p q r
        //
        // => B = 1 0 1 0
        // ==================================================
        [Fact]
        public void TaoDay_MaTran4x4()
        {
            char[,] a =
            {
                { 'a', 'b', 'c', 'd' },
                { 'a', 'b', 'c', 'a' },
                { 'x', 'y', 'z', 'w' },
                { 'p', 'p', 'q', 'r' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 4);

            Assert.Equal(
                new int[] { 1, 0, 1, 0 },
                ketQua
            );
        }


        // ==================================================
        // TEST 8
        //
        // Ký tự trùng nằm ở giữa dòng
        //
        // a b c b
        //
        // 'b' xuất hiện 2 lần
        // => 0
        // ==================================================
        [Fact]
        public void TaoDay_TrungOPhiaGiua()
        {
            char[,] a =
            {
                { 'a', 'b', 'c', 'b' },
                { 'd', 'e', 'f', 'g' },
                { 'h', 'i', 'j', 'k' },
                { 'l', 'm', 'n', 'o' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 4);

            Assert.Equal(
                new int[] { 0, 1, 1, 1 },
                ketQua
            );
        }


        // ==================================================
        // TEST 9
        //
        // Kiểm tra ma trận 5x5
        // Các dòng xen kẽ trùng / không trùng
        //
        // => B = 1 0 1 0 1
        // ==================================================
        [Fact]
        public void TaoDay_MaTran5x5()
        {
            char[,] a =
            {
                { 'a', 'b', 'c', 'd', 'e' },
                { 'a', 'b', 'c', 'd', 'a' },
                { 'f', 'g', 'h', 'i', 'j' },
                { 'k', 'l', 'k', 'm', 'n' },
                { 'o', 'p', 'q', 'r', 's' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 5);

            Assert.Equal(
                new int[] { 1, 0, 1, 0, 1 },
                ketQua
            );
        }


        // ==================================================
        // TEST 10
        //
        // Kiểm tra một dòng có nhiều ký tự trùng nhau
        //
        // a b a b
        //
        // Có nhiều cặp trùng
        // => chỉ cần phát hiện một cặp là đủ
        // => 0
        // ==================================================
        [Fact]
        public void TaoDay_NhieuKyTuTrung()
        {
            char[,] a =
            {
                { 'a', 'b', 'a', 'b' },
                { 'c', 'd', 'e', 'f' },
                { 'g', 'h', 'i', 'j' },
                { 'k', 'l', 'm', 'n' }
            };

            int[] ketQua =
                BT1.TaoDay(a, 4);

            Assert.Equal(
                new int[] { 0, 1, 1, 1 },
                ketQua
            );
        }
    }
}