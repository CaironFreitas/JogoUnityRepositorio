using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpClickActionButton : MonoBehaviour
{
    [Header("Identification codes")]
    public long plActionCode;
    public long plActionType;

    [Header("General scripts")]
    public scpEnemyInfo pscpEnemyInfo;

    private ScpEscreveAcoes pscpEscreveAcoes;
    private scpEnemyActions pscpEnemyAction;
    private scpPlayerActions pscpPlayerActions;

    private void Start()
    {
        pscpEscreveAcoes  = GameObject.Find("ContentHistoric").GetComponent<ScpEscreveAcoes>();
        pscpPlayerActions = new scpPlayerActions();
        pscpEnemyAction = new scpEnemyActions();

        pscpPlayerActions.pscpEscreveAcoes = pscpEscreveAcoes;
        pscpPlayerActions.pscpEnemyInfo = pscpEnemyInfo;

        pscpEnemyAction.pscpEscreveAcoes = pscpEscreveAcoes;
        pscpEnemyAction.pscpEnemyInfo = pscpEnemyInfo;
    }

    public void metClickButton()
    {
        if (plActionType == 1)
        {
            switch (plActionCode)
            {
                case 0: //-- Melee Combat
                    pscpPlayerActions.metPlayerAction(plActionType, plActionCode);
                    pscpEnemyAction.metEnemyReaction(plActionType, plActionCode);
                    break;
                case 1: //-- Flee
                    pscpPlayerActions.metPlayerAction(plActionType, plActionCode);
                    pscpEnemyAction.metEnemyReaction(plActionType, plActionCode);
                    break;
                case 2: //-- Hide
                    pscpPlayerActions.metPlayerAction(plActionType, plActionCode);
                    pscpEnemyAction.metEnemyReaction(plActionType, plActionCode);
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
