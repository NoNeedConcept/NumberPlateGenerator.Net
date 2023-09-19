using System.Collections.Generic;
using NumberPlateGenerator.Net.Core.Generators;

namespace NumberPlateGenerator.Net.Core
{
    private static IDictionary<Countries, IGenerator> _supportetNumberPlateTypes = new Dictionary<Countries, IGenerator> (){
        { Countries.Unknown , new TestGenerator() },
        
    };
    
    public static IGenerator GetGenerator(Countries type)
    {
        private static IDictionary<NumberPlateType, IGenerator> _supportetNumberPlateTypes = new Dictionary<NumberPlateType, IGenerator> (){
            { NumberPlateType.Unknown , new TestGenerator() },
        
        };
    
        public static IGenerator GetGenerator(NumberPlateType type)
        {
            return _supportetNumberPlateTypes[type];
        }
    }
}
