[Mota("This is the User class")]
public class User
{
    [Mota("User ID property")]
    public int UserID { get; set; }

    [Mota("User Name property")]
    public string UserName { get; set; }

    [Mota("Display user information")]
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {UserID}, Name: {UserName}");
    }
}
