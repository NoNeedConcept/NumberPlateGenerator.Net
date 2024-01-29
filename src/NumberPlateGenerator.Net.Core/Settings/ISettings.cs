using NumberPlateGenerator.Net.Core.CustomTypes;

namespace NumberPlateGenerator.Net.Core.Settings
{
    public interface ISettings
    {
        DateRange Range { get; }
    }
}
