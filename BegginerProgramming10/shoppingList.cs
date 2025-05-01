
using System.Collections.Generic;

List<string> shoppingList = new List<string>();

Console.WriteLine("Hello! Your shopping list is currently empty. Please add a product to continue: ");
AddProduct();


var ending = 0;
while (ending == 0)
{
    Console.WriteLine("Thanks! What would you like to do now? Please choose a number: ");
    Console.WriteLine("1) Show my list");
    Console.WriteLine("2) Add a new item");
    Console.WriteLine("3) Delete an item");
    Console.WriteLine("4) Finish");

    var option = Console.ReadLine();

    if (option == "1")
    {
        Console.WriteLine("Of course! Here is your list: ");
        shoppingList.ForEach(Console.WriteLine);
    }
    else if (option == "2")
    {
        Console.WriteLine("Of course! Which product would you like to add?");
        AddProduct();
    }
    else if (option == "3")
    {
        if (shoppingList.Count > 0)
        {
            Console.WriteLine("Of course! Which product would you like to delete?");
            var delete = Console.ReadLine();
            shoppingList.Remove(delete);
        }
        else
        {
            Console.WriteLine("Your list is currently empty. First add a product to start.");
        }
    }
    else if (option == "4")
    {
        ending++;
    }
    else
    {
        Console.WriteLine("Incorrect option. Please choose again.");
    }
    Console.WriteLine();

}




void AddProduct()
    {
        var item = Console.ReadLine();
        shoppingList.Add(item);
    }

