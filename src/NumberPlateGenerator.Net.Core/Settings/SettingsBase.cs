using System;
using NumberPlateGenerator.Net.Core.CustomTypes;

namespace NumberPlateGenerator.Net.Core.Settings
{
    public abstract class SettingsBase<TProvinceEnum> : ISettings where TProvinceEnum : Enum
    {
        public virtual TProvinceEnum Province { get; protected set; }

        public virtual DateRange Range { get; protected set; }
    }
}
