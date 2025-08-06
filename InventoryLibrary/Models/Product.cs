namespace InventoryLibrary.Models;

public class Product
{
    public String Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product()
    {
        this.Name = String.Empty;
        this.Price = Int16.MaxValue;
        this.Quantity = 0;
    }

    public Product(String name, decimal price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public void Print()
    {
        Console.WriteLine($"[Quantity {Quantity}] - Product {Name} with Price ${Price}");
    }
}