using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NumberPlateGenerator.Net.Core.Generators;

namespace NumberPlateGenerator.Net.Core
{

    public class NumberPlate{
        
        private IDictionary<Countries, IGenerator> _supportedNumberPlateTypes = new Dictionary<Countries, IGenerator> (){
            { Countries.Unknown , new TestGenerator() },
            
        };
        
        public static IGenerator GetGenerator(Countries type)
        {

                return new TestGenerator();
        }
    }
}