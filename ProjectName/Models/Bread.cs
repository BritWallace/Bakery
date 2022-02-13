using System;
using Treats.Logic;

namespace BreadTime
{
public class BreadStuff
{
    public int Price { get; private set;}
    public int Quantity { get; private set; }

    public BreadStuff(int quantity, int price = 0)
    {
    Price = price;
    Quantity = quantity;
    }

    public int QuantityPrice()
    {
    if(Quantity > 2) 
    {
        int remainder = Quantity % 3;
        Price = (((Quantity - remainder) / 3) * 10) + (remainder * 5);
        return Price;
    }
    else 
    {
        Price = Quantity * 5;
        return Price;
    }
    }
}
}
