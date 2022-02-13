using System;
using BreadTime;
using PastryTime;
using TotalCost;

namespace Treats.Logic
{
public class Program
    {
public static void Main()
{
    Console.Write("Welcome to the Olive Bakery! \n");
    Console.Write("Here is our menu... \n");
    Console.Write("One loaf of bread is $5 \n");
    Console.Write("Buy two get one free loaf! \n");
    Console.Write("One pastry is $2 \n" );
    Console.Write("Buy three pastries get $1 off! \n");
    {

    Console.Write("Are you ready to order? 'Respond yes or no   ");
    string CostumerReply = Console.ReadLine();
    if ("yes" == "yes")
    {

        Console.Write("How many loafs of bread would you like to order today? (Enter 0 if none.)\n" );
        string breadQuantity = Console.ReadLine();
        Console.Write("How many pastries would you like today? (Enter 0 if none. \n");
        string pastryQuantity = Console.ReadLine();
        Console.Write($"You ordered {breadQuantity} loafs of bread and {pastryQuantity} tasty pastries.  \n");
        
        BreadStuff breadOrder = new BreadStuff (int.Parse(breadQuantity));
        // PastryStuff pastryOrder = new PastryStuff(pastryQuantity);
        // TotalCost  = totalCost();

        Console.Write($"The total cost of the bread order is {0:C}\n", breadOrder);
        Console.Write($"The cost of the pastries order is {0:C}\n");
        Console.Write($"Coming to a grand total of {0:C}\n");
        Console.Write("Thanks for coming into the Olive Bakery. Please come again!");
        
        // BreadStuff newBreadOrder = new BreadStuff(quantity);
        // newBreadOrder.QuantityPrice();
    // }
    // else 
    // {
    //     // ("no" == "no");"
    // }
    
    }
    }
}

}
}

