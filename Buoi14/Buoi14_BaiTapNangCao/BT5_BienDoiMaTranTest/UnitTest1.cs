using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestBienDoiMaTran
    {
        [Fact]
        public void Test_DuaMinXuongGocDuoiPhai()
        {
            double[,] a =
            {
                { 1, 8, 3 },
                { 7, 5, -9 },
                { 4, 2, 6 }
            };

            double[,] ketQua = BienDoiMaTran.BienDoi(a);

            double[,] mongDoi =
            {
                { 1, 8, 3 },
                { 4, 2, 6 },
                { 7, 5, -9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MinNamOCanhTrai()
        {
            double[,] a =
            {
                { 1, 8, 3 },
                { 4, 5, 6 },
                { -9, 2, 7 }
            };

            double[,] ketQua = BienDoiMaTran.BienDoi(a);

            double[,] mongDoi =
            {
                { 3, 8, 1 },
                { 6, 5, 4 },
                { 7, 2, -9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MinNamOCanhDuoi()
        {
            double[,] a =
            {
                { 1, 8, 3 },
                { 4, 2, 6 },
                { 7, -9, 5 }
            };

            double[,] ketQua = BienDoiMaTran.BienDoi(a);

            double[,] mongDoi =
            {
                { 1, 3, 8 },
                { 4, 6, 2 },
                { 7, 5, -9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MaTran1x1()
        {
            double[,] a =
            {
                { -5 }
            };

            double[,] ketQua = BienDoiMaTran.BienDoi(a);

            double[,] mongDoi =
            {
                { -5 }
            };

            Assert.Equal(mongDoi, ketQua);
        }
    }
}

