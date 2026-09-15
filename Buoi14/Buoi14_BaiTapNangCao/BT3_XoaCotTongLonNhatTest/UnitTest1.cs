using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestXoaCotTongLonNhat
    {
        [Fact]
        public void Test_XoaCotCoTongLonNhat()
        {
            double[,] a =
            {
                { 1, 2, 10 },
                { 3, 4, 5 },
                { 2, 6, 7 }
            };

            double[,] ketQua = XoaCotTongLonNhat.Xoa(a);

            double[,] mongDoi =
            {
                { 1, 2 },
                { 3, 4 },
                { 2, 6 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_XoaNhieuCotCoCungTongLonNhat()
        {
            double[,] a =
            {
                { 1, 2, 3 },
                { 4, 3, 2 }
            };

            double[,] ketQua = XoaCotTongLonNhat.Xoa(a);

            double[,] mongDoi = new double[2, 0];

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_SoThuc()
        {
            double[,] a =
            {
                { 1.5, 2.5, 4.0 },
                { 2.5, 1.5, 3.0 }
            };

            double[,] ketQua = XoaCotTongLonNhat.Xoa(a);

            double[,] mongDoi =
            {
                { 1.5, 2.5 },
                { 2.5, 1.5 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_TatCaCotCoCungTong()
        {
            double[,] a =
            {
                { 1, 2, 3 },
                { 3, 2, 1 }
            };

            double[,] ketQua = XoaCotTongLonNhat.Xoa(a);

            double[,] mongDoi = new double[2, 0];

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
