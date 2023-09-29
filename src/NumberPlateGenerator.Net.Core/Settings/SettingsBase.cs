using System;

namespace NumberPlateGenerator.Net.Core.Settings
{
    public abstract class SettingsBase<TProvinceEnum> : ISettings where TProvinceEnum : Enum
    {
        protected SettingsBase()
        { }

        public virtual TProvinceEnum Province { get; protected set; }
    }
}
