using System;

namespace NumberPlateGenerator.Net.Core.Provinces
{
    [Flags]
    public enum NLProvinces : short
    {
        Unknown = 0,
        Groningen = 1 << 0,
        Friesland = 1 << 1,
        Drenthe = 1 << 2,
        Overijssel = 1 << 3,
        Gelderland = 1 << 4,
        Utrecht = 1 << 5,
        Noord_Holland = 1 << 6,
        Zuid_Holland = 1 << 7,
        Zeeland = 1 << 8,
        Noord_Brabant = 1 << 9,
        Limburg = 1 << 10,
        Flevoland = 1 << 11,
    }
}
