using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damage_TestConsole
{
    internal class W_Engines_B_rank
    {
        public string name1 = "[Lunar] Pleniluna";
        public string name2 = "[Lunar] Decrescent";
        public string name3 = "[Lunar] Noviluna";
        public string name4 = "[Reverb] Mark I";
        public string name5 = "[Reverb] Mark II";
        public string name6 = "[Reverb] Mark III";
        public string name7 = "[Vortex] Revolver";
        public string name8 = "[Vortex] Arrow";
        public string name9 = "[Vortex] Hatchet";
        public string name10 = "[Magnetic Storm] Alpha";
        public string name11 = "[Magnetic Storm] Bravo";
        public string name12 = "[Magnetic Storm] Charlie";
        public string name13 = "[Identity] Base";
        public string name14 = "[Identity] Inflection";
        public string name15 = "[Cinder] Cobalt";
        public class Main
        {
            public class LunarPleniluna
            {
                public double Wengine_LunarPleniluna_Main { get; } = 475;
            }
            public class LunarDecrescent
            {
                public double Wengine_LunarDecrescent_Main { get; } = 475;
            }
            public class LunarNoviluna
            {
                public double Wengine_LunarNoviluna_Main { get; } = 475;
            }
            public class VortexRevolver
            {
                public double Wengine_VortexRevolver_Main { get; } = 475;
            }
            public class VortexHatchet
            {
                public double Wengine_VortexHatchet_Main { get; } = 475;
            }
            public class VortexArrow
            {
                public double Wengine_VortexArrow_Main { get; } = 475;
            }
            public class MagneticStormAlpha
            {
                public double Wengine_MagneticStormAlpha_Main { get; } = 475;
            }
            public class MagneticStormBravo
            {
                public double Wengine_MagneticStormBravo_Main { get; } = 475;
            }
            public class MagneticStormCharlie
            {
                public double Wengine_MagneticStormCharlie_Main { get; } = 475;
            }
            public class ReverbMarkI
            {
                public double Wengine_ReverbMarkI_Main { get; } = 475;
            }
            public class ReverbMarkII
            {
                public double Wengine_ReverbMarkII_Main { get; } = 475;
            }
            public class ReverbMarkIII
            {
                public double Wengine_ReverbMarkIII_Main { get; } = 475;
            }
            public class IdentityBase
            {
                public double Wengine_IdentityBase_Main { get; } = 475;
            }
            public class IdentityInflection
            {
                public double Wengine_IdentityInflection_Main { get; } = 475;
            }
            public class CinderCobalt
            {
                public double Wengine_CinderCobalt_Main { get; } = 475;
            }
        }
        public class Sub
        {
            public class ATK_Bufs
            {
                public class LunarPleniluna
                {
                    public double Wengine_LunarPleniluna_Sub_ATK { get; } = 0.2;
                }
                public class LunarDecrescent
                {
                    public double Wengine_LunarDecrescent_Sub_ATK { get; } = 0.2;
                }
                public class VortexRevolver
                {
                    public double Wengine_VortexRevolver_Sub_ATK { get; } = 0.2;
                }
                public class MagneticStormAlpha
                {
                    public double Wengine_MagneticStormAlpha_Sub_ATK { get; } = 0.2;
                }
                public class ReverbMarkI
                {
                    public double Wengine_ReverbMarkI_Sub_ATK { get; } = 0.2;
                }
            }
            public class CritRate_Bufs
            {
                public class LunarNoviluna
                {
                    public double Wengine_LunarNoviluna_Sub_CritRate { get; } = 0.16;
                }
            }
            public class EnergyRegen_Bufs
            {
                public class VortexHatchet
                {
                    public double Wengine_VortexHatchet_Sub_EnergyRegen { get; } = 0.4;
                }
                public class ReverbMarkII
                {
                    public double Wengine_ReverbMarkII_Sub_EnergyRegen { get; } = 0.4;
                }
            }
            public class Impact_Bufs
            {
                public class VortexArrow
                {
                    public double Wengine_VortexArrow_Sub_Impact { get; } = 0.12;
                }
            }
            public class AM_Bufs
            {
                public class MagneticStormBravo
                {
                    public double Wengine_MagneticStormBravo_Sub_AM { get; } = 60;
                }
            }
            public class PenRatio_Bufs
            {
                public class MagneticStormCharlie
                {
                    public double Wengine_MagneticStormCharlie_Sub_PenRatio { get; } = 0.16;
                }
            }
            public class HP_Bufs
            {
                public class ReverbMarkIII
                {
                    public double Wengine_ReverbMarkIII_Sub_HP { get; } = 0.2;
                }
                public class CinderCobalt
                {
                    public double Wengine_CinderCobalt_Sub_HP { get; } = 0.2;
                }
            }
            public class DEF_Bufs
            {
                public class IdentityBase
                {
                    public double Wengine_IdentityBase_Sub_DEF { get; } = 0.32;
                }
                public class IdentityInflection
                {
                    public double Wengine_IdentityInflection_Sub_DEF { get; } = 0.32;
                }
            }
        }
        public class Pasive
        {
            public class DMG_Bufs
            {
                public class LunarPleniluna
                {
                    public double[] Wengine_LunarPleniluna_Pasive_BasicAttack_DashAttack_DodgeCounter_DMG { get; } = { 0.12, 0.14, 0.16, 0.18, 0.2 };
                }
                public class LunarDecrescent
                {
                    public double[] Wengine_LunarDecrescent_Pasive_DMG { get; } = { 0.15, 0.175, 0.2, 0.225, 0.25 };
                }
            }
            public class Impact_Bufs
            {
                public class VortexHatchet
                {
                    public double[] Wengine_VortexHatchet_Pasive_CombatImpact { get; } = { 0.09, 0.1, 0.11, 0.12, 0.13 };
                }
                public class ReverbMarkI
                {
                    public double[] Wengine_ReverbMarkI_Pasive_Impact_allsquad { get; } = { 0.08, 0.09, 0.1, 0.11, 0.12 };
                }
            }
            public class AM_Bufs
            {
                public class MagneticStormAlpha
                {
                    public double[] Wengine_MagneticStormAlpha_Pasive_AM { get; } = { 25, 28, 32, 36, 40 };
                }
                public class MagneticStormBravo
                {
                    public double[] Wengine_MagneticStormBravo_Pasive_AM { get; } = { 25, 28, 32, 36, 40 };
                }
                public class ReverbMarkII
                {
                    public double[] Wengine_ReverbMarkII_Pasive_AM { get; } = { 10, 12, 13, 15, 16 };
                }
            }
            public class AP_Bufs
            {
                public class ReverbMarkII
                {
                    public double[] Wengine_ReverbMarkII_Pasive_AM_AP { get; } = { 10, 12, 13, 15, 16 };
                }
            }
            public class ATK_Bufs
            {
                public class ReverbMarkIII
                {
                    public double[] Wengine__Pasive_ATK_allsquad { get; } = { 0.08, 0.09, 0.1, 0.11, 0.12 };
                }
                public class CinderCobalt
                {
                    public double[] Wengine_CinderCobalt_Pasive_ATK { get; } = { 0.072, 0.082, 0.093, 0.104, 0.115 };
                }
            }
            public class DEF_Bufs
            {
                public class IdentityBase
                {
                    public double[] Wengine_IdentityBase_Pasive_DEF { get; } = { 0.2, 0.23, 0.26, 0.29, 0.32 };
                }
            }
        }
    }
}