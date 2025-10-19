using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damage_TestConsole
{
    internal class DriveDisc
    {
        public class CombatATK_Bufs
        {
            public class AstralVoice
            {
                public double AstralVoice_2_ATK { get; } = 0.1;
            }
            public class HormonePunk
            {
                double HormonePunk_2_ATK = 0.1;
            }
        }
        public class ATK_Bufs
        {
            public class HormonePunk
            {
                double HormonePunk_4_ATK = 0.25;
            }
            public class PufferElectro
            {
                double PufferElectro_4_ATK = 0.1;
            }
            public class ShadowHarmony
            {
                double[] ShadowHarmony_4_ATK = { 0.04, 0.08, 0.12 };
            }
            public class ThunderMetal
            {
                double ThunderMetal_4_ATK = 0.28;
            }
            public class WoodpeckerElectro
            {

                double[] WoodpeckerElectro_4_ATK = { 0.09, 0.18, 0.27 };
            }
        }
        public class CritRate_Bufs
        {
            public class BranchBladeSong
            {
                public double BranchBladeSong_2_CritDMG { get; } = 0.16;
                public double BranchBladeSong_4_CritRate { get; } = 0.12;
            }
            public class ChaoticMetal
            {
                double ChaoticMetal_4_CritRate = 0.33;
            }
            public class InfernoMetal
            {
                double InfernoMetal_4_CritRate = 0.28;
            }
            public class ShadowHarmony
            {
                double[] ShadowHarmony_4_CritRate = { 0.04, 0.08, 0.12 };
            }

            public class WoodpeckerElectro
            {
                double WoodpeckerElectro_2_CritRate = 0.08;
            }
            public class YunkuiTales
            {
                double[] YunkuiTales_4_CritRate = { 0.09, 0.18, 0.12 };
            }
        }
        public class CritDMG_Bufs
        {
            public class BranchBladeSong
            {
                public double BranchBladeSong_4_CritDMG { get; } = 0.3;
            }
            public class ChaoticMetal
            {
                double ChaoticMetal_4_CritDMG = 0.2;
            }
            public class KingOfTheSummit
            {
                //all squad
                //>50 critrate
                double KingOfTheSummit_4_CritDMG_1 = 0.15;
                //<50 critrate
                double KingOfTheSummit_4_CritDMG_2 = 0.30;
            }
        }
        public class AP_Bufs
        {
            public class ChaosJazz
            {
                double ChaosJazz_2_AP { get; } = 30;
            }
            public class FreedomBlues
            {
                double FreedomBlues_2_AP = 30;
            }
            public class PhaethonsMelody
            {
                double PhaethonsMelody_4_AP = 45;
            }
        }
        public class AM_Bufs
        {
            public class PhaethonsMelody
            {
                double PhaethonsMelody_2_AM = 0.08;
            }
        }
        public class Pen_Buff
        {
            public class PufferElectro
            {
                double PufferElectro_2_Pen = 0.08;
            }
        }
        public class Impact
        {
            
            public class ShockstarDisco
            {
                double ShockstarDisco_2_Impact = 0.06;
            }
        }
        public class DEF
        {
            public class SoulRock
            {
                double SoulRock_2_DEF = 0.16;
            }

        }
        public class EnergyRegen
        {
            public class SwingJazz
            {
                double SwingJazz_2_EnergyRegen = 0.2;
            }
            public class MoonlightLullaby
            {
                double MoonlightLullaby_2_EnergyRegen = 0.2;
            }
        }
        public class HP
        {
            public class YunkuiTales
            {
                double YunkuiTales_2_HP = 0.1;
            }
        }
        public class DMG_Bufs
        {
            public class AstralVoice
            {
                public double[] AstralVoice_4_DMG { get; } = { 0.08, 0.16, 0.24 };
            }
            public class ChaosJazz
            {
                //Fire and Electric
                public double ChaosJazz_4_DMG_1 { get; } = 0.15;
                //EX and Assist
                public double ChaosJazz_4_DMG_2 { get; } = 0.2;
            }
            public class ChaoticMetal
            {
                //Ether
                double ChaoticMetal_2_DMG = 0.1;
            }
            public class FangedMetal
            {
                //Physical
                double FangedMetal_2_DMG = 0.1;

                double FangedMetal_4_DMG = 0.35;
            }
            public class InfernoMetal
            {
                //Fire
                double InfernoMetal_2_DMG = 0.1;
            }
            public class PhaethonsMelody
            {
                double PhaethonsMelody_4_EtherDMG = 0.25;
            }
            public class PolarMetal
            {
                double PolarMetal_2_IceDMG = 0.1;
                //Basic Dash
                double PolarMetal_4_DMG_1 = 0.2;
                //Basic Dash, Freeze or Shatter
                double PolarMetal_4_DMG_2 = 0.4;
            }
            public class ProtoPunk
            {
                //all squad
                double ProtoPunk_4_DMG = 0.15;
            }
            public class PufferElectro
            {
                //Ultimate
                double PufferElectro_4_DMG = 0.2;
            }
            public class ShadowHarmony
            {
                //Aftershocks and Dash
                double ShadowHarmony_2_DMG = 0.15;
            }
            public class SwingJazz
            {
                double SwingJazz_4_DMG = 0.15;
            }
            public class ThunderMetal
            {
                //Electric
                double ThunderMetal_2_DMG = 0.1;
            }
            public class YunkuiTales
            {
                //Sheer
                double YunkuiTales_4_DMG = 0.1;
            }
            public class DawnBloom
            {
                //Basic
                double DawnBloom_2_DMG = 0.15;
                double DawnBloom_4_DMG_1 = 0.2;
                //if ex or ult
                double DawnBloom_4_DMG_2 = 0.2;
            }
            public class MoonlightLullaby
            {
                //if ex or ult, all squad
                double MoonlightLullaby_4_DMG = 0.18;
            }
        }
    }
}