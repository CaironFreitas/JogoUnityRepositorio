using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpEnemyInfo : MonoBehaviour
{
    [Header("Map/position info")]
    public GameObject pobjCurrentEnemyTile;

    [Header("Main info")]
    public string psName;
    public long plMelee;
    public long plRange;
    public long plAthletics;
    public long plSneak;

    [Header("Health Status")]
    public float pfHealth;
    public float pfHealthHead;
    public float pfHealthNeck;
    public float pfHealthChest;
    public float pfHealthLeftShoulder;
    public float pfHealthRightShoulder;
    public float pfHealthLeftArm;
    public float pfHealthRightArm;
    public float pfHealthForearmLeft;
    public float pfHealthForearmRight;
    public float pfHealthHandLeft;
    public float pfHealthHandRight;
    public float pfHealthThighRight;
    public float pfHealthThighLeft;
    public float pfHealthShinRight;
    public float pfHealthShinLeft;
    public float pfHealthFeetRight;
    public float pfHealthFeetLeft;

    private void Start()
    {
        string lsEnemyTag = this.tag;

        switch (lsEnemyTag)
        {
            case "EnemyDefault":

                psName      = "Estranho";
                plMelee     = Random.Range(2, 6);
                plRange     = Random.Range(2, 6);
                plAthletics = Random.Range(2, 4);
                plSneak     = Random.Range(2, 3);

                pfHealth = metRandomHealthPropertie(95, 98, 100);
                pfHealthHead = metRandomHealthPropertie(95, 98, 100);
                pfHealthNeck = metRandomHealthPropertie(95, 98, 100);
                pfHealthChest = metRandomHealthPropertie(95, 98, 100);
                pfHealthLeftShoulder = metRandomHealthPropertie(95, 98, 100);
                pfHealthRightShoulder = metRandomHealthPropertie(95, 98, 100);
                pfHealthLeftArm = metRandomHealthPropertie(95, 98, 100);
                pfHealthRightArm = metRandomHealthPropertie(95, 98, 100);
                pfHealthForearmLeft = metRandomHealthPropertie(95, 98, 100);
                pfHealthForearmRight = metRandomHealthPropertie(95, 98, 100);
                pfHealthHandLeft = metRandomHealthPropertie(95, 98, 100);
                pfHealthHandRight = metRandomHealthPropertie(95, 98, 100);
                pfHealthThighRight = metRandomHealthPropertie(95, 98, 100);
                pfHealthThighLeft = metRandomHealthPropertie(95, 98, 100);
                pfHealthShinRight = metRandomHealthPropertie(95, 98, 100);
                pfHealthShinLeft = metRandomHealthPropertie(95, 98, 100);
                pfHealthFeetRight = metRandomHealthPropertie(95, 98, 100);
                pfHealthFeetLeft = metRandomHealthPropertie(95, 98, 100);

                break;
        }
    }

    private void Update()
    {
        metHealthCalculation();
    }

    private float metRandomHealthPropertie(int pariUnhurtChance, int pariSlightlyinjuredChance, int pariHurtChance)
    {
        int llBodyPartHeathChance = Random.Range(0, 100);
        switch (llBodyPartHeathChance)
        {
            case int llChance when (llChance <= pariUnhurtChance):
                return 100f;
            case int llChance when (llChance <= pariSlightlyinjuredChance):
                return Random.Range(80, 99);
            case int llChance when (llChance <= pariHurtChance):
                return Random.Range(50, 80);
        }

        return 100;
    }

    private void metHealthCalculation()
    {
        float lfHealthDamage = 0;

        lfHealthDamage += metOveralDamageCalculation(pfHealthHead, 1.4f, 2.3f, 3, 7, 25, 50);
        lfHealthDamage += metOveralDamageCalculation(pfHealthNeck, 1.4f, 2.3f, 3, 7, 25, 50);
        lfHealthDamage += metOveralDamageCalculation(pfHealthChest, 1.4f, 2.3f, 3, 6, 25, 45);
        lfHealthDamage += metOveralDamageCalculation(pfHealthLeftShoulder, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthRightShoulder, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthLeftArm, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthRightArm, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthForearmLeft, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthForearmRight, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthHandLeft, 1.4f, 2.3f, 3, 5, 18, 30);
        lfHealthDamage += metOveralDamageCalculation(pfHealthHandRight, 1.4f, 2.3f, 3, 5, 18, 30);
        lfHealthDamage += metOveralDamageCalculation(pfHealthThighRight, 1.4f, 2.3f, 3, 7, 25, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthThighLeft, 1.4f, 2.3f, 3, 7, 25, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthShinRight, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthShinLeft, 1.4f, 2.3f, 3, 6, 20, 40);
        lfHealthDamage += metOveralDamageCalculation(pfHealthFeetRight, 1.4f, 2.3f, 3, 5, 18, 30);
        lfHealthDamage += metOveralDamageCalculation(pfHealthFeetLeft, 1.4f, 2.3f, 3, 5, 18, 62);

        pfHealth = 100 - lfHealthDamage;
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
