﻿using System.ComponentModel;

namespace JD_XI_Editor.Models.Enums.DrumKit
{
    internal enum Wave
    {
        [Description("000: Off")] Off = 0x0,
        [Description("001: CR-78 Kick P")] Cr78KickP = 0x1,
        [Description("002: TR-606 Kick P")] Tr606KickP,
        [Description("003: TR-808 Kick 1a P")] Tr808Kick1aP,
        [Description("004: TR-808 Kick 1b P")] Tr808Kick1bP,
        [Description("005: TR-808 Kick 1c P")] Tr808Kick1cP,
        [Description("006: TR-808 Kick 2a P")] Tr808Kick2aP,
        [Description("007: TR-808 Kick 2b P")] Tr808Kick2bP,
        [Description("008: TR-808 Kick 2c P")] Tr808Kick2cP,
        [Description("009: TR-808 Kick 3a P")] Tr808Kick3aP,
        [Description("010: TR-808 Kick 3b P")] Tr808Kick3bP,
        [Description("011: TR-808 Kick 3c P")] Tr808Kick3cP,
        [Description("012: TR-808 Kick 4a P")] Tr808Kick4aP,
        [Description("013: TR-808 Kick 4b P")] Tr808Kick4bP,
        [Description("014: TR-808 Kick 4c P")] Tr808Kick4cP,
        [Description("015: TR-808 Kick 1L p")] Tr808Kick1Lp,
        [Description("016: TR-808 Kick 2L p")] Tr808Kick2Lp,
        [Description("017: TR-909 Kick 1a P")] Tr909Kick1aP,
        [Description("018: TR-909 Kick 1b P")] Tr909Kick1bP,
        [Description("019: TR-909 Kick 1c P")] Tr909Kick1cP,
        [Description("020: TR-909 Kick 2b P")] Tr909Kick2bP,
        [Description("021: TR-909 Kick 2c P")] Tr909Kick2cP,
        [Description("022: TR-909 Kick 3 P")] Tr909Kick3P,
        [Description("023: TR-909 Kick 4")] Tr909Kick4,
        [Description("024: TR-909 Kick 5")] Tr909Kick5,
        [Description("025: TR-909 Kick 6")] Tr909Kick6,

