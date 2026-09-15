namespace NNLTCSharp.Buoi14
{
    // Bài toán: đưa dòng và cột chứa phần tử nhỏ nhất xuống/cuối ma trận.
    // 
    // Ý tưởng thuật toán:
    //   Tìm vị trí nhỏ nhất, hoán đổi dòng của nó với dòng cuối,
    //   rồi hoán đổi cột của nó với cột cuối.
    public class BienDoiMaTran
    {
        // Hàm BienDoi thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a.
        // Đầu ra: ma trận số thực sau khi xử lý.
        public static double[,] BienDoi(double[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            // Tìm phần tử nhỏ nhất
            double min = a[0, 0];
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

            // Đưa dòng chứa min xuống dòng cuối
            if (dongMin != n - 1)
            {
                for (int j = 0; j < m; j++)
                {
                    double temp = a[dongMin, j];
                    a[dongMin, j] = a[n - 1, j];
                    a[n - 1, j] = temp;
                }
            }

            // Đưa cột chứa min sang cột cuối
            if (cotMin != m - 1)
            {
                for (int i = 0; i < n; i++)
                {
                    double temp = a[i, cotMin];
                    a[i, cotMin] = a[i, m - 1];
                    a[i, m - 1] = temp;
                }
            }

            return a;
        }
    }
}
