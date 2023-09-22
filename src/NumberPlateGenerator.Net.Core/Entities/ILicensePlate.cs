using System;

namespace NumberPlateGenerator.Net.Core
{
    public interface ILicensePlate
    {
        string Text { get; }
    }

    public abstract class LicensePlateBase<TSettings, TProvince> : ILicensePlate where TSettings : SettingsBase<TProvince> where TProvince : Enum
    {
        protected LicensePlateBase()
        { }

        public virtual string Text { get; protected set; } = string.Empty;
        public virtual TSettings Settings { get; protected set; } = default;
        
        public static implicit operator string(LicensePlateBase<TSettings, TProvince> license) => license.Text;
        public override string ToString() => Text;
    }
}