        [Description("026: TR-909 Distorted Kick P")]
        Tr909DistortedKickP,
        [Description("027: TR-909 Kick Lp")] Tr909KickLp,
        [Description("028: TR-707 Kick 1 P")] Tr707Kick1P,
        [Description("029: TR-707 Kick 2 P")] Tr707Kick2P,
        [Description("030: TR-626 Kick 1 P")] Tr626Kick1P,
        [Description("031: TR-626 Kick 2 P")] Tr626Kick2P,
        [Description("032: Analog Kick 1")] AnalogKick1,
        [Description("033: Analog Kick 2")] AnalogKick2,
        [Description("034: Analog Kick 3")] AnalogKick3,
        [Description("035: Analog Kick 4")] AnalogKick4,
        [Description("036: Analog Kick 5")] AnalogKick5,
        [Description("037: Plastic Kick 1")] PlasticKick1,
        [Description("038: Plastic Kick 2")] PlasticKick2,
        [Description("039: Synth Kick 1")] SynthKick1,
        [Description("040: Synth Kick 2")] SynthKick2,
        [Description("041: Synth Kick 3")] SynthKick3,
        [Description("042: Synth Kick 4")] SynthKick4,
        [Description("043: Synth Kick 5")] SynthKick5,
        [Description("044: Synth Kick 6")] SynthKick6,
        [Description("045: Synth Kick 7")] SynthKick7,
        [Description("046: Synth Kick 8")] SynthKick8,
        [Description("047: Synth Kick 9")] SynthKick9,
        [Description("048: Synth Kick10")] SynthKick10,
        [Description("049: Synth Kick11")] SynthKick11,
        [Description("050: Synth Kick12")] SynthKick12,
        [Description("051: Synth Kick13")] SynthKick13,
        [Description("052: Synth Kick14")] SynthKick14,
        [Description("053: Synth Kick15")] SynthKick15,
        [Description("054: Vint Kick P")] VintageKickP,
        [Description("055: Jungle KickP")] JungleKickP,
        [Description("056: Hash Kick 1 P")] HashKick1P,
        [Description("057: Hash Kick 2 P")] HashKick2P,
        [Description("058: Lite Kick P")] LiteKickP,
        [Description("059: Dry Kick 1")] DryKick1,
        [Description("060: Dry Kick 2")] DryKick2,
        [Description("061: Tight Kick P")] TightKickP,
        [Description("062: Old Kick")] OldKick,
        [Description("063: Warm Kick P")] WarmKickP,
        [Description("064: Hush Kick P")] HushKickP,
        [Description("065: Power Kick")] PowerKick,
        [Description("066: Break Kick")] BreakKick,
        [Description("067: Turbo Kick")] TurboKick,
        [Description("068: TM-2 Kick 1")] Tm2Kick1,
        [Description("069: TM-2 Kick 2")] Tm2Kick2,
        [Description("070: PurePhatKck P")] PurePhatKckP,
        [Description("071: Bright Kick P")] BrightKickP,
        [Description("072: Low Bit Kick 1 P")] LoBitKick1P,
        [Description("073: Low Bit Kick 2 P")] LoBitKick2P,
        [Description("074: Dance Kick P")] DanceKickP,
        [Description("075: Hip Kick P")] HipKickP,
        [Description("076: Hip-Hop Kick")] HipHopKick,
        [Description("077: Mix Kick 1")] MixKick1,
        [Description("078: Mix Kick 2")] MixKick2,
        [Description("079: Wide Kick P")] WideKickP,
        [Description("080: LD Kick P")] LdKickP,
        [Description("081: SF Kick 1 P")] SfKick1P,
        [Description("082: SF Kick 2 P")] SfKick2P,
        [Description("083: TY Kick P")] TyKickP,
        [Description("084: WD Kick P")] WdKickP,
        [Description("085: Regular Kick P")] RegularKickP,
        [Description("086: Rock Kick P")] RockKickP,
        [Description("087: Jazz Dry Kick")] JazzDryKick,
        [Description("088: Jazz Kick P")] JazzKickP,
        [Description("089: CR-78 Snare")] Cr78Snare,
        [Description("090: TR-606 Snare 1 P")] Tr606Snare1P,
        [Description("091: TR-606 Snare 2 P")] Tr606Snare2P,

        [Description("092: TR-808 Snare 1a P")]
        Tr808Snare1aP,

        [Description("093: TR-808 Snare 1b P")]
        Tr808Snare1bP,

        [Description("094: TR-808 Snare 1c P")]
        Tr808Snare1cP,

        [Description("095: TR-808 Snare 2a P")]
        Tr808Snare2aP,

        [Description("096: TR-808 Snare 2b P")]
        Tr808Snare2bP,

        [Description("097: TR-808 Snare 2c P")]
        Tr808Snare2cP,

        [Description("098: TR-808 Snare 3a P")]
        Tr808Snare3aP,

        [Description("099: TR-808 Snare 3b P")]
        Tr808Snare3bP,

        [Description("100: TR-808 Snare 3c P")]
        Tr808Snare3cP,

        [Description("101: TR-909 Snare 1a P")]
        Tr909Snare1aP,

        [Description("102: TR-909 Snare 1b P")]
        Tr909Snare1bP,

        [Description("103: TR-909 Snare 1c P")]
        Tr909Snare1cP,

        [Description("104: TR-909 Snare 1d P")]
        Tr909Snare1dP,

        [Description("105: TR-909 Snare 2a P")]
        Tr909Snare2aP,

        [Description("106: TR-909 Snare 2b P")]
        Tr909Snare2bP,

        [Description("107: TR-909 Snare 2c P")]
        Tr909Snare2cP,

        [Description("108: TR-909 Snare 2d P")]
        Tr909Snare2dP,

        [Description("109: TR-909 Snare 3a P")]
        Tr909Snare3aP,

        [Description("110: TR-909 Snare 3b P")]
        Tr909Snare3bP,

        [Description("111: TR-909 Snare 3c P")]
        Tr909Snare3cP,

