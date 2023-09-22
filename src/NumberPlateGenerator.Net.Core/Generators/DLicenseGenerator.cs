namespace NumberPlateGenerator.Net.Core.Generators
{
    public class DLicenseGenerator : IGenerator
    {
        public Countries Type => Countries.D;

        public ILicensePlate<TSettings> Generate<TSettings>(TSettings settings) where TSettings : ISettings
        {
            throw new System.NotImplementedException();
        }

    }
}