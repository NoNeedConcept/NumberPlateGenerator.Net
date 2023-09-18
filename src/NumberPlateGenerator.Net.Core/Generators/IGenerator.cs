namespace NumberPlateGenerator.Net.Core
{
    public interface IGenerator
    {
        NumberPlateType Type { get; }

        NumberPlateType GetType();

        NumberPlateType ValueType { get; set; }
    }
}
