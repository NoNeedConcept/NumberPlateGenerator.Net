using System;

namespace NumberPlateGenerator.Net.Core
{
    public interface ILicensePlate<TSettings> where TSettings : ISettings
    {
        string Text { get; }

        TSettings Settings { get; }

    }

    public abstract class LicensePlateBase<TSettings, TProvinceEnum> : ILicensePlate<TSettings> where TSettings : SettingsBase<TProvinceEnum> where TProvinceEnum : Enum
    {
        protected LicensePlateBase()
        { }

        public virtual string Text { get; protected set; } = string.Empty;
        public virtual TProvinceEnum PlateType { get; protected set; } = default;
        public virtual TSettings Settings { get; protected set; } = default;
    }
}
