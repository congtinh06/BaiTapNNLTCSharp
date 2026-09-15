namespace NNLTCSharp.Buoi14
{
    // Bài toán: sắp xếp các cột theo số lượng phần tử chẵn tăng dần.
    // 
    // Ý tưởng thuật toán:
    //   Đếm số chẵn của từng cột, rồi dùng đổi chỗ kề nhau
    //   và luôn đổi cả dữ liệu cột khi đổi số lượng tương ứng.
    public class SapXepCot
    {
        // Hàm SapXep thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a.
        // Đầu ra: ma trận số nguyên sau khi xử lý.
        public static int[,] SapXep(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            // Đếm số lượng số chẵn của từng cột
            int[] soChan = new int[m];

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        soChan[j]++;
                    }
                }
            }

            // Sắp xếp tăng dần theo số lượng số chẵn
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < m - 1 - i; j++)
                {
                    if (soChan[j] > soChan[j + 1])
                    {
                        // Đổi số lượng số chẵn
                        int temp = soChan[j];
                        soChan[j] = soChan[j + 1];
                        soChan[j + 1] = temp;

                        // Đổi toàn bộ 2 cột
                        for (int k = 0; k < n; k++)
                        {
                            int tempCot = a[k, j];
                            a[k, j] = a[k, j + 1];
                            a[k, j + 1] = tempCot;
                        }
                    }
                }
            }

            return a;
        }
    }
}
