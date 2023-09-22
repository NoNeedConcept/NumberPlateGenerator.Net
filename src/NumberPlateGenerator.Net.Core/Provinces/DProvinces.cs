using System;

namespace NumberPlateGenerator.Net.Core.Provinces
{
    [Flags]
    public enum DProvinces
    {
        A, //Augsburg
        ABI, //Anhalt,//Bitterfeld
        AB, //Aschaffenburg
        AIC, //Aichach,//Friedberg
        AS, //Amberg
        AT, //Altentreptow
        AÖ, //Altötting
        B, //Berlin
        BIT, //Bitburg,//Prüm
        BIR, //Birkenfeld
        BN, //Bonn
        BO, //Bochum
        BOR, //Borken
        BRK, //Landkreis Bad Kissingen
        BT, //Bayreuth
        BU, //Burghausen
        BÜZ, //Bützow
        CE, //Celle
        C, //Chemnitz
        COC, //Cochem,//Zell
        COE, //Coesfeld
        DA, //Darmstadt
        DAU, //Daun
        DN, //Düren
        DGF, //Dingolfing,//Landau
        DÜW, //Bad Dürkheim
        DS, //Dessau,//Roßlau
        DD, //Dresden
        E, //Essen
        EA, //Ilm,//Kreis
        EBE, //Ebersberg
        ED, //Erding
        EDW, //Elbe,//Weser
        EF, //Erfurt
        ES, //Esslingen
        F, //Frankfurt
        FFB, //Fürstenfeldbruck
        FF, //Frankfurt (Oder)
        FRG, //Freyung,//Grafenau
        FY, //Friesland (Netherlands)
        G, //Göttingen
        GER, //Gerolstein
        GI, //Gießen
        GTH, //Gotha
        GÖ, //Göttingen
        GÖD, //Görlitz
        H, //Hanover (Hannover)
        HAM, //Hamm
        HD, //Heidelberg
        HIG, //Werra,//Meißner,//Kreis
        HSK, //Hochsauerlandkreis
        HX, //Höxter
        HST, //Rostock
        IN, //Ingolstadt
        KA, //Karlsruhe
        KH, //Bad Kreuznach
        KL, //Kaiserslautern
        K, //Cologne (Köln)
        KLE, //Kleve
        KIB, //Kaiserslautern
        KK, //Kerkrade (Netherlands)
        KM, //Kamenz
        KO, //Koblenz
        KÖZ, //Kötzting
        KP, //Kempten (Allgäu)
        KUS, //Kusel
        L, //Leipzig
        LAI, //Landau in der Pfalz
        LB, //Ludwigsburg
        LIP, //Lippe
        LL, //Landsberg am Lech
        LU, //Ludwigshafen
        LUP, //Ludwigslust,//Parchim
        LS, //Lüdenscheid
        M, //Munich (München)
        MA, //Mannheim
        MEK, //Saale,//Orla,//Kreis
        MG, //Mönchengladbach
        MKK, //Main,//Kinzig,//Kreis
        MTK, //Main,//Taunus,//Kreis
        MS, //Münster
        MSE, //Müritz
        NU, //Neuburg,//Schrobenhausen
        NVP, //Neustadt an der Waldnaab
        NWM, //Nordwestmecklenburg
        NZ, //Neustrelitz
        OA, //Garmisch,//Partenkirchen
        OAL, //Ostallgäu
        OB, //Oberhausen
        OBG, //Oberhavel
        OC, //Oberspreewald,//Lausitz
        OD, //Oder,//Spree
        OE, //Olpe
        OF, //Offenbach am Main
        OG, //Ortenaukreis
        OH, //Stormarn (Germany)
        OHA, //Osterode am Harz
        OHV, //Oberhavel
        OHZ, //Osterholz
        OK, //Saalekreis
        OL, //Oldenburg (Oldb)
        OP, //Ober,//Pfalz (Germany)
        OS, //Osnabrück
        OSL, //Oberspreewald,//Lausitz
        OVI, //Ostvorpommern
        OVP, //Ostvorpommern
        OZ, //Ludwigslust,//Parchim
        P, //Potsdam
        PA, //Passau
        PAF, //Pfaffenhofen
        PAN, //Passau
        PB, //Paderborn
        PCH, //Ludwigslust,//Parchim
        PE, //Peine
        PI, //Starnberg
        PL, //Potsdam
        PLÖ, //Ploen
        PM, //Potsdam,//Mittelmark
        PR, //Prignitz
        PS, //Pirmasens
        PW, //Pw
        R, //Regensburg
        RA, //Ravensburg
        RD, //Rendsburg,//Eckernförde
        RDG, //Rostock
        RE, //Recklinghausen
        REG, //Regen
        REM, //Rems,//Murr,//Kreis
        RES, //Augsburg
        RG, //Rosenheim
        RH, //Rhein,//Hunsrück,//Kreis
        RHE, //Rhein,//Erft,//Kreis
        RI, //Rheinisch,//Bergischer Kreis
        RIE, //Riesa,//Großenhain
        RO, //Rosenheim
        ROW, //Rotenburg (Wümme)
        RPL, //Rheinland,//Pfalz
        RÜD, //Marburg,//Biedenkopf
        RÜG, //Rügen
        RV, //Ravensburg
        RW, //Rheinland,//Pfalz
        RZ, //Rendsburg
        S, //Stuttgart
        SAD, //Schwandorf
        SAK, //Saalekreis
        SAN, //Wunsiedel im Fichtelgebirge
        SB, //Saarbrücken
        SBG, //Saarburg
        SBN, //Saarburg
        SBÜ, //Saarburg
        SC, //Schwarzwald,//Baar,//Kreis
        SDH, //Suhl
        SE, //Segeberg
        SEG, //Stendal
        SEK, //Salzlandkreis
        SEL, //Seelow
        SFA, //Saalfeld,//Rudolstadt
        SG, //Sangerhausen
        SGH, //Saalekreis
        SH, //Schleswig,//Holstein
        SHA, //Schwäbisch Hall
        SHL, //Suhl
        SI, //Siegen
        SIG, //Sigmaringen
        SIM, //Simmern
        SL, //Saarlouis
        SLS, //Saarlouis
        SLÜ, //Schleiz
        SM, //Schmölln
        SN, //Schwerin
        SO, //Solingen
        SOK, //Saale,//Orla,//Kreis
        SON, //Sonneberg
        SP, //Speyer
        SPN, //Spree,//Neiße
        SR, //Straubing
        SRB, //Straubing
        SRO, //Saalfeld,//Rudolstadt
        ST, //Stendal
        STA, //Starnberg
        STL, //Stollberg
        SU, //Rhein,//Sieg,//Kreis
        SW, //Schwerin
        SWA, //Schwabach
        SWK, //Saale,//Orla,//Kreis
        SWS, //Saarwellingen
        SY, //Schmölln
        TBB, //Main,//Tauber,//Kreis
        TE, //Tecklenburg
        THL, //Thuringia
        TIR, //Tirschenreuth
        TO, //Torgau
        TÖL, //Bad Tölz,//Wolfratshausen
        TR, //Trier
        TUT, //Tuttlingen
        UE, //Uelzen
        UER, //Uecker,//Randow
        UFF, //Uffenheim
        UG, //St. Georgen im Schwarzwald
        UL, //Ulm
        UM, //Unna
        UN, //Unna
        USI, //Usti nad Orlici
        V, //Vogtlandkreis
        VER, //Verden
        VG, //Völklingen
        VIB, //Vogtlandkreis
        VIE, //Viersen
        VK, //Völklingen
        VR, //Vorpommern,//Rügen
        VW, //Vilseck
        W, //Wesel
        WAF, //Warendorf
        WB, //Wittenberg
        WBS, //Wittenberg
        WEN, //Weiden
        WER, //Wertingen
        WES, //Wesel
        WF, //Wolfenbüttel
        WHV, //Wilhelmshaven
        WI, //Wiesbaden
        WK, //Wittenberg
        WL, //Ludwigslust,//Parchim
        WM, //Weilheim
        WND, //St. Wendel
        WO, //Wolfenbüttel
        WOB, //Wolfsburg
        WST, //Nordwestmecklenburg
        WT, //Rastatt
        WUG, //Weißenburg,//Gunzenhausen
        WÜ, //Würzburg
        WUN, //Wunsiedel im Fichtelgebirge
        WUR, //Bad Wurzach
        WW, //Westerwaldkreis
        WZ, //Weilheim,//Schongau
        WZL, //Weilheim,//Schongau
        Z, //Zwickau
        ZE, //Zerbst
        ZI, //Zittau
        ZIG, //Zittau
        ZP, //Zschopau
        ZW, //Zweiwbrücken
    }
}