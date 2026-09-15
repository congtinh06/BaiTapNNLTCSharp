using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestSapXepDongNguyenTo
    {
        [Fact]
        public void Test_SapXepDongNguyenTo()
        {
            int[,] a =
            {
                { 2, 3, 4, 5 },
                { 1, 4, 6, 8 },
                { 7, 9, 11, 2 },
                { 10, 12, 14, 16 }
            };

            int[,] ketQua = SapXepDongNguyenTo.SapXep(a);

            int[,] mongDoi =
            {
                { 2, 3, 4, 5 },
                { 7, 9, 11, 2 },
                { 1, 4, 6, 8 },
                { 10, 12, 14, 16 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_DemSoNguyenTo()
        {
            int[,] a =
            {
                { 2, 3, 4, 5 },
                { 1, 4, 6, 8 },
                { 7, 9, 11, 2 }
            };

            Assert.Equal(3, SapXepDongNguyenTo.DemSoNguyenTo(a, 0));
            Assert.Equal(0, SapXepDongNguyenTo.DemSoNguyenTo(a, 1));
            Assert.Equal(3, SapXepDongNguyenTo.DemSoNguyenTo(a, 2));
        }

        [Fact]
        public void Test_TatCaDongKhongCoSoNguyenTo()
        {
            int[,] a =
            {
                { 1, 4, 6, 8 },
                { 9, 10, 12, 14 },
                { 15, 16, 18, 20 }
            };

            int[,] ketQua = SapXepDongNguyenTo.SapXep(a);

            int[,] mongDoi =
            {
                { 1, 4, 6, 8 },
                { 9, 10, 12, 14 },
                { 15, 16, 18, 20 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_MaTran1Dong()
        {
            int[,] a =
            {
                { 2, 4, 6, 7, 9 }
            };

            int[,] ketQua = SapXepDongNguyenTo.SapXep(a);

            int[,] mongDoi =
            {
                { 2, 4, 6, 7, 9 }
            };

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
