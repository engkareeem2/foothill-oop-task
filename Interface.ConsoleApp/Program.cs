using System.Text;
using FoothillOOPTask.Utility;
using InventoryLibrary.Models;

StringBuilder mainMenu = new();

mainMenu.Append("------------------- [ Main Menu ] -------------------\n");
mainMenu.Append("\t=> Pick an option <= \n");
mainMenu.Append("=> 1. Add Product\n");
mainMenu.Append("=> 2. View All Products\n");
mainMenu.Append("=> 3. Edit a Product\n");
mainMenu.Append("=> 4. Delete a Product\n");
mainMenu.Append("=> 5. Search for a Product\n");


while (true)
{
    Console.Write(mainMenu);
    int option = ConsoleUtils.ReadInteger("Select an option: ", null);

    switch (option)
    {
        case 1:
            UserInterface.HandleAddProduct();
            break;
        default:
            Console.WriteLine("Invalid option!");
            break;
    }

    Console.Write("\nPress any key to continue...");
    Console.ReadKey();
}