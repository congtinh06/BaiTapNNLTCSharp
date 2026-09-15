using Bai5_InCacCheoTheoHinh;

namespace Bai5_InCacCheoTheoHinhTests
{
    public class UnitTest1
    {
        // ==================================================
        // Ma trận mẫu trong đề
        //
        //  1   2   3   4   5
        //  6   7   8   9  10
        // 11  12  13  14  15
        // 16  17  18  19  20
        // 21  22  23  24  25
        // ==================================================
        private int[,] TaoMaTranMau()
        {
            return new int[,]
            {
                { 1,  2,  3,  4,  5  },
                { 6,  7,  8,  9,  10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };
        }


        // ==================================================
        // TEST 1
        // Kiểm tra toàn bộ các đường chéo phụ
        // theo đúng ví dụ trong đề.
        // ==================================================
        [Fact]
        public void LayCacCheoPhu_TheoDe()
        {
            int[,] a = TaoMaTranMau();

            List<List<int>> ketQua =
                BT5.LayCacCheoPhu(a, 5);

            Assert.Equal(9, ketQua.Count);

            Assert.Equal(
                new int[] { 1 },
                ketQua[0]
            );

            Assert.Equal(
                new int[] { 2, 6 },
                ketQua[1]
            );

            Assert.Equal(
                new int[] { 11, 7, 3 },
                ketQua[2]
            );

            Assert.Equal(
                new int[] { 4, 8, 12, 16 },
                ketQua[3]
            );

            Assert.Equal(
                new int[] { 21, 17, 13, 9, 5 },
                ketQua[4]
            );

            Assert.Equal(
                new int[] { 10, 14, 18, 22 },
                ketQua[5]
            );

            Assert.Equal(
                new int[] { 23, 19, 15 },
                ketQua[6]
            );

            Assert.Equal(
                new int[] { 20, 24 },
                ketQua[7]
            );

            Assert.Equal(
                new int[] { 25 },
                ketQua[8]
            );
        }


        // ==================================================
        // TEST 2
        // Kiểm tra toàn bộ các đường chéo chính
        // theo đúng ví dụ trong đề.
        // ==================================================
        [Fact]
        public void LayCacCheoChinh_TheoDe()
        {
            int[,] a = TaoMaTranMau();

            List<List<int>> ketQua =
                BT5.LayCacCheoChinh(a, 5);

            Assert.Equal(9, ketQua.Count);

            Assert.Equal(
                new int[] { 5 },
                ketQua[0]
            );

            Assert.Equal(
                new int[] { 10, 4 },
                ketQua[1]
            );

            Assert.Equal(
                new int[] { 3, 9, 15 },
                ketQua[2]
            );

            Assert.Equal(
                new int[] { 20, 14, 8, 2 },
                ketQua[3]
            );

            Assert.Equal(
                new int[] { 1, 7, 13, 19, 25 },
                ketQua[4]
            );

            Assert.Equal(
                new int[] { 24, 18, 12, 6 },
                ketQua[5]
            );

            Assert.Equal(
                new int[] { 11, 17, 23 },
                ketQua[6]
            );

            Assert.Equal(
                new int[] { 22, 16 },
                ketQua[7]
            );

            Assert.Equal(
                new int[] { 21 },
                ketQua[8]
            );
        }


        // ==================================================
        // TEST 3
        // Ma trận 1x1
        //
        // Chéo phụ: [1]
        // Chéo chính: [1]
        // ==================================================
        [Fact]
        public void LayCacCheo_MaTran1x1()
        {
            int[,] a =
            {
                { 1 }
            };

            List<List<int>> cheoPhu =
                BT5.LayCacCheoPhu(a, 1);

            List<List<int>> cheoChinh =
                BT5.LayCacCheoChinh(a, 1);

            Assert.Single(cheoPhu);
            Assert.Single(cheoChinh);

            Assert.Equal(
                new int[] { 1 },
                cheoPhu[0]
            );

            Assert.Equal(
                new int[] { 1 },
                cheoChinh[0]
            );
        }


        // ==================================================
        // TEST 4
        // Ma trận 2x2
        //
        // 1 2
        // 3 4
        //
        // Chéo phụ:
        // [1]
        // [2, 3]
        // [4]
        // ==================================================
        [Fact]
        public void LayCacCheoPhu_MaTran2x2()
        {
            int[,] a =
            {
                { 1, 2 },
                { 3, 4 }
            };

            List<List<int>> ketQua =
                BT5.LayCacCheoPhu(a, 2);

            Assert.Equal(3, ketQua.Count);

            Assert.Equal(
                new int[] { 1 },
                ketQua[0]
            );

            Assert.Equal(
                new int[] { 2, 3 },
                ketQua[1]
            );

            Assert.Equal(
                new int[] { 4 },
                ketQua[2]
            );
        }


        // ==================================================
        // TEST 5
        // Ma trận 2x2
        //
        // Chéo chính:
        // [2]
        // [4, 1]
        // [3]
        //
        // Theo thứ tự trong hình:
        // [2], [1, 4], [3]
        // ==================================================
        [Fact]
        public void LayCacCheoChinh_MaTran2x2()
        {
            int[,] a =
            {
                { 1, 2 },
                { 3, 4 }
            };

            List<List<int>> ketQua =
                BT5.LayCacCheoChinh(a, 2);

            Assert.Equal(3, ketQua.Count);

            Assert.Equal(
                new int[] { 2 },
                ketQua[0]
            );

            Assert.Equal(
                new int[] { 4, 1 },
                ketQua[1]
            );

            Assert.Equal(
                new int[] { 3 },
                ketQua[2]
            );
        }


        // ==================================================
        // TEST 6
        // Ma trận 3x3
        //
        // Kiểm tra số lượng đường chéo.
        //
        // Ma trận n x n luôn có:
        // 2n - 1 đường chéo
        //
        // n = 3 => 5 đường
        // ==================================================
        [Fact]
        public void LayCacCheo_SoLuongDuongCheo()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            List<List<int>> cheoPhu =
                BT5.LayCacCheoPhu(a, 3);

            List<List<int>> cheoChinh =
                BT5.LayCacCheoChinh(a, 3);

            Assert.Equal(5, cheoPhu.Count);
            Assert.Equal(5, cheoChinh.Count);
        }


