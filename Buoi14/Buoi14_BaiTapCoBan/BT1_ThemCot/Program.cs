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

double[] b = new double[n];

Console.WriteLine("\nNhap day B:");

for (int i = 0; i < n; i++)
{
    Console.Write($"B[{i}] = ");
    b[i] = double.Parse(Console.ReadLine()!);
}

Console.Write("\nNhap vi tri cot can chen k: ");
int k = int.Parse(Console.ReadLine()!);

Console.WriteLine("\nMa tran A truoc khi them:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + " ");
    }

    Console.WriteLine();
}

Console.WriteLine("\nDay B:");

for (int i = 0; i < n; i++)
{
    Console.Write(b[i] + " ");
}

Console.WriteLine();

double[,] ketQua = ThemCot.Them(a, b, k);

Console.WriteLine($"\nMa tran sau khi them o cot {k}:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m + 1; j++)
    {
        Console.Write(ketQua[i, j] + " ");
    }

    Console.WriteLine();
}
