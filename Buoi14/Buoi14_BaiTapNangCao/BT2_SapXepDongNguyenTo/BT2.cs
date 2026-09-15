namespace NNLTCSharp.Buoi14
{
    // Bài toán: sắp xếp dòng theo số lượng số nguyên tố giảm dần.
    // 
    // Ý tưởng thuật toán:
    //   Đếm số nguyên tố trên mỗi dòng, rồi đổi chỗ hai dòng liền kề
    //   khi số lượng ở dòng trước nhỏ hơn dòng sau.
    public class SapXepDongNguyenTo
    {
        // Kiểm tra một số có phải số nguyên tố hay không
        // Hàm LaSoNguyenTo thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: giá trị x cần xử lý.
        // Đầu ra: true hoặc false theo điều kiện kiểm tra.
        public static bool LaSoNguyenTo(int x)
        {
            if (x < 2)
                return false;

            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }

        // Đếm số nguyên tố trong một dòng
        // Hàm DemSoNguyenTo thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a; chỉ số dòng cần xét.
        // Đầu ra: một giá trị số nguyên.
        public static int DemSoNguyenTo(int[,] a, int dong)
        {
            int m = a.GetLength(1);
            int dem = 0;

            for (int j = 0; j < m; j++)
            {
                if (LaSoNguyenTo(a[dong, j]))
                {
                    dem++;
                }
            }

            return dem;
        }

        // Sắp xếp dòng có nhiều số nguyên tố lên trước
        // Hàm SapXep thực hiện phần xử lý tương ứng của bài toán.
        // Đầu vào: ma trận đầu vào a.
        // Đầu ra: ma trận số nguyên sau khi xử lý.
        public static int[,] SapXep(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int[] soNguyenTo = new int[n];

            // Đếm số nguyên tố của từng dòng
            for (int i = 0; i < n; i++)
            {
                soNguyenTo[i] = DemSoNguyenTo(a, i);
            }

            // Sắp xếp giảm dần theo số lượng số nguyên tố
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (soNguyenTo[j] < soNguyenTo[j + 1])
                    {
                        // Đổi số lượng số nguyên tố
                        int temp = soNguyenTo[j];
                        soNguyenTo[j] = soNguyenTo[j + 1];
                        soNguyenTo[j + 1] = temp;

                        // Đổi toàn bộ hai dòng
                        for (int k = 0; k < m; k++)
                        {
                            int tempDong = a[j, k];
                            a[j, k] = a[j + 1, k];
                            a[j + 1, k] = tempDong;
                        }
                    }
                }
            }

            return a;
        }
    }
}
