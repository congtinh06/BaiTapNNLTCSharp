using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestQuayMaTran
    {
        [Fact]
        public void Test_QuayMaTran()
        {
            int[,] a =
            {
                { 1, 2, 3, 4, 5 },
                { 9, 9, 9, 9, 9 },
                { 7, 7, 7, 7, 7 },
                { 8, 8, 8, 8, 8 },
                { 5, 5, 5, 5, 5 }
            };

            int[,] ketQua = QuayMaTran.Quay90Do(a);

            int[,] mongDoi =
            {
                { 5, 8, 7, 9, 1 },
                { 5, 8, 7, 9, 2 },
                { 5, 8, 7, 9, 3 },
                { 5, 8, 7, 9, 4 },
                { 5, 8, 7, 9, 5 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MaTran2x2()
        {
            int[,] a =
            {
                { 1, 2 },
                { 3, 4 }
            };

            int[,] ketQua = QuayMaTran.Quay90Do(a);

            int[,] mongDoi =
            {
                { 3, 1 },
                { 4, 2 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MaTran3x3()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] ketQua = QuayMaTran.Quay90Do(a);

            int[,] mongDoi =
            {
                { 7, 4, 1 },
                { 8, 5, 2 },
                { 9, 6, 3 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MaTran1x1()
        {
            int[,] a =
            {
                { 5 }
            };

            int[,] ketQua = QuayMaTran.Quay90Do(a);

            int[,] mongDoi =
            {
                { 5 }
            };

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
