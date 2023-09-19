namespace NumberPlateGenerator.Net.Core
{
    public class TestLicensePlate : LicensePlateBase<TestSettings, NumberPlateType>
    {
        public TestLicensePlate()
        {
            base.PlateType = NumberPlateType.DE;
        }

        public override string Text { get; protected set; } = string.Empty;
        public override TestSettings Settings { get; protected set; } = null;
    }
}
