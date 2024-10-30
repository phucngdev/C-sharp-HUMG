using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        var productService = new ProductService();

        //  Thêm sản phẩm mới
        var newProduct = new Product
        {
            TenSanpham = "Product B",  
            CungcapID = 1,       
            DanhmucID = 1,       
            Gia = 200,              
            Donvi = "Thùng"
        };
        // productService.CreateProduct(newProduct);

        //  Lấy danh sách sản phẩm
        var products = productService.GetProducts(10, 0);
        Console.WriteLine("List of Products:");
        foreach (var product in products) {
            Console.WriteLine($"{product.SanphamID} - {product.TenSanpham} - {product.CungcapID} - {product.DanhmucID} - {product.Gia} - {product.Donvi}");
        }

        // xoá sản phẩm
        // productService.DeleteProduct(81);


    }
}
