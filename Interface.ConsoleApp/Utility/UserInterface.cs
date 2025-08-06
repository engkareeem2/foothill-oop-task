using InventoryLibrary.Models;

namespace FoothillOOPTask.Utility;

public class UserInterface
{
    public static void PrintMain()
    {
        Console.WriteLine("------------------- [ Main Menu ] -------------------");
        Console.WriteLine("\t=> Pick an option <= ");
        Console.WriteLine("=> 1. Add Product");
        Console.WriteLine("=> 2. View All Products");
        Console.WriteLine("=> 3. Edit a Product");
        Console.WriteLine("=> 4. Delete a Product");
        Console.WriteLine("=> 5. Search for a Product");
    }
    
    public static void HandleAddProduct()
    {
        String name = ConsoleUtils.ReadConsole("Enter Product's Name: ", null);
        while (Inventory.IsExist(name))
        {
            Console.WriteLine("Invalid name (Already exist)");
            name = ConsoleUtils.ReadConsole("Enter Product's Name: ", null);
        }

        decimal price = ConsoleUtils.ReadDecimal("Enter price: ", null, true);
        int quantity = ConsoleUtils.ReadInteger("Enter Quantity (Default 0): ", 0, true);
        Product newProduct = new(name, price, quantity);

        bool success = Inventory.AddProduct(newProduct);
        if (success)
        {
            Console.WriteLine($"[Quantity {quantity}] - Product {name} with price ${price} added successfully!");
        }
        else
        {
            Console.WriteLine("Product not added.\nThere is something went wrong, try again later.");
        }
    }

    public static void HandleViewAllProducts()
    {
        Console.WriteLine("All stored products in inventory:");
        Console.WriteLine("--------------------------------");
        Inventory.ViewAllProducts();
        Console.WriteLine("--------------------------------");
    }

    public static void HandleEditProduct()
    {
        String name = ConsoleUtils.ReadConsole("Enter the product's name: ", null);
        Product? product = Inventory.Search(name);

        if (product == null)
        {
            Console.WriteLine("The product not found!");
            return;
        }
     
        Console.WriteLine("Fill the fields you want to edit, and leave the fields you dont want to edit\n");

        String newName = ConsoleUtils.ReadConsole("Enter new name: ", "");
        decimal newPrice = ConsoleUtils.ReadDecimal("Enter new price: ", -1, true);
        int newQuantity = ConsoleUtils.ReadInteger("Enter new quantity: ", -1, true);
        
        Inventory.EditProduct(name, newName, newPrice, newQuantity);
    }
    
    public static void HandleSearchProduct()
    {
        String name = ConsoleUtils.ReadConsole("Enter the product's name: ", null);
        Product? product = Inventory.Search(name);

        if (product != null)
        {
            product.Print();
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }
}