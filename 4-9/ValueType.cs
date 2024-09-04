public struct Product {

    public string name;   // trường tên sản phẩm
    public decimal price; // trường giá sản phẩm

    // Phương thức sinh ra chuỗi thông tin
    public override string ToString() => $"{name} : {price}$";

}