namespace NumberPlateGenerator.Net.Core
{
    public interface IGenerator
    {
        NumberPlateType Type { get; }

        ILicensePlate<TSettings> Generate<TSettings>(TSettings settings) where TSettings : ISettings;
    }
}
