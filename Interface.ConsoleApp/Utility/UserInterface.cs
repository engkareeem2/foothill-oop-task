using InventoryLibrary.Models;

namespace FoothillOOPTask.Utility;

public class UserInterface
{
    public static void HandleAddProduct()
    {
        String name = ConsoleUtils.ReadConsole("Enter Product's Name: ", null);
        while (Inventory.IsExist(name))
        {
            Console.WriteLine("Invalid name (Already exist)");
            name = ConsoleUtils.ReadConsole("Enter Product's Name: ", null);
        }

        decimal price = ConsoleUtils.ReadDecimal("Enter price", null, true);
        int quantity = ConsoleUtils.ReadInteger("Enter Quantity (Default 0)", 0);
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
}