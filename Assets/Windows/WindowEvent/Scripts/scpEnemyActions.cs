using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpEnemyActions : MonoBehaviour
{
    [Header("General Scripts (Automatic set)")]
    public scpEnemyInfo pscpEnemyInfo;
    public ScpEscreveAcoes pscpEscreveAcoes;

    public void metEnemyReaction(long pariActionType, long pariActionCode)
    {
        if (pariActionType == 1)
        {
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
        }
    }

    public void metMeleeCombat()
    {
        long llDefaultHitChance = 70;
        long llSkillDiff = 3;
        long llEnemyMelee = pscpEnemyInfo.plMelee;
        long llPlayerMelee = StaticPersonagem.plMelee;

        long EnemyHitChance = ((llEnemyMelee - llPlayerMelee) * llSkillDiff) + llDefaultHitChance;
        Debug.Log(EnemyHitChance + "% enemy hit chance");

        long llChance = Random.Range(0, 100);

        if (llChance <= EnemyHitChance)
        {
            pscpEscreveAcoes.metDefaultText(pscpEnemyInfo.psName, "Chutou sua perna");
        }
        else
        {
            pscpEscreveAcoes.metDefaultText(pscpEnemyInfo.psName, "Errou o ataque");
        }
    }

    public void metFlee()
    {
        long llDefaultFleeChance = 50;
        long llSkillDiff = 5;
        long llEnemyAthletics = pscpEnemyInfo.plAthletics;
        long llPlayerAthletics = StaticPersonagem.plAthletics;

        long llEnemyFleeChance = ((llEnemyAthletics - llPlayerAthletics) * llSkillDiff) + llDefaultFleeChance;
        Debug.Log(llEnemyFleeChance + "% enemy flee chance");

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
        Debug.Log(llEnemyHideChance + "% enemy hide chance");

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
