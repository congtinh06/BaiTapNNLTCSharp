namespace NNLTCSharp.Buoi14
{
    // Bài toán: chèn một dòng và cột tại vị trí phần tử lớn nhất.
    // 
    // Ý tưởng thuật toán:
    //   Tìm phần tử lớn nhất; trong ma trận mới, dòng hoặc cột được chèn nhận giá trị này,
    //   các vị trí còn lại được ánh xạ về ma trận cũ.
    public class ThemDongCot
    {
        // Hàm Them thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a.
        // Đầu ra: ma trận số thực sau khi xử lý.
        public static double[,] Them(double[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            // Tìm phần tử lớn nhất
            double max = a[0, 0];
            int dongMax = 0;
            int cotMax = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        dongMax = i;
                        cotMax = j;
                    }
                }
            }

            // Ma trận mới có thêm 1 dòng và 1 cột
            double[,] ketQua = new double[n + 1, m + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    // Nếu là dòng mới hoặc cột mới
                    if (i == dongMax || j == cotMax)
                    {
                        ketQua[i, j] = max;
                    }
                    else
                    {
                        // Xác định vị trí tương ứng trong ma trận cũ
                        int dongCu;
                        int cotCu;

                        if (i < dongMax)
                        {
                            dongCu = i;
                        }
                        else
                        {
                            dongCu = i - 1;
                        }

                        if (j < cotMax)
                        {
                            cotCu = j;
                        }
                        else
                        {
                            cotCu = j - 1;
                        }

                        ketQua[i, j] = a[dongCu, cotCu];
                    }
                }
            }

            return ketQua;
        }
    }
}
