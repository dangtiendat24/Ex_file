using System;
using System.Text;

namespace ex4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double[] numbers = { 1.5, 2.7, 3.9, 4.2, 5.1 };

            array_double_1d ob = new array_double_1d();
            ob.setNumbers(numbers);
            double min = ob.FindMin();
            double max = ob.FindMax();

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }
}
