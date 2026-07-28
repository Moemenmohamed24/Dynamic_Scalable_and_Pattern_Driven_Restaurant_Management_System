public class BigMac : IFood
{
    FoodItem foodItem = new FoodItem();
    public void Make()
    {
        foodItem.Name = "BigMac";
        foodItem.price = 10;
        foodItem.Description = "Iconic double-decker burger with two beef patties and special sauce.";
        foodItem.DietaryTags.Add("burger");
        foodItem.DietaryTags.Add("beef");
        Console.WriteLine("BigMac is prepearing....");
    }
}

