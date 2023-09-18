namespace NumberPlateGenerator.Net.Core;

public interface IGenerator
{
   static NumberPlateType Type { get; }

   NumberPlateType NumberPlateType { get; }
}
