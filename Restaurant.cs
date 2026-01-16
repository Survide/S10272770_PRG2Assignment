namespace prg_asg;

public class Restaurant
{
    public string RestaurantId { get; set; }
    public string RestaurantName { get; set; }
    public string RestaurantEmail { get; set; }

    public Restaurant(string restaurantId, string restaurantName, string restaurantEmail)
    {
        RestaurantId = restaurantId;
        RestaurantName = restaurantName;
        RestaurantEmail = restaurantEmail;
    }

    public void DisplayOrders() { }
    public void DisplaySpecialOffers() { }
    public void DisplayMenu() { }
    public void AddMenu() { }
    public bool RemoveMenu() { return false; }

    public override string ToString()
    {
        return "";
    }

}
