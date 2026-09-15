using NNLTCSharp.Buoi14;

Console.Write("Nhap cap ma tran n: ");
int n = int.Parse(Console.ReadLine()!);

double[,] a = new double[n, n];

Console.WriteLine("\nNhap ma tran A:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"A[{i},{j}] = ");
        a[i, j] = double.Parse(Console.ReadLine()!);
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

double[,] ketQua = XayDungMaTran.XayDung(a);

Console.WriteLine("\nMa tran B sau khi xoa:");

int soDongMoi = ketQua.GetLength(0);
int soCotMoi = ketQua.GetLength(1);

for (int i = 0; i < soDongMoi; i++)
{
    for (int j = 0; j < soCotMoi; j++)
    {
        Console.Write(ketQua[i, j] + " ");
    }

    Console.WriteLine();
}
