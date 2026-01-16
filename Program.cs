
using prg_asg;

List<Restaurant> restaurants = new List<Restaurant>();
List<FoodItem> foodItems = new List<FoodItem>();

void LoadRestaurants()
{
    try
    {
        string[] records = File.ReadAllLines("data/restaurants.csv").Skip(1).ToArray();
        foreach (string record in records)
        {
            string[] details = record.Split(",");
            restaurants.Add(new Restaurant(details[0], details[1], details[2]));
        }
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine("Restaurants file not found!");
        Console.WriteLine($"Error message {ex.Message}");
    }
    finally
    {
        Console.WriteLine($"{restaurants.Count()} restaurants loaded!");
    }
}

void LoadFoodItems()
{
    try
    {
        string[] records = File.ReadAllLines("data/fooditems.csv").Skip(1).ToArray();
        foreach (string record in records)
        {
            string[] test = record.Split('"'); // ["r005,greek salad","Cucumber ...", ",10"]
            foreach (string tes in test)
            {
                Console.WriteLine($"test {tes}");
            }
            string[] details = record.Split(",");
            if (!double.TryParse(details[3], out double price))
            {
                Console.WriteLine($"Could not parse price to double in line: {record}");
                continue;
            }
            foodItems.Add(new FoodItem(details[0], details[1], price, details[3]));
        }
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine("FoodItems file not found!");
        Console.WriteLine($"Error message {ex.Message}");
    }
    finally
    {
        Console.WriteLine($"{foodItems.Count()} food items loaded!");
    }
}
void InitializeGruberoo()
{
    Console.WriteLine("Welcome to the Gruberoo Food Delivery System");
    LoadRestaurants();
    // LoadFoodItems(); WIP
}

InitializeGruberoo();
