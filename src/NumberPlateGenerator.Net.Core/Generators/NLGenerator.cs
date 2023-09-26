using System;
using NumberPlateGenerator.Net.Core.Generators;
using NumberPlateGenerator.Net.Core.LicensePlates;
using NumberPlateGenerator.Net.Core.Provinces;
using NumberPlateGenerator.Net.Core.Settings;

namespace NumberPlateGenerator.Net.Core
{
    public class NLGenerator : GeneratorBase<NLLicensePlate, NLProvinces, NLSettings>
    {
        public NLGenerator()
        {
            Type = Countries.NL;
        }

        public override NLLicensePlate Generate(NLSettings settings)
        {
            return default;
        }
    }
}