        [Description("112: TR-909 Snare 3d P")]
        Tr909Snare3dP,

        [Description("113: TR-909 Distorted Snare 1 P")]
        Tr909DistortedSnare1P,

        [Description("114: TR-909 Distorted Snare 2 P")]
        Tr909DistortedSnare2P,

        [Description("115: TR-909 Distorted Snare 3 P")]
        Tr909DistortedSnare3P,

        [Description("116: TR-707 Snare 1a P")]
        Tr707Snare1aP,

        [Description("117: TR-707 Snare 2a P")]
        Tr707Snare2aP,

        [Description("118: TR-707 Snare 1b P")]
        Tr707Snare1bP,

        [Description("119: TR-707 Snare 2b P")]
        Tr707Snare2bP,
        [Description("120: TR-626 Snare 1")] Tr626Snare1,
        [Description("121: TR-626 Snare 2")] Tr626Snare2,
        [Description("122: TR-626 Snare 3")] Tr626Snare3,

        [Description("123: TR-626 Snare 1a P")]
        Tr626Snare1aP,

        [Description("124: TR-626 Snare 3a P")]
        Tr626Snare3aP,

        [Description("125: TR-626 Snare 1b P")]
        Tr626Snare1bP,
        [Description("126: TR-626 Snare 2 P")] Tr626Snare2P,

        [Description("127: TR-626 Snare 3b P")]
        Tr626Snare3bP,
        [Description("128: Analog Snare 1")] AnalogSnare1,
        [Description("129: Analog Snare 2")] AnalogSnare2,
        [Description("130: Analog Snare 3")] AnalogSnare3,
        [Description("131: Synth Snare 1")] SynthSnare1,
        [Description("132: Synth Snare 2")] SynthSnare2,
        [Description("133: JUNO-106 Snare")] Juno106Snare,
        [Description("134: Sim Snare")] SimSnare,
        [Description("135: Jungle Snare 1")] JungleSnare1,
        [Description("136: Jungle Snare 2")] JungleSnare2,
        [Description("137: Jungle Snare 3")] JungleSnare3,
        [Description("138: Lite Snare")] LiteSnare,
        [Description("139: Lo-Bit Snare 1 P")] LoBitSnare1P,
        [Description("140: Lo-Bit Snare 2 P")] LoBitSnare2P,

        [Description("141: Hip-Hop Jazz Snare P")]
        HphpJazzSnareP,

        [Description("142: Pure Phat Snare P")]
        PurePhatSnareP,
        [Description("143: DRDisco Snare P")] DrDiscoSnareP,
        [Description("144: Ragga Snare")] RaggaSnare,
        [Description("145: Lo-Fi Snare")] LoFiSnare,
        [Description("146: DR Snare")] DrSnare,
        [Description("147: Dance Hall Snare")] DanceHallSnare,
        [Description("148: Break Snare")] BreakSnare,
        [Description("149: Piccolo Snare P")] PiccoloSnareP,
        [Description("150: TM-2 Snare 1")] Tm2Snare1,
        [Description("151: TM-2 Snare 2")] Tm2Snare2,
        [Description("152: Wood Snare RS")] WoodSnareRs,
        [Description("153: LD Snare")] LdSnare,
        [Description("154: SF Snare P")] SfSnareP,
        [Description("155: TY Snare")] TySnare,
        [Description("156: WD Snare P")] WdSnareP,
        [Description("157: Tight Snare")] TightSnare,

        [Description("158: Regular Snare 1 P")]
        RegSnare1P,

        [Description("159: Regular Snare 2 P")]
        RegSnare2P,
        [Description("160: Ballad Snare P")] BalladSnareP,
        [Description("161: Rock Snare 1 P")] RockSnare1P,
        [Description("162: Rock Snare 2 P")] RockSnare2P,
        [Description("163: LD Rim")] LdRim,
        [Description("164: SF Rim")] SfRim,
        [Description("165: TY Rim")] TyRim,
        [Description("166: WD Rim P")] WdRimP,
        [Description("167: Jazz Snare P")] JazzSnareP,
        [Description("168: Jazz Rim P")] JazzRimP,

        [Description("169: Jazz Brush Slap P")]
        JazzBrshSlapP,

