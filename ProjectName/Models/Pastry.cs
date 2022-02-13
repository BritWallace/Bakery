using System;
using Treats.Logic;

namespace BreadTime
{
public class MoreStoreStuff
{
    public string typeOfPastry {get; set;}
    public int quantity {get; set;}

    public int Price {get; set;}

    public MoreStoreStuff(string PastryType, string qty)
    {
        typeOfPastry = PastryType;
        int quantityTemp;
        Int32.TryParse(qty, out quantityTemp);
        quantity = quantityTemp;
    }
}
}

