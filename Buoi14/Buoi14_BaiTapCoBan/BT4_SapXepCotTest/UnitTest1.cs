using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestSapXepCot
    {
        [Fact]
        public void Test_SapXepCot()
        {
            int[,] a =
            {
                { 8, 1, 3, 5, 4, 2 },
                { 9, 3, 9, 1, 9, 7 },
                { 2, 4, 2, 6, 6, 3 },
                { 6, 7, 3, 2, 2, 9 }
            };

            int[,] ketQua = SapXepCot.SapXep(a);

            int[,] mongDoi =
            {
                { 1, 3, 2, 5, 8, 4 },
                { 3, 9, 7, 1, 9, 9 },
                { 4, 2, 3, 6, 2, 6 },
                { 7, 3, 9, 2, 6, 2 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_CotKhongCoSoChan()
        {
            int[,] a =
            {
                { 1, 2, 5 },
                { 3, 4, 7 },
                { 5, 6, 9 }
            };

            int[,] ketQua = SapXepCot.SapXep(a);

            int[,] mongDoi =
            {
                { 1, 5, 2 },
                { 3, 7, 4 },
                { 5, 9, 6 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_CotToanSoChan()
        {
            int[,] a =
            {
                { 2, 1, 4 },
                { 6, 3, 8 },
                { 10, 5, 12 }
            };

            int[,] ketQua = SapXepCot.SapXep(a);

            int[,] mongDoi =
            {
                { 1, 2, 4 },
                { 3, 6, 8 },
                { 5, 10, 12 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_GiuNguyenThuTuKhiSoLuongSoChanBangNhau()
        {
            int[,] a =
            {
                { 2, 1, 4 },
                { 3, 5, 7 },
                { 6, 9, 8 }
            };

            int[,] ketQua = SapXepCot.SapXep(a);

            int[,] mongDoi =
            {
                { 1, 2, 4 },
                { 5, 3, 7 },
                { 9, 6, 8 }
            };

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
