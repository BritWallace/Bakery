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
    if (CostumerReply == "yes")
    {

        Console.WriteLine("How many loafs of bread would you like to order today? (Enter 0 if none.)" );
        string breadQuantity = Console.ReadLine();
        Console.WriteLine("How many pastries would you like today? (Enter 0 if none.");
        string pastryQuantity = Console.ReadLine();
        Console.Write($"You ordered {breadQuantity} loafs of bread and {pastryQuantity} tasty pastries.  \n");
        
        BreadStuff breadOrder = new BreadStuff (int.Parse(breadQuantity));
        PastryStuff pastryOrder = new PastryStuff(int.Parse(pastryQuantity));

        int breadCost = breadOrder.QuantityPrice();
        Console.WriteLine($"Your bread cost ${breadCost}");
        int pastryCost = pastryOrder.QuantityPrice();
        Console.WriteLine($"Your pastries cost ${pastryCost}");
        Console.WriteLine($"The total cost is ${pastryCost + breadCost}");
        Console.Write("Thanks for coming into the Olive Bakery. Please come again soon!");
        
    }
    else 
    {
        Console.WriteLine("Okay. Order when you are ready. ");
    }
    }
    }
    }

}


