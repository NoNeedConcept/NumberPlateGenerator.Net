using NumberPlateGenerator.Net.Core.Provinces;

namespace NumberPlateGenerator.Net.Core.Settings
{
    public class NLSettings : SettingsBase<NLProvinces>
    {
        public DateRange TimeRange { get; internal set; }

        public NLSettings()
        { }
    }

    public class NLSettingsBuilder{

        private readonly NLSettings _nlSettings = new NLSettings();

        public static NLSettingsBuilder Create() => new NLSettingsBuilder();

        public NLSettingsBuilder AddTimeRange(DateRange range){
            _nlSettings.TimeRange = range;
            return this;
        }
    }
}
