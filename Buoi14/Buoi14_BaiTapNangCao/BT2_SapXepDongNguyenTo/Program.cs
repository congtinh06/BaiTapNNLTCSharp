using NNLTCSharp.Buoi14;

Console.Write("Nhap so dong n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Nhap so cot m: ");
int m = int.Parse(Console.ReadLine()!);

int[,] a = new int[n, m];

Console.WriteLine("\nNhap ma tran A:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"A[{i},{j}] = ");
        a[i, j] = int.Parse(Console.ReadLine()!);
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

SapXepDongNguyenTo.SapXep(a);

Console.WriteLine("\nMa tran sau khi sap xep:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + " ");
    }

    Console.WriteLine();
}
