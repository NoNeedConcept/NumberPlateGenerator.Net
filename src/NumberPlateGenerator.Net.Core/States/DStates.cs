using System;

namespace NumberPlateGenerator.Net.Core.States
{
    [Flags]
    public enum DStates : short
    {
        Unknown = 0,
        Hamburg = 1 << 0,
        Berlin = 1 << 1,
        Bavaria = 1 << 2,
        BadenWurttemberg = 1 << 3,
        RhinelandPalatinate = 1 << 4,
        Hesse = 1 << 5,
        Thuringia = 1 << 6,
        Saxony = 1 << 7,
        Brandenburg = 1 << 8,
        SaxonyAnhalt = 1 << 9,
        SchleswigHolstein = 1 << 10,
        LowerSaxony = 1 << 11,
        NorthRhineWestphalia = 1 << 12,
        Saarland = 1 << 13,
        MecklenburgVorpommern = 1 << 14,
    }
}
