﻿using System;

namespace NumberPlateGenerator.Net.Core
{
    [Flags]
    public enum Countries : int
    {
        Unknown = 0,



        DE = 1 << 0,
        NL = 1 << 1,
        B = 1 << 2,
        FR = 1 << 3,

        EU = FR | B | NL | DE 

    }
}
