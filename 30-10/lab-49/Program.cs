using System;
using MySql.Data.MySqlClient;
using System.Data;

class Program
{
    public class Exam1
    {
        public static void Test()
        {
            // TẠO CHUỖI KẾT NỐI bằng MySqlConnectionStringBuilder
            var stringBuilder = new MySqlConnectionStringBuilder();
            stringBuilder["Server"] = "127.0.0.1";
            stringBuilder["Database"] = "newdotnet";
            stringBuilder["User Id"] = "root";
            stringBuilder["Password"] = "";
            stringBuilder["Port"] = "3306";

            string sqlConnectionString = stringBuilder.ToString();

            var connection = new MySqlConnection(sqlConnectionString);

            Console.WriteLine($"{"ConnectionString ",17} : {stringBuilder}");
            Console.WriteLine($"{"DataSource ",17} : {connection.DataSource}");

            // Bắt sự kiện trạng thái kết nối thay đổi
            connection.StateChange += (object sender, StateChangeEventArgs e) =>
            {
                Console.WriteLine($"Kết nối thay đổi: {e.CurrentState}, trạng thái trước: " + $"{e.OriginalState}");
            };

            // mở kết nối
            connection.Open();

            // Dùng MySqlCommand để thi hành SQL
            using (var command = new MySqlCommand("SELECT * FROM Sanpham LIMIT 5", connection))
            {
                // Thực hiện truy vấn và lấy dữ liệu
                using (var reader = command.ExecuteReader())
                {
                    Console.WriteLine("\r\nCÁC SẢN PHẨM:");
                    Console.WriteLine($"{"SanphamID ",10} {"TenSanpham "}");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["SanphamID"],10} {reader["TenSanpham"]}");
                    }
                }
            }

            // đóng kết nối 
            connection.Close();
        }
    }

    static void Main(string[] args)
    {
        Exam1.Test();
    }
}
