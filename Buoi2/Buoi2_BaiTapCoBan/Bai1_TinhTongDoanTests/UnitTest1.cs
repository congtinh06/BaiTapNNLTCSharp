using Xunit;
using TongDoan;

namespace Bai1_TinhTongDoan.Tests
{
    public class TinhTongDoanTests
    {
        [Fact]
        public void TinhTong_TuBaDenNam_TraVe12()
        {
            // Arrange
            int a = 3, b = 5;

            // Act
            long ketQua = Program.TinhTongDoan(a, b);

            // Assert
            Assert.Equal(12, ketQua); // 3+4+5 = 12
        }

        [Fact]
        public void TinhTong_ABangB_TraVeChinhSoDo()
        {
            long ketQua = Program.TinhTongDoan(7, 7);
            Assert.Equal(7, ketQua);
        }

        [Theory]
        [InlineData(1, 10, 55)]
        [InlineData(1, 100, 5050)]
        [InlineData(-3, 3, 0)]
        public void TinhTong_NhieuTruongHop(int a, int b, long ketQuaMongMuon)
        {
            long ketQua = Program.TinhTongDoan(a, b);
            Assert.Equal(ketQuaMongMuon, ketQua);
        }
    }
}
