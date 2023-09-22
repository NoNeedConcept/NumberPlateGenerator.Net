namespace NumberPlateGenerator.Net.Core
{
    public class TestGenerator : GeneratorBase<TestLicensePlate, TestProvince, TestSettings>
    {
        public TestGenerator()
        {
        }

        public override TestLicensePlate Generate(TestSettings settings)
        {
            return default;
        }
    }
}
