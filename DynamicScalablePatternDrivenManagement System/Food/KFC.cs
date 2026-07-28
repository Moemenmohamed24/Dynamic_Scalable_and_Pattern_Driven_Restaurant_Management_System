public class KFC : IFood
{
    FoodItem foodItem = new FoodItem();

    public void Make()
    {
        foodItem.Name = "KFC";
        foodItem.price = 15;
        foodItem.Description = "Delicious crispy fried chicken coated in a secret spice blend.";
        foodItem.DietaryTags.Add("pizza");
        foodItem.DietaryTags.Add("beef");
        Console.WriteLine("BigMac is KFC....");
    }
}

