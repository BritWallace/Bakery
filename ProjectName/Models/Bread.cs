using System;
using Treats.Logic;

namespace BreadTime
{
public class StoreStuff
{
    public int Price {get; set;}
    public int Quantity {get; set;}



    public StoreStuff(int price, int quantity = 0)
    {
        Price = price;
        Quantity = quantity;

    }

    // public int TotalPrice()
    // {
    //     if(Quantity >2)
    // }
}
}

// typeOfBread = BreadType;
//         int quantityTemp;
//         Int32.TryParse(qty, out quantityTemp);
//         quantity = quantityTemp;