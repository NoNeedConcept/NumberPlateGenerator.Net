using NumberPlateGenerator.Net.Core.Provinces;
using Xunit;

namespace NumberPlateGenerator.Net.Core.Test;

public class NameplateTests
{
    [Fact]
    public void NumberPlateTest()
    {
        var result = NumberPlate.GetGenerator(Countries.NL);
        Assert.NotNull(result);
        Assert.IsType<NLGenerator>(result);
        Assert.Equal(Countries.NL, result.Type);
    }

    [Fact]
    public void CorrectBitwiseOperator()
    {
        var germanId = 1 << 240;
        var nlId = 1 << 11;
        Assert.Equal((int)DProvinces.ZW, germanId);
        Assert.Equal((int)NLProvinces.Flevoland, nlId);
    }
}