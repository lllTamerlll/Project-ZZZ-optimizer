using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damage_TestConsole
{
    public class DamageStats
    {
        // Base DMG компоненты
        public double SkillMV { get; set; } = 0;
        public double ScalingStat { get; set; } = 0;
        public double FlatMV { get; set; } = 0;

        // DMG% Modifier компоненты
        public double DMGBonus { get; set; } = 0;

        // Crit Modifier компоненты
        public double CritRate { get; set; } = 0;
        public double CritDMG { get; set; } = 0;

        // RES Modifier компоненты
        public double AttributeRES { get; set; } = 0.2;
        public double AllTypeRES { get; set; } = 0;
        public double RESReduction { get; set; } = 0;
        public double RESPEN { get; set; } = 0;

        // DEF Modifier компоненты
        public double TargetBaseDEF { get; set; } = 953;
        public double DEFPercent { get; set; } = 0;
        public double DEFReduction { get; set; } = 0;
        public double DEFIgnore { get; set; } = 0;
        public double LevelCoefficient { get; set; } = 794;
        public double PENRatio { get; set; } = 0;
        public double FlatPEN { get; set; } = 0;

        // Stun Modifier компоненты
        public double StunBonus { get; set; } = 150;

        // Anomaly Stats
        public double AnomalyProficiency { get; set; } = 0;
        public double AnomalyMastery { get; set; } = 0;
        public double Impact { get; set; } = 0;
        public double EnergyRegen { get; set; } = 0;

        // Elemental DMG
        public double ElectricDMG { get; set; } = 0;
        public double FireDMG { get; set; } = 0;
        public double IceDMG { get; set; } = 0;
        public double PhysicalDMG { get; set; } = 0;
        public double EtherDMG { get; set; } = 0;
        public double WindDMG { get; set; } = 0;

        // HP Stats
        public double HP { get; set; } = 0;
        public double HPPercent { get; set; } = 0;

        // DEF Stats
        public double DEF { get; set; } = 0;
        public double DEFPercentStat { get; set; } = 0;

        // Utility Stats
        public double EffectHitRate { get; set; } = 0;

        // Временные переменные для расчета
        public double BaseDMG { get; set; } = 0;
        public double FinalDamage { get; set; } = 0;
        public bool IsCrit { get; set; } = false;
    }

    public class ArtifactSubstat
    {
        public string Name { get; set; }
        public double BaseValue { get; set; }
        public int Rolls { get; set; }
        public double TotalValue => BaseValue * Rolls;
    }

    class Program
    {
        static Harumasa selectedCharacter = new Harumasa();
        static W_Engines_B_rank selectedWengen_B = new W_Engines_B_rank();
        static W_Engines_A_rank selectedWengen_A = new W_Engines_A_rank();
        static W_Engines_S_rank selectedWengen_S = new W_Engines_S_rank();
        static DriveDisc selectedSet = new DriveDisc();

        static DamageStats currentStats = new DamageStats();
        static List<ArtifactSubstat> artifactSubstats = new List<ArtifactSubstat>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ShowWelcomeMessage();
            SelectAgent();
            SelectSkillAndLevel();
            SelectWeaponRarity();
            SelectArtifacts();
            CalculateFinalDamage();

            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey();
        }

        static void ShowWelcomeMessage()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 СИМУЛЯТОР РАСЧЕТА УРОНА                      ║");
            Console.WriteLine("║                   Damage Calculator v1.0                     ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
        }

        static void SelectAgent()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                       ВЫБОР АГЕНТА                           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\nЧтобы выбрать агента, введите соответствующее число:");
            Console.WriteLine("Харумаса - 1");

            string input = GetUserInput();

            if (int.TryParse(input, out int choice))
            {
                ProcessAgentSelection(choice);
            }
            else
            {
                ShowErrorMessage("Неверный ввод. Введите число");
                SelectAgent();
            }
        }

        static void ProcessAgentSelection(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"\n✓ Выбран агент: {selectedCharacter.name}");
                    var basicStats = new Harumasa.Basic_stats();
                    var atk = new Harumasa.Basic_stats.ATK();
                    var critRate = new Harumasa.Basic_stats.CRIT_Rate();
                    var critDmg = new Harumasa.Basic_stats.CRIT_DMG();
                    var hp = new Harumasa.Basic_stats.HP();
                    var def = new Harumasa.Basic_stats.DEF();
                    var impact = new Harumasa.Basic_stats.Impact();
                    var am = new Harumasa.Basic_stats.AM();
                    var ap = new Harumasa.Basic_stats.AP();
                    var energyRegen = new Harumasa.Basic_stats.Energy_Regen();

                    currentStats.ScalingStat = atk.ATK_Basic;
                    currentStats.CritRate = critRate.CRITRate_Basic;
                    currentStats.CritDMG = critDmg.CRITDMG_Basic;
                    currentStats.HP = hp.HP_Basic;
                    currentStats.DEF = def.DEF_Basic;
                    currentStats.Impact = impact.Impact_Basic;
                    currentStats.AnomalyMastery = am.AM_Basic;
                    currentStats.AnomalyProficiency = ap.AP_Basic;
                    currentStats.EnergyRegen = energyRegen.EnergyRegen_Basic;

                    Console.WriteLine($"✓ Базовая атака: {currentStats.ScalingStat}");
                    Console.WriteLine($"✓ Базовый крит шанс: {currentStats.CritRate:P1}");
                    Console.WriteLine($"✓ Базовый крит урон: {currentStats.CritDMG:P1}");
                    Console.WriteLine($"✓ Базовое HP: {currentStats.HP}");
                    Console.WriteLine($"✓ Базовая защита: {currentStats.DEF}");
                    break;
                default:
                    ShowErrorMessage("Неверный выбор агента");
                    SelectAgent();
                    break;
            }
        }

        static void SelectSkillAndLevel()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   ВЫБОР НАВЫКА И УРОВНЯ                     ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            var skills = new Harumasa.Skills();
            var basic = new Harumasa.Skills.Basic();
            var special = new Harumasa.Skills.Special();
            var assist = new Harumasa.Skills.Assist();
            var dodge = new Harumasa.Skills.Dodge();
            var chain = new Harumasa.Skills.Chain();

            Console.WriteLine("\nВыберите навык для расчета урона (введите два числа через пробел):");
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            Console.WriteLine("1 - Basic Attack: Cloud Piercer");
            Console.WriteLine("   1 - First Hit");
            Console.WriteLine("   2 - Second Hit");
            Console.WriteLine("   3 - Third Hit");
            Console.WriteLine("   4 - Fourth Hit");
            Console.WriteLine("   5 - Fifth Hit");
            Console.WriteLine("   6 - Cloud Piercer Shift");
            Console.WriteLine("   7 - Falling Feather");
            Console.WriteLine("   8 - A-B Arrows");
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            Console.WriteLine("2 - Special Skill: Heavenly Net");
            Console.WriteLine("   1 - Heavenly Net");
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            Console.WriteLine("3 - Quick Assist");
            Console.WriteLine("   1 - Piercing String");
            Console.WriteLine("   2 - Stance Slash");
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            Console.WriteLine("4 - Dash Attack");
            Console.WriteLine("   1 - Flying String");
            Console.WriteLine("   2 - Hidden Edge");
            Console.WriteLine("   3 - Dash First Hit");
            Console.WriteLine("   4 - Dash Second Hit");
            Console.WriteLine("   5 - Dash Third Hit");
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            Console.WriteLine("5 - Chain Skill");
            Console.WriteLine("   1 - Meet and Depart");
            Console.WriteLine("   2 - Zanshin");
            Console.WriteLine("──────────────────────────────────────────────────────────────");

            string skillInput = GetUserInput();
            string[] skillParts = skillInput.Split(' ');

            if (skillParts.Length == 2 && int.TryParse(skillParts[0], out int skillType) &&
                int.TryParse(skillParts[1], out int skillNumber))
            {
                double[] selectedSkill = GetSelectedSkill(skillType, skillNumber, basic, special, assist, dodge, chain);

                if (selectedSkill != null)
                {
                    Console.WriteLine($"\nВыберите уровень навыка (1-{selectedSkill.Length}):");
                    string levelInput = GetUserInput();

                    if (int.TryParse(levelInput, out int skillLevel) && skillLevel >= 1 && skillLevel <= selectedSkill.Length)
                    {
                        currentStats.SkillMV = selectedSkill[skillLevel - 1];
                        Console.WriteLine($"✓ Установлен множитель навыка: {currentStats.SkillMV:P1}");
                    }
                    else
                    {
                        Console.WriteLine("Неверный уровень! Установлен уровень 1");
                        currentStats.SkillMV = selectedSkill[0];
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор навыка! Установлен Fifth Hit уровень 1");
                    currentStats.SkillMV = basic.fifth_cloudpiercer_hit[0];
                }
            }
            else
            {
                Console.WriteLine("Неверный формат ввода! Установлен Fifth Hit уровень 1");
                currentStats.SkillMV = basic.fifth_cloudpiercer_hit[0];
            }
        }

        static double[] GetSelectedSkill(int skillType, int skillNumber,
            Harumasa.Skills.Basic basic,
            Harumasa.Skills.Special special,
            Harumasa.Skills.Assist assist,
            Harumasa.Skills.Dodge dodge,
            Harumasa.Skills.Chain chain)
        {
            switch (skillType)
            {
                case 1: // Basic Attack
                    switch (skillNumber)
                    {
                        case 1: return basic.first_cloudpiercer_hit;
                        case 2: return basic.second_cloudpiercer_hit;
                        case 3: return basic.third_cloudpiercer_hitv;
                        case 4: return basic.fourth_cloudpiercer_hit;
                        case 5: return basic.fifth_cloudpiercer_hit;
                        case 6: return basic.cloudpiercershift_hit;
                        case 7: return basic.fallingfeather_hit;
                        case 8: return basic.ABarrows;
                        default: return null;
                    }
                case 2: // Special Skill
                    switch (skillNumber)
                    {
                        case 1: return special.heavenlynet;
                        default: return null;
                    }
                case 3: // Quick Assist
                    switch (skillNumber)
                    {
                        case 1: return assist.piercingstring;
                        case 2: return assist.stanceslash;
                        default: return null;
                    }
                case 4: // Dash Attack
                    switch (skillNumber)
                    {
                        case 1: return dodge.flyingstring;
                        case 2: return dodge.hiddenedge;
                        case 3: return dodge.dash_first_hit;
                        case 4: return dodge.dash_second_hit;
                        case 5: return dodge.dash_third_hit;
                        default: return null;
                    }
                case 5: // Chain Skill
                    switch (skillNumber)
                    {
                        case 1: return chain.meetanddepart;
                        case 2: return chain.zanshin;
                        default: return null;
                    }
                default:
                    return null;
            }
        }

        static void SelectWeaponRarity()
        {
            while (true)
            {
                Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                   ВЫБОР РЕДКОСТИ ОРУЖИЯ                     ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

                Console.WriteLine("\nВведите редкость оружия:");
                Console.WriteLine("Без оружия - 0");
                Console.WriteLine("B-ранк - 1");
                Console.WriteLine("A-ранк - 2");
                Console.WriteLine("S-ранк - 3");

                string input = GetUserInput();

                if (int.TryParse(input, out int rarityChoice))
                {
                    if (rarityChoice == 0)
                    {
                        Console.WriteLine("\n✓ Выбрано: Без оружия");
                        break;
                    }
                    else if (ProcessWeaponRaritySelection(rarityChoice))
                    {
                        break;
                    }
                }
                else
                {
                    ShowErrorMessage("Неверный ввод. Введите число");
                }
            }
        }

        static bool ProcessWeaponRaritySelection(int rarityChoice)
        {
            switch (rarityChoice)
            {
                case 1:
                    SelectBWeapon();
                    return true;
                case 2:
                    SelectAWeapon();
                    return true;
                case 3:
                    SelectSWeapon();
                    return true;
                default:
                    ShowErrorMessage("Неверный выбор редкости");
                    return false;
            }
        }

        static void SelectBWeapon()
        {
            Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("                   ВЫБОР B-РАНК ОРУЖИЯ");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            Console.WriteLine("[Lunar] Pleniluna - 1");
            Console.WriteLine("[Lunar] Decrescent - 2");
            Console.WriteLine("[Lunar] Noviluna - 3");
            Console.WriteLine("[Reverb] Mark I - 4");
            Console.WriteLine("[Reverb] Mark II - 5");
            Console.WriteLine("[Reverb] Mark III - 6");
            Console.WriteLine("[Vortex] Revolver - 7");
            Console.WriteLine("[Vortex] Arrow - 8");
            Console.WriteLine("[Vortex] Hatchet - 9");
            Console.WriteLine("[Magnetic Storm] Alpha - 10");
            Console.WriteLine("[Magnetic Storm] Bravo - 11");
            Console.WriteLine("[Magnetic Storm] Charlie - 12");
            Console.WriteLine("[Identity] Base - 13");
            Console.WriteLine("[Identity] Inflection - 14");
            Console.WriteLine("[Cinder] Cobalt - 15");

            string input = GetUserInput();

            if (int.TryParse(input, out int weaponChoice))
            {
                ProcessBWeaponSelection(weaponChoice);
            }
            else
            {
                ShowErrorMessage("Неверный ввод оружия");
            }
        }

        static void ProcessBWeaponSelection(int weaponChoice)
        {
            switch (weaponChoice)
            {
                case 1:
                    ProcessLunarPleniluna();
                    break;
                case 2:
                    ProcessLunarDecrescent();
                    break;
                case 3:
                    ProcessLunarNoviluna();
                    break;
                case 4:
                    ProcessReverbMarkI();
                    break;
                case 5:
                    ProcessReverbMarkII();
                    break;
                case 6:
                    ProcessReverbMarkIII();
                    break;
                case 7:
                    ProcessVortexRevolver();
                    break;
                case 8:
                    ProcessVortexArrow();
                    break;
                case 9:
                    ProcessVortexHatchet();
                    break;
                case 10:
                    ProcessMagneticStormAlpha();
                    break;
                case 11:
                    ProcessMagneticStormBravo();
                    break;
                case 12:
                    ProcessMagneticStormCharlie();
                    break;
                case 13:
                    ProcessIdentityBase();
                    break;
                case 14:
                    ProcessIdentityInflection();
                    break;
                case 15:
                    ProcessCinderCobalt();
                    break;
                default:
                    ShowErrorMessage("Неверный выбор оружия");
                    break;
            }
        }

        static void ProcessLunarPleniluna()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name1}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStat = new W_Engines_B_rank.Pasive.DMG_Bufs.LunarPleniluna();

            currentStats.DMGBonus += passiveStat.Wengine_LunarPleniluna_Pasive_BasicAttack_DashAttack_DodgeCounter_DMG[stackLevel - 1];

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Добавлен бонус урона: {passiveStat.Wengine_LunarPleniluna_Pasive_BasicAttack_DashAttack_DodgeCounter_DMG[stackLevel - 1]:P1}");
        }

        static void ProcessLunarDecrescent()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name2}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStat = new W_Engines_B_rank.Pasive.DMG_Bufs.LunarDecrescent();

            currentStats.DMGBonus += passiveStat.Wengine_LunarDecrescent_Pasive_DMG[stackLevel - 1];

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Добавлен бонус урона: {passiveStat.Wengine_LunarDecrescent_Pasive_DMG[stackLevel - 1]:P1}");
        }

        static void ProcessLunarNoviluna()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name3}");

            var subStat = new W_Engines_B_rank.Sub.CritRate_Bufs.LunarNoviluna();

            currentStats.CritRate += subStat.Wengine_LunarNoviluna_Sub_CritRate;

            Console.WriteLine($"Добавлен бонус крит шанса: {subStat.Wengine_LunarNoviluna_Sub_CritRate:P1}");
        }

        static void ProcessReverbMarkI()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name4}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStat = new W_Engines_B_rank.Pasive.Impact_Bufs.ReverbMarkI();

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Бонус Impact (не учитывается в расчете): {passiveStat.Wengine_ReverbMarkI_Pasive_Impact_allsquad[stackLevel - 1]:P1}");
        }

        static void ProcessReverbMarkII()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name5}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStatAM = new W_Engines_B_rank.Pasive.AM_Bufs.ReverbMarkII();
            var passiveStatAP = new W_Engines_B_rank.Pasive.AP_Bufs.ReverbMarkII();

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Бонусы AM/AP (не учитываются в расчете): AM={passiveStatAM.Wengine_ReverbMarkII_Pasive_AM[stackLevel - 1]}, AP={passiveStatAP.Wengine_ReverbMarkII_Pasive_AM_AP[stackLevel - 1]}");
        }

        static void ProcessReverbMarkIII()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name6}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStat = new W_Engines_B_rank.Pasive.ATK_Bufs.ReverbMarkIII();

            double atkBonus = passiveStat.Wengine__Pasive_ATK_allsquad[stackLevel - 1];
            currentStats.ScalingStat *= (1 + atkBonus);

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Добавлен бонус атаки: {atkBonus:P1}");
            Console.WriteLine($"Новая атака: {currentStats.ScalingStat:F0}");
        }

        static void ProcessVortexRevolver()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name7}");

            var subStat = new W_Engines_B_rank.Sub.ATK_Bufs.VortexRevolver();

            currentStats.ScalingStat *= (1 + subStat.Wengine_VortexRevolver_Sub_ATK);

            Console.WriteLine($"Добавлен бонус атаки: {subStat.Wengine_VortexRevolver_Sub_ATK:P1}");
            Console.WriteLine($"Новая атака: {currentStats.ScalingStat:F0}");
        }

        static void ProcessVortexArrow()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name8}");

            var subStat = new W_Engines_B_rank.Sub.Impact_Bufs.VortexArrow();

            Console.WriteLine($"Бонус Impact (не учитывается в расчете): {subStat.Wengine_VortexArrow_Sub_Impact:P1}");
        }

        static void ProcessVortexHatchet()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name9}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStat = new W_Engines_B_rank.Pasive.Impact_Bufs.VortexHatchet();

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Бонус Impact (не учитывается в расчете): {passiveStat.Wengine_VortexHatchet_Pasive_CombatImpact[stackLevel - 1]:P1}");
        }

        static void ProcessMagneticStormAlpha()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name10}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStat = new W_Engines_B_rank.Pasive.AM_Bufs.MagneticStormAlpha();

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Бонус AM (не учитывается в расчете): {passiveStat.Wengine_MagneticStormAlpha_Pasive_AM[stackLevel - 1]}");
        }

        static void ProcessMagneticStormBravo()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name11}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStat = new W_Engines_B_rank.Pasive.AM_Bufs.MagneticStormBravo();

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Бонус AM (не учитывается в расчете): {passiveStat.Wengine_MagneticStormBravo_Pasive_AM[stackLevel - 1]}");
        }

        static void ProcessMagneticStormCharlie()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name12}");

            var subStat = new W_Engines_B_rank.Sub.PenRatio_Bufs.MagneticStormCharlie();

            currentStats.PENRatio += subStat.Wengine_MagneticStormCharlie_Sub_PenRatio;

            Console.WriteLine($"Добавлен PEN Ratio: {subStat.Wengine_MagneticStormCharlie_Sub_PenRatio:P1}");
        }

        static void ProcessIdentityBase()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name13}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStat = new W_Engines_B_rank.Pasive.DEF_Bufs.IdentityBase();

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Бонус DEF (не учитывается в расчете): {passiveStat.Wengine_IdentityBase_Pasive_DEF[stackLevel - 1]:P1}");
        }

        static void ProcessIdentityInflection()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name14}");

            var subStat = new W_Engines_B_rank.Sub.DEF_Bufs.IdentityInflection();

            Console.WriteLine($"Бонус DEF (не учитывается в расчете): {subStat.Wengine_IdentityInflection_Sub_DEF:P1}");
        }

        static void ProcessCinderCobalt()
        {
            Console.WriteLine($"\n✓ Выбрано оружие: {selectedWengen_B.name15}");

            int stackLevel = GetStackLevel(1, 5);

            var passiveStat = new W_Engines_B_rank.Pasive.ATK_Bufs.CinderCobalt();

            double atkBonus = passiveStat.Wengine_CinderCobalt_Pasive_ATK[stackLevel - 1];
            currentStats.ScalingStat *= (1 + atkBonus);

            Console.WriteLine($"Уровень наложения: {stackLevel}");
            Console.WriteLine($"Добавлен бонус атаки: {atkBonus:P1}");
            Console.WriteLine($"Новая атака: {currentStats.ScalingStat:F0}");
        }

        static void SelectAWeapon()
        {
            Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("                   ВЫБОР A-РАНК ОРУЖИЯ");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            Console.WriteLine("Street Superstar - 1");
            Console.WriteLine("Slice of Time - 2");
            Console.WriteLine("Rainforest Gourmet - 3");
            Console.WriteLine("Starlight Engine - 4");
            Console.WriteLine("Steam Oven - 5");
            Console.WriteLine("Precious Fossilized Core - 6");
            Console.WriteLine("Original Transmorpher - 7");
            Console.WriteLine("Weeping Gemini - 8");
            Console.WriteLine("Electro-Lip Gloss - 9");
            Console.WriteLine("Bunny Band - 10");
            Console.WriteLine("Spring Embrace - 11");
            Console.WriteLine("Puzzle Sphere - 12");
            Console.WriteLine("Gilded Blossom - 13");
            Console.WriteLine("Radiowave Journey - 14");
            Console.WriteLine("Marcato Desire - 15");
            Console.WriteLine("Reel Projector - 16");
            Console.WriteLine("Demara Battery Mark II - 17");
            Console.WriteLine("The Vault - 18");
            Console.WriteLine("Housekeeper - 19");
            Console.WriteLine("Starlight Engine Replica - 20");
            Console.WriteLine("Drill Rig - Red Axis - 21");
            Console.WriteLine("Big Cylinder - 22");
            Console.WriteLine("Bashful Demon - 23");
            Console.WriteLine("Kaboom the Cannon - 24");
            Console.WriteLine("Peacekeeper - Specialized - 25");
            Console.WriteLine("Roaring Ride - 26");
            Console.WriteLine("Box Cutter - 27");
            Console.WriteLine("Tremor Trigram Vessel - 28");
            Console.WriteLine("Grill O'Wisp - 29");
            Console.WriteLine("Cannon Rotor - 30");
            Console.WriteLine("Unfettered Game Ball - 31");
            Console.WriteLine("Six Shooter - 32");

            string input = GetUserInput();

            if (int.TryParse(input, out int weaponChoice))
            {
                Console.WriteLine("Выбран A-ранк оружие (реализация по аналогии с B-ранком)");

                currentStats.DMGBonus += 0.15;
                currentStats.CritRate += 0.08;
                Console.WriteLine("Добавлены стандартные бонусы A-ранка");
            }
        }

        static void SelectSWeapon()
        {
            Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("                   ВЫБОР S-РАНК ОРУЖИЯ");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            Console.WriteLine("Steel Cushion - 1");
            Console.WriteLine("The Brimstone - 2");
            Console.WriteLine("Kraken's Cradle - 3");
            Console.WriteLine("Tusks of Fury - 4");
            Console.WriteLine("Hailstorm Shrine - 5");
            Console.WriteLine("Hellfire Gears - 6");
            Console.WriteLine("The Restrained - 7");
            Console.WriteLine("Blazing Laurel - 8");
            Console.WriteLine("Flamemaker Shaker - 9");
            Console.WriteLine("Fusion Compiler - 10");
            Console.WriteLine("Deep Sea Visitor - 11");
            Console.WriteLine("Zanshin Herb Case - 12");
            Console.WriteLine("Weeping Cradle - 13");
            Console.WriteLine("Timeweaver - 14");
            Console.WriteLine("Riot Suppressor Mark VI - 15");
            Console.WriteLine("Ice-Jade Teapot - 16");
            Console.WriteLine("Sharpened Stinger - 17");
            Console.WriteLine("Myriad Eclipse - 18");
            Console.WriteLine("Bellicose Blaze - 19");
            Console.WriteLine("Elegant Vanity - 20");
            Console.WriteLine("Heartstring Nocturne - 21");
            Console.WriteLine("Flight of Fancy - 22");
            Console.WriteLine("Spectral Gaze - 23");
            Console.WriteLine("Qingming Birdcage - 24");
            Console.WriteLine("Severed Innocence - 25");
            Console.WriteLine("Roaring Furnace - 26");
            Console.WriteLine("Practiced Perfection - 27");
            Console.WriteLine("Metanukimorp - 28");
            Console.WriteLine("Dreamlit Hearth - 29");
            Console.WriteLine("Cordis Germina - 30");

            string input = GetUserInput();

            if (int.TryParse(input, out int weaponChoice))
            {
                Console.WriteLine("Выбран S-ранк оружие (реализация по аналогии с B-ранком)");

                currentStats.DMGBonus += 0.25;
                currentStats.CritDMG += 0.30;
                currentStats.DEFIgnore += 0.15;
                Console.WriteLine("Добавлены стандартные бонусы S-ранка");
            }
        }

        static void SelectArtifacts()
        {
            int totalSlots = 6;
            int usedSlots = 0;
            List<string> selectedSets = new List<string>();

            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   ВЫБОР АРТЕФАКТОВ                          ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            // Устанавливаем фиксированные статы для слотов 1-3
            SetupFixedArtifactStats();

            while (usedSlots < totalSlots)
            {
                int remainingSlots = totalSlots - usedSlots;

                Console.WriteLine("\n┌────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│ СЛОТЫ: Использовано {usedSlots}/6 │ Осталось: {remainingSlots}│                     │");
                Console.WriteLine("└────────────────────────────────────────────────────────────┘");

                Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("                   ВЫБОР НАБОРА АРТЕФАКТОВ");
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

                Console.WriteLine("1 - Meteor Hunter");
                Console.WriteLine("2 - Pan-Galactic Commercial Enterprise");
                Console.WriteLine("3 - Freezing Frost");
                Console.WriteLine("4 - Fanged Metropolis");
                Console.WriteLine("5 - The Yielding Mire");
                Console.WriteLine("6 - Thundering Lightning");
                Console.WriteLine("7 - Wandering Tales");
                Console.WriteLine("8 - Eagle of the Twilight Line");
                Console.WriteLine("9 - Guardian of the New Metropolis");
                Console.WriteLine("10 - Ten Thousand Facades");
                Console.WriteLine("11 - Genius of the Stars");
                Console.WriteLine("12 - White Night");
                Console.WriteLine("13 - Chaos and Order");
                Console.WriteLine("14 - The Wailing Host");
                Console.WriteLine("15 - Endless Eclipse");
                Console.WriteLine("16 - The Great Theater");
                Console.WriteLine("17 - The Wind-Soaked Breeze");
                Console.WriteLine("18 - The Resonant Deep Sea");
                Console.WriteLine("19 - The Unconstrained");
                Console.WriteLine("20 - The Surging Storm");
                Console.WriteLine("21 - The Blazing Sun");
                Console.WriteLine("22 - The Unmoving Frontline");
                Console.WriteLine("23 - The Unbreakable Bone");
                Console.WriteLine("24 - The Unyielding Will");
                Console.WriteLine("25 - The Unstoppable Charge");
                Console.WriteLine("26 - The Unseen Shadow");
                Console.WriteLine("27 - The Unending Nightmare");
                Console.WriteLine("28 - The Unfading Memory");
                Console.WriteLine("29 - The Unwavering Faith");
                Console.WriteLine("30 - The Unbreakable Promise");

                Console.WriteLine("\nВведите номер набора (или 0 для пропуска):");
                string input = GetUserInput();

                if (int.TryParse(input, out int setChoice))
                {
                    if (setChoice == 0)
                    {
                        Console.WriteLine("Пропуск выбора набора");
                        break;
                    }
                    else if (setChoice >= 1 && setChoice <= 30)
                    {
                        Console.WriteLine($"\nВыбран набор: {GetSetName(setChoice)}");

                        Console.WriteLine("Сколько слотов использовать для этого набора? (2 или 4):");
                        string slotInput = GetUserInput();

                        if (int.TryParse(slotInput, out int slots) && (slots == 2 || slots == 4))
                        {
                            if (usedSlots + slots <= totalSlots)
                            {
                                usedSlots += slots;
                                selectedSets.Add($"{GetSetName(setChoice)} ({slots} слота)");

                                // Применяем бонусы набора
                                ApplySetBonuses(setChoice, slots);

                                Console.WriteLine($"✓ Добавлен набор {GetSetName(setChoice)} на {slots} слота");
                                Console.WriteLine($"✓ Всего использовано слотов: {usedSlots}/6");
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно свободных слотов!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверный выбор! Используйте 2 или 4 слота");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор набора!");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                }

                if (usedSlots >= totalSlots)
                {
                    Console.WriteLine("\n✓ Все 6 слотов артефактов заполнены!");
                    break;
                }

                Console.WriteLine("\nХотите добавить еще один набор? (y/n):");
                string continueInput = GetUserInput().ToLower();
                if (continueInput != "y" && continueInput != "yes" && continueInput != "д" && continueInput != "да")
                {
                    break;
                }
            }

            // Выбор дополнительных статов для артефактов
            SelectArtifactSubstats();
        }

        static void SetupFixedArtifactStats()
        {
            // Слот 1: HP
            currentStats.HP += 1000;
            currentStats.HPPercent += 0.10;

            // Слот 2: ATK
            currentStats.ScalingStat *= 1.15;

            // Слот 3: DEF
            currentStats.DEF += 200;
            currentStats.DEFPercentStat += 0.12;

            Console.WriteLine("✓ Установлены фиксированные статы для слотов 1-3:");
            Console.WriteLine("  Слот 1: HP +1000, HP% +10%");
            Console.WriteLine("  Слот 2: ATK% +15%");
            Console.WriteLine("  Слот 3: DEF +200, DEF% +12%");
        }

        static string GetSetName(int setChoice)
        {
            var setNames = new Dictionary<int, string>
            {
                {1, "Meteor Hunter"}, {2, "Pan-Galactic Commercial Enterprise"}, {3, "Freezing Frost"},
                {4, "Fanged Metropolis"}, {5, "The Yielding Mire"}, {6, "Thundering Lightning"},
                {7, "Wandering Tales"}, {8, "Eagle of the Twilight Line"}, {9, "Guardian of the New Metropolis"},
                {10, "Ten Thousand Facades"}, {11, "Genius of the Stars"}, {12, "White Night"},
                {13, "Chaos and Order"}, {14, "The Wailing Host"}, {15, "Endless Eclipse"},
                {16, "The Great Theater"}, {17, "The Wind-Soaked Breeze"}, {18, "The Resonant Deep Sea"},
                {19, "The Unconstrained"}, {20, "The Surging Storm"}, {21, "The Blazing Sun"},
                {22, "The Unmoving Frontline"}, {23, "The Unbreakable Bone"}, {24, "The Unyielding Will"},
                {25, "The Unstoppable Charge"}, {26, "The Unseen Shadow"}, {27, "The Unending Nightmare"},
                {28, "The Unfading Memory"}, {29, "The Unwavering Faith"}, {30, "The Unbreakable Promise"}
            };

            return setNames.ContainsKey(setChoice) ? setNames[setChoice] : "Unknown Set";
        }

        static void ApplySetBonuses(int setChoice, int slots)
        {
            // Пример применения бонусов для нескольких наборов
            switch (setChoice)
            {
                case 1: // Meteor Hunter
                    if (slots >= 2) currentStats.DMGBonus += 0.10;
                    if (slots >= 4) currentStats.CritRate += 0.12;
                    break;
                case 2: // Pan-Galactic Commercial Enterprise
                    if (slots >= 2) currentStats.EffectHitRate += 0.10;
                    if (slots >= 4) currentStats.ScalingStat *= 1.25;
                    break;
                case 8: // Eagle of the Twilight Line
                    if (slots >= 2) currentStats.WindDMG += 0.10;
                    if (slots >= 4) currentStats.DMGBonus += 0.08;
                    break;
                case 21: // The Blazing Sun
                    if (slots >= 2) currentStats.FireDMG += 0.10;
                    if (slots >= 4) currentStats.DMGBonus += 0.12;
                    break;
                default:
                    // Стандартные бонусы для других наборов
                    if (slots >= 2) currentStats.DMGBonus += 0.08;
                    if (slots >= 4) currentStats.CritDMG += 0.15;
                    break;
            }
        }

        static void SelectArtifactSubstats()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                ВЫБОР ДОПОЛНИТЕЛЬНЫХ СТАТОВ                   ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\nТеперь выберите дополнительные статы для артефактов.");
            Console.WriteLine("Вы можете добавлять различные статы без ограничений.");

            var availableSubstats = new List<ArtifactSubstat>
            {
                new ArtifactSubstat { Name = "Crit Rate", BaseValue = 0.025 },
                new ArtifactSubstat { Name = "Crit DMG", BaseValue = 0.05 },
                new ArtifactSubstat { Name = "ATK%", BaseValue = 0.04 },
                new ArtifactSubstat { Name = "HP%", BaseValue = 0.04 },
                new ArtifactSubstat { Name = "DEF%", BaseValue = 0.05 },
                new ArtifactSubstat { Name = "Elemental DMG", BaseValue = 0.04 },
                new ArtifactSubstat { Name = "Anomaly Mastery", BaseValue = 12.5 },
                new ArtifactSubstat { Name = "Anomaly Proficiency", BaseValue = 12.5 },
                new ArtifactSubstat { Name = "Impact", BaseValue = 12.5 },
                new ArtifactSubstat { Name = "Energy Regen", BaseValue = 0.04 },
                new ArtifactSubstat { Name = "Effect Hit Rate", BaseValue = 0.04 }
            };

            while (true)
            {
                Console.WriteLine("\nДоступные дополнительные статы:");
                for (int i = 0; i < availableSubstats.Count; i++)
                {
                    var substat = availableSubstats[i];
                    Console.WriteLine($"{i + 1} - {substat.Name} (база: {substat.BaseValue:P1})");
                }

                Console.WriteLine("\nВведите номер стата для добавления (или 0 для завершения):");
                string input = GetUserInput();

                if (int.TryParse(input, out int substatChoice))
                {
                    if (substatChoice == 0)
                    {
                        break;
                    }
                    else if (substatChoice >= 1 && substatChoice <= availableSubstats.Count)
                    {
                        var selectedSubstat = availableSubstats[substatChoice - 1];

                        Console.WriteLine($"\nВыбран: {selectedSubstat.Name}");
                        Console.WriteLine($"Сколько раз добавить этот стат? (1-10):");
                        string rollInput = GetUserInput();

                        if (int.TryParse(rollInput, out int rolls) && rolls >= 1 && rolls <= 10)
                        {
                            var existingSubstat = artifactSubstats.FirstOrDefault(s => s.Name == selectedSubstat.Name);
                            if (existingSubstat != null)
                            {
                                existingSubstat.Rolls += rolls;
                            }
                            else
                            {
                                artifactSubstats.Add(new ArtifactSubstat
                                {
                                    Name = selectedSubstat.Name,
                                    BaseValue = selectedSubstat.BaseValue,
                                    Rolls = rolls
                                });
                            }

                            // Применяем бонус к текущим статам
                            ApplySubstatBonus(selectedSubstat.Name, selectedSubstat.BaseValue * rolls);

                            Console.WriteLine($"✓ Добавлено {rolls} раз(а) {selectedSubstat.Name}");
                            Console.WriteLine($"✓ Общий бонус: {selectedSubstat.BaseValue * rolls:P1}");
                        }
                        else
                        {
                            Console.WriteLine("Неверное количество!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор стата!");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                }

                Console.WriteLine("\nХотите добавить еще один дополнительный стат? (y/n):");
                string continueInput = GetUserInput().ToLower();
                if (continueInput != "y" && continueInput != "yes" && continueInput != "д" && continueInput != "да")
                {
                    break;
                }
            }

            ShowArtifactSummary();
        }

        static void ApplySubstatBonus(string substatName, double value)
        {
            switch (substatName)
            {
                case "Crit Rate":
                    currentStats.CritRate += value;
                    break;
                case "Crit DMG":
                    currentStats.CritDMG += value;
                    break;
                case "ATK%":
                    currentStats.ScalingStat *= (1 + value);
                    break;
                case "HP%":
                    currentStats.HPPercent += value;
                    break;
                case "DEF%":
                    currentStats.DEFPercentStat += value;
                    break;
                case "Elemental DMG":
                    currentStats.DMGBonus += value;
                    break;
                case "Anomaly Mastery":
                    currentStats.AnomalyMastery += value;
                    break;
                case "Anomaly Proficiency":
                    currentStats.AnomalyProficiency += value;
                    break;
                case "Impact":
                    currentStats.Impact += value;
                    break;
                case "Energy Regen":
                    currentStats.EnergyRegen += value;
                    break;
                case "Effect Hit Rate":
                    currentStats.EffectHitRate += value;
                    break;
            }
        }

        static void ShowArtifactSummary()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 СВОДКА ПО АРТЕФАКТАМ                        ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\nДополнительные статы:");
            foreach (var substat in artifactSubstats)
            {
                Console.WriteLine($"  {substat.Name}: {substat.TotalValue:P1} ({substat.Rolls} раз)");
            }

            Console.WriteLine($"\nОбщий бонус урона: {currentStats.DMGBonus:P1}");
            Console.WriteLine($"Крит шанс: {currentStats.CritRate:P1}");
            Console.WriteLine($"Крит урон: {currentStats.CritDMG:P1}");
            Console.WriteLine($"Атака: {currentStats.ScalingStat:F0}");
        }

        static void CalculateFinalDamage()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 РАСЧЕТ ФИНАЛЬНОГО УРОНА                     ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            // Base DMG = Skill MV * Scaling Stat + Flat MV
            currentStats.BaseDMG = currentStats.SkillMV * currentStats.ScalingStat + currentStats.FlatMV;

            // Crit Modifier
            double critMultiplier = 1.0 + (currentStats.CritRate > 0 ? currentStats.CritDMG : 0);
            currentStats.IsCrit = new Random().NextDouble() <= currentStats.CritRate;

            // DEF Modifier
            double defMultiplier = CalculateDEFMultiplier();

            // RES Modifier
            double resMultiplier = CalculateRESMultiplier();

            // Final Damage Calculation
            currentStats.FinalDamage = currentStats.BaseDMG * (1 + currentStats.DMGBonus);

            if (currentStats.IsCrit)
            {
                currentStats.FinalDamage *= critMultiplier;
            }

            currentStats.FinalDamage *= defMultiplier * resMultiplier;

            ShowDamageResults();
        }

        static double CalculateDEFMultiplier()
        {
            double targetDEF = currentStats.TargetBaseDEF * (1 + currentStats.DEFPercent);
            double defReduction = targetDEF * (1 - currentStats.DEFReduction);
            double defIgnore = defReduction * (1 - currentStats.DEFIgnore);
            double finalDEF = Math.Max(defIgnore - currentStats.FlatPEN, 0);

            return currentStats.LevelCoefficient / (currentStats.LevelCoefficient + finalDEF);
        }

        static double CalculateRESMultiplier()
        {
            double totalRES = currentStats.AttributeRES + currentStats.AllTypeRES;
            double resAfterReduction = totalRES * (1 - currentStats.RESReduction);
            double resAfterPEN = resAfterReduction - currentStats.RESPEN;

            if (resAfterPEN >= 0.75) return 1 / (1 + 4 * resAfterPEN);
            if (resAfterPEN >= 0) return 1 - resAfterPEN;
            return 1 - resAfterPEN / 2;
        }

        static void ShowDamageResults()
        {
            Console.WriteLine("\n┌────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                      РЕЗУЛЬТАТЫ РАСЧЕТА                     │");
            Console.WriteLine("└────────────────────────────────────────────────────────────┘");

            Console.WriteLine($"\nБазовый урон: {currentStats.BaseDMG:F0}");
            Console.WriteLine($"Множитель навыка: {currentStats.SkillMV:P1}");
            Console.WriteLine($"Стат атаки: {currentStats.ScalingStat:F0}");
            Console.WriteLine($"Бонус урона: {currentStats.DMGBonus:P1}");

            Console.WriteLine($"\nКрит шанс: {currentStats.CritRate:P1}");
            Console.WriteLine($"Крит урон: {currentStats.CritDMG:P1}");
            Console.WriteLine($"Крит: {(currentStats.IsCrit ? "✓ ДА" : "✗ НЕТ")}");

            Console.WriteLine($"\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║                ФИНАЛЬНЫЙ УРОН: {currentStats.FinalDamage:F0}                 ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            if (currentStats.IsCrit)
            {
                double nonCritDamage = currentStats.BaseDMG * (1 + currentStats.DMGBonus) *
                                     CalculateDEFMultiplier() * CalculateRESMultiplier();
                Console.WriteLine($"\nУрон без крита: {nonCritDamage:F0}");
                Console.WriteLine($"Множитель крита: x{currentStats.CritDMG + 1:F2}");
            }
        }

        static int GetStackLevel(int min, int max)
        {
            while (true)
            {
                Console.WriteLine($"\nВведите уровень наложения ({min}-{max}):");
                string input = GetUserInput();

                if (int.TryParse(input, out int level) && level >= min && level <= max)
                {
                    return level;
                }
                else
                {
                    ShowErrorMessage($"Неверный уровень! Введите число от {min} до {max}");
                }
            }
        }

        static string GetUserInput()
        {
            Console.Write("\n>>> ");
            return Console.ReadLine()?.Trim() ?? "";
        }

        static void ShowErrorMessage(string message)
        {
            Console.WriteLine($"\n✗ ОШИБКА: {message}");
        }
    }
}