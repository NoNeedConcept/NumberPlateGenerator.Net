namespace NumberPlateGenerator.Net.Core
{
    public class TestLicensePlate : LicensePlateBase<TestSettings, Countries>
    {
        public TestLicensePlate()
        {

        }

        public override Countries PlateType => Settings.Province;

        public override string Text { get; protected set; } = string.Empty;
        public override TestSettings Settings { get; protected set; } = null;
    }
}
