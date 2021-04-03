using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpPlayerInfo : MonoBehaviour
{
    [Header("Main Properties")]
    public long clSkillPoints;
    public long clMelee;
    public long clRange;
    public long clAthletics;
    public long clSneak;

    [Header("Health Status")]
    public float cfHealth;
    public float cfHealthHead;
    public float cfHealthNeck;
    public float cfHealthChest;
    public float cfHealthLeftShoulder;
    public float cfHealthRightShoulder;
    public float cfHealthLeftArm;
    public float cfHealthRightArm;
    public float cfHealthForearmLeft;
    public float cfHealthForearmRight;
    public float cfHealthHandLeft;
    public float cfHealthHandRight;
    public float cfHealthThighRight;
    public float cfHealthThighLeft;
    public float cfHealthShinRight;
    public float cfHealthShinLeft;
    public float cfHealthFeetRight;
    public float cfHealthFeetLeft;

    void Update()
    {
        clSkillPoints = StaticPersonagem.plSkillPoints;
        clMelee = StaticPersonagem.plMelee;
        clRange = StaticPersonagem.plRange;
        clAthletics = StaticPersonagem.plAthletics;
        clSneak = StaticPersonagem.plSneak;

        cfHealth = StaticPersonagem.pfHealth;
        cfHealthHead = StaticPersonagem.pfHealthHead;
        cfHealthNeck = StaticPersonagem.pfHealthNeck;
        cfHealthChest = StaticPersonagem.pfHealthChest;
        cfHealthLeftShoulder = StaticPersonagem.pfHealthLeftShoulder;
        cfHealthRightShoulder = StaticPersonagem.pfHealthRightShoulder;
        cfHealthLeftArm = StaticPersonagem.pfHealthLeftArm;
        cfHealthRightArm = StaticPersonagem.pfHealthRightArm;
        cfHealthForearmLeft = StaticPersonagem.pfHealthForearmLeft;
        cfHealthForearmRight = StaticPersonagem.pfHealthForearmRight;
        cfHealthHandLeft = StaticPersonagem.pfHealthHandLeft;
        cfHealthHandRight = StaticPersonagem.pfHealthHandRight;
        cfHealthThighRight = StaticPersonagem.pfHealthThighRight;
        cfHealthThighLeft = StaticPersonagem.pfHealthThighLeft;
        cfHealthShinRight = StaticPersonagem.pfHealthShinRight;
        cfHealthShinLeft = StaticPersonagem.pfHealthShinLeft;
        cfHealthFeetRight = StaticPersonagem.pfHealthFeetRight;
        cfHealthFeetLeft = StaticPersonagem.pfHealthFeetLeft;

        metHealthCalculation();
    }

    private void metHealthCalculation()
    {
        float lfHealthDamage = 0;

        lfHealthDamage += metOveralDamageCalculation(cfHealthHead, 1.4f, 2.3f, 3, 7, 25, 50);
        lfHealthDamage += metOveralDamageCalculation(cfHealthNeck, 1.4f, 2.3f, 3, 7, 25, 50);
        lfHealthDamage += metOveralDamageCalculation(cfHealthChest, 1.4f, 2.3f, 3, 6, 25, 45);
        lfHealthDamage += metOveralDamageCalculation(cfHealthLeftShoulder, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthRightShoulder, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthLeftArm, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthRightArm, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthForearmLeft, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthForearmRight, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthHandLeft, 1.4f, 2.3f, 3, 5, 18, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthHandRight, 1.4f, 2.3f, 3, 5, 18, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthThighRight, 1.4f, 2.3f, 3, 7, 25, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthThighLeft, 1.4f, 2.3f, 3, 7, 25, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthShinRight, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthShinLeft, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthFeetRight, 1.4f, 2.3f, 3, 5, 18, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthFeetLeft, 1.4f, 2.3f, 3, 5, 18, 62);

        cfHealth = 100 - lfHealthDamage;

        StaticPersonagem.pfHealth = cfHealth;
    }

    private float metOveralDamageCalculation(float parfBodyPartHealth, float parfScratches, float parfSuperficialInjury, float parfModerateInjury, float parfInjury, float parfSeriousInjury, float parfVerySeriousInjury)
    {
        switch (parfBodyPartHealth)
        {
            case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfVerySeriousInjury):
                return parfVerySeriousInjury;
            case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfSeriousInjury):
                return parfSeriousInjury;
            case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfInjury):
                return parfInjury;
            case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfModerateInjury):
                return parfModerateInjury;
            case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfSuperficialInjury):
                return parfSuperficialInjury;
            case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfScratches):
                return parfScratches;
        }
        return 0;
    }
}
