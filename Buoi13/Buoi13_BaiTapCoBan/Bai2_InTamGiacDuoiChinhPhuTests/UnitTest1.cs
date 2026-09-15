using Bai2_InTamGiacDuoiChinhPhu;

namespace Bai2_InTamGiacDuoiChinhPhuTests
{
    public class UnitTest1
    {
        // ==================================================
        // Ma trận mẫu trong đề
        //
        // 5 5 5 0 0
        // 0 5 0 1 1
        // 0 5 0 0 0
        // 0 0 0 2 3
        // 1 1 1 4 7
        // ==================================================
        private double[,] TaoMaTranMau()
        {
            return new double[,]
            {
                { 5, 5, 5, 0, 0 },
                { 0, 5, 0, 1, 1 },
                { 0, 5, 0, 0, 0 },
                { 0, 0, 0, 2, 3 },
                { 1, 1, 1, 4, 7 }
            };
        }


        // ==================================================
        // TEST 1
        // Tam giác dưới đường chéo chính theo ví dụ đề
        //
        // Điều kiện:
        // i > j
        //
        // Kết quả:
        // 0 0 5 0 0 0 1 1 1 4
        // ==================================================
        [Fact]
        public void TamGiacDuoiCheoChinh_TheoDe()
        {
            double[,] a = TaoMaTranMau();

            List<double> ketQua =
                BT2.TamGiacDuoiCheoChinh(a, 5);

            double[] mongDoi =
            {
                0, 0, 5,
                0, 0, 0,
                1, 1, 1, 4
            };

            Assert.Equal(mongDoi, ketQua);
        }


        // ==================================================
        // TEST 2
        // Tam giác dưới đường chéo phụ theo điều kiện toán học
        //
        // Điều kiện:
        // i + j > n - 1
        //
        // Kết quả:
        // 1 0 0 0 2 3 1 1 4 7
        // ==================================================
        [Fact]
        public void TamGiacDuoiCheoPhu_TheoDe()
        {
            double[,] a = TaoMaTranMau();

            List<double> ketQua =
                BT2.TamGiacDuoiCheoPhu(a, 5);

            double[] mongDoi =
            {
                1,
                0, 0,
                0, 2, 3,
                1, 1, 4, 7
            };

            Assert.Equal(mongDoi, ketQua);
        }


        // ==================================================
        // TEST 3
        // Ma trận 1x1
        //
        // Không có phần tử nào nằm dưới chéo chính
        // ==================================================
        [Fact]
        public void TamGiacDuoiCheoChinh_MaTran1x1()
        {
            double[,] a =
            {
                { 5 }
            };

            List<double> ketQua =
                BT2.TamGiacDuoiCheoChinh(a, 1);

            Assert.Empty(ketQua);
        }


        // ==================================================
        // TEST 4
        // Ma trận 1x1
        //
        // Không có phần tử nào nằm dưới chéo phụ
        // ==================================================
        [Fact]
        public void TamGiacDuoiCheoPhu_MaTran1x1()
        {
            double[,] a =
            {
                { 5 }
            };

            List<double> ketQua =
                BT2.TamGiacDuoiCheoPhu(a, 1);

            Assert.Empty(ketQua);
        }


        // ==================================================
        // TEST 5
        // Ma trận 3x3
        //
        // 1 2 3
        // 4 5 6
        // 7 8 9
        //
        // Dưới chéo chính:
        // 4 7 8
        // ==================================================
        [Fact]
        public void TamGiacDuoiCheoChinh_MaTran3x3()
        {
            double[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            List<double> ketQua =
                BT2.TamGiacDuoiCheoChinh(a, 3);

            double[] mongDoi =
            {
                4,
                7, 8
            };

            Assert.Equal(mongDoi, ketQua);
        }


        // ==================================================
        // TEST 6
        // Ma trận 3x3
        //
        // 1 2 3
        // 4 5 6
        // 7 8 9
        //
        // Dưới chéo phụ:
        // 6 8 9
        // ==================================================
        [Fact]
        public void TamGiacDuoiCheoPhu_MaTran3x3()
        {
            double[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            List<double> ketQua =
                BT2.TamGiacDuoiCheoPhu(a, 3);

            double[] mongDoi =
            {
                6,
                8, 9
            };

            Assert.Equal(mongDoi, ketQua);
        }


        // ==================================================
        // TEST 7
        // Kiểm tra ma trận số thực
        //
        // 1.5 2.5 3.5
        // 4.5 5.5 6.5
        // 7.5 8.5 9.5
        //
        // Dưới chéo chính:
        // 4.5 7.5 8.5
        // ==================================================
        [Fact]
        public void TamGiacDuoiCheoChinh_SoThuc()
        {
            double[,] a =
            {
                { 1.5, 2.5, 3.5 },
                { 4.5, 5.5, 6.5 },
                { 7.5, 8.5, 9.5 }
            };

            List<double> ketQua =
                BT2.TamGiacDuoiCheoChinh(a, 3);

            double[] mongDoi =
            {
                4.5,
                7.5, 8.5
            };

            Assert.Equal(mongDoi, ketQua);
        }


        // ==================================================
        // TEST 8
        // Kiểm tra không lấy phần tử trên chéo chính
        //
        // 1 2
        // 3 4
        //
        // Chéo chính: 1 4
        // Dưới chéo chính chỉ có: 3
        // ==================================================
        [Fact]
        public void TamGiacDuoiCheoChinh_KhongLayCheoChinh()
        {
            double[,] a =
            {
                { 1, 2 },
                { 3, 4 }
            };

            List<double> ketQua =
                BT2.TamGiacDuoiCheoChinh(a, 2);

            double[] mongDoi =
            {
                3
            };

            Assert.Equal(mongDoi, ketQua);
        }


        // ==================================================
        // TEST 9
        // Kiểm tra không lấy phần tử trên chéo phụ
        //
        // 1 2
        // 3 4
        //
        // Chéo phụ: 2 3
        // Dưới chéo phụ chỉ có: 4
        // ==================================================
        [Fact]
        public void TamGiacDuoiCheoPhu_KhongLayCheoPhu()
        {
            double[,] a =
            {
                { 1, 2 },
                { 3, 4 }
            };

            List<double> ketQua =
                BT2.TamGiacDuoiCheoPhu(a, 2);

            double[] mongDoi =
            {
                4
            };

            Assert.Equal(mongDoi, ketQua);
        }


        // ==================================================
        // TEST 10
        // Ma trận toàn số 0
        //
        // 0 0 0
        // 0 0 0
        // 0 0 0
        //
        // Dưới chéo chính có 3 phần tử
        // Dưới chéo phụ cũng có 3 phần tử
        // ==================================================
        [Fact]
        public void TamGiacDuoiHaiCheo_MaTranToan0()
        {
            double[,] a =
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            List<double> ketQuaChinh =
                BT2.TamGiacDuoiCheoChinh(a, 3);

            List<double> ketQuaPhu =
                BT2.TamGiacDuoiCheoPhu(a, 3);

            // Có 3 phần tử dưới mỗi đường chéo
            Assert.Equal(3, ketQuaChinh.Count);
            Assert.Equal(3, ketQuaPhu.Count);

            // Tất cả đều bằng 0
            Assert.All(
                ketQuaChinh,
                x => Assert.Equal(0, x)
            );

            Assert.All(
                ketQuaPhu,
                x => Assert.Equal(0, x)
            );
        }
    }
}