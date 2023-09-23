using System;
using NumberPlateGenerator.Net.Core.LicensePlates;
using NumberPlateGenerator.Net.Core.Settings;

namespace NumberPlateGenerator.Net.Core.Generators
{
    public interface IGenerator
    {
        Countries Type { get; }

        ILicensePlate Generate(ISettings settings);
    }

    public abstract class GeneratorBase<TLicensePlate, TProvince, TSettings> : IGenerator where TSettings : SettingsBase<TProvince> where TLicensePlate : LicensePlateBase<TSettings, TProvince>, new() where TProvince : Enum
    {
        public Countries Type { get; protected set; }

        public abstract TLicensePlate Generate(TSettings settings);

        public ILicensePlate Generate(ISettings settings) => Generate(settings as SettingsBase<TProvince>);
    }

}
