using System;
using System.IO;

public static class ArrayFloat2D
{
    public static float[,] NhapMangFloat2D(int rows, int cols)
    {
        float[,] array = new float[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhập phần tử [{i},{j}]: ");
                array[i, j] = EditNumbers.NhapSoThuc4Byte();
            }
        }
        return array;
    }

    public static void HienThiMangFloat2D(float[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void GhiMang2DFloatFileCSV(float[,] array, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    writer.Write(array[i, j]);
                    if (j < cols - 1)
                        writer.Write(",");
                }
                writer.WriteLine();
            }
        }
    }

    public static float[,] DocMang2DFloatTuFileCSV(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        int rows = lines.Length;
        int cols = lines[0].Split(',').Length;
        float[,] array = new float[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            string[] values = lines[i].Split(',');
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = float.Parse(values[j]);
            }
        }
        return array;
    }
}
