using System.Text;

string HelloText = "Xin chào";       // Khai báo và khởi tạo chuỗi
HelloText += " các bạn";             // Nối chuỗi +=, trả về "Xin chào các bạn"
Console.WriteLine(HelloText);         // In ra màn hình "Xin chào các bạn"

char c = HelloText[0];               // c = 'X'
Console.WriteLine(c);                // In ra màn hình 'X'

int a = 10;
int b = 2;
string s = $"Kết quả {a}/{b} là {a/b}";  // "Kết quả 10/2 là 5"

string MilText = @"Xin chào dòng 1,
dòng 2                  
";
Console.WriteLine(MilText);         // In ra màn hình: Xin chào dòng 1, dòng 2

var ReplaceString = HelloText.Replace("chào", "CHÀO");
Console.WriteLine($"Replace {ReplaceString}");    // In ra màn hình: Xin CHÀO các bạn

var SplitString = HelloText.Split(' ');  // {"Xin", "chào", "các", "bạn" }

// join chuỗi
string joinedString = string.Join(", ", SplitString);
Console.WriteLine($"Join {joinedString}"); // In ra màn hình: Xin, chào, các, bạn

// Ví dụ sử dụng StringBuilder
StringBuilder sb = new StringBuilder();
sb.Append("Xin chào ");
sb.Append("các bạn");
Console.WriteLine(sb.ToString()); // In ra màn hình: Xin chào các bạn

sb.Replace("chào", "CHÀO");
Console.WriteLine(sb.ToString()); // In ra màn hình: Xin CHÀO các bạn

// cắt khoảng trắng của chuỗi ở 2 đầu
string trimmedString = HelloText.Trim();
Console.WriteLine(trimmedString);    // In ra màn hình: Xin chào các bạn

// chuyển chuoi thành chuoi in hoa
string upperString = HelloText.ToUpper();
Console.WriteLine(upperString);    

// chuyển chuoi thành chuoi in thưong
string lowerString = HelloText.ToLower();
Console.WriteLine(lowerString);    


