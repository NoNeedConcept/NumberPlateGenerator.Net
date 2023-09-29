using System;
using NumberPlateGenerator.Net.Core.LicensePlates;
using NumberPlateGenerator.Net.Core.Settings;

namespace NumberPlateGenerator.Net.Core.Generators
{
    public interface IGenerator
    {
        Countries Type { get; }

        ILicensePlate Generate<TSettings>(Func<SettingsBuilderBase<TSettings>, TSettings> configure) where TSettings : ISettings, new();
    }
}
