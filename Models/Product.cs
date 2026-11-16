namespace wt_lab8_8razor_postgresql_makarevich.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public string Description { get; set; } = ""; // <-- Эта строка должна быть здесь!
}