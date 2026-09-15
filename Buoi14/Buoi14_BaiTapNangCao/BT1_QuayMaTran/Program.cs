using NNLTCSharp.Buoi14;

Console.Write("Nhap cap ma tran n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] a = new int[n, n];

Console.WriteLine("\nNhap ma tran A:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"A[{i},{j}] = ");
        a[i, j] = int.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine("\nMa tran ban dau:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j] + " ");
    }

    Console.WriteLine();
}

int[,] ketQua = QuayMaTran.Quay90Do(a);

Console.WriteLine("\nMa tran sau khi quay 90 do theo chieu kim dong ho:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(ketQua[i, j] + " ");
    }

    Console.WriteLine();
}
