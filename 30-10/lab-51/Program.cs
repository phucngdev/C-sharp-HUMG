using System;
using System.Data;
using MySql.Data.MySqlClient;

public class Program
{
    private static string _connectionString = "Server=127.0.0.1;Database=newdotnet;UserID=root;Password=;Port=3306;";

    public static void Main(string[] args)
    {
        // Tạo một DataSet để chứa dữ liệu
        DataSet dataSet = new DataSet();

        // Tạo một DataAdapter để tương tác với cơ sở dữ liệu
        using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Sanpham", _connectionString))
        {
            // Tạo một DataTable để lưu trữ kết quả truy vấn
            DataTable productTable = new DataTable("Products");

            // Điền dữ liệu từ cơ sở dữ liệu vào DataTable
            adapter.Fill(productTable);

            // Thêm DataTable vào DataSet
            dataSet.Tables.Add(productTable);

            // Hiển thị dữ liệu từ DataTable
            foreach (DataRow row in productTable.Rows)
            {
                Console.WriteLine($"ID: {row["SanphamID"]}, Name: {row["TenSanpham"]}, Price: {row["Gia"]}");
            }
        }
        Console.WriteLine("----------------------------------------------------------------");
        // Cập nhật dữ liệu : thêm một sản phẩm mới
        AddNewProduct(dataSet);
    }

    private static void AddNewProduct(DataSet dataSet)
    {
        // Lấy DataTable từ DataSet
        DataTable productTable = dataSet.Tables["Products"];

        // Tạo một hàng mới trong DataTable
        DataRow newRow = productTable.NewRow();
        newRow["TenSanpham"] = "New Product";
        newRow["CungcapID"] = 1; 
        newRow["DanhmucID"] = 1; 
        newRow["Gia"] = 100; 
        newRow["Donvi"] = "Thùng"; 

        // Thêm hàng mới vào DataTable
        productTable.Rows.Add(newRow);

        // Tạo một DataAdapter để cập nhật dữ liệu vào cơ sở dữ liệu
        using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Sanpham", _connectionString))
        {
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            adapter.Update(productTable); // Cập nhật dữ liệu từ DataTable vào cơ sở dữ liệu
        }

        Console.WriteLine("New product added successfully.");
    }
}
