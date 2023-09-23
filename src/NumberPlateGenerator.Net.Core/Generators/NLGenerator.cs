using System;
using NumberPlateGenerator.Net.Core.Generators;

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
            throw new NotImplementedException();
        }
    }
}
