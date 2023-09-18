namespace NumberPlateGenerator.Net.Core;

public static class NumberPlate
{
    private static IDictionary<NumberPlateType, object> _supportetNumberPlateTypes = new Dictionary<NumberPlateType, object> (){
        {NumberPlateType.Unkown, null },
            
    };

    public static object Generate(NumberPlateType type)
    {
        return _supportetNumberPlateTypes[type];
    }
}
