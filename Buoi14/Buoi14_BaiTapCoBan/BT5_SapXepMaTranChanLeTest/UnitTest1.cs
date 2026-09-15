using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestSapXepMaTranChanLe
    {
        [Fact]
        public void Test_SapXepMaTranChanLe()
        {
            int[,] a =
            {
                { 8, 1, 3, 5, 4, 2 },
                { 9, 3, 9, 1, 9, 7 },
                { 2, 4, 2, 6, 6, 3 },
                { 6, 7, 3, 2, 2, 9 }
            };

            int[,] ketQua = SapXepMaTranChanLe.SapXep(a);

            int[,] mongDoi =
            {
                { 8, 4, 2, 2, 4, 2 },
                { 6, 6, 6, 2, 2, 1 },
                { 3, 5, 9, 3, 9, 1 },
                { 9, 7, 3, 7, 3, 9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_ToanSoChan()
        {
            int[,] a =
            {
                { 2, 4 },
                { 6, 8 }
            };

            int[,] ketQua = SapXepMaTranChanLe.SapXep(a);

            int[,] mongDoi =
            {
                { 2, 4 },
                { 6, 8 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_ToanSoLe()
        {
            int[,] a =
            {
                { 1, 3 },
                { 5, 7 }
            };

            int[,] ketQua = SapXepMaTranChanLe.SapXep(a);

            int[,] mongDoi =
            {
                { 1, 3 },
                { 5, 7 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_ChanLeXenKe()
        {
            int[,] a =
            {
                { 1, 2 },
                { 3, 4 }
            };

            int[,] ketQua = SapXepMaTranChanLe.SapXep(a);

            int[,] mongDoi =
            {
                { 2, 4 },
                { 1, 3 }
            };

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
