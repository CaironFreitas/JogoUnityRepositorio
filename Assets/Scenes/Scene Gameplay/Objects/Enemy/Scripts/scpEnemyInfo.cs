using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpEnemyInfo : MonoBehaviour
{
    public long plMeleeCombat;
    public int[] piCombatOptions;
    public int[] piDialogueOptions;

    private void Start()
    {
        string lsEnemyTag = this.tag;

        switch (lsEnemyTag)
        {
            case "EnemyDefault":
                plMeleeCombat = Random.Range(2, 6);
                piCombatOptions = new int[3] {0, 1, 2};
                piDialogueOptions = new int[0];
                break;
        }
    }
}
