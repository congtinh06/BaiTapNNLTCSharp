namespace NNLTCSharp.Buoi14
{
    // Bài toán: tạo ma trận con bằng cách bỏ dòng và cột chứa trị tuyệt đối lớn nhất.
    // 
    // Ý tưởng thuật toán:
    //   Tìm vị trí phần tử có trị tuyệt đối lớn nhất,
    //   rồi sao chép các phần tử không thuộc dòng và cột đó.
    public class XayDungMaTran
    {
        // Hàm XayDung thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a.
        // Đầu ra: ma trận số thực sau khi xử lý.
        public static double[,] XayDung(double[,] a)
        {
            int n = a.GetLength(0);

            // Tìm phần tử có giá trị tuyệt đối lớn nhất
            double giaTriLonNhat = Math.Abs(a[0, 0]);
            int dongMax = 0;
            int cotMax = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(a[i, j]) > giaTriLonNhat)
                    {
                        giaTriLonNhat = Math.Abs(a[i, j]);
                        dongMax = i;
                        cotMax = j;
                    }
                }
            }

            // Ma trận kết quả có cấp n - 1
            double[,] ketQua = new double[n - 1, n - 1];

            int dongMoi = 0;

            // Sao chép các phần tử không thuộc
            // dòng và cột cần xóa
            for (int i = 0; i < n; i++)
            {
                if (i == dongMax)
                {
                    continue;
                }

                int cotMoi = 0;

                for (int j = 0; j < n; j++)
                {
                    if (j == cotMax)
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
