using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpClickActionButton : MonoBehaviour
{
    public long plActionCode;
    public long plActionType;
    public scpEnemyInfo pscpEnemyInfo;

    private ScpEscreveAcoes pscpEscreveAcoes;

    private void Start()
    {
        pscpEscreveAcoes = GameObject.Find("ContentHistoric").GetComponent<ScpEscreveAcoes>();
    }

    public void metClickButton()
    {
        if (plActionType == 1)
        {
            switch (plActionCode)
            {
                case 0: //-- Melee Combat
                    metMeleeCombat();
                    break;
                case 1: //-- Flee
                    metFlee();
                    break;
                case 2: //-- Hide
                    metHide();
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

    private void metMeleeCombat()
    {
        long llDefaultHitChance = 70; 
        long llSkillDiff = 3; 
        long llEnemyMelee = pscpEnemyInfo.plMelee;
        long llPlayerMelee = StaticPersonagem.plMelee;

        long llPlayerHitChance = ((llPlayerMelee - llEnemyMelee) * llSkillDiff) + llDefaultHitChance;
        Debug.Log(llPlayerHitChance + "% hit chance");

        long llChance = Random.Range(0, 100);

        if (llChance <= llPlayerHitChance)
        {
            pscpEscreveAcoes.metDefaultText("You", "Acerta o estranho");
        }
        else
        {
            pscpEscreveAcoes.metDefaultText("You", "Erra o ataque");
        }
    }

    private void metFlee()
    {
        long llDefaultFleeChance = 50;
        long llSkillDiff = 5;
        long llEnemyAthletics = pscpEnemyInfo.plAthletics;
        long llPlayerAthletics = StaticPersonagem.plAthletics;

        long llPlayerFleeChance = ((llPlayerAthletics - llEnemyAthletics) * llSkillDiff) + llDefaultFleeChance;
        Debug.Log(llPlayerFleeChance + "% flee chance");

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

    private void metHide()
    {
        long llDefaultHideChance = 10;
        long llSkillDiff = 5;
        long llEnemyHide = pscpEnemyInfo.plSneak;
        long llPlayerHide = StaticPersonagem.plSneak;

        long llPlayerHideChance = ((llPlayerHide - llEnemyHide) * llSkillDiff) + llDefaultHideChance;
        Debug.Log(llPlayerHideChance + "% hide chance");

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
