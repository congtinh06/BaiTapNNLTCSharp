namespace NNLTCSharp.Buoi14
{
    // Bài toán: xóa dòng và cột chứa phần tử nhỏ nhất của ma trận.
    // 
    // Ý tưởng thuật toán:
    //   Tìm vị trí phần tử nhỏ nhất, sau đó sao chép các phần tử
    //   không thuộc dòng và cột đó vào ma trận kết quả.
    public class XoaDongCot
    {
        // Hàm Xoa thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a.
        // Đầu ra: ma trận số nguyên sau khi xử lý.
        public static int[,] Xoa(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            // Tìm vị trí phần tử nhỏ nhất
            int min = a[0, 0];
            int dongMin = 0;
            int cotMin = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        dongMin = i;
                        cotMin = j;
                    }
                }
            }

            // Ma trận mới bị giảm 1 dòng và 1 cột
            int[,] ketQua = new int[n - 1, m - 1];

            int dongMoi = 0;

            for (int i = 0; i < n; i++)
            {
                // Bỏ qua dòng chứa phần tử nhỏ nhất
                if (i == dongMin)
                {
                    continue;
                }

                int cotMoi = 0;

                for (int j = 0; j < m; j++)
                {
                    // Bỏ qua cột chứa phần tử nhỏ nhất
                    if (j == cotMin)
                    {
                        continue;
                    }

                    ketQua[dongMoi, cotMoi] = a[i, j];
                    cotMoi++;
                }

                dongMoi++;
            }

            return ketQua;
        }
    }
}
