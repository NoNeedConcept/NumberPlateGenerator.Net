namespace NumberPlateGenerator.Net.Core
{
    public interface IGenerator
    {
        Countries Type { get; }

        ILicensePlate<TSettings> Generate<TSettings>(TSettings settings) where TSettings : ISettings;
    }
}
