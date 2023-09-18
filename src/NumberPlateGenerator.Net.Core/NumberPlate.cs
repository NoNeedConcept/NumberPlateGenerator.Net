﻿using System.Collections.Generic;
using NumberPlateGenerator.Net.Core;

public static class NumberPlate
{
    private static IDictionary<NumberPlateType, IGenerator> _supportetNumberPlateTypes = new Dictionary<NumberPlateType, IGenerator> (){
        { NumberPlateType.Unknown , new TestGenerator() },
        
    };
    
    public static IGenerator GetGenerator(NumberPlateType type)
    {
        return _supportetNumberPlateTypes[type];
    }
}
