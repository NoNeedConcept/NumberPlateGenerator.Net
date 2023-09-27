using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using NumberPlateGenerator.Net.Core.CustomTypes;
using NumberPlateGenerator.Net.Core.Provinces;

namespace NumberPlateGenerator.Net.Core.Settings
{
    public class NLSettings : SettingsBase<NLProvinces>
    {
        public DateRange TimeRange { get; internal set; }

        public NLSettings()
        { }
    }

    public class NLSettingsBuilder : SettingsBuilderBase<NLSettings>
    {

        private readonly NLSettings _nlSettings = new NLSettings();

        public static NLSettingsBuilder Create() => new NLSettingsBuilder();

        public NLSettingsBuilder AddTimeRange(DateRange range){
            if(range.Start.Year < 1905)
            {
                throw new ArgumentOutOfRangeException($"start date can not be before 1905");
            }

            _nlSettings.TimeRange = range;
            return this;
        }


        public NLSettingsBuilder AddProvince(NLProvinces provinces){
            
            if(1951 >= _nlSettings.TimeRange?.Start.Year){
                // todo: better exception handling ??? :(
                throw new ArgumentOutOfRangeException($"");
            }

            _nlSettings.Province = provinces;

            return this;
        }

        public override NLSettings Build() => _nlSettings;
    }
}
