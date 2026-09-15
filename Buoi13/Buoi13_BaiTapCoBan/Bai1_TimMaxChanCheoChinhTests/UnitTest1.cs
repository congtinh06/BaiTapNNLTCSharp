using Bai1_TimMaxChanCheoChinh;

namespace Bai1_TimMaxChanCheoChinhTests
{
    public class UnitTest1
    {
        // --------------------------------------------------
        // TEST 1:
        // Đúng theo ví dụ trong đề
        //
        // Đường chéo chính:
        // 5 5 0 2 7
        //
        // Số chẵn:
        // 0 2
        //
        // Kết quả = 2
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_TheoViDu_TraVe2()
        {
            int[,] a =
            {
                { 5, 5, 5, 0, 0 },
                { 0, 5, 0, 1, 1 },
                { 0, 5, 0, 0, 0 },
                { 0, 0, 0, 2, 3 },
                { 1, 1, 1, 4, 7 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 5);

            Assert.Equal(2, ketQua);
        }


        // --------------------------------------------------
        // TEST 2:
        // Đường chéo chính toàn số chẵn
        //
        // 2  1  3
        // 4  6  5
        // 7  8  10
        //
        // Đường chéo:
        // 2 6 10
        //
        // Kết quả = 10
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_ToanSoChan_TraVe10()
        {
            int[,] a =
            {
                { 2, 1, 3 },
                { 4, 6, 5 },
                { 7, 8, 10 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 3);

            Assert.Equal(10, ketQua);
        }


        // --------------------------------------------------
        // TEST 3:
        // Đường chéo chính toàn số lẻ
        //
        // 1 2 3
        // 4 5 6
        // 7 8 9
        //
        // Đường chéo:
        // 1 5 9
        //
        // Không có số chẵn
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_ToanSoLe_TraVeNull()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 3);

            Assert.Null(ketQua);
        }


        // --------------------------------------------------
        // TEST 4:
        // Có số 0 trên đường chéo
        //
        // 0 1 2
        // 3 5 6
        // 7 8 9
        //
        // Đường chéo:
        // 0 5 9
        //
        // Số chẵn lớn nhất = 0
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_CoSo0_TraVe0()
        {
            int[,] a =
            {
                { 0, 1, 2 },
                { 3, 5, 6 },
                { 7, 8, 9 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 3);

            Assert.Equal(0, ketQua);
        }


        // --------------------------------------------------
        // TEST 5:
        // Có số âm
        //
        // Đường chéo:
        // -10 -4 8
        //
        // Số chẵn lớn nhất = 8
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_CoSoAm_TraVe8()
        {
            int[,] a =
            {
                { -10, 1, 2 },
                { 3, -4, 5 },
                { 6, 7, 8 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 3);

            Assert.Equal(8, ketQua);
        }


        // --------------------------------------------------
        // TEST 6:
        // Giá trị chẵn lớn nhất nằm ở đầu
        //
        // Đường chéo:
        // 20 8 6
        //
        // Kết quả = 20
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_LonNhatNamDau_TraVe20()
        {
            int[,] a =
            {
                { 20, 1, 2 },
                { 3, 8, 5 },
                { 6, 7, 6 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 3);

            Assert.Equal(20, ketQua);
        }


        // --------------------------------------------------
        // TEST 7:
        // Giá trị chẵn lớn nhất nằm ở cuối
        //
        // Đường chéo:
        // 2 4 100
        //
        // Kết quả = 100
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_LonNhatNamCuoi_TraVe100()
        {
            int[,] a =
            {
                { 2, 1, 3 },
                { 4, 4, 5 },
                { 6, 7, 100 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 3);

            Assert.Equal(100, ketQua);
        }


        // --------------------------------------------------
        // TEST 8:
        // Ma trận cấp 1
        //
        // 8
        //
        // Kết quả = 8
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_MaTranCap1_TraVe8()
        {
            int[,] a =
            {
                { 8 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 1);

            Assert.Equal(8, ketQua);
        }


        // --------------------------------------------------
        // TEST 9:
        // Các giá trị chẵn đều âm
        //
        // Đường chéo:
        // -2 -4 -6
        //
        // Số lớn nhất là -2
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_TatCaSoChanAm_TraVeAm2()
        {
            int[,] a =
            {
                { -2, 1, 3 },
                { 4, -4, 5 },
                { 6, 7, -6 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 3);

            Assert.Equal(-2, ketQua);
        }


        // --------------------------------------------------
        // TEST 10:
        // Đường chéo có cả số lẻ và số chẵn
        //
        // Đường chéo:
        // 11 14 7 20
        //
        // Số chẵn:
        // 14 20
        //
        // Kết quả = 20
        // --------------------------------------------------
        [Fact]
        public void TimMaxChan_NhieuSoChan_TraVe20()
        {
            int[,] a =
            {
                { 11, 1, 2, 3 },
                { 4, 14, 5, 6 },
                { 7, 8, 7, 9 },
                { 10, 11, 12, 20 }
            };

            int? ketQua = BT1.TimMaxChanCheoChinh(a, 4);

            Assert.Equal(20, ketQua);
        }
    }
}