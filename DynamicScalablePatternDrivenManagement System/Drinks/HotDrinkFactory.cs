public class HotDrinkFactory : DrinkFactory
{
    public override IDrinks CreateDrink(string type)
    {
        return type.ToLower() switch
        {
            "coffee" => new Coffee(),
            "tea" => new Tea(),
            _=> throw new ArgumentException("Invalid type")
        };
    }
}