        [Description("170: Jazz Brush Swsh P")]
        JazzBrshSwshP,
        [Description("171: Swish & Trn P")] SwishAndTrnP,
        [Description("172: CR-78 Rimshot")] Cr78Rimshot,
        [Description("173: TR-808 RimshotP")] Tr808RimshotP,
        [Description("174: TR-909 RimshotP")] Tr909RimshotP,
        [Description("175: TR-707 Rimshot")] Tr707Rimshot,
        [Description("176: TR-626 Rimshot")] Tr626Rimshot,
        [Description("177: Vintage Stick P")] VintStickP,
        [Description("178: Lo-Bit Stk P")] LoBitStkP,
        [Description("179: Hard Stick P")] HardStickP,
        [Description("180: Wild Stick P")] WildStickP,
        [Description("181: LD Cstick")] LdCstick,
        [Description("182: TY Cstick")] TyCstick,
        [Description("183: WD Cstick")] WdCstick,

        [Description("184: TR-606 High Tom P")]
        Tr606HighTomP,

        [Description("185: TR-808 High Tom P")]
        Tr808HighTomP,

        [Description("186: TR-909 High Tom P")]
        Tr909HighTomP,

        [Description("187: TR-707 High Tom P")]
        Tr707HighTomP,

        [Description("188: TR-626 High Tom 1")]
        Tr626HighTom1,

        [Description("189: TR-626 High Tom 2")]
        Tr626HighTom2,
        [Description("190: SimV Tom 1 P")] SimVTom1P,
        [Description("191: LD High Tom P")] LdHightTomP,
        [Description("192: SF High Tom P")] SfHightTomP,
        [Description("193: TY High Tom P")] TyHightTomP,
        [Description("194: TR-808 Mid Tom P")] Tr808MidTomP,
        [Description("195: TR-909 Mid Tom P")] Tr909MidTomP,
        [Description("196: TR-707 Mid Tom P")] Tr707MidTomP,
        [Description("197: TR-626 Mid Tom 1")] Tr626MidTom1,
        [Description("198: TR-626 Mid Tom 2")] Tr626MidTom2,
        [Description("199: SimV Tom 2 P")] SimVTom2P,
        [Description("200: LD Mid Tom P")] LdMidTomP,
        [Description("201: SF Mid Tom P")] SfMidTomP,
        [Description("202: TY Mid Tom P")] TyMidTomP,
        [Description("203: TR-606 Low Tom P")] Tr606LowTomP,
        [Description("204: TR-808 Low Tom P")] Tr808LowTomP,
        [Description("205: TR-909 Low Tom P")] Tr909LowTomP,
        [Description("206: TR-707 Low Tom P")] Tr707LowTomP,
        [Description("207: TR-626 Low Tom 1")] Tr626LowTom1,
        [Description("208: TR-626 Low Tom 2")] Tr626LowTom2,
        [Description("209: SimV Tom 3 P")] SimVTom3P,
        [Description("210: SimV Tom 4 P")] SimVTom4P,
        [Description("211: LD Low Tom P")] LdLowTomP,
        [Description("212: SF Low Tom P")] SfLowTomP,
        [Description("213: TY Low Tom P")] TyLowTomP,

        [Description("214: CR-78 Closed Hi Hat")]
        Cr78ClosedHiHat,

        [Description("215: TR-606 Closed Hi Hat")]
        Tr606ClosedHiHat,

        [Description("216: TR-808 Closed Hi Hat")]
        Tr808ClosedHiHat,

        [Description("217: TR-909 Closed Hi Hat 1")]
        Tr909ClosedHiHat1,

        [Description("218: TR-909 Closed Hi Hat 2")]
        Tr909ClosedHiHat2,

        [Description("219: TR-909 Closed Hi Hat 3")]
        Tr909ClosedHiHat3,

        [Description("220: TR-909 Closed Hi Hat 4")]
        Tr909ClosedHiHat4,

        [Description("221: TR-707 Closed Hi Hat")]
        Tr707ClosedHiHat,

        [Description("222: TR-626 Closed Hi Hat")]
        Tr626ClosedHiHat,

