using System.Collections.Generic;
using NumberPlateGenerator.Net.Core;

public static class NumberPlate
{
    private static IDictionary<Countries, IGenerator> _supportetNumberPlateTypes = new Dictionary<Countries, IGenerator> (){
        { Countries.Unknown , new TestGenerator() },
        
    };
    
    public static IGenerator GetGenerator(Countries type)
    {
        return _supportetNumberPlateTypes[type];
    }
}
