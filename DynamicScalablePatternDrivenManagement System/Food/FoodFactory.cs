public class FoodFactory
{

    public IFood CreateFood(string foodType)
    {
        return foodType.ToLower() switch
        {
            "bigmac" => new BigMac(),
            "pizza" => new Pitzaabeef(),
            "kfc" => new KFC(),
        };
    }
}