        [Description("223: HipHop Closed Hi Hat")]
        HipHopClosedHiHat,

        [Description("224: Lite Closed Hi Hat")]
        LiteClosedHiHat,

        [Description("225: Regular Closed Hi Hat")]
        RegClosedHiHat,

        [Description("226: Rock Closed Hi Hat")]
        RockClosedHiHat,

        [Description("227: S13 Closed Hi Hat Tip")]
        S13ClosedHiHatTip,

        [Description("228: S14 Closed Hi Hat Tip")]
        S14ClosedHiHatTip,

        [Description("229: TR-606 Closed & Open Hi Hat")]
        Tr606ClosedAndOpenHiHat,

        [Description("230: TR-808 Closed & Open Hi Hat S")]
        Tr808ClosedAndOpenHiHatS,

        [Description("231: TR-808 Closed & Open Hi Hat L")]
        Tr808ClosedAndOpenHiHatL,
        [Description("232: Hip Pedal Hi Hat")] HipPedalHiHat,

        [Description("233: Regular Pedal Hi Hat")]
        RegularPedalHiHat,

        [Description("234: Rock Pedal Hi Hat")]
        RockPedalHiHat,
        [Description("235: S13 Pedal Hi Hat")] S13PedalHiHat,
        [Description("236: S14 Pedal Hi Hat")] S14PedalHiHat,

        [Description("237: TR-606 Open Hi Hat")]
        Tr606OpenHiHat,

        [Description("238: TR-808 Open Hi Hat S")]
        Tr808OpenHiHatS,

        [Description("239: TR-808 Open Hi Hat L")]
        Tr808OpenHiHatL,

        [Description("240: TR-909 Open Hi Hat 1")]
        Tr909OpenHiHat1,

        [Description("241: TR-909 Open Hi Hat 2")]
        Tr909OpenHiHat2,

        [Description("242: TR-909 Open Hi Hat 3")]
        Tr909OpenHiHat3,

        [Description("243: TR-707 Open Hi Hat")]
        Tr707OpenHiHat,

        [Description("244: TR-626 Open Hi Hat")]
        Tr626OpenHiHat,

        [Description("245: Hip-Hop Open Hi Hat")]
        HipHopOpenHiHat,
        [Description("246: Lite Open Hi Hat")] LiteOpenHiHat,

        [Description("247: RegularOpen Hi Hat")]
        RegularOpenHiHat,
        [Description("248: Rock Open Hi Hat")] RockOpenHiHat,

        [Description("249: S13 Open Hi Hat Shift")]
        S13OpenHiHatShift,

        [Description("250: S14 Open Hi Hat Shift")]
        S14OpenHiHatShift,
        [Description("251: CR-78 Cymbal")] Cr78Cymbal,
        [Description("252: TR-606 Cymbal")] Tr606Cymbal,
        [Description("253: TR-808 Cymbal 1")] Tr808Cymbal1,
        [Description("254: TR-808 Cymbal 2")] Tr808Cymbal2,
        [Description("255: TR-808 Cymbal 3")] Tr808Cymbal3,

        [Description("256: TR-909 CrashCymbal")]
        Tr909CrashCymbal,

        [Description("257: TR-909 ReverseCymbal")]
        Tr909ReverseCymbal,
        [Description("258: MG Nz Cymbal")] MgNzCymbal,

        [Description("259: TR-707 CrashCymbal")]
        Tr707CrashCymbal,

        [Description("260: TR-626 CrashCymbal")]
        Tr626CrashCymbal,
        [Description("261: Crash Cymbal 1")] CrashCymbal1,
        [Description("262: Crash Cymbal 2")] CrashCymbal2,
        [Description("263: Rock Crash 1")] RockCrash1,
        [Description("264: Rock Crash 2")] RockCrash2,
        [Description("265: P17 CrashTip")] P17CrashTip,
        [Description("266: S18 CrashTip")] S18CrashTip,
        [Description("267: Z18k Crash Sft")] Z18KCrashSft,
        [Description("268: Jazz Crash")] JazzCrash,

        [Description("269: TR-909 Ride Cymbal")]
        Tr909RideCymbal,

