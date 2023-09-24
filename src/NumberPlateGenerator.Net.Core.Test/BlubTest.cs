using Xunit;

namespace NumberPlateGenerator.Net.Core.Test;

public class BlubTest
{
    [Fact]
    public void Blub()
    {
        Assert.True(new Blub().GetTrue);
    }
}