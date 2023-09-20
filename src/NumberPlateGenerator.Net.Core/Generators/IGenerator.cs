using System;

namespace NumberPlateGenerator.Net.Core
{
    public interface IGenerator
    {
        Countries Type { get; }
    }

    public abstract class GeneratorBase<TLicensePlate, TProvince, TSettings> : IGenerator where TSettings : SettingsBase<TProvince> where TLicensePlate : LicensePlateBase<TSettings, TProvince>, new() where TProvince : Enum
    {
        public Countries Type { get; protected set; }

        public abstract TLicensePlate Generate(TSettings settings);
    }
}
