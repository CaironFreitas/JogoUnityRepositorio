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
    private scpSetRichText cscpSetRichText;

    private void Start()
    {
        pscpEscreveAcoes  = GameObject.Find("ContentHistoric").GetComponent<ScpEscreveAcoes>();
        pscpPlayerActions = this.gameObject.AddComponent(typeof(scpPlayerActions)) as scpPlayerActions;
        pscpEnemyAction = this.gameObject.AddComponent(typeof(scpEnemyActions)) as scpEnemyActions;
        cscpSetRichText = this.gameObject.AddComponent(typeof(scpSetRichText)) as scpSetRichText;

        pscpPlayerActions.pscpEscreveAcoes = pscpEscreveAcoes;
        pscpPlayerActions.pscpEnemyInfo = pscpEnemyInfo;

        pscpEnemyAction.pscpEscreveAcoes = pscpEscreveAcoes;
        pscpEnemyAction.pscpEnemyInfo = pscpEnemyInfo;
    }

    public void metClickButton()
    {
        pscpPlayerActions.metPlayerAction(plActionType, plActionCode);
        pscpEnemyAction.metEnemyReaction(plActionType, plActionCode);

        pscpEscreveAcoes.plRoundCount++;
        pscpEscreveAcoes.metDefaultText(staticGameBusinessLogic.psOrangeInformation + "(Round " + pscpEscreveAcoes.plRoundCount + " " + cscpSetRichText.metFindText(4, 1) + ")</color>");
    }
}
