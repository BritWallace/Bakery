using System;
using BreadTime;

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
    Console.Write("Are you ready to order? 'Respond 'yes' or 'no'");
    string CostumerReply = Console.ReadLine();

    if(CostumerReply == "yes")
    {
        Console.Write("How many loafs of bread would you like to order today? (Enter 0 if none.)" );
        // TotalPrice();
    }
    else
    {
        Console.Write("How many pastries would you like to order today?(Enter 0 if none.)");
        // TotalPastryPrice();
    }


    }
    }
}
