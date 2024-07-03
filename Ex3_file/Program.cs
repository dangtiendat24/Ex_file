using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

using System.Text.Json;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, decimal price, string category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }
}

public class JSONHandler
{
    public static List<Product> ReadFromJSON(string filePath)
    {
        var jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Product>>(jsonString);
    }

    public static void WriteToJSON(string filePath, List<Product> products)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonString = JsonSerializer.Serialize(products, options);
        File.WriteAllText(filePath, jsonString);
    }
}

public class ProductInput
{
    public static List<Product> GetProductsFromUser()
    {
        var products = new List<Product>();

        while (true)
        {
            Console.Write("Enter Product Id (or type 'exit' to finish): ");
            string idInput = Console.ReadLine();
            if (idInput.ToLower() == "exit")
            {
                break;
            }

            int id = int.Parse(idInput);

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Product Category: ");
            string category = Console.ReadLine();

            var product = new Product(id, name, price, category);
            products.Add(product);

            Console.WriteLine("Product added.\n");
        }

        return products;
    }
}
class Program
{
    private const string FilePath = "products.json";

    static void Main()
    {
        // Nhập thông tin sản phẩm từ người dùng
        var products = ProductInput.GetProductsFromUser();

        // Ghi danh sách sản phẩm vào tệp JSON
        JSONHandler.WriteToJSON(FilePath, products);

        // Đọc danh sách sản phẩm từ tệp JSON
        var readProducts = JSONHandler.ReadFromJSON(FilePath);

        // Hiển thị thông tin sản phẩm đọc từ tệp JSON
        Console.WriteLine("\nProducts read from JSON:");
        foreach (var product in readProducts)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
        }
    }
}
