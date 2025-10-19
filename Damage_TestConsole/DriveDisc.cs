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
                public double HormonePunk_2_ATK { get; } = 0.1;
            }
        }
        public class ATK_Bufs
        {
            public class HormonePunk
            {
                public double HormonePunk_4_ATK { get; } = 0.25;
            }
            public class PufferElectro
            {
                public double PufferElectro_4_ATK { get; } = 0.1;
            }
            public class ShadowHarmony
            {
                double[] ShadowHarmony_4_ATK { get; } = { 0.04, 0.08, 0.12 };
            }
            public class ThunderMetal
            {
                public double ThunderMetal_4_ATK { get; } = 0.28;
            }
            public class WoodpeckerElectro
            {

                public double[] WoodpeckerElectro_4_ATK { get; } = { 0.09, 0.18, 0.27 };
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
                public double ChaoticMetal_4_CritRate { get; } = 0.33;
            }
            public class InfernoMetal
            {
                public double InfernoMetal_4_CritRate { get; } = 0.28;
            }
            public class ShadowHarmony
            {
                public double[] ShadowHarmony_4_CritRate { get; } = { 0.04, 0.08, 0.12 };
            }

            public class WoodpeckerElectro
            {
                public double WoodpeckerElectro_2_CritRate { get; } = 0.08;
            }
            public class YunkuiTales
            {
                public double[] YunkuiTales_4_CritRate { get; } = { 0.09, 0.18, 0.12 };
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
                public double ChaoticMetal_4_CritDMG { get; } = 0.2;
            }
            public class KingOfTheSummit
            {
                //all squad
                //>50 critrate
                public double KingOfTheSummit_4_CritDMG_1 { get; } = 0.15;
                //<50 critrate
                public double KingOfTheSummit_4_CritDMG_2 { get; } = 0.30;
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
                public double FreedomBlues_2_AP { get; } = 30;
            }
            public class PhaethonsMelody
            {
                public double PhaethonsMelody_4_AP { get; } = 45;
            }
        }
        public class AM_Bufs
        {
            public class PhaethonsMelody
            {
                public double PhaethonsMelody_2_AM { get; } = 0.08;
            }
        }
        public class Pen_Buff
        {
            public class PufferElectro
            {
                public double PufferElectro_2_Pen { get; } = 0.08;
            }
        }
        public class Impact
        {

            public class ShockstarDisco
            {
                public double ShockstarDisco_2_Impact { get; } = 0.06;
            }
        }
        public class DEF
        {
            public class SoulRock
            {
                public double SoulRock_2_DEF { get; } = 0.16;
            }

        }
        public class EnergyRegen
        {
            public class SwingJazz
            {
                public double SwingJazz_2_EnergyRegen { get; } = 0.2;
            }
            public class MoonlightLullaby
            {
                public double MoonlightLullaby_2_EnergyRegen { get; } = 0.2;
            }
        }
        public class HP
        {
            public class YunkuiTales
            {
                public double YunkuiTales_2_HP { get; } = 0.1;
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
                public double ChaoticMetal_2_DMG { get; } = 0.1;
            }
            public class FangedMetal
            {
                //Physical
                public double FangedMetal_2_DMG { get; } = 0.1;

                public double FangedMetal_4_DMG { get; } = 0.35;
            }
            public class InfernoMetal
            {
                //Fire
                public double InfernoMetal_2_DMG { get; } = 0.1;
            }
            public class PhaethonsMelody
            {
                public double PhaethonsMelody_4_EtherDMG { get; } = 0.25;
            }
            public class PolarMetal
            {
                public double PolarMetal_2_IceDMG { get; } = 0.1;
                //Basic Dash
                public double PolarMetal_4_DMG_1 { get; } = 0.2;
                //Basic Dash, Freeze or Shatter
                public double PolarMetal_4_DMG_2 { get; } = 0.4;
            }
            public class ProtoPunk
            {
                //all squad
                public double ProtoPunk_4_DMG { get; } = 0.15;
            }
            public class PufferElectro
            {
                //Ultimate
                public double PufferElectro_4_DMG { get; } = 0.2;
            }
            public class ShadowHarmony
            {
                //Aftershocks and Dash
                public double ShadowHarmony_2_DMG { get; } = 0.15;
            }
            public class SwingJazz
            {
                public double SwingJazz_4_DMG { get; } = 0.15;
            }
            public class ThunderMetal
            {
                //Electric
                public double ThunderMetal_2_DMG { get; } = 0.1;
            }
            public class YunkuiTales
            {
                //Sheer
                public double YunkuiTales_4_DMG { get; } = 0.1;
            }
            public class DawnBloom
            {
                //Basic
                public double DawnBloom_2_DMG { get; } = 0.15;
                public double DawnBloom_4_DMG_1 { get; } = 0.2;
                //if ex or ult
                public double DawnBloom_4_DMG_2 { get; } = 0.2;
            }
            public class MoonlightLullaby
            {
                //if ex or ult, all squad
                public double MoonlightLullaby_4_DMG { get; } = 0.18;
            }
        }
    }
}