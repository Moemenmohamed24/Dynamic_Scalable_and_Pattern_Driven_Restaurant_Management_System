public class ColdDrinkFactor : DrinkFactory
{
    public override IDrinks CreateDrink(string type)
    {
        return type.ToLower() switch
        {
            "Cola" => new Cola(),
            "Juice" => new Juice(),
            _ => throw new ArgumentException("Invalid type")
        };
    }
}

