using System;
using NumberPlateGenerator.Net.Core.LicensePlates;
using NumberPlateGenerator.Net.Core.Settings;

namespace NumberPlateGenerator.Net.Core.Generators
{
    public abstract class GeneratorBase<TLicensePlate, TProvince, TSettings, TSettingsBuilder> : IGenerator
        where TLicensePlate : LicensePlateBase<TSettings, TProvince>, new()
        where TProvince : Enum
        where TSettings : SettingsBase<TProvince>, new()
        where TSettingsBuilder : SettingsBuilderBase<TSettings>
    {
        public Countries Type { get; protected set; }

        public abstract TLicensePlate Generate(Func<TSettingsBuilder, TSettings> configure);

        public ILicensePlate Generate<TCustomSettings>(Func<SettingsBuilderBase<TCustomSettings>, TCustomSettings> configure) where TCustomSettings : ISettings, new() => Generate(configure);
    }
}
