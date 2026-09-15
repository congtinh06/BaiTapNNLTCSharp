using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestThemDongCot
    {
        // Kiểm tra đúng theo ví dụ của đề
        [Fact]
        public void Test_ThemDongCot()
        {
            double[,] a =
            {
                { 1.2, -3.4, 5.6, -8.9, 4.3, 2.6 },
                { 3.7, -9.2, 1.8, -3.4, 9.2, 7.5 },
                { 4.5, -2.6, 6.3, -2.1, 6.2, 3.1 },
                { 7.1, -3.1, 2.4, -6.2, 2.4, 9.2 }
            };

            double[,] ketQua = ThemDongCot.Them(a);

            double[,] mongDoi =
            {
                { 1.2, -3.4, 5.6, -8.9, 9.2, 4.3, 2.6 },
                { 9.2, 9.2, 9.2, 9.2, 9.2, 9.2, 9.2 },
                { 3.7, -9.2, 1.8, -3.4, 9.2, 9.2, 7.5 },
                { 4.5, -2.6, 6.3, -2.1, 9.2, 6.2, 3.1 },
                { 7.1, -3.1, 2.4, -6.2, 9.2, 2.4, 9.2 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        // Max nằm ở dòng đầu, cột đầu
        [Fact]
        public void Test_ThemTaiDongCotDauTien()
        {
            double[,] a =
            {
                { 9, 2 },
                { 3, 4 }
            };

            double[,] ketQua = ThemDongCot.Them(a);

            double[,] mongDoi =
            {
                { 9, 9, 9 },
                { 9, 9, 2 },
                { 9, 3, 4 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_ThemTaiDongCotCuoi()
        {
            double[,] a =
            {
                { 1, 2 },
                { 3, 9 }
            };

            double[,] ketQua = ThemDongCot.Them(a);

            double[,] mongDoi =
            {
                { 1, 9, 2 },
                { 9, 9, 9 },
                { 3, 9, 9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        // Ma trận chỉ có 1 phần tử
        [Fact]
        public void Test_MaTran1x1()
        {
            double[,] a =
            {
                { 5 }
            };

            double[,] ketQua = ThemDongCot.Them(a);

            double[,] mongDoi =
            {
                { 5, 5 },
                { 5, 5 }
            };

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
