public abstract class DrinkFactory
{
    public abstract IDrinks CreateDrink(string type);

    //// A static method, so we can call it directly using the class name: DrinkFactory.GetFactory.
    public static DrinkFactory GetFactory(string category)
    {
        return category.ToLower() switch
        {
            "hot" => new HotDrinkFactory(),           
            "Cold" => new ColdDrinkFactor(),
            _=>throw new ArgumentException("Invalid category")
        };
    }
}

