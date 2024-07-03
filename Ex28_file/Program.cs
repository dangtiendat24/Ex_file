using System;
using System.Text;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            class_demo ob = new class_demo();
            ob.Show();

            Console.WriteLine("Nhập n:");
            ushort n = ob.nhapsonguyen2bytekhongdau();
            Console.WriteLine("n=" + n.ToString());
        }
    }
}
