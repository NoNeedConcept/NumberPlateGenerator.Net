using System;
using NumberPlateGenerator.Net.Core.Settings;

namespace NumberPlateGenerator.Net.Core
{
    public static class NLSettingsExtensions
    {
        public static NLSettings AddTimeRange(this NLSettings settings, DateRange range)
        {
            settings.TimeRange = range;
            return settings;
        }
    }
}
