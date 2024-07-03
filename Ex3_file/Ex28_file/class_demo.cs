using System;

namespace Ex4
{
    public class class_demo
    {
        public void Show()
        {
            Console.WriteLine("Tôi là một lớp đơn giản!");
        }

        public ushort nhapsonguyen2bytekhongdau()
        {
            ushort n = 0;
            while (true)
            {
                try
                {
                    string sz;
                    sz = Console.ReadLine();
                    n = ushort.Parse(sz);
                    break;
                }
                catch
                {
                    Console.Beep();
                    //Console.WriteLine("...");
                }
            }
            return n;
        }
    }
}
