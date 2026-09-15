using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestXoaDongCot
    {
        [Fact]
        public void Test_XoaDongCot()
        {
            int[,] a =
            {
                { 1, -3, 5, 8, 4, 2 },
                { 3, 9, -1, -9, 9, 7 },
                { 4, -2, 6, -2, -6, 3 },
                { 7, -3, 2, -6, 2, -9 }
            };

            int[,] ketQua = XoaDongCot.Xoa(a);

            int[,] mongDoi =
            {
                { 1, -3, 5, 4, 2 },
                { 4, -2, 6, -6, 3 },
                { 7, -3, 2, 2, -9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MinNamOPhanTuDauTien()
        {
            int[,] a =
            {
                { -10, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] ketQua = XoaDongCot.Xoa(a);

            int[,] mongDoi =
            {
                { 5, 6 },
                { 8, 9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MinNamOOCuoi()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, -10 }
            };

            int[,] ketQua = XoaDongCot.Xoa(a);

            int[,] mongDoi =
            {
                { 1, 2 },
                { 4, 5 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MaTran2x2()
        {
            int[,] a =
            {
                { 5, 2 },
                { 3, 4 }
            };

            int[,] ketQua = XoaDongCot.Xoa(a);

            int[,] mongDoi =
            {
                { 3 }
            };

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
