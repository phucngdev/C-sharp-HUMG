using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class Product
{
    public int SanphamID { get; set; }   
    public string TenSanpham { get; set; } 
    public int CungcapID { get; set; }  
    public int DanhmucID { get; set; }  
    public decimal Gia { get; set; }       
    public string Donvi { get; set; }         
}

public class ProductService
{
    private readonly string _connectionString;

    public ProductService()
    {
        var stringBuilder = new MySqlConnectionStringBuilder {
            Server = "127.0.0.1",          
            Database = "newdotnet",        
            UserID = "root",               
            Password = "",                 
            Port = 3306                    
        };
        _connectionString = stringBuilder.ToString(); // Tạo chuỗi kết nối từ các thông tin trên
    }

    
    public void CreateProduct(Product product)
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Open(); // Mở kết nối đến cơ sở dữ liệu

        string query = @"INSERT INTO Sanpham 
                         (TenSanpham, CungcapID, DanhmucID, Gia, Donvi) 
                         VALUES (@TenSanpham, @CungcapID, @DanhmucID, @Gia, @Donvi)";
        using var command = new MySqlCommand(query, connection);

        // Thiết lập các tham số cho câu truy vấn
        command.Parameters.AddWithValue("@TenSanpham", product.TenSanpham);
        command.Parameters.AddWithValue("@CungcapID", product.CungcapID);
        command.Parameters.AddWithValue("@DanhmucID", product.DanhmucID);
        command.Parameters.AddWithValue("@Gia", product.Gia);
        command.Parameters.AddWithValue("@Donvi", product.Donvi);

        command.ExecuteNonQuery(); // Thực thi truy vấn
        Console.WriteLine("Product created successfully.");
    }

  
    public List<Product> GetProducts(int limit, int offset)
    {
        var products = new List<Product>();

        using var connection = new MySqlConnection(_connectionString);
        connection.Open(); // Mở kết nối đến cơ sở dữ liệu

        
        string query = "SELECT * FROM Sanpham LIMIT @Limit OFFSET @Offset";
        using var command = new MySqlCommand(query, connection);

        // Thiết lập giá trị cho các tham số LIMIT và OFFSET
        command.Parameters.AddWithValue("@Limit", limit);
        command.Parameters.AddWithValue("@Offset", offset);

        using var reader = command.ExecuteReader(); // Thực thi truy vấn và đọc kết quả

        // Đọc từng dòng kết quả và thêm vào danh sách `products`
        while (reader.Read())
        {
            products.Add(new Product
            {
                SanphamID = reader.GetInt32("SanphamID"),
                TenSanpham = reader.GetString("TenSanpham"),
                CungcapID = reader.GetInt32("CungcapID"),
                DanhmucID = reader.GetInt32("DanhmucID"),
                Gia = reader.GetDecimal("Gia"),
                Donvi = reader.GetString("Donvi")
            });
        }

        return products; // Trả về danh sách sản phẩm
    }
    
    public void DeleteProduct(int productId)
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Open(); // Mở kết nối đến cơ sở dữ liệu

        string query = "DELETE FROM Sanpham WHERE SanphamID = @SanphamID";
        using var command = new MySqlCommand(query, connection);

        // Thiết lập tham số SanphamID cho truy vấn
        command.Parameters.AddWithValue("@SanphamID", productId);

        command.ExecuteNonQuery(); // Thực thi truy vấn
        Console.WriteLine("Product deleted successfully.");
    }
}
