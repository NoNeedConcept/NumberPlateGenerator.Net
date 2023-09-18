using Xunit;

namespace NumberPlateGenerator.Net.Core.Test
{
    public class NameplateTests
    {
<<<<<<< HEAD
        var result = NumberPlate.GetGenerator(NumberPlateType.Unknown);
        Assert.NotNull(result);
        Assert.IsType<TestGenerator>(result);
        Assert.Equal(TestGenerator.Type, result.NumberPlateType);
=======
        [Fact]
        public void NumberPlateTest()
        {
            var result = NumberPlate.GetGenerator(NumberPlateType.Unknown);
            Assert.NotNull(result);
            Assert.IsType<TestGenerator>(result);
            Assert.Equal(NumberPlateType.Unknown, result.Type);
        }
>>>>>>> a7be1f5 (update)
    }
}