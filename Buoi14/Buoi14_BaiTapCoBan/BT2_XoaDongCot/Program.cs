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

Console.WriteLine("\nMa tran truoc khi xoa:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + " ");
    }

    Console.WriteLine();
}

int[,] ketQua = XoaDongCot.Xoa(a);

Console.WriteLine("\nMa tran sau khi xoa:");

int soDongMoi = ketQua.GetLength(0);
int soCotMoi = ketQua.GetLength(1);

Console.WriteLine($"Mang co {soDongMoi} dong x {soCotMoi} cot:");

for (int i = 0; i < soDongMoi; i++)
{
    for (int j = 0; j < soCotMoi; j++)
    {
        Console.Write(ketQua[i, j] + " ");
    }

    Console.WriteLine();
}
