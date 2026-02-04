//==========================================================
// Student Number : S10271061J
// Student Name : Nicole Tan
// Partner Name : Tan Jun Ming
//==========================================================

namespace S10271061_PRG2Assignment;

public class Menu
{
    public string MenuId { get; set; }
    public string MenuName { get; set; }
    public List<FoodItem> FoodItems { get; set; }

    public Menu(string menuId, string menuName)
    {
        MenuId = menuId;
        MenuName = menuName;

        FoodItems = [new FoodItem()];
    }

    public void AddFoodItem(FoodItem foodItem)
    {
        FoodItems.Add(foodItem);
        if (FoodItems[0].ItemName == "Placeholder") FoodItems.RemoveAt(0);
    }

    public bool RemoveFoodItem(FoodItem foodItem)
    {
        bool removed = FoodItems.Remove(foodItem);
        return removed;
    }

    public void DisplayFoodItems()
    {
        foreach (FoodItem foodItem in FoodItems)
        {
            Console.WriteLine(foodItem.ToString());
        }
    }

    public override string ToString()
    {
        return "MenuId: " + MenuId + " MenuName: " + MenuName;
    }
}
