﻿namespace NumberPlateGenerator.Net.Core
{
    public enum NumberPlateType : byte
    {
        Unknown = 0,
        DE = 1 << 0,
        NL = 1 << 1,
        B = 1 << 2,
        FR = 1 << 3,

    }
}
