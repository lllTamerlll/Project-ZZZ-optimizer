//Crit damagers
double DMG;
double DMG_Average_Mod;

double ATK = 3678;
double ATK_astra_buff = 1200;
double ATK_BoomW_buff = 0.16;
double ATK_dash_buff = 0.12;
double ATK_Brimstone_buff = 0.28;

double Base_DMG;
double Skill_MV = 3.25;
double Scaling_Stat;
double Flat_MV = 1;

double DMG_per_Mod;
double DMG_per_anomaly = 0.4;
double DMG_per_dash = 0.15;
double DMG_per_AstraSet = 0.24;

double Crit_Mod;
double Crit_Damage = 1.22;

double Average_Mod;
double Crit_Rate = 0.63;
double Crit_Rate_Dash_Buff = 0.12;

double RES_Mod;
double Attribute_RES_per = 0.2;
double All_Type_RES_per = 0;
double RES_Reduction_per = 0;
double RES_PEN_per = 0;

double Target_DEF;
double Effective_DEF;
double DEF_Mod;
double Target_Base_DEF = 858;
double DEF_per = 0;
double DEF_Reduction_per = 0;
double DEF_Ignore_per = 0;
double Flat_DEF = 0;
double PEN_Ratio_per = 0.24;
double Flat_PEN = 27;
double Level_Coefficient = 794;

double Stun_Mod;
double Stun_Bonus_per = 2.3;

//double DMG_Taken;
//double ОЈDMG_Reduction_per = 0.2;
// ОЈDMG_Taken = 0.15;

Scaling_Stat = (ATK + ATK_astra_buff) * (1 + ATK_BoomW_buff) * (1 + ATK_dash_buff) * (1 + ATK_Brimstone_buff);
Base_DMG = Skill_MV * Scaling_Stat * Flat_MV;
DMG_per_Mod = 1 + DMG_per_anomaly + DMG_per_dash + DMG_per_AstraSet;
Crit_Mod = 1 + Crit_Damage;
Average_Mod = 1 + (Crit_Rate + Crit_Rate_Dash_Buff) * Crit_Mod;
RES_Mod = 1 - Attribute_RES_per - All_Type_RES_per + RES_Reduction_per + RES_PEN_per;
Target_DEF = Target_Base_DEF * (1 + DEF_per - DEF_Reduction_per - DEF_Ignore_per) + Flat_DEF;
Effective_DEF = Target_DEF * (1 - PEN_Ratio_per) - Flat_PEN;
DEF_Mod = Level_Coefficient / (Level_Coefficient + Effective_DEF);
Stun_Mod = 1 + Stun_Bonus_per;
//DMG_Taken = 1 - ОЈDMG_Reduction_per + ОЈDMG_Taken;

DMG = Base_DMG * DMG_per_Mod * Crit_Mod * RES_Mod * DEF_Mod * Stun_Mod; //*DMG_Taken;
DMG_Average_Mod = Base_DMG * DMG_per_Mod * Average_Mod * RES_Mod * DEF_Mod * Stun_Mod; //* DMG_Taken;


Console.WriteLine("ATK:" + Scaling_Stat);
Console.WriteLine("DMG:" + DMG);
Console.WriteLine("DMG_Average_Mod:" + DMG_Average_Mod);

//Sheer Damage
double Sheer_DMG;

double Sheer_DMG_Mod;
double ОЈSheer_DMG_per = 1;

Sheer_DMG_Mod = 1 + ОЈSheer_DMG_per;

Sheer_DMG = Base_DMG * DMG_per_Mod * Crit_Mod * RES_Mod * Stun_Mod * Sheer_DMG_Mod;//* DMG_Taken

Console.WriteLine("Sheer Damage:" + Sheer_DMG);

//Anomaly damagers
double Anomaly_DMG;

double Anomaly_per_Mod;
double ОЈAnomaly_DMG_per = 1;

double AP_Bonus;
double AP = 1;

double Buff_Level_Mod;
double Attacker_Level = 1;

Anomaly_per_Mod = 1 + ОЈAnomaly_DMG_per;

AP_Bonus = AP / 100;

Buff_Level_Mod = 1 + ((Attacker_Level - 1) / (59));

Anomaly_DMG = Base_DMG * DMG_per_Mod * Anomaly_per_Mod * RES_Mod * DEF_Mod * Stun_Mod * AP_Bonus * Buff_Level_Mod;//* DMG_Taken

Console.WriteLine("Anomaly damager" + Anomaly_DMG);

//Anomaly Buildup

double Buildup;

double Base_Buildup = 1;

double AM_Bonus;
double AM = 1;

double Anomaly_Buildup_Bonus_Mod;
double ОЈAnomaly_Buildup_Bonus_per = 1;

double Anomaly_Buildup_RES_Mod;

double Target_Anomaly_RES = 1;
double ОЈAnomaly_RES_Reduction = 1;

AM_Bonus = AM / 100;

Anomaly_Buildup_Bonus_Mod = 1 + ОЈAnomaly_Buildup_Bonus_per;

Anomaly_Buildup_RES_Mod = 1 - (Target_Anomaly_RES - ОЈAnomaly_RES_Reduction);

Buildup = Base_Buildup * Anomaly_Buildup_Bonus_Mod * Anomaly_Buildup_Bonus_Mod * Anomaly_Buildup_RES_Mod;

Console.WriteLine("Anomaly Buildup " + Buildup);