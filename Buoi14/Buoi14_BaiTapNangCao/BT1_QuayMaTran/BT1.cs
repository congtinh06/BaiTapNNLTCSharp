namespace NNLTCSharp.Buoi14
{
    // Bài toán: quay ma trận vuông 90 độ theo chiều kim đồng hồ.
    // 
    // Ý tưởng thuật toán:
    //   Mỗi phần tử ở vị trí cũ được ánh xạ sang vị trí mới theo chỉ số
    //   ketQua[i, j] = a[n - 1 - j, i].
    public class QuayMaTran
    {
        // Hàm Quay90Do thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a.
        // Đầu ra: ma trận số nguyên sau khi xử lý.
        public static int[,] Quay90Do(int[,] a)
        {
            int n = a.GetLength(0);

            int[,] ketQua = new int[n, n];

            // Ánh xạ mỗi phần tử sang vị trí mới theo quy tắc quay ma trận 90 độ theo chiều kim đồng hồ.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ketQua[i, j] = a[n - 1 - j, i];
                }
            }

            return ketQua;
        }
    }
}
