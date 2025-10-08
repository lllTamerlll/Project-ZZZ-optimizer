using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damage_TestConsole
{
    internal class W_Engines_A_rank
    {
        //A-Rank
        //Attack
        //Street Superstar
        double Wengine_StreetSuperstar_Main = 594;
        double Wengine_StreetSuperstar_Sub_ATK = 0.25;
        double[] Wengine_StreetSuperstar_Pasive_UltDMG_stack_1 = { 0.15, 0.172, 0.195, 0.217, 0.24 };
        double[] Wengine_StreetSuperstar_Pasive_UltDMG_stack_2 = { 0.3, 0.344, 0.39, 0.434, 0.48 };
        double[] Wengine_StreetSuperstar_Pasive_UltDMG_stack_3 = { 0.45, 0.516, 0.585, 0.651, 0.72 };

        //Starlight Engine
        double Wengine_Starlight_Engine_Main = 594;
        double Wengine_Starlight_Engine_Sub_ATK = 0.25;
        double[] Wengine_Starlight_Engine_Pasive_ATK = { 0.12, 0.138, 0.156, 0174, 0.192 };

        //Gilded Blossom
        double Wengine_GildedBlossom_Main = 594;
        double Wengine_GildedBlossom_Sub_ATK = 0.25;
        double[] Wengine_GildedBlossom_Pasive_exAttackDMG = { 0.06, 0.069, 0.078, 0.087, 0.096 };
        double[] Wengine_GildedBlossom_CombatATK = { 0.15, 0.172, 0.195, 0.218, 0.24 };

        //Marcato Desire
        double Wengine_MarcatoDesire_Main = 594;
        double Wengine_MarcatoDesire_Sub_CritRate = 0.2;
        double[] Wengine_MarcatoDesire_Pasive_ATK_ex = { 0.06, 0.069, 0.078, 0.087, 0.096 };
        double[] Wengine_MarcatoDesire_Pasive_ATK_anomaly = { 0.06, 0.069, 0.078, 0.087, 0.096 };

        //Housekeeper
        double Wengine_Housekeeper_Main = 642;
        double Wengine_Housekeeper_Sub_ATK = 0.25;
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_1 = { 0.03, 0.035, 0.04, 0.044, 0.048 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_2 = { 0.06, 0.07, 0.08, 0.088, 0.096 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_3 = { 0.09, 0.105, 0.12, 0.132, 0.144 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_4 = { 0.012, 0.14, 0.16, 0.176, 0.192 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_5 = { 0.015, 0.175, 0.2, 0.22, 0.24 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_6 = { 0.18, 0.21, 0.24, 0.264, 0.288 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_7 = { 0.21, 0.245, 0.28, 0.308, 0.336 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_8 = { 0.24, 0.28, 0.32, 0.352, 0.384 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_9 = { 0.27, 0.315, 0.36, 0.396, 0.432 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_10 = { 0.3, 0.35, 0.4, 0.44, 0.48 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_11 = { 0.33, 0.385, 0.44, 0.484, 0.528 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_12 = { 0.36, 0.42, 0.48, 0.528, 0.576 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_13 = { 0.39, 0.455, 0.52, 0.572, 0.624 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_14 = { 0.42, 0.49, 0.56, 0.616, 0.672 };
        double[] Wengine_Housekeeper_Pasive_PhysicalDMG_stack_15 = { 0.45, 0.525, 0.6, 0.66, 0.72 };

        //Starlight Engine Replica
        double Wengine_StarlightEngineReplica_Main = 624;
        double Wengine_StarlightEngineReplica_Sub_ATK = 0.25;
        double[] Wengine_StarlightEngineReplica_Pasive_PhysicalDMG = { 0.36, 0.41, 0.465, 0.52, 0.575 };

        //Drill Rig - Red Axis
        double Wengine_DrillRigRedAxis_Main = 624;
        double Wengine_DrillRigRedAxis_Sub_ER = 0.5;
        double[] Wengine_DrillRigRedAxis_Pasive_Basic_Dash_ElectricDMG = { 0.5, 0.575, 0.65, 0.725, 0.8 };

        //Cannon Rotor
        double Wengine_CannonRotor_Main = 594;
        double Wengine_CannonRotor_Sub_CritRate = 0.2;
        double[] Wengine_CannonRotor_Pasive_combatATK = { 0.075, 0.086, 0.097, 0.108, 0.12 };

        //Stun
        //Steam Oven
        double Wengine_SteamOven_Main = 594;
        double Wengine_SteamOven_Sub_Energy_Regen = 0.5;
        double[] Wengine_SteamOven_Pasive_ImpactBon_stack_1 = { 0.02, 0.023, 0.026, 0.029, 0.032 };
        double[] Wengine_SteamOven_Pasive_ImpactBon_stack_2 = { 0.04, 0.046, 0.052, 0.058, 0.064 };
        double[] Wengine_SteamOven_Pasive_ImpactBon_stack_3 = { 0.06, 0.069, 0.078, 0.087, 0.096 };
        double[] Wengine_SteamOven_Pasive_ImpactBon_stack_4 = { 0.08, 0.092, 0.104, 0.116, 0.128 };
        double[] Wengine_SteamOven_Pasive_ImpactBon_stack_5 = { 0.1, 0.115, 0.13, 0.145, 0.16 };
        double[] Wengine_SteamOven_Pasive_ImpactBon_stack_6 = { 0.12, 0.138, 0.156, 0.174, 0.192 };
        double[] Wengine_SteamOven_Pasive_ImpactBon_stack_7 = { 0.14, 0.161, 0.182, 0.203, 0.224 };
        double[] Wengine_SteamOven_Pasive_ImpactBon_stack_8 = { 0.16, 0.184, 0.208, 0.232, 0.256 };

        //Precious Fossilized Core
        double Wengine_PreciousFossilizedCore_Main = 594;
        double Wengine_PreciousFossilizedCore_Sub_Impact = 0.15;
        double[] Wengine_PreciousFossilizedCore_Pasive_DazeBon_HP_50 = { 0.1, 0.115, 0.13, 0.145, 0.16 };
        double[] Wengine_PreciousFossilizedCore_Pasive_DazeBon_HP_75 = { 0.2, 0.23, 0.26, 0.29, 0.32 };

        //Demara Battery Mark II
        double Wengine_DemaraBatteryMarkII_Main = 624;
        double Wengine_DemaraBatteryMarkII_Sub_Impact = 0.15;
        double[] Wengine_DemaraBatteryMarkII_Pasive_Electric_DMG = { 0.15, 0.175, 0.2, 0.22, 0.24 };

        //Box Cutter
        double Wengine_BoxCutter_Main = 624;
        double Wengine_BoxCutter_Sub_Impact = 0.15;
        double[] Wengine_BoxCutter_Pasive_Physical_DMG = { 0.15, 0.173, 0.195, 0.218, 0.24 };
        double[] Wengine_BoxCutter_Pasive_Impact = { 0.1, 0.115, 0.13, 0.145, 0.16 };

        //Six Shooter
        double Wengine_SixShooter_Main = 594;
        double Wengine_SixShooter_Sub_Impact = 0.15;
        double[] Wengine_SixShooter_Pasive_DazeBon_stack_1 = { 0.04, 0.046, 0.052, 0.058, 0.064 };
        double[] Wengine_SixShooter_Pasive_DazeBon_stack_2 = { 0.08, 0.092, 0.104, 0.116, 0.128 };
        double[] Wengine_SixShooter_Pasive_DazeBon_stack_3 = { 0.12, 0.132, 0.156, 0.174, 0.192 };
        double[] Wengine_SixShooter_Pasive_DazeBon_stack_4 = { 0.16, 0.184, 0.208, 0.232, 0.256 };
        double[] Wengine_SixShooter_Pasive_DazeBon_stack_5 = { 0.2, 0.23, 0.26, 0.29, 0.32 };
        double[] Wengine_SixShooter_Pasive_DazeBon_stack_6 = { 0.24, 0.276, 0.312, 0.348, 0.384 };

        //Anomaly
        //Rainforest Gourmet
        double Wengine_RainforestGourmet_Main = 594;
        double Wengine_RainforestGourmet_Sub_AP = 75;
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_1 = { 0.025, 0.028, 0.032, 0.036, 0.04 };
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_2 = { 0.05, 0.056, 0.64, 0.072, 0.08 };
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_3 = { 0.075, 0.084, 0.96, 0.108, 0.12 };
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_4 = { 0.1, 0.112, 0.128, 0.144, 0.16 };
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_5 = { 0.125, 0.14, 0.16, 0.18, 0.2 };
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_6 = { 0.15, 0.168, 0.192, 0.216, 0.24 };
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_7 = { 0.175, 0.196, 0.224, 0.252, 0.28 };
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_8 = { 0.2, 0.224, 0.256, 0.288, 0.32 };
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_9 = { 0.225, 0.252, 0.288, 0.324, 0.36 };
        double[] Wengine_RainforestGourmet_Pasive_ATK_stack_10 = { 0.25, 0.28, 0.32, 0.36, 0.4 };

        //Weeping Gemini
        double Wengine_WeepingGemini_Main = 594;
        double Wengine_WeepingGemini_Sub_ATK = 0.25;
        double[] Wengine_WeepingGemini_Pasive_AP_stack_1 = { 30, 34, 38, 42, 48 };
        double[] Wengine_WeepingGemini_Pasive_AP_stack_2 = { 60, 68, 76, 84, 96 };
        double[] Wengine_WeepingGemini_Pasive_AP_stack_3 = { 90, 102, 114, 126, 144 };
        double[] Wengine_WeepingGemini_Pasive_AP_stack_4 = { 120, 136, 152, 168, 192 };

        //Electro-Lip Gloss
        double Wengine_ElectroLipGloss_Main = 594;
        double Wengine_ElectroLipGloss_Sub_AP = 75;
        double[] Wengine_ElectroLipGloss_Pasive_ATK = { 0.1, 0.115, 0.13, 0.145, 0, 16 };
        double[] Wengine_ElectroLipGloss_Pasive_DMG = { 0.15, 0.175, 0.2, 0.225, 0.25 };

        //Roaring Ride
        double Wengine_RoaringRide_Main = 624;
        double Wengine_RoaringRide_Sub_ATK = 0.25;
        double[] Wengine_RoaringRide_Pasive_ATK = { 0, 08, 0.092, 0.104, 0.116, 0.128 };
        double[] Wengine_RoaringRide_Pasive_AP = { 40, 46, 52, 58, 64 };
        double[] Wengine_RoaringRide_Pasive_AnomalyBuildup = { 0.25, 0.28, 0.32, 0.36, 0.4 };

        //Support
        //Slice of Time
        double Wengine_SliceofTime_Main = 594;
        double Wengine_SliceofTime_Sub_PENRatio = 0.2;

        //The Vault
        double Wengine_TheVault_Main = 624;
        double Wengine_TheVault_Sub_EnergyRegen = 0.5;
        double[] Wengine_TheVault_Pasive_DMG = { 0.15, 0.175, 0.2, 0.22, 0.24 };

        //Bashful Demon
        double Wengine_BashfulDemon_Main = 624;
        double Wengine_BashfulDemon_Sub_ATK = 0.25;
        double[] Wengine_BashfulDemon_Pasive_IceDMG = { 0.15, 0.175, 0.2, 0.22, 0.24, };
        double[] Wengine_BashfulDemon_Pasive_ATK_allsquad = { 0.02, 0.023, 0.026, 0.029, 0.032 };

        //Kaboom the Cannon
        double Wengine_KaboomtheCannon_Main = 624;
        double Wengine_KaboomtheCannon_Sub_EnergyRegen = 0.5;
        double[] Wengine_KaboomtheCannon_Pasive_ATK_allsquad_stac_1 = { 0.025, 0.028, 0.032, 0.036, 0.04 };
        double[] Wengine_KaboomtheCannon_Pasive_ATK_allsquad_stac_2 = { 0.05, 0.056, 0.064, 0.072, 0.08 };
        double[] Wengine_KaboomtheCannon_Pasive_ATK_allsquad_stac_3 = { 0.075, 0.084, 0.096, 0.108, 0.12 };
        double[] Wengine_KaboomtheCannon_Pasive_ATK_allsquad_stac_4 = { 0.1, 0.112, 0.128, 0.144, 0.16 };

        //Unfettered Game Ball
        double Wengine_UnfetteredGameBall_Main = 594;
        double Wengine_UnfetteredGameBall_Sub_EnergyRegen = 0.5;
        double[] Wengine_UnfetteredGameBall_Pasive_CritRate = { 0.12, 0.135, 0.155, 0.175, 0.2 };

        //Defense
        //Original Transmorpher
        double Wengine_OriginalTransmorpher_Main = 594;
        double Wengine_OriginalTransmorpher_Sub_HP = 0.25;
        double[] Wengine_OriginalTransmorpher_Pasive_InitialHP = { 0.08, 0.09, 0.1, 0.11, 0.125 };
        double[] Wengine_OriginalTransmorpher_Pasive_Impact = { 0.1, 0.115, 0.13, 0.145, 0.16 };

        //Bunny Band
        double Wengine_BunnyBand_Main = 594;
        double Wengine_BunnyBand_Sub_DEF = 0.4;
        double[] Wengine_BunnyBand_Pasive_InitialHP = { 0.08, 0.092, 0.104, 0.116, 0.128 };
        double[] Wengine_BunnyBand_Pasive_ATK = { 0.1, 0.115, 0.13, 0.145, 0.16 };

        //Spring Embrace
        double Wengine_SpringEmbrace_Main = 594;
        double Wengine_SpringEmbrace_Sub_ATK = 0.25;

        //Reel Projector
        double Wengine_ReelProjector_Main = 594;
        double Wengine_ReelProjector_Sub_Impact = 0.15;

        //Big Cylinder
        double Wengine_BigCylinder_Main = 624;
        double Wengine_BigCylinder_Sub_DEF = 0.4;

        //Peacekeeper - Specialized
        double Wengine_PeacekeeperSpecialized_Main = 624;
        double Wengine_PeacekeeperSpecialized_Sub_ATK = 0.25;
        double[] Wengine_PeacekeeperSpecialized_Pasive_AnomalyBuildup_ex_assist = { 0.36, 0.4, 0.45, 0.5, 0.55 };

        //Tremor Trigram Vessel
        double Wengine_TremorTrigramVessel_Main = 624;
        double Wengine_TremorTrigramVessel_Sub_ATK = 0.25;
        double[] Wengine_TremorTrigramVessel_Pasive_DMG = { 0.25, 0.287, 0.325, 0.362, 0.4 };

        //Rupture
        //Puzzle Sphere
        double Wengine_PuzzleSphere_Main = 594;
        double Wengine_PuzzleSphere_Sub_ATK = 0.25;
        double[] Wengine_PuzzleSphere_Pasive_CritDMG = { 0.16, 0.184, 0.208, 0.232, 0.256 };
        double[] Wengine_PuzzleSphere_Pasive_exDMG = { 0.2, 0.23, 0.26, 0.29, 0.32 };

        //Radiowave Journey
        double Wengine_RadiowaveJourney_Main = 594;
        double Wengine_RadiowaveJourney_Sub_HP = 0.25;
        double[] Wengine_RadiowaveJourney_Pasive_SheerForce_stac_1 = { 80, 92, 104, 116, 128 };
        double[] Wengine_RadiowaveJourney_Pasive_SheerForce_stac_2 = { 160, 184, 208, 232, 256 };
        double[] Wengine_RadiowaveJourney_Pasive_SheerForce_stac_3 = { 240, 276, 312, 348, 384 };


        /*double Wengine__Main = ;
        double Wengine__Sub_ = ;
        double[] Wengine__Pasive_ = {  } ;*/
    }
}
