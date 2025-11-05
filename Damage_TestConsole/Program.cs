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

        // HP Stats
        public double HP { get; set; } = 0;
        public double HPPercent { get; set; } = 0;

        // DEF Stats
        public double DEF { get; set; } = 0;
        public double DEFPercentStat { get; set; } = 0;

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

            Console.WriteLine("\nВыберите навык для расчета урона:");
            Console.WriteLine("1 - Basic Attack: Fifth Hit (Пятый удар)");
            Console.WriteLine("2 - Special Skill: Heavenly Net (Небесная сеть)");
            Console.WriteLine("3 - Quick Assist: Piercing String (Пронзающая струна)");
            Console.WriteLine("4 - Dash Attack: Flying String (Летящая струна)");
            Console.WriteLine("5 - Dodge Counter: Hidden Edge (Скрытый клинок)");
            Console.WriteLine("6 - Chain Skill: Meet and Depart (Встреча и расставание)");
            Console.WriteLine("7 - Ultimate Skill: Zanshin (Дзансин)");

            string skillInput = GetUserInput();

            if (int.TryParse(skillInput, out int skillChoice))
            {
                double[] selectedSkill = GetSelectedSkill(skillChoice, basic, special, assist, dodge, chain);

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
        }

        static double[] GetSelectedSkill(int choice,
            Harumasa.Skills.Basic basic,
            Harumasa.Skills.Special special,
            Harumasa.Skills.Assist assist,
            Harumasa.Skills.Dodge dodge,
            Harumasa.Skills.Chain chain)
        {
            switch (choice)
            {
                case 1:
                    return basic.fifth_cloudpiercer_hit;
                case 2:
                    return special.heavenlynet;
                case 3:
                    return assist.piercingstring;
                case 4:
                    return dodge.flyingstring;
                case 5:
                    return dodge.hiddenedge;
                case 6:
                    return chain.meetanddepart;
                case 7:
                    return chain.zanshin;
                default:
                    return basic.fifth_cloudpiercer_hit;
            }
        }

        static void SelectWeaponRarity()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   ВЫБОР РЕДКОСТИ ОРУЖИЯ                     ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\nВведите редкость оружия:");
            Console.WriteLine("B-ранк - 1");
            Console.WriteLine("A-ранк - 2");
            Console.WriteLine("S-ранк - 3");

            string input = GetUserInput();

            if (int.TryParse(input, out int rarityChoice))
            {
                ProcessWeaponRaritySelection(rarityChoice);
            }
            else
            {
                ShowErrorMessage("Неверный ввод. Введите число");
            }
        }

        static void ProcessWeaponRaritySelection(int rarityChoice)
        {
            switch (rarityChoice)
            {
                case 1:
                    SelectBWeapon();
                    break;
                case 2:
                    SelectAWeapon();
                    break;
                case 3:
                    SelectSWeapon();
                    break;
                default:
                    ShowErrorMessage("Неверный выбор редкости");
                    break;
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
            Dictionary<string, int> setStacks = new Dictionary<string, int>();

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
                Console.WriteLine("                   ВЫБЕРИТЕ СЕТ АРТЕФАКТОВ:");
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

                Console.WriteLine("1  │ Moonlight Lullaby");
                Console.WriteLine("2  │ Dawn's Bloom");
                Console.WriteLine("3  │ King of the Summit");
                Console.WriteLine("4  │ Yunkui Tales");
                Console.WriteLine("5  │ Phaethon's Melody");
                Console.WriteLine("6  │ Shadow Harmony");
                Console.WriteLine("7  │ Astral Voice");
                Console.WriteLine("8  │ Branch & Blade Song");
                Console.WriteLine("9  │ Fanged Metal");
                Console.WriteLine("10 │ Polar Metal");
                Console.WriteLine("11 │ Thunder Metal");
                Console.WriteLine("12 │ Chaotic Metal");
                Console.WriteLine("13 │ Inferno Metal");
                Console.WriteLine("14 │ Proto Punk");
                Console.WriteLine("15 │ Chaos Jazz");
                Console.WriteLine("16 │ Swing Jazz");
                Console.WriteLine("17 │ Soul Rock");
                Console.WriteLine("18 │ Hormone Punk");
                Console.WriteLine("19 │ Freedom Blues");
                Console.WriteLine("20 │ Shockstar Disco");
                Console.WriteLine("21 │ Puffer Electro");
                Console.WriteLine("22 │ Woodpecker Electro");
                Console.WriteLine("0  │ ЗАВЕРШИТЬ ВЫБОР");
                Console.WriteLine("──────────────────────────────────────────────────────────────");
                Console.Write("Введите номер сета: ");

                string input = GetUserInput();

                if (int.TryParse(input, out int setChoice))
                {
                    if (setChoice == 0)
                    {
                        Console.WriteLine("\n✓ ВЫБОР АРТЕФАКТОВ ЗАВЕРШЕН");
                        break;
                    }

                    if (setChoice < 1 || setChoice > 22)
                    {
                        ShowErrorMessage("Неверный выбор. Введите число от 1 до 22");
                        continue;
                    }

                    string selectedSetName = GetSetName(setChoice);

                    if (IsSetAlreadySelected(selectedSets, selectedSetName))
                    {
                        ShowErrorMessage($"Сет '{selectedSetName}' уже выбран! Пожалуйста, выберите другой сет.");
                        continue;
                    }

                    Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.WriteLine("  ВЫБЕРИТЕ КОЛИЧЕСТВО ДИСКОВ:");
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.Write("Введите 2 или 4: ");

                    string quantityInput = GetUserInput();

                    if (int.TryParse(quantityInput, out int quantityChoice) && (quantityChoice == 2 || quantityChoice == 4))
                    {
                        if (quantityChoice > remainingSlots)
                        {
                            ShowErrorMessage($"Недостаточно слотов! Вы выбрали {quantityChoice} дисков, но осталось только {remainingSlots} слотов");
                            continue;
                        }

                        int stacks = 1;
                        if (NeedsStacks(selectedSetName, quantityChoice))
                        {
                            stacks = GetStacksForSet(selectedSetName, quantityChoice);
                        }

                        ProcessArtifactSetSelection(setChoice, quantityChoice, stacks, ref usedSlots, selectedSets);
                    }
                    else
                    {
                        ShowErrorMessage("Неверный ввод. Введите 2 или 4");
                    }
                }
                else
                {
                    ShowErrorMessage("Неверный ввод. Введите число от 1 до 22");
                }
            }

            // Выбор главных статов для слотов 4, 5, 6
            SelectMainStatsForArtifacts();

            // Выбор сабстатов для всех артефактов
            SelectSubstatsForArtifacts();

            ShowArtifactsSummary(usedSlots, selectedSets);
        }

        static void SetupFixedArtifactStats()
        {
            Console.WriteLine("\n══════════════════════════════════════════════════════════════");
            Console.WriteLine("  УСТАНОВКА ФИКСИРОВАННЫХ СТАТОВ ДЛЯ СЛОТОВ 1-3:");
            Console.WriteLine("══════════════════════════════════════════════════════════════");

            // Слот 1: HP - 2200
            currentStats.HP += 2200;
            Console.WriteLine($"✓ Слот 1: HP +2200");

            // Слот 2: ATK - 316
            currentStats.ScalingStat += 316;
            Console.WriteLine($"✓ Слот 2: ATK +316");

            // Слот 3: DEF - 184
            currentStats.DEF += 184;
            Console.WriteLine($"✓ Слот 3: DEF +184");

            Console.WriteLine("══════════════════════════════════════════════════════════════");
        }

        static void SelectMainStatsForArtifacts()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║             ВЫБОР ГЛАВНЫХ СТАТОВ ДЛЯ СЛОТОВ 4-6             ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            // Слот 4
            Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("                   ВЫБОР СТАТА ДЛЯ СЛОТА 4:");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("1 - HP% (30%)");
            Console.WriteLine("2 - DEF% (48%)");
            Console.WriteLine("3 - ATK% (30%)");
            Console.WriteLine("4 - Crit Rate% (24%)");
            Console.WriteLine("5 - Crit DMG% (48%)");
            Console.WriteLine("6 - Anomaly Proficiency (92)");

            string slot4Input = GetUserInput();
            ProcessSlot4MainStat(slot4Input);

            // Слот 5
            Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("                   ВЫБОР СТАТА ДЛЯ СЛОТА 5:");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("1 - HP% (30%)");
            Console.WriteLine("2 - DEF% (48%)");
            Console.WriteLine("3 - ATK% (30%)");
            Console.WriteLine("4 - PEN% (24%)");
            Console.WriteLine("5 - Electric DMG% (30%)");
            Console.WriteLine("6 - Fire DMG% (30%)");
            Console.WriteLine("7 - Ice DMG% (30%)");
            Console.WriteLine("8 - Physical DMG% (30%)");
            Console.WriteLine("9 - Ether DMG% (30%)");

            string slot5Input = GetUserInput();
            ProcessSlot5MainStat(slot5Input);

            // Слот 6
            Console.WriteLine("\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("                   ВЫБОР СТАТА ДЛЯ СЛОТА 6:");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("1 - HP% (30%)");
            Console.WriteLine("2 - DEF% (48%)");
            Console.WriteLine("3 - ATK% (30%)");
            Console.WriteLine("4 - Anomaly Mastery% (30%)");
            Console.WriteLine("5 - Impact% (18%)");
            Console.WriteLine("6 - Energy Regen% (60%)");

            string slot6Input = GetUserInput();
            ProcessSlot6MainStat(slot6Input);
        }

        static void ProcessSlot4MainStat(string input)
        {
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        currentStats.HPPercent += 0.30;
                        Console.WriteLine("✓ Слот 4: HP% +30%");
                        break;
                    case 2:
                        currentStats.DEFPercentStat += 0.48;
                        Console.WriteLine("✓ Слот 4: DEF% +48%");
                        break;
                    case 3:
                        currentStats.ScalingStat *= 1.30;
                        Console.WriteLine("✓ Слот 4: ATK% +30%");
                        break;
                    case 4:
                        currentStats.CritRate += 0.24;
                        Console.WriteLine("✓ Слот 4: Crit Rate% +24%");
                        break;
                    case 5:
                        currentStats.CritDMG += 0.48;
                        Console.WriteLine("✓ Слот 4: Crit DMG% +48%");
                        break;
                    case 6:
                        currentStats.AnomalyProficiency += 92;
                        Console.WriteLine("✓ Слот 4: Anomaly Proficiency +92");
                        break;
                    default:
                        currentStats.HPPercent += 0.30;
                        Console.WriteLine("Неверный выбор! Установлен HP% +30%");
                        break;
                }
            }
            else
            {
                currentStats.HPPercent += 0.30;
                Console.WriteLine("Неверный ввод! Установлен HP% +30%");
            }
        }

        static void ProcessSlot5MainStat(string input)
        {
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        currentStats.HPPercent += 0.30;
                        Console.WriteLine("✓ Слот 5: HP% +30%");
                        break;
                    case 2:
                        currentStats.DEFPercentStat += 0.48;
                        Console.WriteLine("✓ Слот 5: DEF% +48%");
                        break;
                    case 3:
                        currentStats.ScalingStat *= 1.30;
                        Console.WriteLine("✓ Слот 5: ATK% +30%");
                        break;
                    case 4:
                        currentStats.PENRatio += 0.24;
                        Console.WriteLine("✓ Слот 5: PEN% +24%");
                        break;
                    case 5:
                        currentStats.ElectricDMG += 0.30;
                        Console.WriteLine("✓ Слот 5: Electric DMG% +30%");
                        break;
                    case 6:
                        currentStats.FireDMG += 0.30;
                        Console.WriteLine("✓ Слот 5: Fire DMG% +30%");
                        break;
                    case 7:
                        currentStats.IceDMG += 0.30;
                        Console.WriteLine("✓ Слот 5: Ice DMG% +30%");
                        break;
                    case 8:
                        currentStats.PhysicalDMG += 0.30;
                        Console.WriteLine("✓ Слот 5: Physical DMG% +30%");
                        break;
                    case 9:
                        currentStats.EtherDMG += 0.30;
                        Console.WriteLine("✓ Слот 5: Ether DMG% +30%");
                        break;
                    default:
                        currentStats.HPPercent += 0.30;
                        Console.WriteLine("Неверный выбор! Установлен HP% +30%");
                        break;
                }
            }
            else
            {
                currentStats.HPPercent += 0.30;
                Console.WriteLine("Неверный ввод! Установлен HP% +30%");
            }
        }

        static void ProcessSlot6MainStat(string input)
        {
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        currentStats.HPPercent += 0.30;
                        Console.WriteLine("✓ Слот 6: HP% +30%");
                        break;
                    case 2:
                        currentStats.DEFPercentStat += 0.48;
                        Console.WriteLine("✓ Слот 6: DEF% +48%");
                        break;
                    case 3:
                        currentStats.ScalingStat *= 1.30;
                        Console.WriteLine("✓ Слот 6: ATK% +30%");
                        break;
                    case 4:
                        currentStats.AnomalyMastery += 0.30;
                        Console.WriteLine("✓ Слот 6: Anomaly Mastery% +30%");
                        break;
                    case 5:
                        currentStats.Impact += 0.18;
                        Console.WriteLine("✓ Слот 6: Impact% +18%");
                        break;
                    case 6:
                        currentStats.EnergyRegen += 0.60;
                        Console.WriteLine("✓ Слот 6: Energy Regen% +60%");
                        break;
                    default:
                        currentStats.HPPercent += 0.30;
                        Console.WriteLine("Неверный выбор! Установлен HP% +30%");
                        break;
                }
            }
            else
            {
                currentStats.HPPercent += 0.30;
                Console.WriteLine("Неверный ввод! Установлен HP% +30%");
            }
        }

        static void SelectSubstatsForArtifacts()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  ВЫБОР САБСТАТОВ АРТЕФАКТОВ                 ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            Console.WriteLine("Выберите сабстаты для артефактов (можно выбрать несколько):");
            Console.WriteLine("1 - HP (112 за 1 прок)");
            Console.WriteLine("2 - ATK (19 за 1 прок)");
            Console.WriteLine("3 - DEF (15 за 1 прок)");
            Console.WriteLine("4 - HP% (3% за 1 прок)");
            Console.WriteLine("5 - ATK% (3% за 1 прок)");
            Console.WriteLine("6 - DEF% (4.8% за 1 прок)");
            Console.WriteLine("7 - PEN (9 за 1 прок)");
            Console.WriteLine("8 - Crit Rate% (2.4% за 1 прок)");
            Console.WriteLine("9 - Crit DMG% (4.8% за 1 прок)");
            Console.WriteLine("10 - Anomaly Proficiency (9 за 1 прок)");
            Console.WriteLine("0 - ЗАВЕРШИТЬ ВЫБОР САБСТАТОВ");

            while (true)
            {
                Console.Write("\nВведите номер сабстата (0 для завершения): ");
                string input = GetUserInput();

                if (input == "0")
                {
                    Console.WriteLine("✓ Выбор сабстатов завершен");
                    break;
                }

                if (int.TryParse(input, out int substatChoice) && substatChoice >= 1 && substatChoice <= 10)
                {
                    ProcessSubstatSelection(substatChoice);
                }
                else
                {
                    ShowErrorMessage("Неверный выбор. Введите число от 1 до 10");
                }
            }
        }

        static void ProcessSubstatSelection(int substatChoice)
        {
            Console.Write($"Введите количество проков для этого сабстата (1-10): ");
            string rollsInput = GetUserInput();

            if (int.TryParse(rollsInput, out int rolls) && rolls >= 1 && rolls <= 10)
            {
                ArtifactSubstat substat = new ArtifactSubstat();
                substat.Rolls = rolls;

                switch (substatChoice)
                {
                    case 1:
                        substat.Name = "HP";
                        substat.BaseValue = 112;
                        currentStats.HP += substat.TotalValue;
                        break;
                    case 2:
                        substat.Name = "ATK";
                        substat.BaseValue = 19;
                        currentStats.ScalingStat += substat.TotalValue;
                        break;
                    case 3:
                        substat.Name = "DEF";
                        substat.BaseValue = 15;
                        currentStats.DEF += substat.TotalValue;
                        break;
                    case 4:
                        substat.Name = "HP%";
                        substat.BaseValue = 0.03;
                        currentStats.HPPercent += substat.TotalValue;
                        break;
                    case 5:
                        substat.Name = "ATK%";
                        substat.BaseValue = 0.03;
                        currentStats.ScalingStat *= (1 + substat.TotalValue);
                        break;
                    case 6:
                        substat.Name = "DEF%";
                        substat.BaseValue = 0.048;
                        currentStats.DEFPercentStat += substat.TotalValue;
                        break;
                    case 7:
                        substat.Name = "PEN";
                        substat.BaseValue = 9;
                        currentStats.FlatPEN += substat.TotalValue;
                        break;
                    case 8:
                        substat.Name = "Crit Rate%";
                        substat.BaseValue = 0.024;
                        currentStats.CritRate += substat.TotalValue;
                        break;
                    case 9:
                        substat.Name = "Crit DMG%";
                        substat.BaseValue = 0.048;
                        currentStats.CritDMG += substat.TotalValue;
                        break;
                    case 10:
                        substat.Name = "Anomaly Proficiency";
                        substat.BaseValue = 9;
                        currentStats.AnomalyProficiency += substat.TotalValue;
                        break;
                }

                artifactSubstats.Add(substat);
                Console.WriteLine($"✓ Добавлен {substat.Name}: {substat.BaseValue} × {substat.Rolls} = {substat.TotalValue}");
            }
            else
            {
                ShowErrorMessage("Неверное количество проков! Установлено 1 прок");
            }
        }

        static void ProcessArtifactSetSelection(int setChoice, int quantityChoice, int stacks, ref int usedSlots, List<string> selectedSets)
        {
            string setName = GetSetName(setChoice);
            string displayName = $"{setName} ({quantityChoice} диска)";

            if (stacks > 1)
            {
                displayName += $" [Стаки: {stacks}]";
            }

            AddArtifactBonuses(setName, quantityChoice, stacks);

            selectedSets.Add(displayName);
            usedSlots += quantityChoice;

            Console.WriteLine("\n══════════════════════════════════════════════════════════════");
            Console.WriteLine($"  ✓ ВЫ УСПЕШНО ВЫБРАЛИ:");
            Console.WriteLine($"     Сет: {setName}");
            Console.WriteLine($"     Количество: {quantityChoice} диска");
            if (stacks > 1)
            {
                Console.WriteLine($"     Стаки: {stacks}");
            }
            Console.WriteLine("══════════════════════════════════════════════════════════════");

            ShowCurrentArtifacts(selectedSets, usedSlots);
        }

        static void AddArtifactBonuses(string setName, int quantity, int stacks)
        {
            switch (setName)
            {
                case "Fanged Metal":
                    if (quantity == 2)
                        currentStats.DMGBonus += 0.1;
                    if (quantity == 4)
                        currentStats.DMGBonus += 0.35;
                    break;

                case "Thunder Metal":
                    if (quantity == 2)
                        currentStats.DMGBonus += 0.1;
                    if (quantity == 4)
                        currentStats.ScalingStat *= 1.28;
                    break;

                case "Branch & Blade Song":
                    if (quantity == 2)
                        currentStats.CritDMG += 0.16;
                    if (quantity == 4)
                    {
                        currentStats.CritRate += 0.12;
                        currentStats.CritDMG += 0.30;
                    }
                    break;

                case "Shadow Harmony":
                    if (quantity == 2)
                        currentStats.DMGBonus += 0.15;
                    if (quantity == 4)
                    {
                        double atkBonus = 0.04 * stacks;
                        double critBonus = 0.04 * stacks;
                        currentStats.ScalingStat *= (1 + atkBonus);
                        currentStats.CritRate += critBonus;
                    }
                    break;

                case "Chaotic Metal":
                    if (quantity == 2)
                        currentStats.DMGBonus += 0.1;
                    if (quantity == 4)
                    {
                        currentStats.CritRate += 0.33;
                        currentStats.CritDMG += 0.20;
                    }
                    break;

                default:
                    if (quantity == 2)
                        currentStats.DMGBonus += 0.1;
                    if (quantity == 4)
                        currentStats.DMGBonus += 0.2;
                    break;
            }

            Console.WriteLine($"✓ Добавлены бонусы от сета {setName}");
        }

        static bool NeedsStacks(string setName, int quantity)
        {
            var setsWithStacks = new List<string>
            {
                "Shadow Harmony",
                "Astral Voice",
                "Woodpecker Electro",
                "Yunkui Tales"
            };

            return quantity == 4 && setsWithStacks.Contains(setName);
        }

        static int GetStacksForSet(string setName, int quantity)
        {
            if (quantity != 4) return 1;

            int maxStacks = setName switch
            {
                "Shadow Harmony" => 3,
                "Astral Voice" => 3,
                "Woodpecker Electro" => 3,
                "Yunkui Tales" => 3,
                _ => 1
            };

            if (maxStacks == 1) return 1;

            Console.WriteLine($"\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine($"  ВЫБЕРИТЕ КОЛИЧЕСТВО СТАКОВ ДЛЯ {setName}:");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.Write($"Введите количество стаков (1-{maxStacks}): ");

            string input = GetUserInput();

            if (int.TryParse(input, out int stacks) && stacks >= 1 && stacks <= maxStacks)
            {
                return stacks;
            }

            Console.WriteLine($"Неверный ввод! Установлено значение по умолчанию: 1");
            return 1;
        }

        static bool IsSetAlreadySelected(List<string> selectedSets, string setName)
        {
            foreach (string selectedSet in selectedSets)
            {
                if (selectedSet.StartsWith(setName))
                {
                    return true;
                }
            }
            return false;
        }

        static void ShowCurrentArtifacts(List<string> selectedSets, int usedSlots)
        {
            Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"СТАТУС: Использовано слотов: {usedSlots}/6");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            Console.WriteLine("\nТЕКУЩИЙ НАБОР АРТЕФАКТОВ:");
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            for (int i = 0; i < selectedSets.Count; i++)
            {
                Console.WriteLine($"   {i + 1}. {selectedSets[i]}");
            }
            Console.WriteLine("──────────────────────────────────────────────────────────────");
        }

        static void ShowArtifactsSummary(int usedSlots, List<string> selectedSets)
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            if (usedSlots == 6)
            {
                Console.WriteLine("║                 ВСЕ СЛОТЫ ЗАПОЛНЕНЫ!                         ║");
            }
            else
            {
                Console.WriteLine($"║           ВЫБОР ЗАВЕРШЕН: {usedSlots}/6 слотов           ║");
            }
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\n══════════════════════════════════════════════════════════════");
            Console.WriteLine("                   ИТОГИ ВЫБОРА АРТЕФАКТОВ:");
            Console.WriteLine("══════════════════════════════════════════════════════════════");
            Console.WriteLine($"Использовано слотов: {usedSlots}/6");
            Console.WriteLine("Выбранные сеты:");
            foreach (var set in selectedSets)
            {
                Console.WriteLine($"  • {set}");
            }

            if (artifactSubstats.Count > 0)
            {
                Console.WriteLine("\nВыбранные сабстаты:");
                foreach (var substat in artifactSubstats)
                {
                    Console.WriteLine($"  • {substat.Name}: {substat.BaseValue} × {substat.Rolls} = {substat.TotalValue}");
                }
            }
            Console.WriteLine("══════════════════════════════════════════════════════════════");
        }

        static string GetSetName(int setNumber)
        {
            switch (setNumber)
            {
                case 1: return "Moonlight Lullaby";
                case 2: return "Dawn's Bloom";
                case 3: return "King of the Summit";
                case 4: return "Yunkui Tales";
                case 5: return "Phaethon's Melody";
                case 6: return "Shadow Harmony";
                case 7: return "Astral Voice";
                case 8: return "Branch & Blade Song";
                case 9: return "Fanged Metal";
                case 10: return "Polar Metal";
                case 11: return "Thunder Metal";
                case 12: return "Chaotic Metal";
                case 13: return "Inferno Metal";
                case 14: return "Proto Punk";
                case 15: return "Chaos Jazz";
                case 16: return "Swing Jazz";
                case 17: return "Soul Rock";
                case 18: return "Hormone Punk";
                case 19: return "Freedom Blues";
                case 20: return "Shockstar Disco";
                case 21: return "Puffer Electro";
                case 22: return "Woodpecker Electro";
                default: return "Неизвестный сет";
            }
        }

        static void CalculateFinalDamage()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   ФИНАЛЬНЫЙ РАСЧЕТ УРОНА                    ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            // Применяем проценты к HP и DEF
            double totalHP = currentStats.HP * (1 + currentStats.HPPercent);
            double totalDEF = currentStats.DEF * (1 + currentStats.DEFPercentStat);

            currentStats.BaseDMG = currentStats.SkillMV * currentStats.ScalingStat + currentStats.FlatMV;

            // Суммируем все бонусы урона
            double totalDMGBonus = currentStats.DMGBonus + currentStats.ElectricDMG + currentStats.FireDMG +
                                  currentStats.IceDMG + currentStats.PhysicalDMG + currentStats.EtherDMG;
            double dmgMod = 1 + totalDMGBonus;

            Random rand = new Random();
            currentStats.IsCrit = rand.NextDouble() <= currentStats.CritRate;
            double critMod = currentStats.IsCrit ? (1 + currentStats.CritDMG) : 1;

            double resMod = 1 - currentStats.AttributeRES - currentStats.AllTypeRES +
                           currentStats.RESReduction + currentStats.RESPEN;
            resMod = Math.Max(0.1, resMod);

            double targetDEF = currentStats.TargetBaseDEF * (1 + currentStats.DEFPercent - currentStats.DEFReduction - currentStats.DEFIgnore);
            double effectiveDEF = targetDEF * (1 - currentStats.PENRatio) - currentStats.FlatPEN;
            effectiveDEF = Math.Max(0, effectiveDEF);
            double defMod = currentStats.LevelCoefficient / (currentStats.LevelCoefficient + effectiveDEF);

            double stunMod = 1 + (currentStats.StunBonus / 100);

            currentStats.FinalDamage = currentStats.BaseDMG * dmgMod * critMod * resMod * defMod * stunMod;

            DisplayFinalResults(dmgMod, critMod, resMod, defMod, stunMod, totalHP, totalDEF);
        }

        static void DisplayFinalResults(double dmgMod, double critMod, double resMod, double defMod, double stunMod, double totalHP, double totalDEF)
        {
            Console.WriteLine("\n══════════════════════════════════════════════════════════════");
            Console.WriteLine("                     РЕЗУЛЬТАТЫ РАСЧЕТА");
            Console.WriteLine("══════════════════════════════════════════════════════════════");

            Console.WriteLine($"\n📊 БАЗОВЫЕ КОМПОНЕНТЫ:");
            Console.WriteLine($"   Множитель навыка (Skill MV): {currentStats.SkillMV:P1}");
            Console.WriteLine($"   Суммарная атака (Scaling Stat): {currentStats.ScalingStat:F0}");
            Console.WriteLine($"   Базовый урон (Base DMG): {currentStats.BaseDMG:F0}");
            Console.WriteLine($"   Суммарное HP: {totalHP:F0} (база +{currentStats.HPPercent:P1})");
            Console.WriteLine($"   Суммарная защита: {totalDEF:F0} (база +{currentStats.DEFPercentStat:P1})");

            Console.WriteLine($"\n🎯 МОДИФИКАТОРЫ:");
            Console.WriteLine($"   Общий бонус урона: {currentStats.DMGBonus:P1}");
            Console.WriteLine($"   Электрический урон: {currentStats.ElectricDMG:P1}");
            Console.WriteLine($"   Огненный урон: {currentStats.FireDMG:P1}");
            Console.WriteLine($"   Ледяной урон: {currentStats.IceDMG:P1}");
            Console.WriteLine($"   Физический урон: {currentStats.PhysicalDMG:P1}");
            Console.WriteLine($"   Эфирный урон: {currentStats.EtherDMG:P1}");
            Console.WriteLine($"   Итоговый множитель урона: {dmgMod:P1}");
            Console.WriteLine($"   Крит шанс: {currentStats.CritRate:P1}");
            Console.WriteLine($"   Крит урон: {currentStats.CritDMG:P1}");
            Console.WriteLine($"   Крит множитель: {critMod:P1} {(currentStats.IsCrit ? "🎯 КРИТ!" : "")}");
            Console.WriteLine($"   Сопротивление (RES): {resMod:P1}");
            Console.WriteLine($"   Защита (DEF): {defMod:P1}");
            Console.WriteLine($"   Оглушение (Stun): {stunMod:P1}");
            Console.WriteLine($"   Anomaly Proficiency: {currentStats.AnomalyProficiency:F0}");
            Console.WriteLine($"   Anomaly Mastery: {currentStats.AnomalyMastery:P1}");
            Console.WriteLine($"   Impact: {currentStats.Impact:P1}");
            Console.WriteLine($"   Energy Regen: {currentStats.EnergyRegen:P1}");

            Console.WriteLine($"\n💫 ФИНАЛЬНЫЙ УРОН: {currentStats.FinalDamage:F0}");
            Console.WriteLine("══════════════════════════════════════════════════════════════");

            Console.WriteLine($"\n🧮 ФОРМУЛА:");
            Console.WriteLine($"   BaseDMG × DMG% × Crit × RES × DEF × Stun");
            Console.WriteLine($"   {currentStats.BaseDMG:F0} × {dmgMod:P1} × {critMod:P1} × {resMod:P1} × {defMod:P1} × {stunMod:P1}");
            Console.WriteLine($"   = {currentStats.FinalDamage:F0}");
        }

        static string GetUserInput()
        {
            Console.Write("> ");
            return Console.ReadLine();
        }

        static void ShowErrorMessage(string message)
        {
            Console.WriteLine($"\n❌ {message}");
        }

        static int GetStackLevel(int min, int max)
        {
            Console.WriteLine($"\nВыберите уровень наложения ({min}-{max}):");
            string input = GetUserInput();

            if (int.TryParse(input, out int level) && level >= min && level <= max)
            {
                return level;
            }

            Console.WriteLine($"Неверный уровень наложения! Установлен по умолчанию: {min}");
            return min;
        }

        static int GetRefinementLevel()
        {
            Console.WriteLine("\nВведите уровень наложения оружия (1-5):");
            string input = GetUserInput();

            if (int.TryParse(input, out int level) && level >= 1 && level <= 5)
            {
                return level;
            }

            Console.WriteLine("Неверный ввод, установлен уровень наложения по умолчанию: 1");
            return 1;
        }

        static int GetStackCount(int min, int max, string prompt)
        {
            Console.WriteLine($"\nВведите {prompt} ({min}-{max}):");
            string input = GetUserInput();

            if (int.TryParse(input, out int count) && count >= min && count <= max)
            {
                return count;
            }

            Console.WriteLine($"Неверный ввод, установлено количество стаков по умолчанию: {min}");
            return min;
        }
    }
}