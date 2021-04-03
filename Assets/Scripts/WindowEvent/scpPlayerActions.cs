﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpPlayerActions : MonoBehaviour
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

    public void metPlayerAction(long pariActionType, long pariActionCode)
    {
        if (pariActionType == 1)
        {
            switch (pariActionCode)
            {
                case 0: //-- Player try to hit
                    metMeleeCombat();
                    break;
                case 1: //-- Player try to flee
                    metFlee();
                    break;
                case 2: //-- Player try to hide
                    metHide();
                    break;
            }
        }
    }

    public void metMeleeCombat()
    {
        //-- Player info for log fill
        string lsTextStart = cscpSetRichText.metFindText(2, 3);
        string lsTextName = cscpSetRichText.metFindText(3, 1);

        //-- Attack mechanics and log fill
        int liBodyPart = 0;
        string lsTextAction = "";
        string lsBodyPartName = "";

        if (cscpBattleCalculation.metPlayerMeleeAttackHumanoid(pscpEnemyInfo, ref liBodyPart))
        {
            lsTextAction = cscpSetRichText.metFindText(2, 1);
            lsBodyPartName = cscpSetRichText.metFindText(1, liBodyPart);
            pscpEscreveAcoes.metDefaultText(lsTextName, lsTextStart + staticGameBusinessLogic.psGreenColorGood + lsTextAction + lsBodyPartName + "</color>"); //-- Log - and hit 
        }
        else
        {
            lsTextAction = cscpSetRichText.metFindText(2, 2);
            pscpEscreveAcoes.metDefaultText(lsTextName, lsTextStart + lsTextAction); //-- Log - But missed
        }
    }

    public void metFlee()
    {
        long llDefaultFleeChance = 50;
        long llSkillDiff = 5;
        long llEnemyAthletics = pscpEnemyInfo.plAthletics;
        long llPlayerAthletics = StaticPersonagem.plAthletics;

        long llPlayerFleeChance = ((llPlayerAthletics - llEnemyAthletics) * llSkillDiff) + llDefaultFleeChance;

        long llChance = Random.Range(0, 100);

        if (llChance <= llPlayerFleeChance)
        {
            pscpEscreveAcoes.metDefaultText("You", "Conseguiu fugir");
        }
        else
        {
            pscpEscreveAcoes.metDefaultText("You", "Não conseguiu fugir");
        }
    }

    public void metHide()
    {
        long llDefaultHideChance = 10;
        long llSkillDiff = 5;
        long llEnemyHide = pscpEnemyInfo.plSneak;
        long llPlayerHide = StaticPersonagem.plSneak;

        long llPlayerHideChance = ((llPlayerHide - llEnemyHide) * llSkillDiff) + llDefaultHideChance;

        long llChance = Random.Range(0, 100);

        if (llChance <= llPlayerHideChance)
        {
            pscpEscreveAcoes.metDefaultText("You", "Se escondeu");
        }
        else
        {
            pscpEscreveAcoes.metDefaultText("You", "Foi visto tentando se esconder");
        }
    }
}