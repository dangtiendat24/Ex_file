using System.Text;

namespace Ex1_file
{
    internal class Program
    {
        private const string FilePath = "data.txt";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CreateFile(FilePath);
            WriteToFile(FilePath, "Đây là chuỗi được viết vào file");
            ReadFromFile(FilePath);

            AppendToFile(FilePath, "\n Đây là chuỗi được nối vào file");
            ReadFromFile(FilePath);

            DeleteFromFile(FilePath);
        }
        static void CreateFile (string FilePath)
        {
            using (FileStream fs = File.Create(FilePath))
            {
                Console.WriteLine("Đã tạo file: " + FilePath);
            }
        }
        static void WriteToFile (string FilePath, string content)
        {
            File.WriteAllText(FilePath, content);
            Console.WriteLine("Chuỗi đã được viết vào file: " + content);
        }
        static void ReadFromFile(string FilePath)
        {
            string content = File.ReadAllText(FilePath);
            Console.WriteLine("Chuỗi đã được đọc từ file là: " + content);
        }
        static void AppendToFile (string FilePath, string content)
        {
            File.AppendAllText(FilePath, content);
            Console.WriteLine("Chuỗi được nối thêm vào file là: " + content);
        }
        static void DeleteFromFile (string FilePath)
        {
            if(File.Exists(FilePath))
            {
                File.Delete(FilePath);
                Console.WriteLine("file đã được xoá");
            }
            else
            {
                Console.WriteLine("file không tồn tại");
            }
        }
    }
}
