using System.Collections.Generic;
using NumberPlateGenerator.Net.Core.Generators;

namespace NumberPlateGenerator.Net.Core
{
    public static class NumberPlate
    {
        private static IDictionary<Countries, IGenerator> _supportedNumberPlateTypes = new Dictionary<Countries, IGenerator>()
        {
            {Countries.Unknown, null}
        };

        public static IGenerator GetGenerator(Countries type) => _supportedNumberPlateTypes[type];
    }
}