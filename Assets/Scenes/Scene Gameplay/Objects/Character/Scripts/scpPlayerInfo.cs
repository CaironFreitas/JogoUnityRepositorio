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

        lfHealthDamage += metOveralDamageCalculation(cfHealthHead, 3, 15, 30, 50);
        lfHealthDamage += metOveralDamageCalculation(cfHealthNeck, 3, 15, 40, 60);
        lfHealthDamage += metOveralDamageCalculation(cfHealthChest, 3, 12, 25, 45);
        lfHealthDamage += metOveralDamageCalculation(cfHealthLeftShoulder, 3, 10, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthRightShoulder, 3, 10, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(cfHealthLeftArm, 3, 10, 20, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthRightArm, 3, 10, 20, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthForearmLeft, 3, 10, 20, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthForearmRight, 3, 10, 20, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthHandLeft, 3, 10, 20, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthHandRight, 3, 10, 20, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthThighRight, 3, 12, 25, 45);
        lfHealthDamage += metOveralDamageCalculation(cfHealthThighLeft, 3, 12, 25, 45);
        lfHealthDamage += metOveralDamageCalculation(cfHealthShinRight, 3, 10, 20, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthShinLeft, 3, 10, 20, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthFeetRight, 3, 10, 20, 30);
        lfHealthDamage += metOveralDamageCalculation(cfHealthFeetLeft, 3, 10, 20, 30);

        cfHealth = 100 - lfHealthDamage;

        StaticPersonagem.pfHealth = cfHealth;
    }

    private float metOveralDamageCalculation(float parfBodyPartHealth, float parfSlightlyinjured, float parfInjured, float parfSeverelyinjured, float parfAlmostDeadBodyPart)
    {
        switch (parfBodyPartHealth)
        {
            case float lfHealth when (lfHealth <= 25):
                return parfAlmostDeadBodyPart * -1;
            case float lfHealth when (lfHealth <= 50):
                return parfSeverelyinjured * -1;
            case float lfHealth when (lfHealth <= 75):
                return parfInjured * -1;
            case float lfHealth when (lfHealth <= 100):
                return parfSlightlyinjured * -1;
        }

        return 0;
    }
}
