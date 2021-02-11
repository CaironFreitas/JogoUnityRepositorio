using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpEnemyInfo : MonoBehaviour
{
    [Header("Main Properties")]
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

    [Header("Possible event options")]
    public int[] piCombatOptions;
    public int[] piDialogueOptions;

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

                piCombatOptions = new int[3] {0, 1, 2};
                piDialogueOptions = new int[0];
                break;
        }
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
}
