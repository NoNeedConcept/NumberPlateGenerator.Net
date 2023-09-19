using System;

namespace NumberPlateGenerator.Net.Core
{
    public interface ISettings
    {
        int ProvinceAsInt { get; }
    }


    public abstract class SettingsBase<TProvinceEnum> : ISettings where TProvinceEnum : Enum
    {
        protected SettingsBase()
        { }

        public virtual TProvinceEnum Province { get; protected set; }

        public int ProvinceAsInt => Convert.ToInt32(Province);
    }
}
