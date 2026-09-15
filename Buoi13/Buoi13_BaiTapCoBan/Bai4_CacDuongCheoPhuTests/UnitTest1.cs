using Bai4_CacDuongCheoPhu;

namespace Bai4_CacDuongCheoPhuTests
{
    public class UnitTest1
    {
        // ==================================================
        // TEST 1
        // Ma trận đúng theo ví dụ trong đề
        //
        // 5 5 5 0 0
        // 0 5 0 1 1
        // 0 5 0 0 0
        // 0 0 0 2 3
        // 1 1 1 4 7
        //
        // Đường có tổng lớn nhất:
        // 5 + 5 + 0 = 10
        // ==================================================
        [Fact]
        public void TinhTongLonNhat_TheoViDuDe()
        {
            double[,] a =
            {
                { 5, 5, 5, 0, 0 },
                { 0, 5, 0, 1, 1 },
                { 0, 5, 0, 0, 0 },
                { 0, 0, 0, 2, 3 },
                { 1, 1, 1, 4, 7 }
            };

            double ketQua =
                BT4.TinhTongLonNhat(a, 5);

            Assert.Equal(10, ketQua);
        }


        // ==================================================
        // TEST 2
        // Ma trận toàn số 1
        //
        // Đường dài nhất có 5 phần tử
        // => tổng lớn nhất = 5
        // ==================================================
        [Fact]
        public void TinhTongLonNhat_MaTranToan1()
        {
            double[,] a =
            {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
            };

            double ketQua =
                BT4.TinhTongLonNhat(a, 5);

            Assert.Equal(5, ketQua);
        }


        // ==================================================
        // TEST 3
        // Ma trận toàn số 0
        //
        // Mọi đường đều có tổng = 0
        // ==================================================
        [Fact]
        public void TinhTongLonNhat_MaTranToan0()
        {
            double[,] a =
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            double ketQua =
                BT4.TinhTongLonNhat(a, 3);

            Assert.Equal(0, ketQua);
        }


        // ==================================================
        // TEST 4
        // Ma trận 1x1
        //
        // 7
        //
        // Chỉ có một đường
        // Tổng = 7
        // ==================================================
        [Fact]
        public void TinhTongLonNhat_MaTran1x1()
        {
            double[,] a =
            {
                { 7 }
            };

            double ketQua =
                BT4.TinhTongLonNhat(a, 1);

            Assert.Equal(7, ketQua);
        }


        // ==================================================
        // TEST 5
        // Kiểm tra số âm
        //
        //  -1  -2  -3
        //  -4  -5  -6
        //  -7  -8  -9
        //
        // Các đường:
        // [-1]             = -1
        // [-2,-4]          = -6
        // [-3,-5,-7]       = -15
        // [-6,-8]          = -14
        // [-9]             = -9
        //
        // Lớn nhất = -1
        // ==================================================
        [Fact]
        public void TinhTongLonNhat_SoAm()
        {
            double[,] a =
            {
                { -1, -2, -3 },
                { -4, -5, -6 },
                { -7, -8, -9 }
            };

            double ketQua =
                BT4.TinhTongLonNhat(a, 3);

            Assert.Equal(-1, ketQua);
        }


        // ==================================================
        // TEST 6
        // Tổng lớn nhất nằm ở đường giữa
        //
        // 1  1  1
        // 1  10 1
        // 1  1  1
        //
        // Đường i+j=2:
        // 1 + 10 + 1 = 12
        //
        // Kết quả = 12
        // ==================================================
        [Fact]
        public void TinhTongLonNhat_DuongGiua()
        {
            double[,] a =
            {
                { 1, 1, 1 },
                { 1, 10, 1 },
                { 1, 1, 1 }
            };

            double ketQua =
                BT4.TinhTongLonNhat(a, 3);

            Assert.Equal(12, ketQua);
        }


        // ==================================================
        // TEST 7
        // Kiểm tra số thực
        //
        // 1.5  1.5  1.5
        // 1.5  2.5  1.5
        // 1.5  1.5  1.5
        //
        // Đường giữa:
        // 1.5 + 2.5 + 1.5 = 5.5
        // ==================================================
        [Fact]
        public void TinhTongLonNhat_SoThuc()
        {
            double[,] a =
            {
                { 1.5, 1.5, 1.5 },
                { 1.5, 2.5, 1.5 },
                { 1.5, 1.5, 1.5 }
            };

            double ketQua =
                BT4.TinhTongLonNhat(a, 3);

            Assert.Equal(5.5, ketQua);
        }


        // ==================================================
        // TEST 8
        // Kiểm tra đường đầu tiên
        //
        // 100 1 1
        // 1   1 1
        // 1   1 1
        //
        // Đường đầu tiên chỉ có 100
        // => kết quả ít nhất phải là 100
        // ==================================================
        [Fact]
        public void TinhTongLonNhat_DuongDauTien()
        {
            double[,] a =
            {
                { 100, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };

            double ketQua =
                BT4.TinhTongLonNhat(a, 3);

            Assert.Equal(100, ketQua);
        }


        // ==================================================
        // TEST 9
        // Kiểm tra đường cuối cùng
        //
        // 1 1 1
        // 1 1 1
        // 1 1 100
        //
        // Đường cuối cùng chỉ có 100
        // => kết quả = 100
        // ==================================================
        [Fact]
        public void TinhTongLonNhat_DuongCuoi()
        {
            double[,] a =
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 100 }
            };

            double ketQua =
                BT4.TinhTongLonNhat(a, 3);

            Assert.Equal(100, ketQua);
        }


        // ==================================================
        // TEST 10
        // Kiểm tra hàm lấy các đường chéo
        //
        // Ma trận:
        //
        // 1 2
        // 3 4
        //
        // Các đường song song chéo phụ:
        //
        // [1]
        // [2, 3]
        // [4]
        // ==================================================
        [Fact]
        public void LayCacDuongCheoPhu_MaTran2x2()
        {
            double[,] a =
            {
                { 1, 2 },
                { 3, 4 }
            };

            List<List<double>> ketQua =
                BT4.LayCacDuongCheoPhu(a, 2);

            Assert.Equal(3, ketQua.Count);

            Assert.Equal(
                new double[] { 1 },
                ketQua[0]
            );

            Assert.Equal(
                new double[] { 2, 3 },
                ketQua[1]
            );

            Assert.Equal(
                new double[] { 4 },
                ketQua[2]
            );
        }
    }
}