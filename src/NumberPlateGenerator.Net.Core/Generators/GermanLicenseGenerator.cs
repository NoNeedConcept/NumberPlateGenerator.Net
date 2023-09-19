namespace NumberPlateGenerator.Net.Core.Generators
{
    public class GermanLicenseGenerator : IGenerator
    {
        public Countries Type => Countries.DE;

        public ILicensePlate<TSettings> Generate<TSettings>(TSettings settings) where TSettings : ISettings
        {
            throw new System.NotImplementedException();
        }

    }
}