namespace NNLTCSharp.Buoi14
{
    // Bài toán: đưa các số chẵn lên trước và số lẻ ra sau trong ma trận.
    // 
    // Ý tưởng thuật toán:
    //   Gom lần lượt số chẵn rồi số lẻ vào mảng một chiều,
    //   sau đó ghi mảng này trở lại ma trận theo thứ tự hàng-cột.
    public class SapXepMaTranChanLe
    {
        // Hàm SapXep thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a.
        // Đầu ra: ma trận số nguyên sau khi xử lý.
        public static int[,] SapXep(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int soPhanTu = n * m;
            int[] mang = new int[soPhanTu];

            int k = 0;

            // Đưa các số chẵn vào trước
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        mang[k] = a[i, j];
                        k++;
                    }
                }
            }

            // Đưa các số lẻ vào sau
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 != 0)
                    {
                        mang[k] = a[i, j];
                        k++;
                    }
                }
            }

            // Đưa mảng 1 chiều trở lại ma trận
            k = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = mang[k];
                    k++;
                }
            }

            return a;
        }
    }
}
