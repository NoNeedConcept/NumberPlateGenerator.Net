using System.Collections.Generic;
using NumberPlateGenerator.Net.Core.Generators;

namespace NumberPlateGenerator.Net.Core
{

    public class NumberPlate
    {

        private static IDictionary<Countries, IGenerator> _supportedNumberPlateTypes = new Dictionary<Countries, IGenerator>(){};

        public static IGenerator GetGenerator(Countries type) => _supportedNumberPlateTypes[type];
    }
}