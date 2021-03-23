using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpBattleCalculation : MonoBehaviour
{

    public bool metEnemyMeleeAttack(scpEnemyInfo parscpEnemyInfo, ref int parliBodyPart)
    {
        float llDefaultHitChance = staticGameBusinessLogic.pfMeleeDefaultHitChance;
        float llSkillDiff = staticGameBusinessLogic.pfMeleeSkillDiff;
        float llSkillDiffDamage = staticGameBusinessLogic.pfMeleeSkillDiffDamage;
        long llEnemyMelee = parscpEnemyInfo.plMelee;
        long llPlayerMelee = StaticPersonagem.plMelee;

        //-- Calculate hit chance using player and enemy melee skills
        float EnemyHitChance = ((llEnemyMelee - llPlayerMelee) * llSkillDiff) + llDefaultHitChance;

        long llChance = Random.Range(0, 100);

        if (llChance <= EnemyHitChance)
        {
            int liBodyPart = Random.Range(1, 18);
            parliBodyPart = liBodyPart;
            float lfDamage = Random.Range(0, 6) + (llEnemyMelee * llSkillDiffDamage);

            switch (liBodyPart)
            {

                case 1:
                    StaticPersonagem.pfHealthHead -= lfDamage;
                    break;
                case 2:
                    StaticPersonagem.pfHealthNeck -= lfDamage;
                    break;
                case 3:
                    StaticPersonagem.pfHealthChest -= lfDamage;
                    break;
                case 4:
                    StaticPersonagem.pfHealthLeftShoulder -= lfDamage;
                    break;
                case 5:
                    StaticPersonagem.pfHealthRightShoulder -= lfDamage;
                    break;
                case 6:
                    StaticPersonagem.pfHealthLeftArm -= lfDamage;
                    break;
                case 7:
                    StaticPersonagem.pfHealthRightArm -= lfDamage;
                    break;
                case 8:
                    StaticPersonagem.pfHealthForearmLeft -= lfDamage;
                    break;
                case 9:
                    StaticPersonagem.pfHealthForearmRight -= lfDamage;
                    break;
                case 10:
                    StaticPersonagem.pfHealthHandLeft -= lfDamage;
                    break;
                case 11:
                    StaticPersonagem.pfHealthHandRight -= lfDamage;
                    break;
                case 12:
                    StaticPersonagem.pfHealthThighRight -= lfDamage;
                    break;
                case 13:
                    StaticPersonagem.pfHealthThighLeft -= lfDamage;
                    break;
                case 14:
                    StaticPersonagem.pfHealthShinLeft -= lfDamage;
                    break;
                case 15:
                    StaticPersonagem.pfHealthShinRight -= lfDamage;
                    break;
                case 16:
                    StaticPersonagem.pfHealthFeetLeft -= lfDamage;
                    break;
                case 17:
                    StaticPersonagem.pfHealthFeetRight -= lfDamage;
                    break;
            }
            
            return true;
        }
        return false;
    }

    public bool metPlayerMeleeAttackHumanoid(scpEnemyInfo parscpEnemyInfo, ref int parliBodyPart)
    {
        float llDefaultHitChance = staticGameBusinessLogic.pfMeleeDefaultHitChance;
        float llSkillDiff = staticGameBusinessLogic.pfMeleeSkillDiff;
        float llSkillDiffDamage = staticGameBusinessLogic.pfMeleeSkillDiffDamage;
        long llEnemyMelee = parscpEnemyInfo.plMelee;
        long llPlayerMelee = StaticPersonagem.plMelee;

        //-- Calculate hit chance using player and enemy melee skills
        float llPlayerHitChance = ((llPlayerMelee - llEnemyMelee) * llSkillDiff) + llDefaultHitChance;

        long llChance = Random.Range(0, 100);

        if (llChance <= llPlayerHitChance)
        {
            int llBodyPart = Random.Range(1, 18);
            parliBodyPart = llBodyPart;
            float lfDamage = Random.Range(0, 6) + (llEnemyMelee * llSkillDiffDamage);

            switch (llBodyPart)
            {

                case 1:
                    parscpEnemyInfo.pfHealthHead -= lfDamage;
                    break;
                case 2:
                    parscpEnemyInfo.pfHealthNeck -= lfDamage;
                    break;
                case 3:
                    parscpEnemyInfo.pfHealthChest -= lfDamage;
                    break;
                case 4:
                    parscpEnemyInfo.pfHealthLeftShoulder -= lfDamage;
                    break;
                case 5:
                    parscpEnemyInfo.pfHealthRightShoulder -= lfDamage;
                    break;
                case 6:
                    parscpEnemyInfo.pfHealthLeftArm -= lfDamage;
                    break;
                case 7:
                    parscpEnemyInfo.pfHealthRightArm -= lfDamage;
                    break;
                case 8:
                    parscpEnemyInfo.pfHealthForearmLeft -= lfDamage;
                    break;
                case 9:
                    parscpEnemyInfo.pfHealthForearmRight -= lfDamage;
                    break;
                case 10:
                    parscpEnemyInfo.pfHealthHandLeft -= lfDamage;
                    break;
                case 11:
                    parscpEnemyInfo.pfHealthHandRight -= lfDamage;
                    break;
                case 12:
                    parscpEnemyInfo.pfHealthThighRight -= lfDamage;
                    break;
                case 13:
                    parscpEnemyInfo.pfHealthThighLeft -= lfDamage;
                    break;
                case 14:
                    parscpEnemyInfo.pfHealthShinLeft -= lfDamage;
                    break;
                case 15:
                    parscpEnemyInfo.pfHealthShinRight -= lfDamage;
                    break;
                case 16:
                    parscpEnemyInfo.pfHealthFeetLeft -= lfDamage;
                    break;
                case 17:
                    parscpEnemyInfo.pfHealthFeetRight -= lfDamage;
                    break;
            }
            return true;
        }
        return false;
    }
}