using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpEnemyActions : MonoBehaviour
{
    [Header("General Scripts (Automatic set)")]
    public scpEnemyInfo pscpEnemyInfo;
    public ScpEscreveAcoes pscpEscreveAcoes;

    private scpSetRichText cscpSetRichText;
    private scpBattleCalculation cscpBattleCalculation;

    public void Start()
    {
        cscpSetRichText = this.gameObject.AddComponent(typeof(scpSetRichText)) as scpSetRichText;
        cscpBattleCalculation = this.gameObject.AddComponent(typeof(scpBattleCalculation)) as scpBattleCalculation;
    }

    public void metEnemyReaction(long pariActionType, long pariActionCode)
    {
        switch (pariActionType)
        {
            case 1:
                switch (pariActionCode)
                {
                    case 0: //-- Player tried to hit
                        metMeleeCombat();
                        break;
                    case 1: //-- Player tried to flee
                        metMeleeCombat();
                        break;
                    case 2: //-- Player tried to hide
                        metMeleeCombat();
                        break;
                }
                break;

            case 2:
                switch (pariActionCode)
                {
                    case 0: //-- Player tried to sneak
                        metMeleeCombat();
                        break;
                    case 1: //-- Player tried to walk
                        metMeleeCombat();
                        break;
                    case 2: //-- Player tried to run
                        metMeleeCombat();
                        break;
                }
                break;
        }
    }

    public void metMeleeCombat()
    {
        //-- Text introduction
        string lsTextStart = cscpSetRichText.metFindText(2, 3);//-- Log - Try to attack

        //-- Attack mechanics and log fill
        int llBodyPart = 0;
        string lsTextAction = "";
        string lsBodyPartName = "";

        if (cscpBattleCalculation.metEnemyMeleeAttack(pscpEnemyInfo, ref llBodyPart)) {
            lsTextAction = cscpSetRichText.metFindText(2, 1); //-- Log - And hit
            lsBodyPartName = cscpSetRichText.metFindText(1, llBodyPart);
            pscpEscreveAcoes.metDefaultText(pscpEnemyInfo.psName, lsTextStart + staticGameBusinessLogic.psRedColorBad + lsTextAction + lsBodyPartName + "</color>");
        }
        else
        {
            lsTextAction = cscpSetRichText.metFindText(2, 4); //-- Log - But miss
            pscpEscreveAcoes.metDefaultText(pscpEnemyInfo.psName, lsTextStart + lsTextAction);
        }
    }

    public void metFlee()
    {
        long llDefaultFleeChance = 50;
        long llSkillDiff = 5;
        long llEnemyAthletics = pscpEnemyInfo.plAthletics;
        long llPlayerAthletics = StaticPersonagem.plAthletics;

        long llEnemyFleeChance = ((llEnemyAthletics - llPlayerAthletics) * llSkillDiff) + llDefaultFleeChance;

        long llChance = Random.Range(0, 100);

        if (llChance <= llEnemyFleeChance)
        {
            pscpEscreveAcoes.metDefaultText(pscpEnemyInfo.psName, "Conseguiu fugir");
        }
        else
        {
            pscpEscreveAcoes.metDefaultText(pscpEnemyInfo.psName, "Não conseguiu fugir");
        }
    }

    public void metHide()
    {
        long llDefaultHideChance = 10;
        long llSkillDiff = 5;
        long llEnemyHide = pscpEnemyInfo.plSneak;
        long llPlayerHide = StaticPersonagem.plSneak;

        long llEnemyHideChance = ((llEnemyHide - llPlayerHide) * llSkillDiff) + llDefaultHideChance;

        long llChance = Random.Range(0, 100);

        if (llChance <= llEnemyHideChance)
        {
            pscpEscreveAcoes.metDefaultText(pscpEnemyInfo.psName, "Se afastou e se escondeu rápidamente");
        }
        else
        {
            pscpEscreveAcoes.metDefaultText(pscpEnemyInfo.psName, "Tentou se esconder mas você o encontrou");
        }
    }
}