        [Description("270: TR-707 Ride Cymbal")]
        Tr707RideCymbal,

        [Description("271: TR-626 Ride Cymbal")]
        Tr626RideCymbal,
        [Description("272: Ride Cymbal")] RideCymbal,

        [Description("273: TR-626 China Cymbal")]
        Tr626ChinaCymbal,
        [Description("274: China Cymbal")] ChinaCymbal,
        [Description("275: Splash Cymbal")] SplashCymbal,
        [Description("276: TR-626 Cup")] Tr626Cup,
        [Description("277: Rock Rd Cup")] RockRdCup,
        [Description("278: TR-808 ClapS1 P")] Tr808ClapS1P,
        [Description("279: TR-808 ClapS2 P")] Tr808ClapS2P,
        [Description("280: TR-808 ClapL1 P")] Tr808ClapL1P,
        [Description("281: TR-808 ClapL2 P")] Tr808ClapL2P,
        [Description("282: TR-909 Clap 1 P")] Tr909Clap1P,
        [Description("283: TR-909 Clap 2 P")] Tr909Clap2P,
        [Description("284: TR-909 Clap 3 P")] Tr909Clap3P,

        [Description("285: TR-909 Distorted Clap P")]
        Tr909DistortedClapP,
        [Description("286: TR-707 Clap P")] T707ClapP,
        [Description("287: TR-626 Clap")] Tr626Clap,
        [Description("288: R8 Clap")] R8Clap,
        [Description("289: Cheap Clap")] CheapClap,
        [Description("290: Old Clap P")] OldClapP,
        [Description("291: Hip Clap")] HipClap,
        [Description("292: Distorted Clap")] DistortedClap,
        [Description("293: Hand Clap")] HandClap,
        [Description("294: Club Clap")] ClubClap,
        [Description("295: Real Clap")] RealClap,
        [Description("296: Funk Clap")] FunkClap,
        [Description("297: Bright Clap")] BrightClap,
        [Description("298: TM-2 Clap")] Tm2Clap,
        [Description("299: Amb Clap")] AmbClap,
        [Description("300: Disc Clap")] DiscClap,
        [Description("301: Claptail")] Claptail,
        [Description("302: Gospel Clap")] GospelClap,
        [Description("303: CR-78 Tamb")] Cr78Tamb,
        [Description("304: TR-707 Tamb P")] Tr707TambP,
        [Description("305: TR-626 Tamb")] Tr626Tamb,
        [Description("306: TM-2 Tamb")] Tm2Tamb,
        [Description("307: Tamborine 1")] Tamborine1,
        [Description("308: Tamborine 2")] Tamborine2,
        [Description("309: Tamborine 3")] Tamborine3,
        [Description("310: TR-808 Cowbell P")] Tr808CowbellP,
        [Description("311: TR-707 Cowbell")] Tr707Cowbell,
        [Description("312: TR-626 Cowbell")] Tr626Cowbell,
        [Description("313: Cowbell Mute")] CowbellMute,

        [Description("314: CR-78 High Bongo P")]
        Cr78HighBongoP,

        [Description("315: TR-727 High Bongo")]
        Tr727HighBongo,
        [Description("316: Bongo High Mt")] BongoHightMt,
        [Description("317: Bongo High Slp")] BongoHighSlp,
        [Description("318: Bongo High Op")] BongoHightOp,

        [Description("319: CR-78 Low Bongo P")]
        Tr78LowBongoP,
        [Description("320: TR-727 Low Bongo")] Tr727LowBongo,
        [Description("321: Bongo Low Op")] BongoLowOp,
        [Description("322: Bongo Low Slp")] BongoLowSlp,

        [Description("323: TR-808 High Conga P")]
        Tr808HightCoongaP,

        [Description("324: TR-727 High Conga Op P")]
        Tr727HightCongOpP,

        [Description("325: TR-727 High Conga Mt P")]
        Tr727HightCongMtP,

        [Description("326: TR-626 High Conga Op")]
        Tr626HightCongaOp,

