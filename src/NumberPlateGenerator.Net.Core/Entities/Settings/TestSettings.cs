namespace NumberPlateGenerator.Net.Core
{
    public class TestSettings : SettingsBase<TestProvince>
    {
        public TestSettings()
        {
            Province = TestProvince.KEKW;
        }
    }

    public enum TestProvince
    {
        None = 0,
        KEKW = 1 << 0,
        LULW = 1 << 1,
    }
}
