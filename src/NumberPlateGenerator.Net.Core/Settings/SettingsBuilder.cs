using NumberPlateGenerator.Net.Core.Settings;

namespace NumberPlateGenerator.Net.Core
{
    public abstract class SettingsBuilderBase<TSettings>  where TSettings : ISettings
    {
        public abstract TSettings Build();

        public static implicit operator TSettings(SettingsBuilderBase<TSettings> settings) => settings.Build();
    }
}
