using Bai3_XoanOc;

namespace Bai3_XoanOcTests
{
    public class UnitTest1
    {
        // ==========================================================
        // TEST 1
        // n = 1
        //
        // 1
        // ==========================================================
        [Fact]
        public void XoanOc_N1()
        {
            int[,] ketQua = BT3.XoanOc(1);

            Assert.Equal(1, ketQua[0, 0]);
        }


        // ==========================================================
        // TEST 2
        // n = 2
        //
        // 1 2
        // 4 3
        // ==========================================================
        [Fact]
        public void XoanOc_N2()
        {
            int[,] ketQua = BT3.XoanOc(2);

            int[,] mongDoi =
            {
                { 1, 2 },
                { 4, 3 }
            };

            KiemTraMaTran(mongDoi, ketQua, 2);
        }


        // ==========================================================
        // TEST 3
        // n = 3
        //
        // 1 2 3
        // 8 9 4
        // 7 6 5
        // ==========================================================
        [Fact]
        public void XoanOc_N3()
        {
            int[,] ketQua = BT3.XoanOc(3);

            int[,] mongDoi =
            {
                { 1, 2, 3 },
                { 8, 9, 4 },
                { 7, 6, 5 }
            };

            KiemTraMaTran(mongDoi, ketQua, 3);
        }


        // ==========================================================
        // TEST 4
        // n = 4
        // ==========================================================
        [Fact]
        public void XoanOc_N4()
        {
            int[,] ketQua = BT3.XoanOc(4);

            int[,] mongDoi =
            {
                { 1,  2,  3,  4 },
                { 12, 13, 14, 5 },
                { 11, 16, 15, 6 },
                { 10, 9,  8,  7 }
            };

            KiemTraMaTran(mongDoi, ketQua, 4);
        }


        // ==========================================================
        // TEST 5
        // n = 5
        //
        // Đây chính là ví dụ trong đề.
        // ==========================================================
        [Fact]
        public void XoanOc_N5()
        {
            int[,] ketQua = BT3.XoanOc(5);

            int[,] mongDoi =
            {
                { 1,  2,  3,  4,  5 },
                { 16, 17, 18, 19, 6 },
                { 15, 24, 25, 20, 7 },
                { 14, 23, 22, 21, 8 },
                { 13, 12, 11, 10, 9 }
            };

            KiemTraMaTran(mongDoi, ketQua, 5);
        }


        // ==========================================================
        // TEST 6
        // n = 6
        // Kiểm tra các góc của ma trận.
        // ==========================================================
        [Fact]
        public void XoanOc_N6_KiemTraGoc()
        {
            int[,] ketQua = BT3.XoanOc(6);

            Assert.Equal(1, ketQua[0, 0]);
            Assert.Equal(6, ketQua[0, 5]);
            Assert.Equal(11, ketQua[5, 5]);
            Assert.Equal(16, ketQua[5, 0]);
        }


        // ==========================================================
        // TEST 7
        // Kiểm tra phần tử cuối cùng.
        //
        // Với mọi n:
        // Phần tử cuối cùng phải là n^2.
        // ==========================================================
        [Fact]
        public void XoanOc_PhanTuCuoi()
        {
            int n = 7;

            int[,] ketQua = BT3.XoanOc(n);

            Assert.Equal(
                n * n,
                ketQua[n / 2, n / 2]
            );
        }


        // ==========================================================
        // TEST 8
        // n = 8
        // Kiểm tra số đầu tiên.
        // ==========================================================
        [Fact]
        public void XoanOc_N8_SoDauTien()
        {
            int[,] ketQua = BT3.XoanOc(8);

            Assert.Equal(1, ketQua[0, 0]);
        }


        // ==========================================================
        // TEST 9
        // n = 10
        // Kiểm tra số cuối cùng nằm ở trung tâm.
        // ==========================================================
        [Fact]
        public void XoanOc_N10_KiemTraSoCuoi()
        {
            int[,] ketQua = BT3.XoanOc(10);

            // Với n chẵn, n^2 nằm tại một trong 4 ô
            // của vòng xoắn cuối.
            //
            // Kiểm tra toàn bộ ma trận có chứa n^2.
            bool timThay = false;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (ketQua[i, j] == 100)
                    {
                        timThay = true;
                    }
                }
            }

            Assert.True(timThay);
        }


        // ==========================================================
        // TEST 10
        // Kiểm tra ma trận có đầy đủ các số từ 1 -> n^2
        // và không bị trùng số.
        // ==========================================================
        [Fact]
        public void XoanOc_KhongTrungSo()
        {
            int n = 5;

            int[,] ketQua = BT3.XoanOc(n);

            bool[] daCo = new bool[n * n + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int x = ketQua[i, j];

                    Assert.True(
                        x >= 1 && x <= n * n
                    );

                    Assert.False(
                        daCo[x],
                        $"So {x} bi trung."
                    );

                    daCo[x] = true;
                }
            }

            // Tất cả các số từ 1 -> n^2 đều phải xuất hiện
            for (int x = 1; x <= n * n; x++)
            {
                Assert.True(daCo[x]);
            }
        }


        // ==========================================================
        // Hàm phụ dùng để so sánh 2 ma trận.
        // ==========================================================
        private void KiemTraMaTran(
            int[,] mongDoi,
            int[,] ketQua,
            int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Assert.Equal(
                        mongDoi[i, j],
                        ketQua[i, j]
                    );
                }
            }
        }
    }
}