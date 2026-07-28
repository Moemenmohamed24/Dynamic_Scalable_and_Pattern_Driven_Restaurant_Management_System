
/*
 * public interface IDrink
{
    public void Prepare();
}

*/

public struct FoodItem
{
    public FoodItem()
    {
    }

    public string Name { get; set; } = "";
    public double price { get; set; } = 0.0;
    public string Description { get; set; } = "";
    public List<string> DietaryTags { get; set; } = new List<string>();
}

