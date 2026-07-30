public class SeatingFactory
{
    public static ISeatingPlace GetSeating(string type)
    {
        return type.ToLower() switch
        {
            "roof" => new RoofSeating(),
            "private" => new PrivatePlaceSeating(),
            "air" => new InTheAirSeating(),
        };
    }
}

