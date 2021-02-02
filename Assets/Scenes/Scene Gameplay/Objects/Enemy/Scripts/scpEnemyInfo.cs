using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpEnemyInfo : MonoBehaviour
{
    public long plMelee;
    public long plRange;
    public long plAthletics;
    public long plSneak;
    public string psName;
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

                piCombatOptions = new int[3] {0, 1, 2};
                piDialogueOptions = new int[0];
                break;
        }
    }
}
