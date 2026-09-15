using NNLTCSharp.Buoi14;

Console.Write("Nhap so dong n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Nhap so cot m: ");
int m = int.Parse(Console.ReadLine()!);

double[,] a = new double[n, m];

Console.WriteLine("\nNhap ma tran A:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"A[{i},{j}] = ");
        a[i, j] = double.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine("\nMa tran ban dau:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + " ");
    }

    Console.WriteLine();
}

double[,] ketQua = BienDoiMaTran.BienDoi(a);

Console.WriteLine("\nMa tran sau khi bien doi:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(ketQua[i, j] + " ");
    }

    Console.WriteLine();
}
