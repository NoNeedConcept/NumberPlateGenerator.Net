namespace NumberPlateGenerator.Net.Core.Settings
{
    public abstract class SettingsBuilderBase<TSettings>  where TSettings : ISettings
    {
        public abstract TSettings Build();

        public static implicit operator TSettings(SettingsBuilderBase<TSettings> settings) => settings.Build();
    }
}
