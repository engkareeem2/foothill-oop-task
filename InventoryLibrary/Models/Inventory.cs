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

    public static void ViewAllProducts()
    {
        if (_products.Count > 0)
        {
            foreach (Product product in _products)
            {
                product.Print();
            }
        }
        else
        {
            Console.WriteLine("Empty.");
        }
    }

    public static void EditProduct(String name, String newName, decimal newPrice, int newQuantity)
    {
        Product? product = Search(name);
        if (product != null)
        {
            if (newName != "") product.Name = newName;
            if (newPrice >= 0) product.Price = newPrice;
            if (newQuantity >= 0) product.Quantity = newQuantity;
        }
    }

    public static void RemoveProduct(Product product)
    {
        _products.Remove(product);
    }

    public static Product? Search(String name)
    {
        return _products.Find(product => product.Name == name);
    }
}