namespace NumberPlateGenerator.Net.Core.Test;

public class NumberPlateTests
{
    [Fact]
    public void Return_type_of_NumberPlate_Generate()
    {
        Assert.Null(NumberPlate.Generate(NumberPlateType.Unkown));
    }
}