using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // 30.a: Nhập số nguyên dương và số thực 4 byte
        int m = EditNumbers.NhapSoNguyenDuong();
        int n = EditNumbers.NhapSoNguyenDuong();
        float x = EditNumbers.NhapSoThuc4Byte();

        // In ra các giá trị của biến m, n và x
        Console.WriteLine($"m = {m}, n = {n}, x = {x}");

        // 30.b: Nhập mảng 2 chiều số thực
        float[,] a = ArrayFloat2D.NhapMangFloat2D(m, n);

        // 30.c: Hiển thị mảng 2 chiều
        Console.WriteLine("Mảng 2 chiều:");
        ArrayFloat2D.HienThiMangFloat2D(a);

        // 30.d: Ghi mảng ra file CSV
        string fileName = "a2d.csv";
        ArrayFloat2D.GhiMang2DFloatFileCSV(a, fileName);

        // 30.e: Đọc mảng từ file CSV và hiển thị
        float[,] b = ArrayFloat2D.DocMang2DFloatTuFileCSV(fileName);
        Console.WriteLine("Mảng 2 chiều đọc từ file CSV:");
        ArrayFloat2D.HienThiMangFloat2D(b);
    }
}
