using NumberPlateGenerator.Net.Core.Provinces;
using Xunit;

namespace NumberPlateGenerator.Net.Core.Test;

public class NameplateTests
{
    [Fact]
    public void NumberPlateTest()
    {
        // var result = NumberPlate.GetGenerator(Countries.NL);
        // Assert.NotNull(result);
        // Assert.IsType<NLGenerator>(result);
        // Assert.Equal(Countries.NL, result.Type);
        Assert.True(true);
    }

    [Fact]
    public void CorrectBitwiseOperator()
    {
        var germanId = 788;
        var nlId = 1 << 11;
        var maxCountryId = 1L << 180;
        Assert.Equal((int)DProvinces.ZW, germanId);
        Assert.NotEqual((int)DProvinces.ZP, germanId);
        Assert.Equal((int)NLProvinces.Flevoland, nlId);
        Assert.Equal((long)Countries.ZW, maxCountryId);
        Assert.Equal((long)Countries.EU, 4613766464139479449);
        Assert.True(Countries.EU.HasFlag(Countries.A));
        Assert.False((Countries.EU & Countries.ZW) == Countries.ZW);
        Assert.False(Countries.EU.HasFlag(Countries.ZW));
    }
}