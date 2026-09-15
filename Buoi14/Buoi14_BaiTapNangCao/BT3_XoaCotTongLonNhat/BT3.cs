namespace NNLTCSharp.Buoi14
{
    // Bài toán: xóa mọi cột có tổng lớn nhất.
    // 
    // Ý tưởng thuật toán:
    //   Tính tổng của từng cột, xác định tổng lớn nhất,
    //   rồi sao chép chỉ các cột còn lại sang ma trận kết quả.
    public class XoaCotTongLonNhat
    {
        // Hàm Xoa thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a.
        // Đầu ra: ma trận số thực sau khi xử lý.
        public static double[,] Xoa(double[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            double[] tongCot = new double[m];

            // Tính tổng từng cột
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    tongCot[j] += a[i, j];
                }
            }

            // Tìm tổng lớn nhất
            double tongLonNhat = tongCot[0];

            for (int j = 1; j < m; j++)
            {
                if (tongCot[j] > tongLonNhat)
                {
                    tongLonNhat = tongCot[j];
                }
            }

            // Đếm số cột không bị xóa
            int soCotConLai = 0;

            for (int j = 0; j < m; j++)
            {
                if (tongCot[j] != tongLonNhat)
                {
                    soCotConLai++;
                }
            }

            double[,] ketQua = new double[n, soCotConLai];

            int cotMoi = 0;

            // Sao chép những cột không có tổng lớn nhất
            for (int j = 0; j < m; j++)
            {
                if (tongCot[j] == tongLonNhat)
                {
                    continue;
                }

                for (int i = 0; i < n; i++)
                {
                    ketQua[i, cotMoi] = a[i, j];
                }

                cotMoi++;
            }

            return ketQua;
        }
    }
}
