using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpClickActionButton : MonoBehaviour
{
    public long plActionCode;
    public long plActionType;
    public scpEnemyInfo pscpEnemyInfo;

    private ScpEscreveAcoes pscpEscreveAcoes;
    private scpPlayerActions pscpPlayerActions;

    private void Start()
    {
        pscpEscreveAcoes  = GameObject.Find("ContentHistoric").GetComponent<ScpEscreveAcoes>();
        pscpPlayerActions = this.GetComponent<scpPlayerActions>();

        pscpPlayerActions.pscpEscreveAcoes = pscpEscreveAcoes;
        pscpPlayerActions.pscpEnemyInfo = pscpEnemyInfo;
    }

    public void metClickButton()
    {
        if (plActionType == 1)
        {
            switch (plActionCode)
            {
                case 0: //-- Melee Combat
                    pscpPlayerActions.metMeleeCombat();
                    break;
                case 1: //-- Flee
                    pscpPlayerActions.metFlee();
                    break;
                case 2: //-- Hide
                    pscpPlayerActions.metHide();
                    break;
            }   
        }

        /*if (plActionType == 2)
        {
            switch (plActionCode)
            {
            }
        }*/
    }
}
