using System;
using NumberPlateGenerator.Net.Core.LicensePlates;
using NumberPlateGenerator.Net.Core.Settings;

namespace NumberPlateGenerator.Net.Core.Generators
{
    public interface IGenerator
    {
        Countries Type { get; }

        ILicensePlate Generate<TSettings>(Func<SettingsBuilderBase<TSettings>, TSettings> configure) where TSettings : ISettings;
    }

    public abstract class GeneratorBase<TLicensePlate, TProvince, TSettings, TSettingsBuilder> : IGenerator
    where TLicensePlate : LicensePlateBase<TSettings, TProvince>, new()
    where TProvince : Enum
    where TSettings : SettingsBase<TProvince>
    where TSettingsBuilder : SettingsBuilderBase<TSettings>
    {
        public Countries Type { get; protected set; }

        public abstract TLicensePlate Generate(Func<TSettingsBuilder, TSettings> configure);

        public ILicensePlate Generate<TSettings1>(Func<SettingsBuilderBase<TSettings1>, TSettings1> configure) where TSettings1 : ISettings => Generate(configure);
    }

}
