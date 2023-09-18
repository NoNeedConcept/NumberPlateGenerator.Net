namespace NumberPlateGenerator.Net.Core
{
    public class TestGenerator : IGenerator
    {
        public TestGenerator()
        {
        }

        public NumberPlateType Type => NumberPlateType.Unknown;
    }
}
