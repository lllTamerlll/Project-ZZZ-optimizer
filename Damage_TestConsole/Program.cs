using System;

namespace Damage_TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Harumasa selectedCharacter = new Harumasa();
            W_Engines_B_rank selectedWengen_B = new W_Engines_B_rank();
            W_Engines_A_rank selectedWengen_A = new W_Engines_A_rank();
            W_Engines_S_rank selectedWengen_S = new W_Engines_S_rank();
            DriveDisc selectedSet = new DriveDisc();

            Console.WriteLine("Выберете Агента\r\n\r\nЧтобы выбрать введите число агента\r\n\r\nХарумаса - 1\r\n");
            Console.WriteLine("Агент");
            string input_char = Console.ReadLine();
            if (int.TryParse(input_char, out int choise_char))
            {
                switch (choise_char)
                {
                    case 1:
                        Console.WriteLine("\r\nВыбран агент " + selectedCharacter.name);
                        break;
                }
            }
            else
            {
                Console.WriteLine("\r\nНеверный ввод. Введите число");
            }

            Console.WriteLine("\r\nВведите редкость оружия на агенте\r\nB - 1\nA - 2\nS - 3\r\n");
            string input_rare_Wengen = Console.ReadLine();
            if (int.TryParse(input_rare_Wengen, out int choise_rare_Wengen))
            {
                switch (choise_rare_Wengen)
                {
                    case 1:
                        Console.WriteLine("\r\nВведите название оружия на агенте\r\n");
                        Console.WriteLine("[Lunar] Pleniluna - 1\r\n[Lunar] Decrescent - 2\r\n[Lunar] Noviluna - 3\r\n\r\n[Reverb] Mark I - 4\r\n[Reverb] Mark II - 5\r\n[Reverb] Mark III -6\r\n\r\n[Vortex] Revolver - 7\r\n[Vortex] Arrow - 8\r\n[Vortex] Hatchet - 9\r\n\r\n[Magnetic Storm] Alpha - 10\r\n[Magnetic Storm] Bravo - 11\r\n[Magnetic Storm] Charlie - 12\r\n\r\n[Identity] Base - 13\r\n[Identity] Inflection - 14\r\n\r\n[Cinder] Cobalt - 15");
                        string input_Wengen_Name_B = Console.ReadLine();
                        if (int.TryParse(input_Wengen_Name_B, out int choise_Wengen_Name_B))
                        {
                            switch (choise_Wengen_Name_B)
                            {
                                case 1:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name1);
                                    W_Engines_B_rank.Main.LunarPleniluna lunarPlenilunaMain = new W_Engines_B_rank.Main.LunarPleniluna();
                                    W_Engines_B_rank.Sub.ATK_Bufs.LunarPleniluna lunarPlenilunaSubATK = new W_Engines_B_rank.Sub.ATK_Bufs.LunarPleniluna();
                                    W_Engines_B_rank.Pasive.DMG_Bufs.LunarPleniluna lunarPlenilunaPasiveDMG = new W_Engines_B_rank.Pasive.DMG_Bufs.LunarPleniluna();

                                    double mainStat_1 = lunarPlenilunaMain.Wengine_LunarPleniluna_Main;
                                    double subStat_1 = lunarPlenilunaSubATK.Wengine_LunarPleniluna_Sub_ATK;
                                    double[] pasiveStat_1 = lunarPlenilunaPasiveDMG.Wengine_LunarPleniluna_Pasive_BasicAttack_DashAttack_DodgeCounter_DMG;
                                    break;
                                case 2:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name2);
                                    W_Engines_B_rank.Main.LunarDecrescent lunarDecrescentMain = new W_Engines_B_rank.Main.LunarDecrescent();
                                    W_Engines_B_rank.Sub.ATK_Bufs.LunarDecrescent lunarDecrescentSubATK = new W_Engines_B_rank.Sub.ATK_Bufs.LunarDecrescent();
                                    W_Engines_B_rank.Pasive.DMG_Bufs.LunarDecrescent lunarDecrescentPasiveDMG = new W_Engines_B_rank.Pasive.DMG_Bufs.LunarDecrescent();

                                    double mainStat_2 = lunarDecrescentMain.Wengine_LunarDecrescent_Main;
                                    double subStat_2 = lunarDecrescentSubATK.Wengine_LunarDecrescent_Sub_ATK;
                                    double[] pasiveStat_2 = lunarDecrescentPasiveDMG.Wengine_LunarDecrescent_Pasive_DMG;
                                    break;
                                case 3:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name3);
                                    W_Engines_B_rank.Main.LunarNoviluna lunarNovilunaMain = new W_Engines_B_rank.Main.LunarNoviluna();
                                    W_Engines_B_rank.Sub.CritRate_Bufs.LunarNoviluna lunarNovilunaSubCritRate = new W_Engines_B_rank.Sub.CritRate_Bufs.LunarNoviluna();

                                    double mainStat_3 = lunarNovilunaMain.Wengine_LunarNoviluna_Main;
                                    double subStat_3 = lunarNovilunaSubCritRate.Wengine_LunarNoviluna_Sub_CritRate;
                                    break;
                                case 4:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name4);
                                    W_Engines_B_rank.Main.ReverbMarkI reverbMarkIMain = new W_Engines_B_rank.Main.ReverbMarkI();
                                    W_Engines_B_rank.Sub.ATK_Bufs.ReverbMarkI reverbMarkISubATK = new W_Engines_B_rank.Sub.ATK_Bufs.ReverbMarkI();
                                    W_Engines_B_rank.Pasive.Impact_Bufs.ReverbMarkI reverbMarkIPasiveImpact = new W_Engines_B_rank.Pasive.Impact_Bufs.ReverbMarkI();

                                    double mainStat_4 = reverbMarkIMain.Wengine_ReverbMarkI_Main;
                                    double subStat_4 = reverbMarkISubATK.Wengine_ReverbMarkI_Sub_ATK;
                                    double[] pasiveStat_4 = reverbMarkIPasiveImpact.Wengine_ReverbMarkI_Pasive_Impact_allsquad;
                                    break;
                                case 5:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name5);
                                    W_Engines_B_rank.Main.ReverbMarkII reverbMarkIIMain = new W_Engines_B_rank.Main.ReverbMarkII();
                                    W_Engines_B_rank.Sub.EnergyRegen_Bufs.ReverbMarkII reverbMarkIISubEnergyRegen = new W_Engines_B_rank.Sub.EnergyRegen_Bufs.ReverbMarkII();
                                    W_Engines_B_rank.Pasive.AM_Bufs.ReverbMarkII reverbMarkIIPasiveAM = new W_Engines_B_rank.Pasive.AM_Bufs.ReverbMarkII();
                                    W_Engines_B_rank.Pasive.AP_Bufs.ReverbMarkII reverbMarkIIPasiveAP = new W_Engines_B_rank.Pasive.AP_Bufs.ReverbMarkII();

                                    double mainStat_5 = reverbMarkIIMain.Wengine_ReverbMarkII_Main;
                                    double subStat_5 = reverbMarkIISubEnergyRegen.Wengine_ReverbMarkII_Sub_EnergyRegen;
                                    double[] pasiveStat_5AM = reverbMarkIIPasiveAM.Wengine_ReverbMarkII_Pasive_AM;
                                    double[] pasiveStat_5AP = reverbMarkIIPasiveAP.Wengine_ReverbMarkII_Pasive_AM_AP;
                                    break;
                                case 6:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name6);
                                    W_Engines_B_rank.Main.ReverbMarkIII reverbMarkIIIMain = new W_Engines_B_rank.Main.ReverbMarkIII();
                                    W_Engines_B_rank.Sub.HP_Bufs.ReverbMarkIII reverbMarkIIISubHP = new W_Engines_B_rank.Sub.HP_Bufs.ReverbMarkIII();
                                    W_Engines_B_rank.Pasive.ATK_Bufs.ReverbMarkIII reverbMarkIIIPasiveATK = new W_Engines_B_rank.Pasive.ATK_Bufs.ReverbMarkIII();

                                    double mainStat_6 = reverbMarkIIIMain.Wengine_ReverbMarkIII_Main;
                                    double subStat_6 = reverbMarkIIISubHP.Wengine_ReverbMarkIII_Sub_HP;
                                    double[] pasiveStat_6 = reverbMarkIIIPasiveATK.Wengine__Pasive_ATK_allsquad;
                                    break;
                                case 7:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name7);
                                    W_Engines_B_rank.Main.VortexRevolver vortexRevolverMain = new W_Engines_B_rank.Main.VortexRevolver();
                                    W_Engines_B_rank.Sub.ATK_Bufs.VortexRevolver vortexRevolverSubATK = new W_Engines_B_rank.Sub.ATK_Bufs.VortexRevolver();

                                    double mainStat_7 = vortexRevolverMain.Wengine_VortexRevolver_Main;
                                    double subStat_7 = vortexRevolverSubATK.Wengine_VortexRevolver_Sub_ATK;
                                    break;
                                case 8:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name8);
                                    W_Engines_B_rank.Main.VortexArrow vortexArrowMain = new W_Engines_B_rank.Main.VortexArrow();
                                    W_Engines_B_rank.Sub.Impact_Bufs.VortexArrow vortexArrowSubImpact = new W_Engines_B_rank.Sub.Impact_Bufs.VortexArrow();

                                    double mainStat_8 = vortexArrowMain.Wengine_VortexArrow_Main;
                                    double subStat_8 = vortexArrowSubImpact.Wengine_VortexArrow_Sub_Impact;
                                    break;
                                case 9:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name9);
                                    W_Engines_B_rank.Main.VortexHatchet vortexHatchetMain = new W_Engines_B_rank.Main.VortexHatchet();
                                    W_Engines_B_rank.Sub.EnergyRegen_Bufs.VortexHatchet vortexHatchetSubEnergyRegen = new W_Engines_B_rank.Sub.EnergyRegen_Bufs.VortexHatchet();
                                    W_Engines_B_rank.Pasive.Impact_Bufs.VortexHatchet vortexHatchetPasiveImpact = new W_Engines_B_rank.Pasive.Impact_Bufs.VortexHatchet();

                                    double mainStat_9 = vortexHatchetMain.Wengine_VortexHatchet_Main;
                                    double subStat_9 = vortexHatchetSubEnergyRegen.Wengine_VortexHatchet_Sub_EnergyRegen;
                                    double[] pasiveStat_9 = vortexHatchetPasiveImpact.Wengine_VortexHatchet_Pasive_CombatImpact;
                                    break;
                                case 10:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name10);
                                    W_Engines_B_rank.Main.MagneticStormAlpha magneticStormAlphaMain = new W_Engines_B_rank.Main.MagneticStormAlpha();
                                    W_Engines_B_rank.Sub.ATK_Bufs.MagneticStormAlpha magneticStormAlphaSubATK = new W_Engines_B_rank.Sub.ATK_Bufs.MagneticStormAlpha();
                                    W_Engines_B_rank.Pasive.AM_Bufs.MagneticStormAlpha magneticStormAlphaPasiveAM = new W_Engines_B_rank.Pasive.AM_Bufs.MagneticStormAlpha();

                                    double mainStat_10 = magneticStormAlphaMain.Wengine_MagneticStormAlpha_Main;
                                    double subStat_10 = magneticStormAlphaSubATK.Wengine_MagneticStormAlpha_Sub_ATK;
                                    double[] pasiveStat_10 = magneticStormAlphaPasiveAM.Wengine_MagneticStormAlpha_Pasive_AM;
                                    break;
                                case 11:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name11);
                                    W_Engines_B_rank.Main.MagneticStormBravo magneticStormBravoMain = new W_Engines_B_rank.Main.MagneticStormBravo();
                                    W_Engines_B_rank.Sub.AM_Bufs.MagneticStormBravo magneticStormBravoSubAM = new W_Engines_B_rank.Sub.AM_Bufs.MagneticStormBravo();
                                    W_Engines_B_rank.Pasive.AM_Bufs.MagneticStormBravo magneticStormBravoPasiveAM = new W_Engines_B_rank.Pasive.AM_Bufs.MagneticStormBravo();

                                    double mainStat_11 = magneticStormBravoMain.Wengine_MagneticStormBravo_Main;
                                    double subStat_11 = magneticStormBravoSubAM.Wengine_MagneticStormBravo_Sub_AM;
                                    double[] pasiveStat_11 = magneticStormBravoPasiveAM.Wengine_MagneticStormBravo_Pasive_AM;
                                    break;
                                case 12:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name12);
                                    W_Engines_B_rank.Main.MagneticStormCharlie magneticStormCharlieMain = new W_Engines_B_rank.Main.MagneticStormCharlie();
                                    W_Engines_B_rank.Sub.PenRatio_Bufs.MagneticStormCharlie magneticStormCharlieSubPenRatio = new W_Engines_B_rank.Sub.PenRatio_Bufs.MagneticStormCharlie();

                                    double mainStat_12 = magneticStormCharlieMain.Wengine_MagneticStormCharlie_Main;
                                    double subStat_12 = magneticStormCharlieSubPenRatio.Wengine_MagneticStormCharlie_Sub_PenRatio;
                                    break;
                                case 13:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name13);
                                    W_Engines_B_rank.Main.IdentityBase identityBaseMain = new W_Engines_B_rank.Main.IdentityBase();
                                    W_Engines_B_rank.Sub.DEF_Bufs.IdentityBase identityBaseSubDEF = new W_Engines_B_rank.Sub.DEF_Bufs.IdentityBase();
                                    W_Engines_B_rank.Pasive.DEF_Bufs.IdentityBase identityBasePasiveDEF = new W_Engines_B_rank.Pasive.DEF_Bufs.IdentityBase();

                                    double mainStat_13 = identityBaseMain.Wengine_IdentityBase_Main;
                                    double subStat_13 = identityBaseSubDEF.Wengine_IdentityBase_Sub_DEF;
                                    double[] pasiveStat_13 = identityBasePasiveDEF.Wengine_IdentityBase_Pasive_DEF;
                                    break;
                                case 14:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name14);
                                    W_Engines_B_rank.Main.IdentityInflection identityInflectionMain = new W_Engines_B_rank.Main.IdentityInflection();
                                    W_Engines_B_rank.Sub.DEF_Bufs.IdentityInflection identityInflectionSubDEF = new W_Engines_B_rank.Sub.DEF_Bufs.IdentityInflection();

                                    double mainStat_14 = identityInflectionMain.Wengine_IdentityInflection_Main;
                                    double subStat_14 = identityInflectionSubDEF.Wengine_IdentityInflection_Sub_DEF;
                                    break;
                                case 15:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_B.name15);
                                    W_Engines_B_rank.Main.CinderCobalt cinderCobaltMain = new W_Engines_B_rank.Main.CinderCobalt();
                                    W_Engines_B_rank.Sub.HP_Bufs.CinderCobalt cinderCobaltSubHP = new W_Engines_B_rank.Sub.HP_Bufs.CinderCobalt();
                                    W_Engines_B_rank.Pasive.ATK_Bufs.CinderCobalt cinderCobaltPasiveATK = new W_Engines_B_rank.Pasive.ATK_Bufs.CinderCobalt();

                                    double mainStat_15 = cinderCobaltMain.Wengine_CinderCobalt_Main;
                                    double subStat_15 = cinderCobaltSubHP.Wengine_CinderCobalt_Sub_HP;
                                    double[] pasiveStat_15 = cinderCobaltPasiveATK.Wengine_CinderCobalt_Pasive_ATK;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите название оружия на агенте");
                        Console.WriteLine("Street Superstar - 1\r\nSlice of Time - 2\r\nRainforest Gourmet - 3\r\nStarlight Engine - 4\r\nSteam Oven - 5\r\nPrecious Fossilized Core - 6\r\nOriginal Transmorpher - 7\r\nWeeping Gemini - 8\r\nElectro-Lip Gloss - 9\r\nBunny Band - 10\r\nSpring Embrace - 11\r\nPuzzle Sphere - 12\r\nGilded Blossom - 13\r\nRadiowave Journey - 14\r\nMarcato Desire - 15\r\nReel Projector - 16\r\nDemara Battery Mark II - 17\r\nThe Vault - 18\r\nHousekeeper - 19\r\nStarlight Engine Replica - 20\r\nDrill Rig - Red Axis -21\r\nBig Cylinder - 22\r\nBashful Demon - 23\r\nKaboom the Cannon - 24\r\nPeacekeeper -  Specialized - 25\r\nRoaring Ride - 26\r\nBox Cutter - 27\r\nTremor Trigram Vessel - 28\r\nGrill O'Wisp - 29\r\nCannon Rotor - 30\r\nUnfettered Game Ball - 31\r\nSix Shooter - 32");
                        string input_Wengen_Name_A = Console.ReadLine();
                        if (int.TryParse(input_Wengen_Name_A, out int choise_Wengen_Name_A))
                        {
                            switch (choise_Wengen_Name_A)
                            {
                                case 1:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name1);
                                    W_Engines_A_rank.Main.StreetSuperstar streetSuperstarMain = new W_Engines_A_rank.Main.StreetSuperstar();
                                    W_Engines_A_rank.Sub.ATK_Bufs.StreetSuperstar streetSuperstarSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.StreetSuperstar();
                                    W_Engines_A_rank.Pasive.DMG.StreetSuperstar streetSuperstarPasiveDMG = new W_Engines_A_rank.Pasive.DMG.StreetSuperstar();

                                    double mainStat_A1 = streetSuperstarMain.Wengine_StreetSuperstar_Main;
                                    double subStat_A1 = streetSuperstarSubATK.Wengine_StreetSuperstar_Sub_ATK;
                                    double[] pasiveStat_A1_stack1 = streetSuperstarPasiveDMG.Wengine_StreetSuperstar_Pasive_DMG_stack_1;
                                    double[] pasiveStat_A1_stack2 = streetSuperstarPasiveDMG.Wengine_StreetSuperstar_Pasive_DMG_stack_2;
                                    double[] pasiveStat_A1_stack3 = streetSuperstarPasiveDMG.Wengine_StreetSuperstar_Pasive_DMG_stack_3;
                                    break;
                                case 2:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name2);
                                    W_Engines_A_rank.Main.SliceofTime sliceofTimeMain = new W_Engines_A_rank.Main.SliceofTime();
                                    W_Engines_A_rank.Sub.PENRatio_Bufs.SliceofTime sliceofTimeSubPEN = new W_Engines_A_rank.Sub.PENRatio_Bufs.SliceofTime();

                                    double mainStat_A2 = sliceofTimeMain.Wengine_SliceofTime_Main;
                                    double subStat_A2 = sliceofTimeSubPEN.Wengine_SliceofTime_Sub_PENRatio;
                                    break;
                                case 3:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name3);
                                    W_Engines_A_rank.Main.RainforestGourmet rainforestGourmetMain = new W_Engines_A_rank.Main.RainforestGourmet();
                                    W_Engines_A_rank.Sub.AP_Bufs.RainforestGourmet rainforestGourmetSubAP = new W_Engines_A_rank.Sub.AP_Bufs.RainforestGourmet();
                                    W_Engines_A_rank.Pasive.ATK_Bufs.RainforestGourmet rainforestGourmetPasiveATK = new W_Engines_A_rank.Pasive.ATK_Bufs.RainforestGourmet();

                                    double mainStat_A3 = rainforestGourmetMain.Wengine_RainforestGourmet_Main;
                                    double subStat_A3 = rainforestGourmetSubAP.Wengine_RainforestGourmet_Sub_AP;
                                    double[] pasiveStat_A3_stack1 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_1;
                                    double[] pasiveStat_A3_stack2 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_2;
                                    double[] pasiveStat_A3_stack3 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_3;
                                    double[] pasiveStat_A3_stack4 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_4;
                                    double[] pasiveStat_A3_stack5 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_5;
                                    double[] pasiveStat_A3_stack6 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_6;
                                    double[] pasiveStat_A3_stack7 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_7;
                                    double[] pasiveStat_A3_stack8 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_8;
                                    double[] pasiveStat_A3_stack9 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_9;
                                    double[] pasiveStat_A3_stack10 = rainforestGourmetPasiveATK.Wengine_RainforestGourmet_Pasive_ATK_stack_10;
                                    break;
                                case 4:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name4);
                                    W_Engines_A_rank.Main.StarlightEngine starlightEngineMain = new W_Engines_A_rank.Main.StarlightEngine();
                                    W_Engines_A_rank.Sub.ATK_Bufs.StarlightEngine starlightEngineSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.StarlightEngine();
                                    W_Engines_A_rank.Pasive.ATK_Bufs.Starlight starlightEnginePasiveATK = new W_Engines_A_rank.Pasive.ATK_Bufs.Starlight();

                                    double mainStat_A4 = starlightEngineMain.Wengine_StarlightEngine_Main;
                                    double subStat_A4 = starlightEngineSubATK.Wengine_StarlightEngine_Sub_ATK;
                                    double[] pasiveStat_A4 = starlightEnginePasiveATK.Wengine_Starlight_Engine_Pasive_ATK;
                                    break;
                                case 5:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name5);
                                    W_Engines_A_rank.Main.SteamOven steamOvenMain = new W_Engines_A_rank.Main.SteamOven();
                                    W_Engines_A_rank.Sub.EnergyRegen_Bufs.SteamOven steamOvenSubEnergy = new W_Engines_A_rank.Sub.EnergyRegen_Bufs.SteamOven();
                                    W_Engines_A_rank.Pasive.Impact_Bufs.SteamOven steamOvenPasiveImpact = new W_Engines_A_rank.Pasive.Impact_Bufs.SteamOven();

                                    double mainStat_A5 = steamOvenMain.Wengine_SteamOven_Main;
                                    double subStat_A5 = steamOvenSubEnergy.Wengine_SteamOven_Sub_EnergyRegen;
                                    double[] pasiveStat_A5_stack1 = steamOvenPasiveImpact.Wengine_SteamOven_Pasive_ImpactBon_stack_1;
                                    double[] pasiveStat_A5_stack2 = steamOvenPasiveImpact.Wengine_SteamOven_Pasive_ImpactBon_stack_2;
                                    double[] pasiveStat_A5_stack3 = steamOvenPasiveImpact.Wengine_SteamOven_Pasive_ImpactBon_stack_3;
                                    double[] pasiveStat_A5_stack4 = steamOvenPasiveImpact.Wengine_SteamOven_Pasive_ImpactBon_stack_4;
                                    double[] pasiveStat_A5_stack5 = steamOvenPasiveImpact.Wengine_SteamOven_Pasive_ImpactBon_stack_5;
                                    double[] pasiveStat_A5_stack6 = steamOvenPasiveImpact.Wengine_SteamOven_Pasive_ImpactBon_stack_6;
                                    double[] pasiveStat_A5_stack7 = steamOvenPasiveImpact.Wengine_SteamOven_Pasive_ImpactBon_stack_7;
                                    double[] pasiveStat_A5_stack8 = steamOvenPasiveImpact.Wengine_SteamOven_Pasive_ImpactBon_stack_8;
                                    break;
                                case 6:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name6);
                                    W_Engines_A_rank.Main.PreciousFossilizedCore preciousFossilizedCoreMain = new W_Engines_A_rank.Main.PreciousFossilizedCore();
                                    W_Engines_A_rank.Sub.Impact_Bufs.PreciousFossilizedCore preciousFossilizedCoreSubImpact = new W_Engines_A_rank.Sub.Impact_Bufs.PreciousFossilizedCore();

                                    double mainStat_A6 = preciousFossilizedCoreMain.Wengine_PreciousFossilizedCore_Main;
                                    double subStat_A6 = preciousFossilizedCoreSubImpact.Wengine_PreciousFossilizedCore_Sub_Impact;
                                    break;
                                case 7:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name7);
                                    W_Engines_A_rank.Main.OriginalTransmorpher originalTransmorpherMain = new W_Engines_A_rank.Main.OriginalTransmorpher();
                                    W_Engines_A_rank.Sub.HP_Bufs.OriginalTransmorpher originalTransmorpherSubHP = new W_Engines_A_rank.Sub.HP_Bufs.OriginalTransmorpher();
                                    W_Engines_A_rank.Pasive.Impact_Bufs.OriginalTransmorpher originalTransmorpherPasiveImpact = new W_Engines_A_rank.Pasive.Impact_Bufs.OriginalTransmorpher();
                                    W_Engines_A_rank.Pasive.InitialHP.OriginalTransmorpher originalTransmorpherPasiveHP = new W_Engines_A_rank.Pasive.InitialHP.OriginalTransmorpher();

                                    double mainStat_A7 = originalTransmorpherMain.Wengine_OriginalTransmorpher_Main;
                                    double subStat_A7 = originalTransmorpherSubHP.Wengine_OriginalTransmorpher_Sub_HP;
                                    double[] pasiveStat_A7_impact = originalTransmorpherPasiveImpact.Wengine_OriginalTransmorpher_Pasive_Impact;
                                    double[] pasiveStat_A7_hp = originalTransmorpherPasiveHP.Wengine_OriginalTransmorpher_Pasive_InitialHP;
                                    break;
                                case 8:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name8);
                                    W_Engines_A_rank.Main.WeepingGemini weepingGeminiMain = new W_Engines_A_rank.Main.WeepingGemini();
                                    W_Engines_A_rank.Sub.ATK_Bufs.WeepingGemini weepingGeminiSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.WeepingGemini();
                                    W_Engines_A_rank.Pasive.AP_Bufs.WeepingGemini weepingGeminiPasiveAP = new W_Engines_A_rank.Pasive.AP_Bufs.WeepingGemini();

                                    double mainStat_A8 = weepingGeminiMain.Wengine_WeepingGemini_Main;
                                    double subStat_A8 = weepingGeminiSubATK.Wengine_WeepingGemini_Sub_ATK;
                                    double[] pasiveStat_A8_stack1 = weepingGeminiPasiveAP.Wengine_WeepingGemini_Pasive_AP_stack_1;
                                    double[] pasiveStat_A8_stack2 = weepingGeminiPasiveAP.Wengine_WeepingGemini_Pasive_AP_stack_2;
                                    double[] pasiveStat_A8_stack3 = weepingGeminiPasiveAP.Wengine_WeepingGemini_Pasive_AP_stack_3;
                                    double[] pasiveStat_A8_stack4 = weepingGeminiPasiveAP.Wengine_WeepingGemini_Pasive_AP_stack_4;
                                    break;
                                case 9:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name9);
                                    W_Engines_A_rank.Main.ElectroLipGloss electroLipGlossMain = new W_Engines_A_rank.Main.ElectroLipGloss();
                                    W_Engines_A_rank.Sub.AP_Bufs.ElectroLipGloss electroLipGlossSubAP = new W_Engines_A_rank.Sub.AP_Bufs.ElectroLipGloss();
                                    W_Engines_A_rank.Pasive.DMG.ElectroLipGloss electroLipGlossPasiveDMG = new W_Engines_A_rank.Pasive.DMG.ElectroLipGloss();
                                    W_Engines_A_rank.Pasive.ATK_Bufs.ElectroLipGloss electroLipGlossPasiveATK = new W_Engines_A_rank.Pasive.ATK_Bufs.ElectroLipGloss();

                                    double mainStat_A9 = electroLipGlossMain.Wengine_ElectroLipGloss_Main;
                                    double subStat_A9 = electroLipGlossSubAP.Wengine_ElectroLipGloss_Sub_AP;
                                    double[] pasiveStat_A9_dmg = electroLipGlossPasiveDMG.Wengine_ElectroLipGloss_Pasive_DMG;
                                    double[] pasiveStat_A9_atk = electroLipGlossPasiveATK.Wengine_ElectroLipGloss_Pasive_ATK;
                                    break;
                                case 10:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name10);
                                    W_Engines_A_rank.Main.BunnyBand bunnyBandMain = new W_Engines_A_rank.Main.BunnyBand();
                                    W_Engines_A_rank.Sub.DEF_Bufs.BunnyBand bunnyBandSubDEF = new W_Engines_A_rank.Sub.DEF_Bufs.BunnyBand();
                                    W_Engines_A_rank.Pasive.ATK_Bufs.BunnyBand bunnyBandPasiveATK = new W_Engines_A_rank.Pasive.ATK_Bufs.BunnyBand();
                                    W_Engines_A_rank.Pasive.InitialHP.BunnyBand bunnyBandPasiveHP = new W_Engines_A_rank.Pasive.InitialHP.BunnyBand();

                                    double mainStat_A10 = bunnyBandMain.Wengine_BunnyBand_Main;
                                    double subStat_A10 = bunnyBandSubDEF.Wengine_BunnyBand_Sub_DEF;
                                    double[] pasiveStat_A10_atk = bunnyBandPasiveATK.Wengine_BunnyBand_Pasive_ATK;
                                    double[] pasiveStat_A10_hp = bunnyBandPasiveHP.Wengine_BunnyBand_Pasive_InitialHP;
                                    break;
                                case 11:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name11);
                                    W_Engines_A_rank.Main.SpringEmbrace springEmbraceMain = new W_Engines_A_rank.Main.SpringEmbrace();
                                    W_Engines_A_rank.Sub.ATK_Bufs.SpringEmbrace springEmbraceSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.SpringEmbrace();

                                    double mainStat_A11 = springEmbraceMain.Wengine_SpringEmbrace_Main;
                                    double subStat_A11 = springEmbraceSubATK.Wengine_SpringEmbrace_Sub_ATK;
                                    break;
                                case 12:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name12);
                                    W_Engines_A_rank.Main.PuzzleSphere puzzleSphereMain = new W_Engines_A_rank.Main.PuzzleSphere();
                                    W_Engines_A_rank.Sub.ATK_Bufs.PuzzleSphere puzzleSphereSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.PuzzleSphere();
                                    W_Engines_A_rank.Pasive.DMG.PuzzleSphere puzzleSpherePasiveDMG = new W_Engines_A_rank.Pasive.DMG.PuzzleSphere();
                                    W_Engines_A_rank.Pasive.CritDMG_Bufs puzzleSpherePasiveCritDMG = new W_Engines_A_rank.Pasive.CritDMG_Bufs();

                                    double mainStat_A12 = puzzleSphereMain.Wengine_PuzzleSphere_Main;
                                    double subStat_A12 = puzzleSphereSubATK.Wengine_PuzzleSphere_Sub_ATK;
                                    double[] pasiveStat_A12_dmg = puzzleSpherePasiveDMG.Wengine_PuzzleSphere_Pasive_DMG;
                                    double[] pasiveStat_A12_critdmg = puzzleSpherePasiveCritDMG.Wengine_PuzzleSphere_Pasive_CritDMG;
                                    break;
                                case 13:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name13);
                                    W_Engines_A_rank.Main.GildedBlossom gildedBlossomMain = new W_Engines_A_rank.Main.GildedBlossom();
                                    W_Engines_A_rank.Sub.ATK_Bufs.GildedBlossom gildedBlossomSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.GildedBlossom();
                                    W_Engines_A_rank.Pasive.DMG.GildedBlossom gildedBlossomPasiveDMG = new W_Engines_A_rank.Pasive.DMG.GildedBlossom();
                                    W_Engines_A_rank.Pasive.CombatATK_Bufs.GildedBlossom gildedBlossomPasiveCombatATK = new W_Engines_A_rank.Pasive.CombatATK_Bufs.GildedBlossom();

                                    double mainStat_A13 = gildedBlossomMain.Wengine_GildedBlossom_Main;
                                    double subStat_A13 = gildedBlossomSubATK.Wengine_GildedBlossom_Sub_ATK;
                                    double[] pasiveStat_A13_dmg = gildedBlossomPasiveDMG.Wengine_GildedBlossom_Pasive_DMG;
                                    double[] pasiveStat_A13_combat = gildedBlossomPasiveCombatATK.Wengine_GildedBlossom_CombatATK;
                                    break;
                                case 14:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name14);
                                    W_Engines_A_rank.Main.RadiowaveJourney radiowaveJourneyMain = new W_Engines_A_rank.Main.RadiowaveJourney();
                                    W_Engines_A_rank.Sub.HP_Bufs.RadiowaveJourney radiowaveJourneySubHP = new W_Engines_A_rank.Sub.HP_Bufs.RadiowaveJourney();
                                    W_Engines_A_rank.Pasive.SheerForce_Bufs.RadiowaveJourney radiowaveJourneyPasiveSheer = new W_Engines_A_rank.Pasive.SheerForce_Bufs.RadiowaveJourney();

                                    double mainStat_A14 = radiowaveJourneyMain.Wengine_RadiowaveJourney_Main;
                                    double subStat_A14 = radiowaveJourneySubHP.Wengine_RadiowaveJourney_Sub_HP;
                                    double[] pasiveStat_A14_stack1 = radiowaveJourneyPasiveSheer.Wengine_RadiowaveJourney_Pasive_SheerForce_stac_1;
                                    double[] pasiveStat_A14_stack2 = radiowaveJourneyPasiveSheer.Wengine_RadiowaveJourney_Pasive_SheerForce_stac_2;
                                    double[] pasiveStat_A14_stack3 = radiowaveJourneyPasiveSheer.Wengine_RadiowaveJourney_Pasive_SheerForce_stac_3;
                                    break;
                                case 15:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name15);
                                    W_Engines_A_rank.Main.MarcatoDesire marcatoDesireMain = new W_Engines_A_rank.Main.MarcatoDesire();
                                    W_Engines_A_rank.Sub.CritRate_Bufs.MarcatoDesire marcatoDesireSubCrit = new W_Engines_A_rank.Sub.CritRate_Bufs.MarcatoDesire();
                                    W_Engines_A_rank.Pasive.ATK_Bufs.MarcatoDesire marcatoDesirePasiveATK = new W_Engines_A_rank.Pasive.ATK_Bufs.MarcatoDesire();

                                    double mainStat_A15 = marcatoDesireMain.Wengine_MarcatoDesire_Main;
                                    double subStat_A15 = marcatoDesireSubCrit.Wengine_MarcatoDesire_Sub_CritRate;
                                    double[] pasiveStat_A15_atk1 = marcatoDesirePasiveATK.Wengine_MarcatoDesire_Pasive_ATK_1;
                                    double[] pasiveStat_A15_atk2 = marcatoDesirePasiveATK.Wengine_MarcatoDesire_Pasive_ATK_2;
                                    break;
                                case 16:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name16);
                                    W_Engines_A_rank.Main.ReelProjector reelProjectorMain = new W_Engines_A_rank.Main.ReelProjector();
                                    W_Engines_A_rank.Sub.Impact_Bufs.ReelProjector reelProjectorSubImpact = new W_Engines_A_rank.Sub.Impact_Bufs.ReelProjector();

                                    double mainStat_A16 = reelProjectorMain.Wengine_ReelProjector_Main;
                                    double subStat_A16 = reelProjectorSubImpact.Wengine_ReelProjector_Sub_Impact;
                                    break;
                                case 17:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name17);
                                    W_Engines_A_rank.Main.DemaraBatteryMarkII demaraBatteryMarkIIMain = new W_Engines_A_rank.Main.DemaraBatteryMarkII();
                                    W_Engines_A_rank.Sub.Impact_Bufs.DemaraBatteryMarkII demaraBatteryMarkIISubImpact = new W_Engines_A_rank.Sub.Impact_Bufs.DemaraBatteryMarkII();
                                    W_Engines_A_rank.Pasive.DMG.DemaraBatteryMarkII demaraBatteryMarkIIPasiveDMG = new W_Engines_A_rank.Pasive.DMG.DemaraBatteryMarkII();

                                    double mainStat_A17 = demaraBatteryMarkIIMain.Wengine_DemaraBatteryMarkII_Main;
                                    double subStat_A17 = demaraBatteryMarkIISubImpact.Wengine_DemaraBatteryMarkII_Sub_Impact;
                                    double[] pasiveStat_A17 = demaraBatteryMarkIIPasiveDMG.Wengine_DemaraBatteryMarkII_Pasive_DMG;
                                    break;
                                case 18:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name18);
                                    W_Engines_A_rank.Main.TheVault theVaultMain = new W_Engines_A_rank.Main.TheVault();
                                    W_Engines_A_rank.Sub.EnergyRegen_Bufs.TheVault theVaultSubEnergy = new W_Engines_A_rank.Sub.EnergyRegen_Bufs.TheVault();
                                    W_Engines_A_rank.Pasive.DMG.TheVault theVaultPasiveDMG = new W_Engines_A_rank.Pasive.DMG.TheVault();

                                    double mainStat_A18 = theVaultMain.Wengine_TheVault_Main;
                                    double subStat_A18 = theVaultSubEnergy.Wengine_TheVault_Sub_EnergyRegen;
                                    double[] pasiveStat_A18 = theVaultPasiveDMG.Wengine_TheVault_Pasive_DMG;
                                    break;
                                case 19:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name19);
                                    W_Engines_A_rank.Main.Housekeeper housekeeperMain = new W_Engines_A_rank.Main.Housekeeper();
                                    W_Engines_A_rank.Sub.ATK_Bufs.Housekeeper housekeeperSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.Housekeeper();
                                    W_Engines_A_rank.Pasive.DMG.Housekeeper housekeeperPasiveDMG = new W_Engines_A_rank.Pasive.DMG.Housekeeper();

                                    double mainStat_A19 = housekeeperMain.Wengine_Housekeeper_Main;
                                    double subStat_A19 = housekeeperSubATK.Wengine_Housekeeper_Sub_ATK;
                                    double[] pasiveStat_A19_stack1 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_1;
                                    double[] pasiveStat_A19_stack2 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_2;
                                    double[] pasiveStat_A19_stack3 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_3;
                                    double[] pasiveStat_A19_stack4 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_4;
                                    double[] pasiveStat_A19_stack5 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_5;
                                    double[] pasiveStat_A19_stack6 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_6;
                                    double[] pasiveStat_A19_stack7 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_7;
                                    double[] pasiveStat_A19_stack8 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_8;
                                    double[] pasiveStat_A19_stack9 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_9;
                                    double[] pasiveStat_A19_stack10 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_10;
                                    double[] pasiveStat_A19_stack11 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_11;
                                    double[] pasiveStat_A19_stack12 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_12;
                                    double[] pasiveStat_A19_stack13 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_13;
                                    double[] pasiveStat_A19_stack14 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_14;
                                    double[] pasiveStat_A19_stack15 = housekeeperPasiveDMG.Wengine_Housekeeper_Pasive_DMG_stack_15;
                                    break;
                                case 20:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name20);
                                    W_Engines_A_rank.Main.StarlightEngineReplica starlightEngineReplicaMain = new W_Engines_A_rank.Main.StarlightEngineReplica();
                                    W_Engines_A_rank.Sub.ATK_Bufs.StarlightEngineReplica starlightEngineReplicaSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.StarlightEngineReplica();
                                    W_Engines_A_rank.Pasive.DMG.StarlightEngineReplica starlightEngineReplicaPasiveDMG = new W_Engines_A_rank.Pasive.DMG.StarlightEngineReplica();

                                    double mainStat_A20 = starlightEngineReplicaMain.Wengine_StarlightEngineReplica_Main;
                                    double subStat_A20 = starlightEngineReplicaSubATK.Wengine_StarlightEngineReplica_Sub_ATK;
                                    double[] pasiveStat_A20 = starlightEngineReplicaPasiveDMG.Wengine_StarlightEngineReplica_Pasive_DMG;
                                    break;
                                case 21:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name21);
                                    W_Engines_A_rank.Main.DrillRigRedAxis drillRigRedAxisMain = new W_Engines_A_rank.Main.DrillRigRedAxis();
                                    W_Engines_A_rank.Sub.EnergyRegen_Bufs.DrillRigRedAxis drillRigRedAxisSubEnergy = new W_Engines_A_rank.Sub.EnergyRegen_Bufs.DrillRigRedAxis();
                                    W_Engines_A_rank.Pasive.DMG.DrillRigRedAxis drillRigRedAxisPasiveDMG = new W_Engines_A_rank.Pasive.DMG.DrillRigRedAxis();

                                    double mainStat_A21 = drillRigRedAxisMain.Wengine_DrillRigRedAxis_Main;
                                    double subStat_A21 = drillRigRedAxisSubEnergy.Wengine_DrillRigRedAxis_Sub_EnergyRegen;
                                    double[] pasiveStat_A21 = drillRigRedAxisPasiveDMG.Wengine_DrillRigRedAxis_Pasive_DMG;
                                    break;
                                case 22:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name22);
                                    W_Engines_A_rank.Main.BigCylinder bigCylinderMain = new W_Engines_A_rank.Main.BigCylinder();
                                    W_Engines_A_rank.Sub.DEF_Bufs.BigCylinder bigCylinderSubDEF = new W_Engines_A_rank.Sub.DEF_Bufs.BigCylinder();

                                    double mainStat_A22 = bigCylinderMain.Wengine_BigCylinder_Main;
                                    double subStat_A22 = bigCylinderSubDEF.Wengine_BigCylinder_Sub_DEF;
                                    break;
                                case 23:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name23);
                                    W_Engines_A_rank.Main.BashfulDemon bashfulDemonMain = new W_Engines_A_rank.Main.BashfulDemon();
                                    W_Engines_A_rank.Sub.ATK_Bufs.BashfulDemon bashfulDemonSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.BashfulDemon();
                                    W_Engines_A_rank.Pasive.DMG.BashfulDemon bashfulDemonPasiveDMG = new W_Engines_A_rank.Pasive.DMG.BashfulDemon();
                                    W_Engines_A_rank.Pasive.ATK_Bufs.BashfulDemon bashfulDemonPasiveATK = new W_Engines_A_rank.Pasive.ATK_Bufs.BashfulDemon();

                                    double mainStat_A23 = bashfulDemonMain.Wengine_BashfulDemon_Main;
                                    double subStat_A23 = bashfulDemonSubATK.Wengine_BashfulDemon_Sub_ATK;
                                    double[] pasiveStat_A23_dmg = bashfulDemonPasiveDMG.Wengine_BashfulDemon_Pasive_DMG;
                                    double[] pasiveStat_A23_atk = bashfulDemonPasiveATK.Wengine_BashfulDemon_Pasive_ATK;
                                    break;
                                case 24:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name24);
                                    W_Engines_A_rank.Main.KaboomtheCannon kaboomtheCannonMain = new W_Engines_A_rank.Main.KaboomtheCannon();
                                    W_Engines_A_rank.Sub.EnergyRegen_Bufs.KaboomtheCannon kaboomtheCannonSubEnergy = new W_Engines_A_rank.Sub.EnergyRegen_Bufs.KaboomtheCannon();
                                    W_Engines_A_rank.Pasive.ATK_Bufs.KaboomtheCannon kaboomtheCannonPasiveATK = new W_Engines_A_rank.Pasive.ATK_Bufs.KaboomtheCannon();

                                    double mainStat_A24 = kaboomtheCannonMain.Wengine_KaboomtheCannon_Main;
                                    double subStat_A24 = kaboomtheCannonSubEnergy.Wengine_KaboomtheCannon_Sub_EnergyRegen;
                                    double[] pasiveStat_A24_stack1 = kaboomtheCannonPasiveATK.Wengine_KaboomtheCannon_Pasive_ATK_stac_1;
                                    double[] pasiveStat_A24_stack2 = kaboomtheCannonPasiveATK.Wengine_KaboomtheCannon_Pasive_ATK_stac_2;
                                    double[] pasiveStat_A24_stack3 = kaboomtheCannonPasiveATK.Wengine_KaboomtheCannon_Pasive_ATK_stac_3;
                                    double[] pasiveStat_A24_stack4 = kaboomtheCannonPasiveATK.Wengine_KaboomtheCannon_Pasive_ATK_stac_4;
                                    break;
                                case 25:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name25);
                                    W_Engines_A_rank.Main.PeacekeeperSpecialized peacekeeperSpecializedMain = new W_Engines_A_rank.Main.PeacekeeperSpecialized();
                                    W_Engines_A_rank.Sub.ATK_Bufs.PeacekeeperSpecialized peacekeeperSpecializedSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.PeacekeeperSpecialized();

                                    double mainStat_A25 = peacekeeperSpecializedMain.Wengine_PeacekeeperSpecialized_Main;
                                    double subStat_A25 = peacekeeperSpecializedSubATK.Wengine_PeacekeeperSpecialized_Sub_ATK;
                                    break;
                                case 26:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name26);
                                    W_Engines_A_rank.Main.RoaringRide roaringRideMain = new W_Engines_A_rank.Main.RoaringRide();
                                    W_Engines_A_rank.Sub.ATK_Bufs.RoaringRide roaringRideSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.RoaringRide();
                                    W_Engines_A_rank.Pasive.ATK_Bufs.RoaringRide roaringRidePasiveATK = new W_Engines_A_rank.Pasive.ATK_Bufs.RoaringRide();
                                    W_Engines_A_rank.Pasive.AP_Bufs.RoaringRide roaringRidePasiveAP = new W_Engines_A_rank.Pasive.AP_Bufs.RoaringRide();

                                    double mainStat_A26 = roaringRideMain.Wengine_RoaringRide_Main;
                                    double subStat_A26 = roaringRideSubATK.Wengine_RoaringRide_Sub_ATK;
                                    double[] pasiveStat_A26_atk = roaringRidePasiveATK.Wengine_RoaringRide_Pasive_ATK;
                                    double[] pasiveStat_A26_ap = roaringRidePasiveAP.Wengine_RoaringRide_Pasive_AP;
                                    break;
                                case 27:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name27);
                                    W_Engines_A_rank.Main.BoxCutter boxCutterMain = new W_Engines_A_rank.Main.BoxCutter();
                                    W_Engines_A_rank.Sub.Impact_Bufs.BoxCutter boxCutterSubImpact = new W_Engines_A_rank.Sub.Impact_Bufs.BoxCutter();
                                    W_Engines_A_rank.Pasive.DMG.BoxCutter boxCutterPasiveDMG = new W_Engines_A_rank.Pasive.DMG.BoxCutter();
                                    W_Engines_A_rank.Pasive.Impact_Bufs.BoxCutter boxCutterPasiveImpact = new W_Engines_A_rank.Pasive.Impact_Bufs.BoxCutter();

                                    double mainStat_A27 = boxCutterMain.Wengine_BoxCutter_Main;
                                    double subStat_A27 = boxCutterSubImpact.Wengine_BoxCutter_Sub_Impact;
                                    double[] pasiveStat_A27_dmg = boxCutterPasiveDMG.Wengine_BoxCutter_Pasive_DMG;
                                    double[] pasiveStat_A27_impact = boxCutterPasiveImpact.Wengine_BoxCutter_Pasive_Impact;
                                    break;
                                case 28:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name28);
                                    W_Engines_A_rank.Main.TremorTrigramVessel tremorTrigramVesselMain = new W_Engines_A_rank.Main.TremorTrigramVessel();
                                    W_Engines_A_rank.Sub.ATK_Bufs.TremorTrigramVessel tremorTrigramVesselSubATK = new W_Engines_A_rank.Sub.ATK_Bufs.TremorTrigramVessel();
                                    W_Engines_A_rank.Pasive.DMG.TremorTrigramVessel tremorTrigramVesselPasiveDMG = new W_Engines_A_rank.Pasive.DMG.TremorTrigramVessel();

                                    double mainStat_A28 = tremorTrigramVesselMain.Wengine_TremorTrigramVessel_Main;
                                    double subStat_A28 = tremorTrigramVesselSubATK.Wengine_TremorTrigramVessel_Sub_ATK;
                                    double[] pasiveStat_A28 = tremorTrigramVesselPasiveDMG.Wengine_TremorTrigramVessel_Pasive_DMG;
                                    break;
                                case 29:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name29);
                                    break;
                                case 30:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name30);
                                    W_Engines_A_rank.Main.CannonRotor cannonRotorMain = new W_Engines_A_rank.Main.CannonRotor();
                                    W_Engines_A_rank.Sub.CritRate_Bufs.CannonRotor cannonRotorSubCrit = new W_Engines_A_rank.Sub.CritRate_Bufs.CannonRotor();
                                    W_Engines_A_rank.Pasive.CombatATK_Bufs.CannonRotor cannonRotorPasiveCombatATK = new W_Engines_A_rank.Pasive.CombatATK_Bufs.CannonRotor();

                                    double mainStat_A30 = cannonRotorMain.Wengine_CannonRotor_Main;
                                    double subStat_A30 = cannonRotorSubCrit.Wengine_CannonRotor_Sub_CritRate;
                                    double[] pasiveStat_A30 = cannonRotorPasiveCombatATK.Wengine_CannonRotor_Pasive_combatATK;
                                    break;
                                case 31:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name31);
                                    W_Engines_A_rank.Main.UnfetteredGameBall unfetteredGameBallMain = new W_Engines_A_rank.Main.UnfetteredGameBall();
                                    W_Engines_A_rank.Sub.EnergyRegen_Bufs.UnfetteredGameBall unfetteredGameBallSubEnergy = new W_Engines_A_rank.Sub.EnergyRegen_Bufs.UnfetteredGameBall();
                                    W_Engines_A_rank.Pasive.CritRate_Bufs.UnfetteredGameBall unfetteredGameBallPasiveCrit = new W_Engines_A_rank.Pasive.CritRate_Bufs.UnfetteredGameBall();

                                    double mainStat_A31 = unfetteredGameBallMain.Wengine_UnfetteredGameBall_Main;
                                    double subStat_A31 = unfetteredGameBallSubEnergy.Wengine_UnfetteredGameBall_Sub_EnergyRegen;
                                    double[] pasiveStat_A31 = unfetteredGameBallPasiveCrit.Wengine_UnfetteredGameBall_Pasive_CritRate;
                                    break;
                                case 32:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_A.name32);
                                    W_Engines_A_rank.Main.SixShooter sixShooterMain = new W_Engines_A_rank.Main.SixShooter();
                                    W_Engines_A_rank.Sub.Impact_Bufs.SixShooter sixShooterSubImpact = new W_Engines_A_rank.Sub.Impact_Bufs.SixShooter();

                                    double mainStat_A32 = sixShooterMain.Wengine_SixShooter_Main;
                                    double subStat_A32 = sixShooterSubImpact.Wengine_SixShooter_Sub_Impact;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите название оружия на агенте");
                        Console.WriteLine("Steel Cushion - 1\r\nThe Brimstone - 2\r\nKraken’s Cradle - 3\r\nTusks of Fury - 4\r\nHailstorm Shrine - 5\r\nHellfire Gears - 6\r\nThe Restrained - 7\r\nBlazing Laurel - 8\r\nFlamemaker Shaker - 9\r\nFusion Compiler - 10\r\nDeep Sea Visitor - 11\r\nZanshin Herb Case - 12\r\nWeeping Cradle - 13\r\nTimeweaver - 14\r\nRiot Suppressor Mark VI - 15\r\nIce-Jade Teapot - 16\r\nSharpened Stinger - 17\r\nMyriad Eclipse - 18\r\nBellicose Blaze - 19\r\nElegant Vanity - 20\r\nHeartstring Nocturne - 21\r\nFlight of Fancy - 22\r\nSpectral Gaze - 23\r\nQingming Birdcage - 24\r\nSevered Innocence - 25\r\nRoaring Furnace - 26\r\nPracticed Perfection - 27\r\nMetanukimorp - 28\r\nDreamlit Hearth - 29\r\nCordis Germina - 30");
                        string input_Wengen_Name_S = Console.ReadLine();
                        if (int.TryParse(input_Wengen_Name_S, out int choise_Wengen_Name_S))
                        {
                            switch (choise_Wengen_Name_S)
                            {
                                case 1:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name1);
                                    W_Engines_S_rank.Main.SteelCushion steelCushionMain = new W_Engines_S_rank.Main.SteelCushion();
                                    W_Engines_S_rank.Sub.CritRate_Bufs.SteelCushion steelCushionSubCrit = new W_Engines_S_rank.Sub.CritRate_Bufs.SteelCushion();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.SteelCushion steelCushionPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.SteelCushion();

                                    double mainStat_S1 = steelCushionMain.Wengine_SteelCushion_Main;
                                    double subStat_S1 = steelCushionSubCrit.Wengine_SteelCushion_Sub_CritRate;
                                    double[] pasiveStat_S1_dmg1 = steelCushionPasiveDMG.Wengine_SteelCushion_Pasive_DMG_1;
                                    double[] pasiveStat_S1_dmg2 = steelCushionPasiveDMG.Wengine_SteelCushion_Pasive_DMG_2;
                                    break;
                                case 2:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name2);
                                    W_Engines_S_rank.Main.Brimstone brimstoneMain = new W_Engines_S_rank.Main.Brimstone();
                                    W_Engines_S_rank.Sub.ATK_Bufs.Brimstone brimstoneSubATK = new W_Engines_S_rank.Sub.ATK_Bufs.Brimstone();
                                    W_Engines_S_rank.Pasive.ATK_Bufs.Brimstone brimstonePasiveATK = new W_Engines_S_rank.Pasive.ATK_Bufs.Brimstone();

                                    double mainStat_S2 = brimstoneMain.Wengine_Brimstone_Main;
                                    double subStat_S2 = brimstoneSubATK.Wengine_Brimstone_Sub_ATK;
                                    double[] pasiveStat_S2_stack1 = brimstonePasiveATK.Wengine_Brimstone_Pasive_ATK_stac_1;
                                    double[] pasiveStat_S2_stack2 = brimstonePasiveATK.Wengine_Brimstone_Pasive_ATK_stac_2;
                                    double[] pasiveStat_S2_stack3 = brimstonePasiveATK.Wengine_Brimstone_Pasive_ATK_stac_3;
                                    double[] pasiveStat_S2_stack4 = brimstonePasiveATK.Wengine_Brimstone_Pasive_ATK_stac_4;
                                    double[] pasiveStat_S2_stack5 = brimstonePasiveATK.Wengine_Brimstone_Pasive_ATK_stac_5;
                                    double[] pasiveStat_S2_stack6 = brimstonePasiveATK.Wengine_Brimstone_Pasive_ATK_stac_6;
                                    double[] pasiveStat_S2_stack7 = brimstonePasiveATK.Wengine_Brimstone_Pasive_ATK_stac_7;
                                    double[] pasiveStat_S2_stack8 = brimstonePasiveATK.Wengine_Brimstone_Pasive_ATK_stac_8;
                                    break;
                                case 3:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name3);
                                    W_Engines_S_rank.Main.KrakensCradle krakensCradleMain = new W_Engines_S_rank.Main.KrakensCradle();
                                    W_Engines_S_rank.Sub.HP_Bufs.KrakensCradle krakensCradleSubHP = new W_Engines_S_rank.Sub.HP_Bufs.KrakensCradle();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.KrakensCradle krakensCradlePasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.KrakensCradle();
                                    W_Engines_S_rank.Pasive.CritRate_Bufs.KrakensCradle krakensCradlePasiveCrit = new W_Engines_S_rank.Pasive.CritRate_Bufs.KrakensCradle();

                                    double mainStat_S3 = krakensCradleMain.Wengine_KrakensCradle_Main;
                                    double subStat_S3 = krakensCradleSubHP.Wengine_KrakensCradle_Sub_HP;
                                    double[] pasiveStat_S3_dmg1 = krakensCradlePasiveDMG.Wengine_KrakensCradle_Pasive_DMG_stac_1;
                                    double[] pasiveStat_S3_dmg2 = krakensCradlePasiveDMG.Wengine_KrakensCradle_Pasive_DMG_stac_2;
                                    double[] pasiveStat_S3_dmg3 = krakensCradlePasiveDMG.Wengine_KrakensCradle_Pasive_DMG_stac_3;
                                    double[] pasiveStat_S3_crit = krakensCradlePasiveCrit.Wengine_KrakensCradle_Pasive_CritRate;
                                    break;
                                case 4:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name4);
                                    W_Engines_S_rank.Main.TusksofFury tusksofFuryMain = new W_Engines_S_rank.Main.TusksofFury();
                                    W_Engines_S_rank.Sub.Impact_Bufs.TusksofFury tusksofFurySubImpact = new W_Engines_S_rank.Sub.Impact_Bufs.TusksofFury();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.TusksofFury tusksofFuryPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.TusksofFury();

                                    double mainStat_S4 = tusksofFuryMain.Wengine_TusksofFury_Main;
                                    double subStat_S4 = tusksofFurySubImpact.Wengine_TusksofFury_Sub_Impact;
                                    double[] pasiveStat_S4 = tusksofFuryPasiveDMG.Wengine_TusksofFury_Pasive_DMG;
                                    break;
                                case 5:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name5);
                                    W_Engines_S_rank.Main.HailstormShrine hailstormShrineMain = new W_Engines_S_rank.Main.HailstormShrine();
                                    W_Engines_S_rank.Sub.CritRate_Bufs.HailstormShrine hailstormShrineSubCrit = new W_Engines_S_rank.Sub.CritRate_Bufs.HailstormShrine();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.HailstormShrine hailstormShrinePasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.HailstormShrine();
                                    W_Engines_S_rank.Pasive.CritDMG_Bufs.HailstormShrine hailstormShrinePasiveCritDMG = new W_Engines_S_rank.Pasive.CritDMG_Bufs.HailstormShrine();

                                    double mainStat_S5 = hailstormShrineMain.Wengine_HailstormShrine_Main;
                                    double subStat_S5 = hailstormShrineSubCrit.Wengine_HailstormShrine_Sub_CritRate;
                                    double[] pasiveStat_S5_dmg1 = hailstormShrinePasiveDMG.Wengine_HailstormShrine_Pasive_DMG_stac_1;
                                    double[] pasiveStat_S5_dmg2 = hailstormShrinePasiveDMG.Wengine_HailstormShrine_Pasive_DMG_stac_2;
                                    double[] pasiveStat_S5_critdmg = hailstormShrinePasiveCritDMG.Wengine_HailstormShrine_Pasive_CritDMG;
                                    break;
                                case 6:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name6);
                                    W_Engines_S_rank.Main.HellfireGears hellfireGearsMain = new W_Engines_S_rank.Main.HellfireGears();
                                    W_Engines_S_rank.Sub.Impact_Bufs.HellfireGears hellfireGearsSubImpact = new W_Engines_S_rank.Sub.Impact_Bufs.HellfireGears();
                                    W_Engines_S_rank.Pasive.Impact_Bufs.HellfireGears hellfireGearsPasiveImpact = new W_Engines_S_rank.Pasive.Impact_Bufs.HellfireGears();

                                    double mainStat_S6 = hellfireGearsMain.Wengine_HellfireGears_Main;
                                    double subStat_S6 = hellfireGearsSubImpact.Wengine_HellfireGears_Sub_Impact;
                                    double[] pasiveStat_S6_stack1 = hellfireGearsPasiveImpact.Wengine_HellfireGears_Pasive_Impact_stac_1;
                                    double[] pasiveStat_S6_stack2 = hellfireGearsPasiveImpact.Wengine_HellfireGears_Pasive_Impact_stac_2;
                                    break;
                                case 7:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name7);
                                    W_Engines_S_rank.Main.TheRestrained theRestrainedMain = new W_Engines_S_rank.Main.TheRestrained();
                                    W_Engines_S_rank.Sub.Impact_Bufs.TheRestrained theRestrainedSubImpact = new W_Engines_S_rank.Sub.Impact_Bufs.TheRestrained();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.TheRestrained theRestrainedPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.TheRestrained();

                                    double mainStat_S7 = theRestrainedMain.Wengine_TheRestrained_Main;
                                    double subStat_S7 = theRestrainedSubImpact.Wengine_TheRestrained_Sub_Impact;
                                    double[] pasiveStat_S7 = theRestrainedPasiveDMG.Wengine_TheRestrained_Pasive_DMG;
                                    break;
                                case 8:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name8);
                                    W_Engines_S_rank.Main.BlazingLaurel blazingLaurelMain = new W_Engines_S_rank.Main.BlazingLaurel();
                                    W_Engines_S_rank.Sub.Impact_Bufs.BlazingLaurel blazingLaurelSubImpact = new W_Engines_S_rank.Sub.Impact_Bufs.BlazingLaurel();
                                    W_Engines_S_rank.Pasive.Impact_Bufs.BlazingLaurel blazingLaurelPasiveImpact = new W_Engines_S_rank.Pasive.Impact_Bufs.BlazingLaurel();
                                    W_Engines_S_rank.Pasive.CritDMG_Bufs.BlazingLaurel blazingLaurelPasiveCritDMG = new W_Engines_S_rank.Pasive.CritDMG_Bufs.BlazingLaurel();

                                    double mainStat_S8 = blazingLaurelMain.Wengine_BlazingLaurel_Main;
                                    double subStat_S8 = blazingLaurelSubImpact.Wengine_BlazingLaurel_Sub_Impact;
                                    double[] pasiveStat_S8_impact = blazingLaurelPasiveImpact.Wengine_BlazingLaurel_Pasive_Impact;
                                    double[] pasiveStat_S8_critdmg1 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_1;
                                    double[] pasiveStat_S8_critdmg2 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_2;
                                    double[] pasiveStat_S8_critdmg3 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_3;
                                    double[] pasiveStat_S8_critdmg4 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_4;
                                    double[] pasiveStat_S8_critdmg5 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_5;
                                    double[] pasiveStat_S8_critdmg6 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_6;
                                    double[] pasiveStat_S8_critdmg7 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_7;
                                    double[] pasiveStat_S8_critdmg8 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_8;
                                    double[] pasiveStat_S8_critdmg9 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_9;
                                    double[] pasiveStat_S8_critdmg10 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_10;
                                    double[] pasiveStat_S8_critdmg11 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_11;
                                    double[] pasiveStat_S8_critdmg12 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_12;
                                    double[] pasiveStat_S8_critdmg13 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_13;
                                    double[] pasiveStat_S8_critdmg14 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_14;
                                    double[] pasiveStat_S8_critdmg15 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_15;
                                    double[] pasiveStat_S8_critdmg16 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_16;
                                    double[] pasiveStat_S8_critdmg17 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_17;
                                    double[] pasiveStat_S8_critdmg18 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_18;
                                    double[] pasiveStat_S8_critdmg19 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_19;
                                    double[] pasiveStat_S8_critdmg20 = blazingLaurelPasiveCritDMG.Wengine_BlazingLaurel_Pasive_CritDMG_stac_20;
                                    break;
                                case 9:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name9);
                                    W_Engines_S_rank.Main.FlamemakerShaker flamemakerShakerMain = new W_Engines_S_rank.Main.FlamemakerShaker();
                                    W_Engines_S_rank.Sub.ATK_Bufs.FlamemakerShaker flamemakerShakerSubATK = new W_Engines_S_rank.Sub.ATK_Bufs.FlamemakerShaker();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.FlamemakerShaker flamemakerShakerPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.FlamemakerShaker();
                                    W_Engines_S_rank.Pasive.AP_Bufs.FlamemakerShaker flamemakerShakerPasiveAP = new W_Engines_S_rank.Pasive.AP_Bufs.FlamemakerShaker();

                                    double mainStat_S9 = flamemakerShakerMain.Wengine_FlamemakerShaker_Main;
                                    double subStat_S9 = flamemakerShakerSubATK.Wengine_FlamemakerShaker_Sub_ATK;
                                    double[] pasiveStat_S9_dmg1 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_1;
                                    double[] pasiveStat_S9_dmg2 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_2;
                                    double[] pasiveStat_S9_dmg3 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_3;
                                    double[] pasiveStat_S9_dmg4 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_4;
                                    double[] pasiveStat_S9_dmg5 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_5;
                                    double[] pasiveStat_S9_dmg6 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_6;
                                    double[] pasiveStat_S9_dmg7 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_7;
                                    double[] pasiveStat_S9_dmg8 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_8;
                                    double[] pasiveStat_S9_dmg9 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_9;
                                    double[] pasiveStat_S9_dmg10 = flamemakerShakerPasiveDMG.Wengine_FlamemakerShaker_Pasive_DMG_stac_10;
                                    double[] pasiveStat_S9_ap = flamemakerShakerPasiveAP.Wengine_FlamemakerShaker_Pasive_AP_5_10_stac;
                                    break;
                                case 10:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name10);
                                    W_Engines_S_rank.Main.FusionCompiler fusionCompilerMain = new W_Engines_S_rank.Main.FusionCompiler();
                                    W_Engines_S_rank.Sub.Pen_Bufs.FusionCompiler fusionCompilerSubPen = new W_Engines_S_rank.Sub.Pen_Bufs.FusionCompiler();
                                    W_Engines_S_rank.Pasive.ATK_Bufs.FusionCompiler fusionCompilerPasiveATK = new W_Engines_S_rank.Pasive.ATK_Bufs.FusionCompiler();
                                    W_Engines_S_rank.Pasive.AP_Bufs.FusionCompiler fusionCompilerPasiveAP = new W_Engines_S_rank.Pasive.AP_Bufs.FusionCompiler();

                                    double mainStat_S10 = fusionCompilerMain.Wengine_FusionCompiler_Main;
                                    double subStat_S10 = fusionCompilerSubPen.Wengine_FusionCompiler_Sub_Pen;
                                    double[] pasiveStat_S10_atk = fusionCompilerPasiveATK.Wengine_FusionCompiler_Pasive_ATK;
                                    double[] pasiveStat_S10_ap1 = fusionCompilerPasiveAP.Wengine_FusionCompiler_Pasive_AP_stac_1;
                                    double[] pasiveStat_S10_ap2 = fusionCompilerPasiveAP.Wengine_FusionCompiler_Pasive_AP_stac_2;
                                    double[] pasiveStat_S10_ap3 = fusionCompilerPasiveAP.Wengine_FusionCompiler_Pasive_AP_stac_3;
                                    break;
                                case 11:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name11);
                                    W_Engines_S_rank.Main.DeepSeaVisitor deepSeaVisitorMain = new W_Engines_S_rank.Main.DeepSeaVisitor();
                                    W_Engines_S_rank.Sub.CritRate_Bufs.DeepSeaVisitor deepSeaVisitorSubCrit = new W_Engines_S_rank.Sub.CritRate_Bufs.DeepSeaVisitor();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.DeepSeaVisitor deepSeaVisitorPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.DeepSeaVisitor();
                                    W_Engines_S_rank.Pasive.CritRate_Bufs.DeepSeaVisitor deepSeaVisitorPasiveCrit = new W_Engines_S_rank.Pasive.CritRate_Bufs.DeepSeaVisitor();

                                    double mainStat_S11 = deepSeaVisitorMain.Wengine_DeepSeaVisitor_Main;
                                    double subStat_S11 = deepSeaVisitorSubCrit.Wengine_DeepSeaVisitor_Sub_CritRate;
                                    double[] pasiveStat_S11_dmg = deepSeaVisitorPasiveDMG.Wengine_DeepSeaVisitor_Pasive_DMG;
                                    double[] pasiveStat_S11_crit1 = deepSeaVisitorPasiveCrit.Wengine_DeepSeaVisitor_Pasive_CritRate_1;
                                    double[] pasiveStat_S11_crit2 = deepSeaVisitorPasiveCrit.Wengine_DeepSeaVisitor_Pasive_CritRate_2;
                                    break;
                                case 12:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name12);
                                    W_Engines_S_rank.Main.ZanshinHerbCase zanshinHerbCaseMain = new W_Engines_S_rank.Main.ZanshinHerbCase();
                                    W_Engines_S_rank.Sub.CritDMG_Bufs.ZanshinHerbCase zanshinHerbCaseSubCritDMG = new W_Engines_S_rank.Sub.CritDMG_Bufs.ZanshinHerbCase();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.ZanshinHerbCase zanshinHerbCasePasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.ZanshinHerbCase();
                                    W_Engines_S_rank.Pasive.CritRate_Bufs.ZanshinHerbCase zanshinHerbCasePasiveCrit = new W_Engines_S_rank.Pasive.CritRate_Bufs.ZanshinHerbCase();

                                    double mainStat_S12 = zanshinHerbCaseMain.Wengine_ZanshinHerbCase_Main;
                                    double subStat_S12 = zanshinHerbCaseSubCritDMG.Wengine_ZanshinHerbCase_Sub_CritDMG;
                                    double[] pasiveStat_S12_dmg = zanshinHerbCasePasiveDMG.Wengine_ZanshinHerbCase_Pasive_DMG;
                                    double[] pasiveStat_S12_crit1 = zanshinHerbCasePasiveCrit.Wengine_ZanshinHerbCase_Pasive_CritRate_1;
                                    double[] pasiveStat_S12_crit2 = zanshinHerbCasePasiveCrit.Wengine_ZanshinHerbCase_Pasive_CritRate_2;
                                    break;
                                case 13:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name13);
                                    W_Engines_S_rank.Main.WeepingCradle weepingCradleMain = new W_Engines_S_rank.Main.WeepingCradle();
                                    W_Engines_S_rank.Sub.Pen_Bufs.WeepingCradle weepingCradleSubPen = new W_Engines_S_rank.Sub.Pen_Bufs.WeepingCradle();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.WeepingCradle weepingCradlePasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.WeepingCradle();

                                    double mainStat_S13 = weepingCradleMain.Wengine_WeepingCradle_Main;
                                    double subStat_S13 = weepingCradleSubPen.Wengine_WeepingCradle_Sub_Pen;
                                    double[] pasiveStat_S13_dmg1 = weepingCradlePasiveDMG.Wengine_WeepingCradle_Pasive_DMG;
                                    double[] pasiveStat_S13_dmg2 = weepingCradlePasiveDMG.Wengine_WeepingCradle_Pasive_DMG_stac_1;
                                    double[] pasiveStat_S13_dmg3 = weepingCradlePasiveDMG.Wengine_WeepingCradle_Pasive_DMG_stac_2;
                                    double[] pasiveStat_S13_dmg4 = weepingCradlePasiveDMG.Wengine_WeepingCradle_Pasive_DMG_stac_3;
                                    double[] pasiveStat_S13_dmg5 = weepingCradlePasiveDMG.Wengine_WeepingCradle_Pasive_DMG_stac_4;
                                    double[] pasiveStat_S13_dmg6 = weepingCradlePasiveDMG.Wengine_WeepingCradle_Pasive_DMG_stac_5;
                                    double[] pasiveStat_S13_dmg7 = weepingCradlePasiveDMG.Wengine_WeepingCradle_Pasive_DMG_stac_6;
                                    break;
                                case 14:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name14);
                                    W_Engines_S_rank.Main.Timeweaver timeweaverMain = new W_Engines_S_rank.Main.Timeweaver();
                                    W_Engines_S_rank.Sub.ATK_Bufs.Timeweaver timeweaverSubATK = new W_Engines_S_rank.Sub.ATK_Bufs.Timeweaver();
                                    W_Engines_S_rank.Pasive.DisorterDMG_Bufs timeweaverPasiveDisorter = new W_Engines_S_rank.Pasive.DisorterDMG_Bufs();
                                    W_Engines_S_rank.Pasive.AP_Bufs.Timeweaver timeweaverPasiveAP = new W_Engines_S_rank.Pasive.AP_Bufs.Timeweaver();

                                    double mainStat_S14 = timeweaverMain.Wengine_Timeweaver_Main;
                                    double subStat_S14 = timeweaverSubATK.Wengine_Timeweaver_Sub_ATK;
                                    double[] pasiveStat_S14_disorter = timeweaverPasiveDisorter.Wengine_Timeweaver_Pasive_DisorterDMG;
                                    double[] pasiveStat_S14_ap = timeweaverPasiveAP.Wengine_Timeweaver_Pasive_AP;
                                    break;
                                case 15:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name15);
                                    W_Engines_S_rank.Main.RiotSuppressorMarkVI riotSuppressorMarkVIMain = new W_Engines_S_rank.Main.RiotSuppressorMarkVI();
                                    W_Engines_S_rank.Sub.CritDMG_Bufs.RiotSuppressorMarkVI riotSuppressorMarkVISubCritDMG = new W_Engines_S_rank.Sub.CritDMG_Bufs.RiotSuppressorMarkVI();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.RiotSuppressorMarkVI riotSuppressorMarkVIPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.RiotSuppressorMarkVI();
                                    W_Engines_S_rank.Pasive.CritRate_Bufs.RiotSuppressorMarkVI riotSuppressorMarkVIPasiveCrit = new W_Engines_S_rank.Pasive.CritRate_Bufs.RiotSuppressorMarkVI();

                                    double mainStat_S15 = riotSuppressorMarkVIMain.Wengine_RiotSuppressorMarkVI_Main;
                                    double subStat_S15 = riotSuppressorMarkVISubCritDMG.Wengine_RiotSuppressorMarkVI_Sub_CritDMG;
                                    double[] pasiveStat_S15_dmg = riotSuppressorMarkVIPasiveDMG.Wengine_RiotSuppressorMarkVI_Pasive_DMG;
                                    double[] pasiveStat_S15_crit = riotSuppressorMarkVIPasiveCrit.Wengine_RiotSuppressorMarkVI_Pasive_CritRate;
                                    break;
                                case 16:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name16);
                                    W_Engines_S_rank.Main.IceJadeTeapot iceJadeTeapotMain = new W_Engines_S_rank.Main.IceJadeTeapot();
                                    W_Engines_S_rank.Sub.Impact_Bufs.IceJadeTeapot iceJadeTeapotSubImpact = new W_Engines_S_rank.Sub.Impact_Bufs.IceJadeTeapot();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.IceJadeTeapot iceJadeTeapotPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.IceJadeTeapot();
                                    W_Engines_S_rank.Pasive.Impact_Bufs.IceJadeTeapot iceJadeTeapotPasiveImpact = new W_Engines_S_rank.Pasive.Impact_Bufs.IceJadeTeapot();

                                    double mainStat_S16 = iceJadeTeapotMain.Wengine_IceJadeTeapot_Main;
                                    double subStat_S16 = iceJadeTeapotSubImpact.Wengine_IceJadeTeapot_Sub_Impact;
                                    double[] pasiveStat_S16_dmg = iceJadeTeapotPasiveDMG.Wengine_IceJadeTeapot_Pasive_DMG;
                                    double[] pasiveStat_S16_impact1 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_1;
                                    double[] pasiveStat_S16_impact2 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_2;
                                    double[] pasiveStat_S16_impact3 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_3;
                                    double[] pasiveStat_S16_impact4 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_4;
                                    double[] pasiveStat_S16_impact5 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_5;
                                    double[] pasiveStat_S16_impact6 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_6;
                                    double[] pasiveStat_S16_impact7 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_7;
                                    double[] pasiveStat_S16_impact8 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_8;
                                    double[] pasiveStat_S16_impact9 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_9;
                                    double[] pasiveStat_S16_impact10 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_10;
                                    double[] pasiveStat_S16_impact11 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_11;
                                    double[] pasiveStat_S16_impact12 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_12;
                                    double[] pasiveStat_S16_impact13 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_13;
                                    double[] pasiveStat_S16_impact14 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_14;
                                    double[] pasiveStat_S16_impact15 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_15;
                                    double[] pasiveStat_S16_impact16 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_16;
                                    double[] pasiveStat_S16_impact17 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_17;
                                    double[] pasiveStat_S16_impact18 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_18;
                                    double[] pasiveStat_S16_impact19 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_19;
                                    double[] pasiveStat_S16_impact20 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_20;
                                    double[] pasiveStat_S16_impact21 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_21;
                                    double[] pasiveStat_S16_impact22 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_22;
                                    double[] pasiveStat_S16_impact23 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_23;
                                    double[] pasiveStat_S16_impact24 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_24;
                                    double[] pasiveStat_S16_impact25 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_25;
                                    double[] pasiveStat_S16_impact26 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_26;
                                    double[] pasiveStat_S16_impact27 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_27;
                                    double[] pasiveStat_S16_impact28 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_28;
                                    double[] pasiveStat_S16_impact29 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_29;
                                    double[] pasiveStat_S16_impact30 = iceJadeTeapotPasiveImpact.Wengine_IceJadeTeapot_Pasive_Impact_stac_30;
                                    break;
                                case 17:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name17);
                                    W_Engines_S_rank.Main.SharpenedStinger sharpenedStingerMain = new W_Engines_S_rank.Main.SharpenedStinger();
                                    W_Engines_S_rank.Sub.AP_Bufs.SharpenedStinger sharpenedStingerSubAP = new W_Engines_S_rank.Sub.AP_Bufs.SharpenedStinger();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.SharpenedStinger sharpenedStingerPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.SharpenedStinger();

                                    double mainStat_S17 = sharpenedStingerMain.Wengine_SharpenedStinger_Main;
                                    double subStat_S17 = sharpenedStingerSubAP.Wengine_SharpenedStinger_Sub_AP;
                                    double[] pasiveStat_S17_dmg1 = sharpenedStingerPasiveDMG.Wengine_SharpenedStinger_Pasive_DMG_stac_1;
                                    double[] pasiveStat_S17_dmg2 = sharpenedStingerPasiveDMG.Wengine_SharpenedStinger_Pasive_DMG_stac_2;
                                    double[] pasiveStat_S17_dmg3 = sharpenedStingerPasiveDMG.Wengine_SharpenedStinger_Pasive_DMG_stac_3;
                                    break;
                                case 18:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name18);
                                    W_Engines_S_rank.Main.MyriadEclipse myriadEclipseMain = new W_Engines_S_rank.Main.MyriadEclipse();
                                    W_Engines_S_rank.Sub.CritRate_Bufs.MyriadEclipse myriadEclipseSubCrit = new W_Engines_S_rank.Sub.CritRate_Bufs.MyriadEclipse();
                                    W_Engines_S_rank.Pasive.CritDMG_Bufs.MyriadEclipse myriadEclipsePasiveCritDMG = new W_Engines_S_rank.Pasive.CritDMG_Bufs.MyriadEclipse();
                                    W_Engines_S_rank.Pasive.DefIgnore_Bufs.MyriadEclipse myriadEclipsePasiveDefIgnore = new W_Engines_S_rank.Pasive.DefIgnore_Bufs.MyriadEclipse();

                                    double mainStat_S18 = myriadEclipseMain.Wengine_MyriadEclipse_Main;
                                    double subStat_S18 = myriadEclipseSubCrit.Wengine_MyriadEclipse_Sub_CritRate;
                                    double[] pasiveStat_S18_critdmg = myriadEclipsePasiveCritDMG.Wengine_MyriadEclipse_Pasive_CritDMG;
                                    double[] pasiveStat_S18_defignore = myriadEclipsePasiveDefIgnore.Wengine_MyriadEclipse_Pasive_DefIgnore;
                                    break;
                                case 19:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name19);
                                    W_Engines_S_rank.Main.BellicoseBlaze bellicoseBlazeMain = new W_Engines_S_rank.Main.BellicoseBlaze();
                                    W_Engines_S_rank.Sub.EnergyRegen_Bufs.BellicoseBlaze bellicoseBlazeSubEnergy = new W_Engines_S_rank.Sub.EnergyRegen_Bufs.BellicoseBlaze();
                                    W_Engines_S_rank.Pasive.CritRate_Bufs.BellicoseBlaze bellicoseBlazePasiveCrit = new W_Engines_S_rank.Pasive.CritRate_Bufs.BellicoseBlaze();
                                    W_Engines_S_rank.Pasive.DefIgnore_Bufs.BellicoseBlaze bellicoseBlazePasiveDefIgnore = new W_Engines_S_rank.Pasive.DefIgnore_Bufs.BellicoseBlaze();

                                    double mainStat_S19 = bellicoseBlazeMain.Wengine_BellicoseBlaze_Main;
                                    double subStat_S19 = bellicoseBlazeSubEnergy.Wengine_BellicoseBlaze_Sub_EnergyRegen;
                                    double[] pasiveStat_S19_crit = bellicoseBlazePasiveCrit.Wengine_BellicoseBlaze_Pasive_CritRate;
                                    double[] pasiveStat_S19_defignore = bellicoseBlazePasiveDefIgnore.Wengine_BellicoseBlaze_Pasive_DefIgnore;
                                    break;
                                case 20:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name20);
                                    W_Engines_S_rank.Main.ElegantVanity elegantVanityMain = new W_Engines_S_rank.Main.ElegantVanity();
                                    W_Engines_S_rank.Sub.ATK_Bufs.ElegantVanity elegantVanitySubATK = new W_Engines_S_rank.Sub.ATK_Bufs.ElegantVanity();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.ElegantVanity elegantVanityPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.ElegantVanity();

                                    double mainStat_S20 = elegantVanityMain.Wengine_ElegantVanity_Main;
                                    double subStat_S20 = elegantVanitySubATK.Wengine_ElegantVanity_Sub_ATK;
                                    double[] pasiveStat_S20_dmg1 = elegantVanityPasiveDMG.Wengine_ElegantVanity_Pasive_DMG_stac_1;
                                    double[] pasiveStat_S20_dmg2 = elegantVanityPasiveDMG.Wengine_ElegantVanity_Pasive_DMG_stac_2;
                                    break;
                                case 21:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name21);
                                    W_Engines_S_rank.Main.HeartstringNocturne heartstringNocturneMain = new W_Engines_S_rank.Main.HeartstringNocturne();
                                    W_Engines_S_rank.Sub.CritRate_Bufs.HeartstringNocturne heartstringNocturneSubCrit = new W_Engines_S_rank.Sub.CritRate_Bufs.HeartstringNocturne();
                                    W_Engines_S_rank.Pasive.CritDMG_Bufs.HeartstringNocturne heartstringNocturnePasiveCritDMG = new W_Engines_S_rank.Pasive.CritDMG_Bufs.HeartstringNocturne();
                                    W_Engines_S_rank.Pasive.DefIgnore_Bufs.HeartstringNocturne heartstringNocturnePasiveDefIgnore = new W_Engines_S_rank.Pasive.DefIgnore_Bufs.HeartstringNocturne();

                                    double mainStat_S21 = heartstringNocturneMain.Wengine_HeartstringNocturne_Main;
                                    double subStat_S21 = heartstringNocturneSubCrit.Wengine_HeartstringNocturne_Sub_CritRate;
                                    double[] pasiveStat_S21_critdmg = heartstringNocturnePasiveCritDMG.Wengine_HeartstringNocturne_Pasive_CritDMG;
                                    double[] pasiveStat_S21_defignore1 = heartstringNocturnePasiveDefIgnore.Wengine_HeartstringNocturne_Pasive_DefIgnore_stac_1;
                                    double[] pasiveStat_S21_defignore2 = heartstringNocturnePasiveDefIgnore.Wengine_HeartstringNocturne_Pasive_DefIgnore_stac_2;
                                    break;
                                case 22:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name22);
                                    W_Engines_S_rank.Main.FlightofFancy flightofFancyMain = new W_Engines_S_rank.Main.FlightofFancy();
                                    W_Engines_S_rank.Sub.AP_Bufs.FlightofFancy flightofFancySubAP = new W_Engines_S_rank.Sub.AP_Bufs.FlightofFancy();
                                    W_Engines_S_rank.Pasive.AP_Bufs.FlightofFancy flightofFancyPasiveAP = new W_Engines_S_rank.Pasive.AP_Bufs.FlightofFancy();

                                    double mainStat_S22 = flightofFancyMain.Wengine_FlightofFancy_Main;
                                    double subStat_S22 = flightofFancySubAP.Wengine_FlightofFancy_Sub_AP;
                                    double[] pasiveStat_S22_ap1 = flightofFancyPasiveAP.Wengine_FlightofFancy_Pasive_AP_stac_1;
                                    double[] pasiveStat_S22_ap2 = flightofFancyPasiveAP.Wengine_FlightofFancy_Pasive_AP_stac_2;
                                    double[] pasiveStat_S22_ap3 = flightofFancyPasiveAP.Wengine_FlightofFancy_Pasive_AP_stac_3;
                                    double[] pasiveStat_S22_ap4 = flightofFancyPasiveAP.Wengine_FlightofFancy_Pasive_AP_stac_4;
                                    double[] pasiveStat_S22_ap5 = flightofFancyPasiveAP.Wengine_FlightofFancy_Pasive_AP_stac_5;
                                    double[] pasiveStat_S22_ap6 = flightofFancyPasiveAP.Wengine_FlightofFancy_Pasive_AP_stac_6;
                                    break;
                                case 23:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name23);
                                    W_Engines_S_rank.Main.SpectralGaze spectralGazeMain = new W_Engines_S_rank.Main.SpectralGaze();
                                    W_Engines_S_rank.Sub.CritRate_Bufs.SpectralGaze spectralGazeSubCrit = new W_Engines_S_rank.Sub.CritRate_Bufs.SpectralGaze();
                                    W_Engines_S_rank.Pasive.Impact_Bufs.SpectralGaze spectralGazePasiveImpact = new W_Engines_S_rank.Pasive.Impact_Bufs.SpectralGaze();
                                    W_Engines_S_rank.Pasive.DefReduced_Bufs.SpectralGaze spectralGazePasiveDefReduced = new W_Engines_S_rank.Pasive.DefReduced_Bufs.SpectralGaze();

                                    double mainStat_S23 = spectralGazeMain.Wengine_SpectralGaze_Main;
                                    double subStat_S23 = spectralGazeSubCrit.Wengine_SpectralGaze_Sub_CritRate;
                                    double[] pasiveStat_S23_impact1 = spectralGazePasiveImpact.Wengine_SpectralGaze_Impact_stac_1;
                                    double[] pasiveStat_S23_impact2 = spectralGazePasiveImpact.Wengine_SpectralGaze_Impact_stac_2;
                                    double[] pasiveStat_S23_impact3 = spectralGazePasiveImpact.Wengine_SpectralGaze_Impact_stac_3;
                                    double[] pasiveStat_S23_impact_full = spectralGazePasiveImpact.Wengine_SpectralGaze_Impact;
                                    double[] pasiveStat_S23_defreduced = spectralGazePasiveDefReduced.Wengine_SpectralGaze_Pasive_DefReduced;
                                    break;
                                case 24:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name24);
                                    W_Engines_S_rank.Main.QingmingBirdcage qingmingBirdcageMain = new W_Engines_S_rank.Main.QingmingBirdcage();
                                    W_Engines_S_rank.Sub.HP_Bufs.QingmingBirdcage qingmingBirdcageSubHP = new W_Engines_S_rank.Sub.HP_Bufs.QingmingBirdcage();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.QingmingBirdcage qingmingBirdcagePasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.QingmingBirdcage();
                                    W_Engines_S_rank.Pasive.CritRate_Bufs.QingmingBirdcage qingmingBirdcagePasiveCrit = new W_Engines_S_rank.Pasive.CritRate_Bufs.QingmingBirdcage();

                                    double mainStat_S24 = qingmingBirdcageMain.Wengine_QingmingBirdcage_Main;
                                    double subStat_S24 = qingmingBirdcageSubHP.Wengine_QingmingBirdcage_Sub_HP;
                                    double[] pasiveStat_S24_dmg1 = qingmingBirdcagePasiveDMG.Wengine_QingmingBirdcage_Pasive_DMG_stac_1;
                                    double[] pasiveStat_S24_dmg2 = qingmingBirdcagePasiveDMG.Wengine_QingmingBirdcage_Pasive_DMG_stac_2;
                                    double[] pasiveStat_S24_dmg3 = qingmingBirdcagePasiveDMG.Wengine_QingmingBirdcage_Pasive_DMG_Ultimate_EX_stac_1;
                                    double[] pasiveStat_S24_dmg4 = qingmingBirdcagePasiveDMG.Wengine_QingmingBirdcage_Pasive_DMG_Ultimate_EX_stac_2;
                                    double[] pasiveStat_S24_crit = qingmingBirdcagePasiveCrit.Wengine_QingmingBirdcage_Pasive_CritRate;
                                    break;
                                case 25:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name25);
                                    W_Engines_S_rank.Main.SeveredInnocence severedInnocenceMain = new W_Engines_S_rank.Main.SeveredInnocence();
                                    W_Engines_S_rank.Sub.CritDMG_Bufs.SeveredInnocence severedInnocenceSubCritDMG = new W_Engines_S_rank.Sub.CritDMG_Bufs.SeveredInnocence();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.SeveredInnocence severedInnocencePasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.SeveredInnocence();
                                    W_Engines_S_rank.Pasive.CritDMG_Bufs.SeveredInnocence severedInnocencePasiveCritDMG = new W_Engines_S_rank.Pasive.CritDMG_Bufs.SeveredInnocence();

                                    double mainStat_S25 = severedInnocenceMain.Wengine_SeveredInnocence_Main;
                                    double subStat_S25 = severedInnocenceSubCritDMG.Wengine_SeveredInnocence_Sub_CritDMG;
                                    double[] pasiveStat_S25_dmg = severedInnocencePasiveDMG.Wengine_SeveredInnocence_Pasive_ElectricDMG;
                                    double[] pasiveStat_S25_critdmg1 = severedInnocencePasiveCritDMG.Wengine_SeveredInnocence_Pasive_CritDMG;
                                    double[] pasiveStat_S25_critdmg2 = severedInnocencePasiveCritDMG.Wengine_SeveredInnocence_Pasive_CritDMG_stac_1;
                                    double[] pasiveStat_S25_critdmg3 = severedInnocencePasiveCritDMG.Wengine_SeveredInnocence_Pasive_CritDMG_stac_2;
                                    double[] pasiveStat_S25_critdmg4 = severedInnocencePasiveCritDMG.Wengine_SeveredInnocence_Pasive_CritDMG_stac_3;
                                    break;
                                case 26:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name26);
                                    W_Engines_S_rank.Main.RoaringFurnace roaringFurnaceMain = new W_Engines_S_rank.Main.RoaringFurnace();
                                    W_Engines_S_rank.Sub.ATK_Bufs.RoaringFurnace roaringFurnaceSubATK = new W_Engines_S_rank.Sub.ATK_Bufs.RoaringFurnace();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.RoaringFurnace roaringFurnacePasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.RoaringFurnace();

                                    double mainStat_S26 = roaringFurnaceMain.Wengine_RoaringFurnace_Main;
                                    double subStat_S26 = roaringFurnaceSubATK.Wengine_RoaringFurnace_Sub_ATK;
                                    double[] pasiveStat_S26 = roaringFurnacePasiveDMG.Wengine_RoaringFurnace_Pasive_DGM;
                                    break;
                                case 27:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name27);
                                    W_Engines_S_rank.Main.PracticedPerfection practicedPerfectionMain = new W_Engines_S_rank.Main.PracticedPerfection();
                                    W_Engines_S_rank.Sub.ATK_Bufs.PracticedPerfection practicedPerfectionSubATK = new W_Engines_S_rank.Sub.ATK_Bufs.PracticedPerfection();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.PracticedPerfection practicedPerfectionPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.PracticedPerfection();
                                    W_Engines_S_rank.Pasive.AP_Bufs.PracticedPerfection practicedPerfectionPasiveAP = new W_Engines_S_rank.Pasive.AP_Bufs.PracticedPerfection();

                                    double mainStat_S27 = practicedPerfectionMain.Wengine_PracticedPerfection_Main;
                                    double subStat_S27 = practicedPerfectionSubATK.Wengine_PracticedPerfection_Sub_ATK;
                                    double[] pasiveStat_S27_dmg1 = practicedPerfectionPasiveDMG.Wengine_PracticedPerfection_Pasive_PhysicalDMG_stac_1;
                                    double[] pasiveStat_S27_dmg2 = practicedPerfectionPasiveDMG.Wengine_PracticedPerfection_Pasive_PhysicalDMG_stac_2;
                                    double[] pasiveStat_S27_ap = practicedPerfectionPasiveAP.Wengine_PracticedPerfection_Pasive_AP;
                                    break;
                                case 28:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name28);
                                    W_Engines_S_rank.Main.Metanukimorphosis metanukimorphosisMain = new W_Engines_S_rank.Main.Metanukimorphosis();
                                    W_Engines_S_rank.Sub.EnergyRegen_Bufs.Metanukimorphosis metanukimorphosisSubEnergy = new W_Engines_S_rank.Sub.EnergyRegen_Bufs.Metanukimorphosis();
                                    W_Engines_S_rank.Pasive.AP_Bufs.Metanukimorphosis metanukimorphosisPasiveAP = new W_Engines_S_rank.Pasive.AP_Bufs.Metanukimorphosis();
                                    W_Engines_S_rank.Pasive.AM_Bufs.Metanukimorphosis metanukimorphosisPasiveAM = new W_Engines_S_rank.Pasive.AM_Bufs.Metanukimorphosis();

                                    double mainStat_S28 = metanukimorphosisMain.Wengine_Metanukimorphosis_Main;
                                    double subStat_S28 = metanukimorphosisSubEnergy.Wengine_Metanukimorphosis_Sub_EnergyRegen;
                                    double[] pasiveStat_S28_ap = metanukimorphosisPasiveAP.Wengine_Metanukimorphosis_Pasive_AP_all_sqad;
                                    double[] pasiveStat_S28_am = metanukimorphosisPasiveAM.Wengine_Metanukimorphosis_Pasive_AM;
                                    break;
                                case 29:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name29);
                                    W_Engines_S_rank.Main.DreamlitHearth dreamlitHearthMain = new W_Engines_S_rank.Main.DreamlitHearth();
                                    W_Engines_S_rank.Sub.HP_Bufs.DreamlitHearth dreamlitHearthSubHP = new W_Engines_S_rank.Sub.HP_Bufs.DreamlitHearth();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.DreamlitHearth dreamlitHearthPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.DreamlitHearth();
                                    W_Engines_S_rank.Pasive.HP_Bufs.DreamlitHearth dreamlitHearthPasiveHP = new W_Engines_S_rank.Pasive.HP_Bufs.DreamlitHearth();

                                    double mainStat_S29 = dreamlitHearthMain.Wengine_DreamlitHearth_Main;
                                    double subStat_S29 = dreamlitHearthSubHP.Wengine_DreamlitHearth_Sub_HP;
                                    double[] pasiveStat_S29_dmg = dreamlitHearthPasiveDMG.Wengine_DreamlitHearth_Pasive_DMG;
                                    double[] pasiveStat_S29_hp = dreamlitHearthPasiveHP.Wengine_DreamlitHearth_Pasive_HP;
                                    break;
                                case 30:
                                    Console.WriteLine("\r\nВыбрано оружие " + selectedWengen_S.name30);
                                    W_Engines_S_rank.Main.CordisGermina cordisGerminaMain = new W_Engines_S_rank.Main.CordisGermina();
                                    W_Engines_S_rank.Sub.CritRate_Bufs.CordisGermina cordisGerminaSubCrit = new W_Engines_S_rank.Sub.CritRate_Bufs.CordisGermina();
                                    W_Engines_S_rank.Pasive.DMG_Bufs.CordisGermina cordisGerminaPasiveDMG = new W_Engines_S_rank.Pasive.DMG_Bufs.CordisGermina();
                                    W_Engines_S_rank.Pasive.CritRate_Bufs.CordisGermina cordisGerminaPasiveCrit = new W_Engines_S_rank.Pasive.CritRate_Bufs.CordisGermina();
                                    W_Engines_S_rank.Pasive.DefIgnore_Bufs.CordisGermina cordisGerminaPasiveDefIgnore = new W_Engines_S_rank.Pasive.DefIgnore_Bufs.CordisGermina();

                                    double mainStat_S30 = cordisGerminaMain.Wengine_CordisGermina_Main;
                                    double subStat_S30 = cordisGerminaSubCrit.Wengine_CordisGermina_Sub_CritRate;
                                    double[] pasiveStat_S30_dmg = cordisGerminaPasiveDMG.Wengine_CordisGermina_Pasive_DMG;
                                    double[] pasiveStat_S30_crit = cordisGerminaPasiveCrit.Wengine_CordisGermina_Pasive_CritRate;
                                    double[] pasiveStat_S30_defignore = cordisGerminaPasiveDefIgnore.Wengine_CordisGermina_Pasive_DefIgnore;
                                    break;
                            }
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("\r\nНеверный ввод. Введите число");
            }

            DriveDisc driveDisc = new DriveDisc();
            DriveDisc.CombatATK_Bufs СombatATK = new DriveDisc.CombatATK_Bufs();
            DriveDisc.ATK_Bufs ATK = new DriveDisc.ATK_Bufs();
            DriveDisc.CritRate_Bufs CritRate = new DriveDisc.CritRate_Bufs();
            DriveDisc.CritDMG_Bufs CritDMG = new DriveDisc.CritDMG_Bufs();
            DriveDisc.AP_Bufs AP = new DriveDisc.AP_Bufs();
            DriveDisc.AM_Bufs AM = new DriveDisc.AM_Bufs();
            DriveDisc.Pen_Buff Pen = new DriveDisc.Pen_Buff();
            DriveDisc.Impact Impact = new DriveDisc.Impact();
            DriveDisc.DEF DEF = new DriveDisc.DEF();
            DriveDisc.EnergyRegen EnergyRegen = new DriveDisc.EnergyRegen();
            DriveDisc.HP HP = new DriveDisc.HP();
            DriveDisc.DMG_Bufs DMG = new DriveDisc.DMG_Bufs();

            double DMG_Per;

            Console.WriteLine("Введите сет артефактов\r\n\r\nMoonlight Lullaby - 1\r\nDawn's Bloom - 2\r\nKing of the Summit - 3\r\nYunkui Tales - 4\r\nPhaethon's Melody - 5\r\nShadow Harmony - 6\r\nAstral Voice - 7\r\nBranch & Blade Song - 8\r\nFanged Metal - 9\r\nPolar Metal - 10\r\nThunder Metal - 11\r\nChaotic Metal - 12\r\nInferno Metal - 13\r\nProto Punk - 14\r\nChaos Jazz - 15\r\nSwing Jazz - 16\r\nSoul Rock - 17\r\nHormone Punk - 18\r\nFreedom Blues - 19\r\nShockstar Disco - 20\r\nPuffer Electro - 21\r\nWoodpecker Electro - 22\r\n\r\n\r\n");
            string input_set = Console.ReadLine();
            if (int.TryParse(input_set, out int choise_set))
            {
                switch (choise_set)
                {
                    case 1:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name1);
                        DriveDisc.DMG_Bufs.MoonlightLullaby moonlightLullaby = new DriveDisc.DMG_Bufs.MoonlightLullaby();
                        double DMG_Per_1 = moonlightLullaby.MoonlightLullaby_4_DMG;
                        break;
                    case 2:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name2);
                        DriveDisc.DMG_Bufs.DawnBloom dawnBloom = new DriveDisc.DMG_Bufs.DawnBloom();
                        double DMG_Per_2 = dawnBloom.DawnBloom_2_DMG;
                        double DMG_Per_2_4_1 = dawnBloom.DawnBloom_4_DMG_1;
                        double DMG_Per_2_4_2 = dawnBloom.DawnBloom_4_DMG_2;
                        break;
                    case 3:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name3);
                        DriveDisc.CritDMG_Bufs.KingOfTheSummit kingOfTheSummit = new DriveDisc.CritDMG_Bufs.KingOfTheSummit();
                        double CritDMG_3_4_1 = kingOfTheSummit.KingOfTheSummit_4_CritDMG_1;
                        double CritDMG_3_4_2 = kingOfTheSummit.KingOfTheSummit_4_CritDMG_2;
                        break;
                    case 4:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name4);
                        DriveDisc.DMG_Bufs.YunkuiTales yunkuiTales = new DriveDisc.DMG_Bufs.YunkuiTales();
                        DriveDisc.CritRate_Bufs.YunkuiTales yunkuiTalesCrit = new DriveDisc.CritRate_Bufs.YunkuiTales();
                        double DMG_Per_4 = yunkuiTales.YunkuiTales_4_DMG;
                        double CritRate_4 = yunkuiTalesCrit.YunkuiTales_4_CritRate[0];
                        break;
                    case 5:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name5);
                        DriveDisc.DMG_Bufs.PhaethonsMelody phaethonsMelodyDMG = new DriveDisc.DMG_Bufs.PhaethonsMelody();
                        DriveDisc.AM_Bufs.PhaethonsMelody phaethonsMelodyAM = new DriveDisc.AM_Bufs.PhaethonsMelody();
                        DriveDisc.AP_Bufs.PhaethonsMelody phaethonsMelodyAP = new DriveDisc.AP_Bufs.PhaethonsMelody();
                        double DMG_Per_5 = phaethonsMelodyDMG.PhaethonsMelody_4_EtherDMG;
                        double AM_5 = phaethonsMelodyAM.PhaethonsMelody_2_AM;
                        double AP_5 = phaethonsMelodyAP.PhaethonsMelody_4_AP;
                        break;
                    case 6:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name6);
                        DriveDisc.DMG_Bufs.ShadowHarmony shadowHarmonyDMG = new DriveDisc.DMG_Bufs.ShadowHarmony();
                        DriveDisc.CritRate_Bufs.ShadowHarmony shadowHarmonyCrit = new DriveDisc.CritRate_Bufs.ShadowHarmony();
                        double DMG_Per_6 = shadowHarmonyDMG.ShadowHarmony_2_DMG;
                        double CritRate_6 = shadowHarmonyCrit.ShadowHarmony_4_CritRate[0];
                        break;
                    case 7:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name7);
                        DriveDisc.DMG_Bufs.AstralVoice astralVoiceDMG = new DriveDisc.DMG_Bufs.AstralVoice();
                        DriveDisc.CombatATK_Bufs.AstralVoice astralVoiceATK = new DriveDisc.CombatATK_Bufs.AstralVoice();
                        double DMG_Per_7 = astralVoiceDMG.AstralVoice_4_DMG[0];
                        double ATK_7 = astralVoiceATK.AstralVoice_2_ATK;
                        break;
                    case 8:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name8);
                        DriveDisc.CritDMG_Bufs.BranchBladeSong branchBladeSongCritDMG = new DriveDisc.CritDMG_Bufs.BranchBladeSong();
                        DriveDisc.CritRate_Bufs.BranchBladeSong branchBladeSongCritRate = new DriveDisc.CritRate_Bufs.BranchBladeSong();
                        double CritDMG_8 = branchBladeSongCritDMG.BranchBladeSong_4_CritDMG;
                        double CritRate_8 = branchBladeSongCritRate.BranchBladeSong_4_CritRate;
                        break;
                    case 9:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name9);
                        DriveDisc.DMG_Bufs.FangedMetal fangedMetalDMG = new DriveDisc.DMG_Bufs.FangedMetal();
                        double DMG_Per_9 = fangedMetalDMG.FangedMetal_2_DMG;
                        double DMG_Per_9_4 = fangedMetalDMG.FangedMetal_4_DMG;
                        break;
                    case 10:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name10);
                        DriveDisc.DMG_Bufs.PolarMetal polarMetalDMG = new DriveDisc.DMG_Bufs.PolarMetal();
                        double DMG_Per_10 = polarMetalDMG.PolarMetal_2_IceDMG;
                        double DMG_Per_10_4_1 = polarMetalDMG.PolarMetal_4_DMG_1;
                        double DMG_Per_10_4_2 = polarMetalDMG.PolarMetal_4_DMG_2;
                        break;
                    case 11:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name11);
                        DriveDisc.DMG_Bufs.ThunderMetal thunderMetalDMG = new DriveDisc.DMG_Bufs.ThunderMetal();
                        DriveDisc.ATK_Bufs.ThunderMetal thunderMetalATK = new DriveDisc.ATK_Bufs.ThunderMetal();
                        double DMG_Per_11 = thunderMetalDMG.ThunderMetal_2_DMG;
                        double ATK_11 = thunderMetalATK.ThunderMetal_4_ATK;
                        break;
                    case 12:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name12);
                        DriveDisc.DMG_Bufs.ChaoticMetal chaoticMetalDMG = new DriveDisc.DMG_Bufs.ChaoticMetal();
                        DriveDisc.CritRate_Bufs.ChaoticMetal chaoticMetalCritRate = new DriveDisc.CritRate_Bufs.ChaoticMetal();
                        double DMG_Per_12 = chaoticMetalDMG.ChaoticMetal_2_DMG;
                        double CritRate_12 = chaoticMetalCritRate.ChaoticMetal_4_CritRate;
                        DriveDisc.CritDMG_Bufs.ChaoticMetal chaoticMetalCritDMG = new DriveDisc.CritDMG_Bufs.ChaoticMetal();
                        double CritDMG_12 = chaoticMetalCritDMG.ChaoticMetal_4_CritDMG;
                        break;
                    case 13:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name13);
                        DriveDisc.DMG_Bufs.InfernoMetal infernoMetalDMG = new DriveDisc.DMG_Bufs.InfernoMetal();
                        DriveDisc.CritRate_Bufs.InfernoMetal infernoMetalCritRate = new DriveDisc.CritRate_Bufs.InfernoMetal();
                        double DMG_Per_13 = infernoMetalDMG.InfernoMetal_2_DMG;
                        double CritRate_13 = infernoMetalCritRate.InfernoMetal_4_CritRate;
                        break;
                    case 14:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name14);
                        DriveDisc.DMG_Bufs.ProtoPunk protoPunkDMG = new DriveDisc.DMG_Bufs.ProtoPunk();
                        double DMG_Per_14 = protoPunkDMG.ProtoPunk_4_DMG;
                        break;
                    case 15:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name15);
                        DriveDisc.DMG_Bufs.ChaosJazz chaosJazzDMG = new DriveDisc.DMG_Bufs.ChaosJazz();
                        DriveDisc.AP_Bufs.ChaosJazz chaosJazzAP = new DriveDisc.AP_Bufs.ChaosJazz();
                        double DMG_Per_15_1 = chaosJazzDMG.ChaosJazz_4_DMG_1;
                        double DMG_Per_15_2 = chaosJazzDMG.ChaosJazz_4_DMG_2;
                        break;
                    case 16:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name16);
                        DriveDisc.DMG_Bufs.SwingJazz swingJazzDMG = new DriveDisc.DMG_Bufs.SwingJazz();
                        DriveDisc.EnergyRegen.SwingJazz swingJazzEnergyRegen = new DriveDisc.EnergyRegen.SwingJazz();
                        double DMG_Per_16 = swingJazzDMG.SwingJazz_4_DMG;
                        double EnergyRegen_16 = swingJazzEnergyRegen.SwingJazz_2_EnergyRegen;
                        break;
                    case 17:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name17);
                        DriveDisc.DEF.SoulRock soulRockDEF = new DriveDisc.DEF.SoulRock();
                        double DEF_17 = soulRockDEF.SoulRock_2_DEF;
                        break;
                    case 18:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name18);
                        DriveDisc.CombatATK_Bufs.HormonePunk hormonePunkATK = new DriveDisc.CombatATK_Bufs.HormonePunk();
                        DriveDisc.ATK_Bufs.HormonePunk hormonePunkATK2 = new DriveDisc.ATK_Bufs.HormonePunk();
                        double ATK_18 = hormonePunkATK.HormonePunk_2_ATK;
                        double ATK_18_4 = hormonePunkATK2.HormonePunk_4_ATK;
                        break;
                    case 19:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name19);
                        DriveDisc.AP_Bufs.FreedomBlues freedomBluesAP = new DriveDisc.AP_Bufs.FreedomBlues();
                        double AP_19 = freedomBluesAP.FreedomBlues_2_AP;
                        break;
                    case 20:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name20);
                        DriveDisc.Impact.ShockstarDisco shockstarDiscoImpact = new DriveDisc.Impact.ShockstarDisco();
                        double Impact_20 = shockstarDiscoImpact.ShockstarDisco_2_Impact;
                        break;
                    case 21:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name21);
                        DriveDisc.Pen_Buff.PufferElectro pufferElectroPen = new DriveDisc.Pen_Buff.PufferElectro();
                        DriveDisc.DMG_Bufs.PufferElectro pufferElectroDMG = new DriveDisc.DMG_Bufs.PufferElectro();
                        DriveDisc.ATK_Bufs.PufferElectro pufferElectroATK = new DriveDisc.ATK_Bufs.PufferElectro();
                        double PEN_21 = pufferElectroPen.PufferElectro_2_Pen;
                        double DMG_21 = pufferElectroDMG.PufferElectro_4_DMG;
                        double ATK_21 = pufferElectroATK.PufferElectro_4_ATK;
                        break;
                    case 22:
                        Console.WriteLine("Выбранный вами сет" + selectedSet.name22);
                        DriveDisc.CritRate_Bufs.WoodpeckerElectro woodpeckerElectroCritRate = new DriveDisc.CritRate_Bufs.WoodpeckerElectro();
                        DriveDisc.ATK_Bufs.WoodpeckerElectro woodpeckerElectroATK = new DriveDisc.ATK_Bufs.WoodpeckerElectro();
                        double CritRate_22 = woodpeckerElectroCritRate.WoodpeckerElectro_2_CritRate;
                        double ATK_22 = woodpeckerElectroATK.WoodpeckerElectro_4_ATK[0];
                        break;
                }
            }
            /*double DMG;
            double BaseDMG;
            double DMG_Mod;
            double Crit_Mod;
            double RES_Mod;
            double DEF_Mod;
            double Stun_Mod;

            double Skill_MV;
            double Scaling_Stat;
            double Flat_MV;
            BaseDMG = Skill_MV * Scaling_Stat + Flat_MV;

            DMG_Per = DMG_Per_1;
            DMG_Mod = 1 + DMG_Per;

            double CritDamage;
            Crit_Mod = 1 + CritDamage;

            double Attribute_RES;
            double All_Type_RES;
            double RES_Reduction;
            double RES_PEN;
            RES_Mod = 1 - Attribute_RES - All_Type_RES + RES_Reduction + RES_PEN;

            double Target_Base_DEF;
            double DEF;
            double DEF_Reduction;
            double DEF_Ignore;
            Target_DEF = Target_Base_DEF * (1 + DEF - DEF_Reduction - DEF_Ignore);
            double Target_DEF;
            double PEN_Ratio;
            double Flat_PEN;
            Effective_DEF = Target_DEF * (1 - PEN_Ratio) - Flat_PEN;
            double Level_Coefficient;
            double Effective_DEF;
            DEF_Mod = Level_Coefficient / (Level_Coefficient + Effective_DEF);

            double Stun_Bonus;
            Stun_Mod = 1 + Stun_Bonus;

            DMG = BaseDMG * DMG_Mod * Crit_Mod * RES_Mod * DEF_Mod * Stun_Mod;

            Console.WriteLine("\nНажмите любую клаишу для выхода");
            Console.ReadKey();*/
        }
    }
}