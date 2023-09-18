using Xunit;

namespace NumberPlateGenerator.Net.Core.Test
{
    [Fact]
    public void NumberPlate_GetGenerator()
    {
        var result = NumberPlate.GetGenerator(NumberPlateType.Unknown);
        Assert.NotNull(result);
        Assert.IsType<TestGenerator>(result);
        Assert.Equal(TestGenerator.Type, result.NumberPlateType);
    }

}