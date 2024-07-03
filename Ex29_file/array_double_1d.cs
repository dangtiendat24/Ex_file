using System;

namespace ex4
{
    public class array_double_1d
    {
        private double[] numbers;

        public void setNumbers(double[] arr)
        {
            numbers = arr;
        }

        public double FindMin()
        {
            double min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public double FindMax()
        {
            double max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
