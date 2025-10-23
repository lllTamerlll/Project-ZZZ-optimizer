using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Damage_TestConsole
{
    internal class Harumasa
    {
        public class Skills
        {
            public class Basic
            {
                //Normal Attack: Cloud Piercer
                public double[] first_cloudpiercer_hit { get; } = { 0.424, 0.463, 0.502, 0.541, 0.58, 0.619, 0.658, 0.697, 0.736, 0.775, 0.814, 0.853, 0.892, 0.931, 0.97, 1.009 };
                public double[] second_cloudpiercer_hit { get; } = { 0.398, 0.435, 0.472, 0.509, 0.546, 0.583, 0.62, 0.657, 0.694, 0.731, 0.768, 0.805, 0.842, 0.879, 0.916, 0.953 };
                public double[] third_cloudpiercer_hitv { get; } = { 0.709, 0.774, 0.839, 0.904, 0.969, 1.034, 1.099, 1.164, 1.229, 1.294, 1.359, 1.424, 1.489, 1.554, 1.619, 1.684 };
                public double[] fourth_cloudpiercer_hit { get; } = { 0.901, 0.983, 1.065, 1.147, 1.229, 1.311, 1.393, 1.475, 1.557, 1.639, 1.721, 1.803, 1.885, 1.967, 2.049, 2.131 };
                public double[] fifth_cloudpiercer_hit { get; } = { 1.329, 1.45, 1.571, 1.692, 1.813, 1.934, 2.055, 2.176, 2.297, 2.418, 2.539, 2.66, 2.781, 2.902, 3.023, 3.144 };
                //Normal Attack: Cloud Piercer - Shift
                public double[] cloudpiercershift_hit { get; } = { 0.695, 0.759, 0.823, 0.887, 0.951, 1.015, 1.079, 1.143, 1.207, 1.271, 1.335, 1.399, 1.463, 1.527, 1.591, 1.655 };
                //Normal Attack: Falling Feather
                public double[] fallingfeather_hit { get; } = { 1.054, 1.15, 1.246, 1.342, 1.438, 1.534, 1.63, 1.726, 1.822, 1.918, 2.014, 2.11, 2.206, 2.302, 2.398, 2.494 };
                //Normal Attack: A-B Arrows
                public double[] ABarrows { get; } = { 0.159, 0.174, 0.18, 90.204, 0.219, 0.234, 0.249, 0.264, 0.279, 0.294, 0.309, 0.324, 0.339, 0.354, 0.369, 0.384 };
            }
            public class Special
            {
                //Special Skill: Heavenly Net
                public double[] heavenlynet { get; } = { 0.523, 0.571, 0.619, 0.667, 0.715, 0.763, 0.811, 0.859, 0.907, 0.955, 1.003, 1.051, 1.099, 1.147, 1.195, 1.243 };
            }
            public class Assist
            {
                //Quick Assist: Piercing String
                public double[] piercingstring { get; } = { 0.843, 0.92, 0.997, 1.074, 1.151, 1.228, 1.305, 1.382, 1.459, 1.536, 1.613, 1.69, 1.767, 1.844, 1.921, 1.998 };
                //Assist Assault: Stance - Slash
                public double[] stanceslash { get; } = { 3.071, 3.351, 3.631, 3.911, 4.191, 4.471, 4.751, 5.031, 5.311, 5.591, 5.871, 6.151, 6.431, 6.711, 6.991, 7.271 };
            }
            public class Dodge
            {
                //Dash Attack: Flying String
                public double[] flyingstring { get; } = { 0.807, 0.881, 0.955, 1.029, 1.103, 1.177, 1.251, 1.325, 1.399, 1.473, 1.547, 1.621, 1.695, 1.769, 1.843, 1.917 };
                //Dodge Counter: Hidden Edge
                public double[] hiddenedge { get; } = { 2.196, 2.396, 2.596, 2.796, 2.996, 3.196, 3.396, 3.596, 3.796, 3.996, 4.196, 4.396, 4.596, 4.796, 4.996, 5.196 };
                //Dash Attack: Flying String - Slash
                public double[] dash_first_hit { get; } = { 1.623, 1.771, 1.919, 2.067, 2.215, 2.363, 2.511, 2.659, 2.807, 2.955, 3.103, 3.251, 3.399, 3.547, 3.695, 3.843 };
                public double[] dash_second_hit { get; } = { 1.666, 1.818, 1.97, 2.122, 2.274, 2.426, 2.578, 2.73, 2.882, 3.034, 3.186, 3.338, 3.49, 3.642, 3.794, 3.946 };
                public double[] dash_third_hit { get; } = { 1.896, 2.069, 2.242, 2.415, 2.588, 2.761, 2.934, 3.107, 3.28, 3.453, 3.626, 3.799, 3.972, 4.145, 4.318, 4.491 };
            }
            public class Chain
            {
                //Chain Skill: Meet and Depart
                public double[] meetanddepart { get; } = { 5.176, 5.647, 6.118, 6.589, 7.06, 7.531, 8.002, 8.473, 8.944, 9.415, 9.886, 10.357, 10.828, 11.299, 11.77, 12.241 };
                //Ultimate Skill: Zanshin
                public double[] zanshin { get; } = { 19.539, 21.316, 23.093, 24.87, 26.647, 28.424, 30.201, 31.978, 33.755, 35.532, 37.309, 39.086, 40.863, 42.64, 44.417, 46.194 };
            }
            public class CoreSkill
            {
                //Core Passive: Dawnbreaker
                //crit rate: Dash Attack: Flying String - Slash
                public double[] CritRate { get; } = { 0.106, 0.13, 0.154, 0.178, 0.202, 0.226, 0.25 };
                //crit dmg: Dash Attack: Flying String - Slash
                public double[] CritDMG_stac_1 { get; } = { 0.06, 0.07, 0.08, 0.09, 0.1, 0.11, 0.12 };
                public double[] CritDMG_stac_2 { get; } = { 0.12, 0.14, 0.16, 0.18, 0.2, 0.22, 0.24 };
                public double[] CritDMG_stac_3 { get; } = { 0.18, 0.21, 0.24, 0.27, 0.3, 0.33, 0.36 };
                //Extra Ability: Overclock
                //Break or Abnormal Status
                public double DMG { get; } = 0.4;
            }
            public class MindscapeCinema
            {
                //Mind Two
                public double MDG_DashAttack_FlyingStringSlash { get; } = 0.5;
                //Min six
                //After [A-B Arrows] hit an enemy in a Stunned or Elemental Abnormal Status
                public double Ignores_Electric_Damage_Resistance { get; } = 0.15;
                //every 12 hits of [A-B Arrows] on the same enemy, dealing 1500% of Harumasa's Attack as Electric Damage to the target
                public double Electric_Damage_frmATK { get; } = 15;
            }
        }
    }
}
