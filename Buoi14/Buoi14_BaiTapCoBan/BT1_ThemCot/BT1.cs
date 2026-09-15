namespace NNLTCSharp.Buoi14
{
    // Bài toán: chèn mảng b thành một cột của ma trận tại vị trí k.
    // 
    // Ý tưởng thuật toán:
    //   Tạo ma trận có thêm một cột; sao chép cột trước k, chèn b ở cột k,
    //   và dịch các cột còn lại sang phải.
    public class ThemCot
    {
        // Hàm Them thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a; mảng đầu vào b; giá trị vị trí/số bước k.
        // Đầu ra: ma trận số thực sau khi xử lý.
        public static double[,] Them(double[,] a, double[] b, int k)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            double[,] ketQua = new double[n, m + 1];

            // Sao chép từng hàng; tại cột k chèn giá trị từ mảng b và dịch các cột sau sang phải.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    if (j < k)
                    {
                        ketQua[i, j] = a[i, j];
                    }
                    else if (j == k)
                    {
                        ketQua[i, j] = b[i];
                    }
                    else
                    {
                        ketQua[i, j] = a[i, j - 1];
                    }
                }
            }

            return ketQua;
        }
    }
}
