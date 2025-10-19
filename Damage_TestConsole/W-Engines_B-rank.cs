using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damage_TestConsole
{
    internal class W_Engines_B_rank
    {
        public class Main
        {
            public class LunarPleniluna
            {
                double Wengine_LunarPleniluna_Main = 475;
            }
            public class LunarDecrescent
            {
                double Wengine_LunarDecrescent_Main = 475;
            }
            public class LunarNoviluna
            {
                double Wengine_LunarNoviluna_Main = 475;
            }
            public class VortexRevolver
            {
                double Wengine_VortexRevolver_Main = 475;
            }
            public class VortexHatchet
            {
                double Wengine_VortexHatchet_Main = 475;
            }
            public class VortexArrow
            {
                double Wengine_VortexArrow_Main = 475;
            }
            public class MagneticStormAlpha
            {
                double Wengine_MagneticStormAlpha_Main = 475;
            }
            public class MagneticStormBravo
            {
                double Wengine_MagneticStormBravo_Main = 475;
            }
            public class MagneticStormCharlie
            {
                double Wengine_MagneticStormCharlie_Main = 475;
            }
            public class ReverbMarkI
            {
                double Wengine_ReverbMarkI_Main = 475;
            }
            public class ReverbMarkII
            {
                double Wengine_ReverbMarkII_Main = 475;
            }
            public class ReverbMarkIII
            {
                double Wengine_ReverbMarkIII_Main = 475;
            }
            public class IdentityBase
            {
                double Wengine_IdentityBase_Main = 475;
            }
            public class IdentityInflection
            {
                double Wengine_IdentityInflection_Main = 475;
            }
            public class CinderCobalt
            {
                double Wengine_CinderCobalt_Main = 475;
            }
        }
        public class Sub
        {
            public class ATK_Bufs
            {
                public class LunarPleniluna
                {
                    double Wengine_LunarPleniluna_Sub_ATK = 0.2;
                }
                public class LunarDecrescent
                {
                    double Wengine_LunarDecrescent_Sub_ATK = 0.2;
                }
                public class VortexRevolver
                {
                    double Wengine_VortexRevolver_Sub_ATK = 0.2;
                }
                public class MagneticStormAlpha
                {
                    double Wengine_MagneticStormAlpha_Sub_ATK = 0.2;
                }
                public class ReverbMarkI
                {
                    double Wengine_ReverbMarkI_Sub_ATK = 0.2;
                }
            }
            public class CritRate_Bufs
            {
                public class LunarNoviluna
                {
                    double Wengine_LunarNoviluna_Sub_CritRate = 0.16;
                }
            }
            public class EnergyRegen_Bufs
            {
                public class VortexHatchet
                {
                    double Wengine_VortexHatchet_Sub_EnergyRegen = 0.4;
                }
                public class ReverbMarkII
                {
                    double Wengine_ReverbMarkII_Sub_EnergyRegen = 0.4;
                }
            }
            public class Impact_Bufs
            {
                public class VortexArrow
                {
                    double Wengine_VortexArrow_Sub_Impact = 0.12;
                }
            }
            public class AM_Bufs
            {
                public class MagneticStormBravo
                {
                    double Wengine_MagneticStormBravo_Sub_AM = 60;
                }
            }
            public class PenRatio_Bufs
            {
                public class MagneticStormCharlie
                {
                    double Wengine_MagneticStormCharlie_Sub_PenRatio = 0.16;
                }
            }
            public class HP_Bufs
            {
                public class ReverbMarkIII
                {
                    double Wengine_ReverbMarkIII_Sub_HP = 0.2;
                }
                public class CinderCobalt
                {
                    double Wengine_CinderCobalt_Sub_HP = 0.2;
                }
            }
            public class DEF_Bufs
            {
                public class IdentityBase
                {
                    double Wengine_IdentityBase_Sub_DEF = 0.32;
                }
                public class IdentityInflection
                {
                    double Wengine_IdentityInflection_Sub_DEF = 0.32;
                }
            }
        }
        public class Pasive
        {
            public class DMG_Bufs
            {
                public class LunarPleniluna
                {
                    double[] Wengine_LunarPleniluna_Pasive_BasicAttack_DashAttack_DodgeCounter_DMG = { 0.12, 0.14, 0.16, 0.18, 0.2 };
                }
                public class LunarDecrescent
                {
                    double[] Wengine_LunarDecrescent_Pasive_DMG = { 0.15, 0.175, 0.2, 0.225, 0.25 };
                }
            }
            public class Impact_Bufs
            {
                public class VortexHatchet
                {
                    double[] Wengine_VortexHatchet_Pasive_CombatImpact = { 0.09, 0.1, 0.11, 0.12, 0.13 };
                }
                public class ReverbMarkI
                {
                    double[] Wengine_ReverbMarkI_Pasive_Impact_allsquad = { 0.08, 0.09, 0.1, 0.11, 0.12 };
                }
            }
            public class AM_Bufs
            {
                public class MagneticStormAlpha
                {
                    double[] Wengine_MagneticStormAlpha_Pasive_AM = { 25, 28, 32, 36, 40 };
                }
                public class MagneticStormBravo
                {
                    double[] Wengine_MagneticStormBravo_Pasive_AM = { 25, 28, 32, 36, 40 };
                }
                public class ReverbMarkII
                {
                    double[] Wengine_ReverbMarkII_Pasive_AM = { 10, 12, 13, 15, 16 };
                }
            }
            public class AP_Bufs
            {
                public class ReverbMarkII
                {
                    double[] Wengine_ReverbMarkII_Pasive_AM_AP = { 10, 12, 13, 15, 16 };
                }
            }
            public class ATK_Bufs
            {
                public class ReverbMarkIII
                {
                    double[] Wengine__Pasive_ATK_allsquad = { 0.08, 0.09, 0.1, 0.11, 0.12 };
                }
                public class CinderCobalt
                {
                    double[] Wengine_CinderCobalt_Pasive_ATK = { 0.072, 0.082, 0.093, 0.104, 0.115 };
                }
            }
            public class DEF_Bufs
            {
                public class IdentityBase
                {
                    double[] Wengine_IdentityBase_Pasive_DEF = { 0.2, 0.23, 0.26, 0.29, 0.32 };
                }
            }
        }
    }
}
