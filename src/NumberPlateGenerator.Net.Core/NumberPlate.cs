using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NumberPlateGenerator.Net.Core.Generators;

namespace NumberPlateGenerator.Net.Core
{

    public class NUmberPlate{
        private IDictionary<Countries, IGenerator> _supportetNumberPlateTypes = new Dictionary<Countries, IGenerator> (){
            { Countries.Unknown , new TestGenerator() },
            
        };
        
        public IGenerator GetGenerator(Countries type)
        {

                return new TestGenerator();
        }
    }
}