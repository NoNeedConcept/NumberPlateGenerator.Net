using Xunit;

namespace NumberPlateGenerator.Net.Core.Test
{
    public class NameplateTests
    {
        [Fact]
        public void NumberPlateTest()
        {
            var result = NumberPlate.GetGenerator(Countries.Unknown);
            Assert.NotNull(result);
            Assert.IsType<TestGenerator>(result);
            Assert.Equal(Countries.Unknown, result.Type);
        }
    }
}