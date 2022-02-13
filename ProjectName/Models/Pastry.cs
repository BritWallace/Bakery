using System;
using Treats.Logic;

namespace PastryTime
{
public class PastryStuff
{
    public int Price { get; private set;}
    public int Quantity { get; private set; }

    public PastryStuff(int quantity, int price = 0)
    {
    Price = price;
    Quantity = quantity;
    }

    public int QuantityPrice()
    {
    if(Quantity > 2) 
    {
        int remainder = Quantity % 3;
        Price = (((Quantity - remainder) / 3) * 5) + (remainder * 2);
        return Price;
    }
    else 
    {
        Price = Quantity * 2;
        return Price;
    }
    }
}
}