        [Description("327: TR-626 High Conga Mt")]
        Tr626HightCongaMt,
        [Description("328: Conga Hi Mt")] CongaHiMt,
        [Description("329: Conga 2H Mt")] Conga2HMt,
        [Description("330: Conga Hi Slp")] CongaHiSlp,
        [Description("331: Conga 2H Slp")] Conga2HSlp,
        [Description("332: Conga Hi Op")] CongaHiOp,
        [Description("333: Conga 2H Op")] Conga2HOp,

        [Description("334: TR-808 Mid Conga P")]
        Tr808MidCongaP,

        [Description("335: CR-78 Low Conga P")]
        Cr78LowCongaP,

        [Description("336: TR-808 Low Conga P")]
        Tr808LowCongaP,

        [Description("337: TR-727 Low Conga P")]
        Tr727LowCongaP,
        [Description("338: TR-626 Low Conga")] Tr626LowConga,
        [Description("339: Conga Low Mt")] CongaLoMt,
        [Description("340: Conga Low Slp")] CongaLoSlp,
        [Description("341: Conga Low Op")] CongaLoOp,
        [Description("342: Conga 2L Mt")] Conga2LMt,
        [Description("343: Conga 2L Op")] Conga2LOp,
        [Description("344: Conga Slp Op")] CongaSlpOp,
        [Description("345: Conga Efx")] CongaEfx,
        [Description("346: Conga Thumb")] CongaThumb,

        [Description("347: TR-727 High Timbal")]
        Tr727HighTimbal,

        [Description("348: TR-626 High Timbal")]
        Tr626HighTimbal,

        [Description("349: TR-727 Low Timbal")]
        Tr727LowTimbal,

        [Description("350: TR-626 Low Timbal")]
        Tr626LowTimbal,
        [Description("351: Timbale 1")] Timbale1,
        [Description("352: Timbale 2")] Timbale2,
        [Description("353: Timbale 3")] Timbale3,
        [Description("354: Timbale 4")] Timbale4,
        [Description("355: Timbles Low Op")] TimblesLoOp,
        [Description("356: Timbles Low Mt")] TimblesLoMt,
        [Description("357: Timbales Hand")] TimbalesHand,
        [Description("358: Timbales Rim")] TimbalesRim,

        [Description("359: Timbales Side Stick")]
        TmbSideStick,

        [Description("360: TR-727 High Agogo")]
        Tr727HighAgogo,

