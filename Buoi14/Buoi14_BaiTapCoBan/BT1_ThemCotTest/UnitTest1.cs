using Xunit;
using NNLTCSharp.Buoi14;

namespace NNLTCSharp.Tests
{
    public class UnitTestThemCot
    {
        [Fact]
        public void Test_ThemCot()
        {
            double[,] a =
            {
                { 1.2, -3.4, 5.6, -8.9, 4.3, 2.6 },
                { 3.7, -9.2, 1.8, -3.4, 9.2, 7.5 },
                { 4.5, -2.6, 6.3, -2.1, 6.2, 3.1 },
                { 7.1, -3.1, 2.4, -6.2, 2.4, 9.2 }
            };

            double[] b = { 8.1, 8.2, 8.3, 8.4 };

            double[,] ketQua = ThemCot.Them(a, b, 2);

            double[,] mongDoi =
            {
                { 1.2, -3.4, 8.1, 5.6, -8.9, 4.3, 2.6 },
                { 3.7, -9.2, 8.2, 1.8, -3.4, 9.2, 7.5 },
                { 4.5, -2.6, 8.3, 6.3, -2.1, 6.2, 3.1 },
                { 7.1, -3.1, 8.4, 2.4, -6.2, 2.4, 9.2 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_ThemCotDau()
        {
            double[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            double[] b = { 7, 8 };

            double[,] ketQua = ThemCot.Them(a, b, 0);

            double[,] mongDoi =
            {
                { 7, 1, 2, 3 },
                { 8, 4, 5, 6 }
            };

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void Test_ThemCotCuoi()
        {
            double[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            double[] b = { 7, 8 };

            double[,] ketQua = ThemCot.Them(a, b, 2);

            double[,] mongDoi =
            {
                { 1, 2, 7, 3 },
                { 4, 5, 8, 6 }
            };

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
