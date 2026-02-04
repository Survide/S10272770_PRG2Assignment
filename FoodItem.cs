//==========================================================
// Student Number : S10272770
// Student Name : Jun Ming
// Partner Name : Nicole
//==========================================================

namespace prg_asg;

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
      ItemName = "Placeholder";
      ItemDesc = "Placeholder";
      ItemPrice = 0.0;
      Customise = "";
    }

    public override string ToString()
    {
        return
          "ItemName: " + ItemName +
          " ItemDesc: " + ItemDesc +
          " ItemPrice: " + ItemPrice +
          " Customise: " + Customise;
    }

}
