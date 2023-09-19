namespace NumberPlateGenerator.Net.Core.Generators
{
    public interface IGenerator
    {
        Countries Type { get; }

        ILicensePlate<TSettings> Generate<TSettings>(TSettings settings) where TSettings : ISettings;
    }

}
