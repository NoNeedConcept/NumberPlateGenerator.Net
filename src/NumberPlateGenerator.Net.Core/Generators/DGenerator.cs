using NumberPlateGenerator.Net.Core.LicensePlates;
using NumberPlateGenerator.Net.Core.Provinces;
using NumberPlateGenerator.Net.Core.Settings;

namespace NumberPlateGenerator.Net.Core.Generators
{
    public class DGenerator : GeneratorBase<DLicensePlate, DProvinces, DSettings>
    {
        public override DLicensePlate Generate(DSettings settings)
        {
            return default;
        }

    }
}