//==========================================================
// Student Number : S10271061J
// Student Name : Nicole Tan
// Partner Name : Tan Jun Ming
//==========================================================

namespace S10271061_PRG2Assignment;

public class FoodItem
{
    public string ItemName { get; set; }
    public string ItemDesc { get; set; }
    public double ItemPrice { get; set; }
    public string Customise { get; set; }

    public FoodItem(string itemName, string itemDesc, double itemPrice, string customise)
    {
        ItemName = itemName;
        ItemDesc = itemDesc;
        ItemPrice = itemPrice;
        Customise = customise;
    }

    public FoodItem()
    {
        ItemName = "Fried carrot cake";
        ItemDesc = "Fried carrot cake";
        ItemPrice = 3.5;
        Customise = "";
    }

    public override string ToString()
    {
        return "ItemName: "
            + ItemName
            + " ItemDesc: "
            + ItemDesc
            + " ItemPrice: "
            + ItemPrice
            + " Customise: "
            + Customise;
    }
}