        // ==================================================
        // TEST 7
        // Kiểm tra chéo phụ ma trận 3x3
        //
        // 1 2 3
        // 4 5 6
        // 7 8 9
        //
        // Kết quả:
        // [1]
        // [2,4]
        // [7,5,3]
        // [6,8]
        // [9]
        // ==================================================
        [Fact]
        public void LayCacCheoPhu_MaTran3x3()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            List<List<int>> ketQua =
                BT5.LayCacCheoPhu(a, 3);

            Assert.Equal(
                new int[] { 1 },
                ketQua[0]
            );

            Assert.Equal(
                new int[] { 2, 4 },
                ketQua[1]
            );

            Assert.Equal(
                new int[] { 7, 5, 3 },
                ketQua[2]
            );

            Assert.Equal(
                new int[] { 6, 8 },
                ketQua[3]
            );

            Assert.Equal(
                new int[] { 9 },
                ketQua[4]
            );
        }


        // ==================================================
        // TEST 8
        // Kiểm tra chéo chính ma trận 3x3
        //
        // Kết quả:
        // [3]
        // [6,2]
        // [1,5,9]
        // [8,4]
        // [7]
        // ==================================================
        [Fact]
        public void LayCacCheoChinh_MaTran3x3()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            List<List<int>> ketQua =
                BT5.LayCacCheoChinh(a, 3);

            Assert.Equal(
                new int[] { 3 },
                ketQua[0]
            );

            Assert.Equal(
                new int[] { 6, 2 },
                ketQua[1]
            );

            Assert.Equal(
                new int[] { 1, 5, 9 },
                ketQua[2]
            );

            Assert.Equal(
                new int[] { 8, 4 },
                ketQua[3]
            );

            Assert.Equal(
                new int[] { 7 },
                ketQua[4]
            );
        }


        // ==================================================
        // TEST 9
        // Ma trận toàn số 0
        //
        // Kiểm tra vẫn lấy đủ 2n - 1 đường.
        // ==================================================
        [Fact]
        public void LayCacCheo_MaTranToan0()
        {
            int[,] a =
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            List<List<int>> cheoPhu =
                BT5.LayCacCheoPhu(a, 3);

            List<List<int>> cheoChinh =
                BT5.LayCacCheoChinh(a, 3);

            Assert.Equal(5, cheoPhu.Count);
            Assert.Equal(5, cheoChinh.Count);

            // Kiểm tra tất cả phần tử đều bằng 0
            foreach (List<int> duong in cheoPhu)
            {
                Assert.All(
                    duong,
                    x => Assert.Equal(0, x)
                );
            }

            foreach (List<int> duong in cheoChinh)
            {
                Assert.All(
                    duong,
                    x => Assert.Equal(0, x)
                );
            }
        }


        // ==================================================
        // TEST 10
        // Kiểm tra ma trận 4x4
        //
        // Đảm bảo mỗi phần tử của ma trận
        // xuất hiện đúng một lần trong tập các đường chéo.
        // ==================================================
        [Fact]
        public void LayCacCheo_MaTran4x4_Du9DuongCheo()
        {
            int[,] a =
            {
                { 1,  2,  3,  4 },
                { 5,  6,  7,  8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            List<List<int>> cheoPhu =
                BT5.LayCacCheoPhu(a, 4);

            List<List<int>> cheoChinh =
                BT5.LayCacCheoChinh(a, 4);

            // n = 4 => 2n - 1 = 7 đường
            Assert.Equal(7, cheoPhu.Count);
            Assert.Equal(7, cheoChinh.Count);

            // Tổng số phần tử của tất cả đường chéo
            // phải bằng n * n = 16
            int tongPhu = 0;

            foreach (List<int> duong in cheoPhu)
            {
                tongPhu += duong.Count;
            }

            int tongChinh = 0;

            foreach (List<int> duong in cheoChinh)
            {
                tongChinh += duong.Count;
            }

            Assert.Equal(16, tongPhu);
            Assert.Equal(16, tongChinh);
        }
    }
}