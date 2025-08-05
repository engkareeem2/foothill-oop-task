namespace InventoryLibrary.Models;

public class Inventory
{
    private static List<Product> _products = new();

    public static bool IsExist(String name)
    {
        Product? exist = _products.Find(p => p.Name == name);
        return exist != null;
    }
    
    public static bool AddProduct(Product product)
    {
        if (IsExist(product.Name)) return false;
        
        _products.Add(product);
        return true;
    }
}