using System.Text;
using FoothillOOPTask.Utility;
using InventoryLibrary.Models;

while (true)
{
    UserInterface.PrintMain();
    int option = ConsoleUtils.ReadInteger("Select an option: ", null);

    switch (option)
    {
        case 1:
            UserInterface.HandleAddProduct();
            break;
        case 2:
            UserInterface.HandleViewAllProducts();
            break;
        case 5:
            UserInterface.HandleSearchProduct();
            break;
        default:
            Console.WriteLine("Invalid option!");
            break;
    }

    Console.Write("\nPress any key to continue...");
    Console.ReadKey();
}