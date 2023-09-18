using Xunit;

namespace NumberPlateGenerator.Net.Core.Test
{
    public class NameplateTests
    {
        [Fact]
        public void NumberPlateTest()
        {
            var result = NumberPlate.GetGenerator(NumberPlateType.Unknown);
            Assert.NotNull(result);
            Assert.IsType<TestGenerator>(result);
            Assert.Equal(NumberPlateType.Unknown, result.Type);
        }
    }
}