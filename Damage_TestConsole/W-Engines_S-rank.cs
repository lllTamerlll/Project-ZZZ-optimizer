using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damage_TestConsole
{
    internal class W_Engines_S_rank
    {
        //Attack
        //SteelCushion
        double Wengine_SteelCushion_Main = 684;
        double Wengine_SteelCushion_Sub_CritRate = 0.24;
        double[] Wengine_SteelCushion_Pasive_PhysicalDMG = { 0.2, 0.25, 0.3, 0.35, 0.4 };
        double[] Wengine_SteelCushion_Pasive_DMG = { 0.25, 0.315, 0.38, 0.44, 0.5 };

        //Brimstone
        double Wengine_Brimstone_Main = 684;
        double Wengine_Brimstone_Sub_ATK = 0.3;
        double[] WengineBrimstone__Pasive_ATK_stac_1 = { 0.035, 0.044, 0.052, 0.06, 0.07 };
        double[] WengineBrimstone__Pasive_ATK_stac_2 = { 0.07, 0.088, 0.104, 0.12, 0.14 };
        double[] WengineBrimstone__Pasive_ATK_stac_3 = { 0.105, 0.132, 0.156, 0.18, 0.21 };
        double[] WengineBrimstone__Pasive_ATK_stac_4 = { 0.14, 0.176, 0.208, 0.24, 0.28 };
        double[] WengineBrimstone__Pasive_ATK_stac_5 = { 0.175, 0.22, 0.26, 0.3, 0.35 };
        double[] WengineBrimstone__Pasive_ATK_stac_6 = { 0.21, 0.264, 0.312, 0.36, 0.42 };
        double[] WengineBrimstone__Pasive_ATK_stac_7 = { 0.245, 0.308, 0.364, 0.42, 0.49 };
        double[] WengineBrimstone__Pasive_ATK_stac_8 = { 0.28, 0.352, 0.416, 0.48, 0.56 };

        //Deep Sea Visitor
        double Wengine_DeepSeaVisitor_Main = 713;
        double Wengine_DeepSeaVisitor_Sub_CritRate = 0.24;
        double[] Wengine_DeepSeaVisitor_Pasive_IceDMG = { 0.25, 0.315, 0.38, 0.445, 0.5 };
        double[] Wengine_DeepSeaVisitor_Pasive_CritRate_Main = { 0.1, 0.125, 0.15, 0.175, 0.2 };
        double[] Wengine_DeepSeaVisitor_Pasive_CritRate_Sub_if_IceDng = { 0.1, 0.125, 0.15, 0.175, 0.2 };

        //Zanshin Herb Case
        double Wengine_ZanshinHerbCase_Main = 713;
        double Wengine_ZanshinHerbCase_Sub_CritDMG = 0.48;
        double[] Wengine_ZanshinHerbCase_Pasive_CritRate = { 0.1, 0.115, 0.13, 0.145, 0.16 };
        double[] Wengine_ZanshinHerbCase_Pasive_DashElectricDMG = { 0.4, 0.46, 0.52, 0.58, 0.64 };
        double[] Wengine_ZanshinHerbCase_Pasive_CritRate_Sub_if_AnomalyStun = { 0.1, 0.115, 0.13, 0.145, 0.16 };

        //RiotSuppressorMarkVI
        double Wengine_RiotSuppressorMarkVI_Main = 713;
        double Wengine_RiotSuppressorMarkVI_Sub_CritDMG = 0.48;
        double[] Wengine_RiotSuppressorMarkVI_Pasive_CritRate = { 0.15, 0.188, 0.226, 0.264, 0.3 };
        double[] Wengine_RiotSuppressorMarkVI_Pasive_Basic_Dash_DMG = { 0.35, 0.435, 0.52, 0.605, 0.7 };

        //Myriad Eclipse
        double Wengine_MyriadEclipse_Main = 713;
        double Wengine_MyriadEclipse_Sub_CritRate = 0.24;
        double[] Wengine_MyriadEclipse_Pasive_CritDMG = { 0.45, 0.5175, 0.585, 0.6525, 0.75 };
        double[] Wengine_MyriadEclipse_Pasive_DefIgnore = { 0.25, 0.2875, 0.325, 0.3625, 0.4 };

        //Bellicose Blaze
        double Wengine_BellicoseBlaze_Main = 713;
        double Wengine_BellicoseBlaze_Sub_EnergyRegen = 0.6;
        double[] Wengine_BellicoseBlaze_Pasive_CritRate = { 0.2, 0.23, 0.26, 0.29, 0.32 };
        double[] Wengine_BellicoseBlaze_Pasive_DefIgnore = { 0.15, 0.172, 0.195, 0.217, 0.24 };

        //Heartstring Nocturne
        double Wengine_HeartstringNocturne_Main = 713;
        double Wengine_HeartstringNocturne_Sub_CritRate = 0.24;
        double[] Wengine_HeartstringNocturne_Pasive_CritDMG = { 0.5, 0.575, 0.65, 0.725, 0.8 };
        double[] Wengine_HeartstringNocturne_Pasive_DefIgnore_stac_1 = { 0.125, 0.145, 0.165, 0.185, 0.2 };
        double[] Wengine_HeartstringNocturne_Pasive_DefIgnore_stac_2 = { 0.25, 0.29, 0.33, 0.37, 0.4 };

        //Severed Innocence
        double Wengine_SeveredInnocence_Main = 713;
        double Wengine_SeveredInnocence_Sub_CritDMG = 0.48;
        double[] Wengine_SeveredInnocence_Pasive_CritDMG = { 0.3, 0.345, 0.39, 0.435, 0.48 };
        double[] Wengine_SeveredInnocence_Pasive_CritDMG_stac_1 = { 0.1, 0.115, 0.13, 0.145, 0.16 };
        double[] Wengine_SeveredInnocence_Pasive_CritDMG_stac_2 = { 0.2, 0.23, 0.26, 0.29, 0.32 };
        double[] Wengine_SeveredInnocence_Pasive_CritDMG_stac_3 = { 0.3, 0.345, 0.39, 0.435, 0.48 };
        double[] Wengine_SeveredInnocence_Pasive_ElectricDMG = { 0.2, 0.23, 0.26, 0.29, 0.32 };

        //CordisGermina
        double Wengine_CordisGermina_Main = 713;
        double Wengine_CordisGermina_Sub_CritRate = 0.24;
        double[] Wengine_CordisGermina_Pasive_CritRare = { 0.15, 0.17, 0.19, 0.21, 0.23 };
        double[] Wengine_CordisGermina_Pasive_ElectricDMG = { 0.125, 0.145, 0.165, 0.185, 0.2 };
        double[] Wengine_CordisGermina_Pasive_DefIgnore = { 0.2, 0.23, 0.26, 0.29, 0.32 };

        //Stun
        //Hellfire Gears
        double Wengine_HellfireGears_Main = 684;
        double Wengine_HellfireGears_Sub_Impact = 0.18;
        double[] Wengine_HellfireGears_Pasive_exImpact_stac_1 = { 0.1, 0.125, 0.15, 0.175, 0.2 };
        double[] Wengine_HellfireGears_Pasive_exImpact_stac_2 = { 0.2, 0.25, 0.3, 0.35, 0.4 };

        //TheRestrained
        double Wengine_TheRestrained_Main = 684;
        double Wengine_TheRestrained_Sub_Impact = 0.18;
        double[] Wengine_TheRestrained_Pasive_DMG_Basic = { 0.06, 0.075, 0.09, 0.105, 0.12 };
        double[] Wengine_TheRestrained_Pasive_Daze_Basic = { 0.06, 0.075, 0.09, 0.105, 0.12 };

        //Blazing Laurel
        double Wengine_BlazingLaurel_Main = 713;
        double Wengine_BlazingLaurel_Sub_ = 0.18 ;
        double[] Wengine_BlazingLaurel_Pasive_Impact = { 0.25, 0.2875, 0.325, 0.3625, 0.4 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_1 = { 0.015, 0.0172, 0.0195, 0.0217, 0.024 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_2 = { 0.03, 0.0344, 0.039, 0.0434, 0.048 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_3 = { 0.045, 0.0516, 0.0585, 0.0651, 0.072 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_4 = { 0.06, 0.0688, 0.078, 0.0868, 0.096 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_5 = { 0.075, 0.086, 0.0975, 0.1085, 0.12 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_6 = { 0.09, 0.1032, 0.117, 0.1302, 0.144 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_7 = { 0.105, 0.1204, 0.1365, 0.1519, 0.168 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_8 = { 0.12, 1376, 0.186, 0.1736, 0.192 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_9 = { 0.135, 0.1548, 0.1755, 0.1953, 0.216 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_10 = { 0.15, 0.172, 0.195, 0.217, 0.24 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_11 = { 0.165, 0.1892, 0.2145, 0.2387, 0.264 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_12 = { 0.18, 0.2064, 0.234, 0.2604, 0.288 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_13 = { 0.195, 0.2236, 0.2535, 0.2821, 0.312 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_14 = { 0.21, 0.2408, 0.273, 0.3038, 0.336 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_15 = { 0.225, 0.258, 0.2925, 0.3255, 0.36 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_16 = { 0.24, 0.2752, 0.312, 0.3472, 0.384 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_17 = { 0.255, 0.2924, 0.3315, 0.3689, 0.408 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_18 = { 0.27, 0.3096, 0.351, 0.3906, 0.432 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_19 = { 0.285, 0.3268, 0.3705, 0.4123, 0.456 };
        double[] Wengine_BlazingLaurel_Pasive_IceFire_CritDMG_stac_20 = { 0.3, 0.344, 0.39, 0.434, 0.48 };

        //Ice Jade Teapot
        double Wengine_IceJadeTeapot_Main = 713;
        double Wengine_IceJadeTeapot_Sub_Impact = 0.18;
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_1 = { 0.007, 0.0088, 0.0105, 0.012, 0.014 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_2 = { 0.014, 0.0176, 0.021, 0.024, 0.028 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_3 = { 0.021, 0.0264, 0.0315, 0.037, 0.042 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_4 = { 0.028, 0.0352, 0.042, 0.049, 0.056 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_5 = { 0.035, 0.044, 0.0525, 0.061, 0.07 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_6 = { 0.042, 0.0528, 0.063, 0.073, 0.084 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_7 = { 0.049, 0.0616, 0.0735, 0.085, 0.098 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_8 = { 0.056, 0.0704, 0.084, 0.098, 0.112 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_9 = { 0.063, 0.0792, 0.0945, 0.110, 0.126 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_10 = { 0.07, 0.088, 0.105, 0.122, 0.14 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_11 = { 0.077, 0.0968, 0.1155, 0.134, 0.154 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_12 = { 0.084, 0.1056, 0.126, 0.146, 0.168 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_13 = { 0.091, 0.1144, 0.1365, 0.159, 0.182 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_14 = { 0.098, 0.1232, 0.147, 0.171, 0.196 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_15 = { 0.105, 0.132, 0.1575, 0.183, 0.21 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_16 = { 0.112, 0.1408, 0.168, 0.195, 0.224 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_17 = { 0.119, 0.1496, 0.1785, 0.207, 0.238 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_18 = { 0.126, 0.1584, 0.189, 0.220, 0.252 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_19 = { 0.133, 0.1672, 0.1995, 0.232, 0.266 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_20 = { 0.14, 0.176, 0.21, 0.244, 0.28 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_21 = { 0.147, 0.1848, 0.2205, 0.256, 0.294 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_22 = { 0.154, 0.1936, 0.231, 0.268, 0.308 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_23 = { 0.161, 0.2024, 0.2415, 0.281, 0.322 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_24 = { 0.168, 0.2112, 0.252, 0.293, 0.336 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_25 = { 0.175, 0.22, 0.2625, 0.305, 0.35 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_26 = { 0.182, 0.2288, 0.273, 0.317, 0.364 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_27 = { 0.189, 0.2376, 0.2835, 0.329, 0.378 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_28 = { 0.196, 0.2464, 0.294, 0.342, 0.392 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_29 = { 0.203, 0.2552, 0.3045, 0.354, 0.406 };
        double[] Wengine_IceJadeTeapot_Pasive_Impact_stac_30 = { 0.21, 0.264, 0.315, 0.366, 0.42 };
        double[] Wengine_IceJadeTeapot_Pasive_DMG_allsquad = {0.2,0.23,0.26,0.29,0.32 };

        //Spectral Gaze
        double Wengine_SpectralGaze_Main = 713;
        double Wengine_SpectralGaze_Sub_CritRate = 0.24;
        double[] Wengine_SpectralGaze_Pasive_DefReduced = { 0.25, 0.2875, 0.325, 0.3625, 0.4 };
        double[] Wengine_SpectralGaze_Impact_stac_1 = { 0.04, 0.046, 0.052, 0.058, 0.064 };
        double[] Wengine_SpectralGaze_Impact_stac_2 = { 0.08, 0.092, 0.104, 0.116, 0.128 };
        double[] Wengine_SpectralGaze_Impact_stac_3 = { 0.12, 0.138, 0.156, 0.174, 0.192 };
        double[] Wengine_SpectralGaze_Impact_FullStac = { 0.08, 0.092, 0.0104, 0.116, 0.128 };

        //Roaring Furnace
        double Wengine_RoaringFurnace_Main = 713;
        double Wengine_RoaringFurnace_Sub_ATK = 0.3;
        double[] Wengine_RoaringFurnace_Pasive_ExChaneUlt_Daze = { 0.28, 0.322, 0.364, 0.406, 0.448 };
        double[] Wengine_RoaringFurnace_Pasive_DGM_allsqad = { 0.1, 0.115, 0.13, 0.145, 0.16 };

        //Anomaly
        //Hailstorm Shrine
        double Wengine_HailstormShrine_Main = 713;
        double Wengine_HailstormShrine_Sub_CritRate = 0.24;
        double[] Wengine_HailstormShrine_Pasive_CritDMG = { 0.5, 0.57, 0.65, 0.73, 0.8 };
        double[] Wengine_HailstormShrine_Pasive_ex_anomaly_IceDMG_stac_1 = { 0.2, 0.23, 0.26, 0.29, 0.32 };
        double[] Wengine_HailstormShrine_Pasive_ex_anomaly_IceDMG_stac_2 = { 0.4, 0.46, 0.52, 0.58, 0.64 };

        //Flamemaker Shaker
        double Wengine_FlamemakerShaker_Main = 713;
        double Wengine_FlamemakerShaker_Sub_ATK = 0.3;
        double[] Wengine_FlamemakerShaker_Pasive_stac_1 = { 0.035, 0.044, 0.052, 0.061, 0.07 };
        double[] Wengine_FlamemakerShaker_Pasive_stac_2 = { 0.07, 0.088, 0.104, 0.122, 0.14 };
        double[] Wengine_FlamemakerShaker_Pasive_stac_3 = { 0.105, 0.132, 0.156, 0.183, 0.21 };
        double[] Wengine_FlamemakerShaker_Pasive_stac_4 = { 0.14, 0.176, 0.208, 0.244, 0.28 };
        double[] Wengine_FlamemakerShaker_Pasive_stac_5 = { 0.175, 0.22, 0.26, 0.305, 0.35 };
        double[] Wengine_FlamemakerShaker_Pasive_stac_6 = { 0.21, 0.264, 0.312, 0.366, 0.42 };
        double[] Wengine_FlamemakerShaker_Pasive_stac_7 = { 0.245, 0.308, 0.364, 0.427, 0.49 };
        double[] Wengine_FlamemakerShaker_Pasive_stac_8 = { 0.28, 0.352, 0.416, 0.488, 0.56 };
        double[] Wengine_FlamemakerShaker_Pasive_stac_9 = { 0.315, 0.396, 0.468, 0.549, 0.63 };
        double[] Wengine_FlamemakerShaker_Pasive_stac_10 = { 0.35, 0.44, 0.52, 0.61, 0.7 };
        double[] Wengine_FlamemakerShaker_Pasive_5_10_stac = { 50, 62, 75, 87, 100 };

        //Fusion Compiler
        double Wengine_FusionCompiler_Main = 684;
        double Wengine_FusionCompiler_Sub_Pen = 0.24;
        double[] Wengine_FusionCompiler_Pasive_ATK = {0.12,0.15,0.18,0.21,0.24 }; 
        double[] Wengine_FusionCompiler_Pasive_AP_stac_1 = { 25, 31, 37, 43, 50 };
        double[] Wengine_FusionCompiler_Pasive_AP_stac_2 = { 50, 62, 74, 86, 100 };
        double[] Wengine_FusionCompiler_Pasive_AP_stac_3 = { 75, 93, 111, 129, 150 };

        //Timeweaver
        double Wengine_Timeweaver_Main = 713;
        double Wengine_Timeweaver_Sub_ATK = 0.3;
        double[] Wengine_Timeweaver_Pasive_AP = { 75, 85, 95, 105, 115 };
        double[] Wengine_Timeweaver_Pasive_DisorterDMG = { 0.25, 0.275, 0.325, 0.35 };

        //Sharpene dStinger
        double Wengine_SharpenedStinger_Main = 713;
        double Wengine_SharpenedStinger_Sub_AP = 90;
        double[] Wengine_SharpenedStinger_Pasive_PhysicalDMG_stac_1 = { 0.12, 0.15, 0.18, 0.21, 0.24 };
        double[] Wengine_SharpenedStinger_Pasive_PhysicalDMG_stac_2 = { 0.24, 0.30, 0.36, 0.42, 0.48 };
        double[] Wengine_SharpenedStinger_Pasive_PhysicalDMG_stac_3 = { 0.36, 0.45, 0.54, 0.63, 0.72 };

        //Flight of Fancy
        double Wengine_FlightofFancy_Main = 713;
        double Wengine_FlightofFancy_Sub_AP = 90;
        double[] Wengine_FlightofFancy_Pasive_AP_stac_1 = { 20, 23, 26, 29, 32 };
        double[] Wengine_FlightofFancy_Pasive_AP_stac_2 = { 40, 46, 52, 58, 64 };
        double[] Wengine_FlightofFancy_Pasive_AP_stac_3 = { 60, 69, 78, 87, 96 };
        double[] Wengine_FlightofFancy_Pasive_AP_stac_4 = { 80, 92, 104, 116, 128 };
        double[] Wengine_FlightofFancy_Pasive_AP_stac_5 = { 100, 115, 130, 145, 160 };
        double[] Wengine_FlightofFancy_Pasive_AP_stac_6 = { 120, 138, 156, 174, 192 };

        //Practiced Perfection
        double Wengine_PracticedPerfection_Main = 713;
        double Wengine_PracticedPerfection_Sub_ATK = 0.3;
        double[] Wengine_PracticedPerfection_Pasive_AP = { 60, 69, 78, 87, 96 };
        double[] Wengine_PracticedPerfection_Pasive_PhysicalDMG_stac_1 = { 20, 23, 26, 29, 32 };
        double[] Wengine_PracticedPerfection_Pasive_PhysicalDMG_stac_2 = { 40, 46, 52, 58, 64 };

        //Support
        //Weeping Cradle
        double Wengine_WeepingCradle_Main = 713;
        double Wengine_WeepingCradle_Sub_Pen = 0.24;
        double[] Wengine_WeepingCradle_Pasive_DMG = { 0.1, 0.125, 0.15, 0.175, 0.2 };
        double[] Wengine_WeepingCradle_Pasive_DMG_stac_1 = { 0.017, 0.02, 0.025, 0.03, 0.033 };
        double[] Wengine_WeepingCradle_Pasive_DMG_stac_2 = { 0.034, 0.04, 0.05, 0.06, 0.066 };
        double[] Wengine_WeepingCradle_Pasive_DMG_stac_3 = { 0.051, 0.06, 0.075, 0.09, 0.099 };
        double[] Wengine_WeepingCradle_Pasive_DMG_stac_4 = { 0.068, 0.08, 0.1, 0.12, 0.132 };
        double[] Wengine_WeepingCradle_Pasive_DMG_stac_5 = { 0.085, 0.1, 0.125, 0.15, 0.165 };
        double[] Wengine_WeepingCradle_Pasive_DMG_stac_6 = { 0.102, 0.12, 0.15, 0.18, 0.198 };

        //Elegant Vanity
        double Wengine_ElegantVanity_Main = 713;
        double Wengine_ElegantVanity_Sub_ATK = 0.3;
        double[] Wengine_ElegantVanity_Pasive_DMG_stac_1 = { 0.1, 0.115, 0.13, 0.145, 0.16 };
        double[] Wengine_ElegantVanity_Pasive_DMG_stac_2 = { 0.2, 0.23, 0.26, 0.29, 0.32 };

        //Metanukimorphosis
        double Wengine_Metanukimorphosis_Main = 713;
        double Wengine_Metanukimorphosis_Sub_EnergyRegen = 0.6;
        double[] Wengine_Metanukimorphosis_Pasive_AM = { 30, 34, 39, 43, 48 };
        double[] Wengine_Metanukimorphosis_Pasive_AP_all_sqad = { 60, 69, 78, 87, 96 };

        //Dream litHearth
        double Wengine_DreamlitHearth_Main = 713;
        double Wengine_DreamlitHearth_Sub_HP = 0.3;
        double[] Wengine_DreamlitHearth_Pasive_DMG = { 0.25, 0.288, 0.325, 0.363, 0.4 };
        double[] Wengine_DreamlitHearth_Pasive_HP_all_sqad = { 0.15, 0.173, 0.195, 0.218, 0.24 };

        //Defense
        //Tusks of Fury
        double Wengine_TusksofFury_Main = 713;
        double Wengine_TusksofFury_Sub_Impact = 0.18;
        double[] Wengine_TusksofFury_Pasive_DMG = { 0.18, 0.225, 0.27, 0.315, 0.36 };
        double[] Wengine_TusksofFury_Pasive_Daze = { 0.12, 0.15, 0.18, 0.21, 0.24 };

        //Rupture
        //Krakens Cradle
        double Wengine_KrakensCradle_Main = 713;
        double Wengine_KrakensCradle_Sub_HP = 0.3;
        double[] Wengine_KrakensCradle_Pasive_Ice_Sheer_DMG_stac_1 = { 0.06, 0.07, 0.08, 0.09, 0.1 };
        double[] Wengine_KrakensCradle_Pasive_Ice_Sheer_DMG_stac_2 = { 0.12, 0.14, 0.16, 0.18, 0.2 };
        double[] Wengine_KrakensCradle_Pasive_Ice_Sheer_DMG_stac_3 = { 0.18, 0.21, 0.24, 0.27, 0.3 };
        double[] Wengine_KrakensCradle_Pasive_CritRate = { 0.2,0.23,0.26,0.29,0.32};

        //Qingming Birdcage
        double Wengine_QingmingBirdcage_Main = 713;
        double Wengine_QingmingBirdcage_Sub_HP = 0.3;
        double[] Wengine_QingmingBirdcage_Pasive_CritRate = { 0.2, 0.23, 0.26, 0.29, 0.32 };
        double[] Wengine_QingmingBirdcage_Pasive_Ether_DMG_stac_1 = { 0.08, 0.092, 0.104, 0.116, 0.128 };
        double[] Wengine_QingmingBirdcage_Pasive_Ether_DMG_stac_2 = { 0.16, 0.184, 0.208, 0.232, 0.256 };
        double[] Wengine_QingmingBirdcage_Pasive_Ether_Sheer_DMG_Ultimate_EX_stac_1 = { 0.1, 0.115, 0.13, 0.145, 0.16 };
        double[] Wengine_QingmingBirdcage_Pasive_Ether_Sheer_DMG_Ultimate_EX_stac_2 = { 0.2, 0.23, 0.26, 0.29, 0.32 };

        /*double Wengine__Main = 713;
        double Wengine__Sub_ = ;
        double[] Wengine__Pasive_ = {  } ;*/
    }
}
