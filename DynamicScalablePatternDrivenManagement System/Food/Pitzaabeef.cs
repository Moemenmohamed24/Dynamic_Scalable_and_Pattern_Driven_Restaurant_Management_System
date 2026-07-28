public class Pitzaabeef : IFood
{
    FoodItem foodItem = new FoodItem();


    public void Make()
    {
        foodItem.Name = "Pitzaa";
        foodItem.price = 15;
        foodItem.Description = "A delicious cheesy pizza loaded with savory, juicy seasoned beef.";
        foodItem.DietaryTags.Add("pizza");
        foodItem.DietaryTags.Add("beef");
        Console.WriteLine("BigMac is Pitzaabeef....");
    }
}

