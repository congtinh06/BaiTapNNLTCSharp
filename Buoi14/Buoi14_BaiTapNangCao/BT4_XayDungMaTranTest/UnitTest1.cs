using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestXayDungMaTran
    {
        [Fact]
        public void Test_XoaDongCotChuaGiaTriTuyetDoiLonNhat()
        {
            double[,] a =
            {
                { 1, -2, 3 },
                { 4, 5, -9 },
                { 7, 8, 6 }
            };

            double[,] ketQua = XayDungMaTran.XayDung(a);

            double[,] mongDoi =
            {
                { 1, -2 },
                { 7, 8 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_GiaTriAmCoTriTuyetDoiLonNhat()
        {
            double[,] a =
            {
                { 1, 2, 3 },
                { 4, -10, 6 },
                { 7, 8, 9 }
            };

            double[,] ketQua = XayDungMaTran.XayDung(a);

            double[,] mongDoi =
            {
                { 1, 3 },
                { 7, 9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_PhanTuLonNhatNamOocGoc()
        {
            double[,] a =
            {
                { -20, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            double[,] ketQua = XayDungMaTran.XayDung(a);

            double[,] mongDoi =
            {
                { 5, 6 },
                { 8, 9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MaTran2x2()
        {
            double[,] a =
            {
                { 1, -5 },
                { 3, 4 }
            };

            double[,] ketQua = XayDungMaTran.XayDung(a);

            double[,] mongDoi =
            {
                { 3 }
            };

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
