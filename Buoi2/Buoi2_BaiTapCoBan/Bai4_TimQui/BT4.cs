using System;

namespace TimQui
{
    public class Program
    {
        // Hàm tính toán thuần túy - có thể unit test được
        public static int TimQui(int thang)
        {
            int qui = (thang - 1) / 3 + 1;
            return qui;
        }

        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap thang: ");
            string? dongNhap = Console.ReadLine();

            if (string.IsNullOrEmpty(dongNhap))
            {
                Console.WriteLine("Ban chua nhap gi ca!");
                return;
            }

            int thang = int.Parse(dongNhap);

            int qui = TimQui(thang);

            Console.WriteLine("Thang {0} thuoc qui {1}.", thang, qui);
        }
    }
}