        [Description("361: TR-626 High Agogo")]
        Tr626HighAgogo,
        [Description("362: TR-727 Low Agogo")] Tr727LowAgogo,
        [Description("363: TR-626 Low Agogo")] Tr626LowAgogo,
        [Description("364: TR-727 Cabasa P")] Tr727CabasaP,
        [Description("365: Cabasa Up")] CabasaUp,
        [Description("366: Cabasa Down")] CabasaDown,
        [Description("367: Cabasa Cut")] CabasaCut,
        [Description("368: CR-78 Maracas P")] Cr78MaracasP,
        [Description("369: TR-808 Maracas P")] Tr808MaracasP,
        [Description("370: TR-727 Maracas P")] Tr727MaracasP,
        [Description("371: Maracas")] Maracas,
        [Description("372: TR-727 Whistle S")] Tr727WhistleS,
        [Description("373: TR-727 Whistle L")] Tr727WhistleL,
        [Description("374: Whistle")] Whistle,
        [Description("375: CR-78 Guiro S")] Cr78GuiroS,
        [Description("376: CR-78 Guiro L")] Cr78GuiroL,
        [Description("377: Guiro")] Guiro,
        [Description("378: Guiro Long")] GuiroLong,
        [Description("379: CR-78 Claves P")] Cr78ClavesP,
        [Description("380: TR-808 Claves P")] Tr808ClavesP,
        [Description("381: TR-626 Claves")] Tr626Claves,
        [Description("382: Claves")] Claves,
        [Description("383: Wood Block")] WoodBlock,
        [Description("384: Triangle")] Triangle,
        [Description("385: CR-78 MetalBt P")] Cr78MetalBtP,
        [Description("386: TR-727 StrChime")] Tr727StrChime,
        [Description("387: TR-626 Shaker")] Tr626Shaker,
        [Description("388: Shaker")] Shaker,
        [Description("389: Finger Snap")] FingerSnap,
        [Description("390: Club FinSnap")] ClubFinSnap,
        [Description("391: Snap")] Snap,
        [Description("392: Group Snap")] GroupSnap,
        [Description("393: Op Pandeiro")] OpPandeiro,
        [Description("394: Mt Pandeiro")] MtPandeiro,
        [Description("395: Pandeiro Op")] PandeiroOp,
        [Description("396: Pandeiro Mt")] PandeiroMt,
        [Description("397: Pandeiro Hit")] PandeiroHit,
        [Description("398: Pandeiro Rim")] PandeiroRim,
        [Description("399: Pandeiro Crash")] PandeiroCrsh,
        [Description("400: Pandeiro Roll")] PandeiroRoll,
        [Description("401: TR-727 Quijada")] Tr727Quijada,
        [Description("402: Tabla Bayam 1")] TablaBayam1,
        [Description("403: Tabla Bayam 2")] TablaBayam2,
        [Description("404: Tabla Bayam 3")] TablaBayam3,
        [Description("405: Tabla Bayam 4")] TablaBayam4,
        [Description("406: Tabla Bayam 5")] TablaBayam5,
        [Description("407: Tabla Bayam 6")] TablaBayam6,
        [Description("408: Tabla Bayam 7")] TablaBayam7,
        [Description("409: Udo")] Udo,
        [Description("410: Udu Pot Hi")] UduPotHigh,
        [Description("411: Udu Pot Slp")] UduPotSlp,
        [Description("412: Scratch 1")] Scratch1,
        [Description("413: Scratch 2")] Scratch2,
        [Description("414: Scratch 3")] Scratch3,
        [Description("415: Scratch 4")] Scratch4,
        [Description("416: Scratch 5")] Scratch5,
        [Description("417: Dance M")] DanceM,
        [Description("418: Ahh M")] AhhM,
        [Description("419: Let\'s Go M")] LetsGoM,
        [Description("420: Hah F")] HahF,
        [Description("421: Yeah F")] YeahF,
        [Description("422: C\'mon Baby F")] CmonBabyF,
        [Description("423: Wooh F")] WoohF,
        [Description("424: White Noise")] WhiteNoise,
        [Description("425: Pink Noise")] PinkNoise,
        [Description("426: Atmosphere")] Atmosphere,

        [Description("427: Percussive Organ 1")]
        PercOrgan1,

        [Description("428: Percussive Organ 2")]
        PercOrgan2,
        [Description("429: TB Blip")] TbBlip,

        [Description("430: Distorted Muted Gtr")]
        DistortedMutedGuitar,
        [Description("431: Flute Fx")] FluteFx,
        [Description("432: Pop Brass Atk")] PopBrassAttack,
        [Description("433: Strings Hit")] StringsHit,
        [Description("434: Smear Hit")] SmearHit,
        [Description("435: O\'Skool Hit")] OldSkoolHit,
        [Description("436: Orchestral Hit")] OrchestralHit,
        [Description("437: Punch Hit")] PunchHit,
        [Description("438: Philly Hit")] PhillyHit,
        [Description("439: Classic Hse Hit")] ClassicHseHt,
        [Description("440: Tao Hit")] TaoHit,
        [Description("441: MG S Zap 1")] MgsZap1,
        [Description("442: MG S Zap 2")] MgsZap2,
        [Description("443: MG S Zap 3")] MgsZap3,
        [Description("444: SH2 S Zap 1")] Sh2SZap1,
        [Description("445: SH2 S Zap 2")] Sh2SZap2,
        [Description("446: SH2 S Zap 3")] Sh2SZap3,
        [Description("447: SH2 S Zap 4")] Sh2SZap4,
        [Description("448: SH2 S Zap 5")] Sh2SZap5,
        [Description("449: SH2 U Zap 1")] Sh2UZap1,
        [Description("450: SH2 U Zap 2")] Sh2UZap2,
        [Description("451: SH2 U Zap 3")] Sh2UZap3,
        [Description("452: SH2 U Zap 4")] Sh2UZap4,
        [Description("453: SH2 U Zap 5")] Sh2UZap5
    }
}