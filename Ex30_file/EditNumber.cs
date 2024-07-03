using System;

public static class EditNumbers
{
    public static int NhapSoNguyenDuong()
    {
        int number;
        while (true)
        {
            Console.Write("Nhập số nguyên dương: ");
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                    break;
                else
                    Console.WriteLine("Số nhập vào phải là số nguyên dương. Vui lòng thử lại.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        return number;
    }

    public static float NhapSoThuc4Byte()
    {
        float number;
        while (true)
        {
            Console.Write("Nhập số thực 4 byte: ");
            try
            {
                number = float.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        return number;
    }
}
