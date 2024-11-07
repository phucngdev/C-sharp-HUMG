using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ef01.Data;
using ef01.Models;
using Microsoft.EntityFrameworkCore;

namespace ef01
{
    class Program
    {
        public static async Task CreateDatabase()
        {
            using (var dbContext = new ProductsContext())
            {
                string databaseName = dbContext.Database.GetDbConnection().Database;
                Console.WriteLine("Tạo " + databaseName);

                bool result = await dbContext.Database.EnsureCreatedAsync();
                string resultMessage = result ? "tạo thành công" : "đã có trước đó";
                Console.WriteLine($"CSDL {databaseName} : {resultMessage}");
            }
        }

        public static async Task InsertCustomer(string name, string email)
        {
            using (var dbContext = new ProductsContext())
            {
                var customer = new Customer {
                    Name = name,
                    Email = email
                };

                dbContext.Customers.Add(customer);
                await dbContext.SaveChangesAsync();
                Console.WriteLine($"Khách hàng {name} đã được thêm vào CSDL.");
            }
        }

        public static async Task UpdateCustomer(int customerId, string newName, string newEmail)
        {
            using (var dbContext = new ProductsContext())
            {
                var customer = await dbContext.Customers.FindAsync(customerId);
                if (customer != null) {
                    customer.Name = newName;
                    customer.Email = newEmail;
                    await dbContext.SaveChangesAsync();
                    Console.WriteLine($"Khách hàng ID {customerId} đã được cập nhật.");
                } else {
                    Console.WriteLine($"Không tìm thấy khách hàng với ID {customerId}.");
                }
            }
        }

        public static async Task DeleteCustomer(int customerId)
        {
            using (var dbContext = new ProductsContext())
            {
                var customer = await dbContext.Customers.FindAsync(customerId);
                if (customer != null) {
                    dbContext.Customers.Remove(customer);
                    await dbContext.SaveChangesAsync();
                    Console.WriteLine($"Khách hàng ID {customerId} đã được xóa.");
                } else {
                    Console.WriteLine($"Không tìm thấy khách hàng với ID {customerId}.");
                }
            }
        }

        // Hàm GetAll để lấy tất cả khách hàng
        public static async Task GetAllCustomers()
        {
            using (var dbContext = new ProductsContext())
            {
                // Lấy tất cả khách hàng
                var customers = await dbContext.Customers.ToListAsync();

                if (customers.Count > 0)
                {
                    Console.WriteLine("Danh sách khách hàng:");
                    foreach (var customer in customers)
                    {
                        Console.WriteLine($"ID: {customer.CustomerId}, Tên: {customer.Name}, Email: {customer.Email}");
                    }
                }
                else
                {
                    Console.WriteLine("Không có khách hàng trong CSDL.");
                }
            }
        }

        static async Task Main(string[] args)
        {
            // Tạo cơ sở dữ liệu
            await CreateDatabase();

            bool exit = false;
            while (!exit)
            {

                Console.WriteLine("\n================================================");
                Console.WriteLine("\nChọn một chức năng:");
                Console.WriteLine("1. Thêm khách hàng");
                Console.WriteLine("2. Cập nhật thông tin khách hàng");
                Console.WriteLine("3. Xóa khách hàng");
                Console.WriteLine("4. Xem tất cả khách hàng");
                Console.WriteLine("5. Thoát");
                Console.WriteLine("\n================================================");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Nhập tên khách hàng:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Nhập email khách hàng:");
                        string email = Console.ReadLine();
                        await InsertCustomer(name, email);
                        break;

                    case "2":
                        Console.WriteLine("Nhập ID khách hàng cần cập nhật:");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập tên mới:");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Nhập email mới:");
                        string newEmail = Console.ReadLine();
                        await UpdateCustomer(updateId, newName, newEmail);
                        break;

                    case "3":
                        Console.WriteLine("Nhập ID khách hàng cần xóa:");
                        int deleteId = int.Parse(Console.ReadLine());
                        await DeleteCustomer(deleteId);
                        break;

                    case "4":
                        await GetAllCustomers();
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Thoát khỏi chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}
