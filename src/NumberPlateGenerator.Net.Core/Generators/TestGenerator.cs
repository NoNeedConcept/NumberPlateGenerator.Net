using System.Runtime.InteropServices.ComTypes;

namespace NumberPlateGenerator.Net.Core
{
    public class TestGenerator : IGenerator
    {
        public TestGenerator()
        {
        }

        public NumberPlateType Type => NumberPlateType.Unknown;

        public ILicensePlate<TSettings> Generate<TSettings>(TSettings settings) where TSettings : ISettings
        {
            


            return default;
        }
    }
}
