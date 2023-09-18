namespace NumberPlateGenerator.Net.Core
{
    public class TestGenerator : IGenerator
    {
        public TestGenerator()
        {
        }

         static NumberPlateType IGenerator.Type => NumberPlateType.Unkown;

        NumberPlateType IGenerator.NumberPlateType => Type;
    }
}
