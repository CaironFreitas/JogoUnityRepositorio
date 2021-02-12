using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpPlayerActions : MonoBehaviour
{
    [Header("General Scripts (Automatic set)")]
    public scpEnemyInfo pscpEnemyInfo;
    public ScpEscreveAcoes pscpEscreveAcoes;
    
    private scpSetRichText cscpSetRichText;

    public void Start()
    {
        cscpSetRichText = this.gameObject.AddComponent(typeof(scpSetRichText)) as scpSetRichText;
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
        long llDefaultHitChance = 70;
        long llSkillDiff = 3;
        long llSkillDiffDamage = 2;
        long llEnemyMelee = pscpEnemyInfo.plMelee;
        long llPlayerMelee = StaticPersonagem.plMelee;

        long llPlayerHitChance = ((llPlayerMelee - llEnemyMelee) * llSkillDiff) + llDefaultHitChance;

        long llChance = Random.Range(0, 100);

        string lsTextStart = cscpSetRichText.metFindText(2, 3);
        string lsTextName = cscpSetRichText.metFindText(3, 1);

        if (llChance <= llPlayerHitChance)
        {
            int llBodyPart = Random.Range(1, 17);
            float lfDamage = Random.Range(0, 6) + (llEnemyMelee * llSkillDiffDamage);

            switch (llBodyPart)
            {

                case 1:
                    pscpEnemyInfo.pfHealthHead -= lfDamage;
                    break;
                case 2:
                    pscpEnemyInfo.pfHealthNeck -= lfDamage;
                    break;
                case 3:
                    pscpEnemyInfo.pfHealthChest -= lfDamage;
                    break;
                case 4:
                    pscpEnemyInfo.pfHealthLeftShoulder -= lfDamage;
                    break;
                case 5:
                    pscpEnemyInfo.pfHealthRightShoulder -= lfDamage;
                    break;
                case 6:
                    pscpEnemyInfo.pfHealthLeftArm -= lfDamage;
                    break;
                case 7:
                    pscpEnemyInfo.pfHealthRightArm -= lfDamage;
                    break;
                case 8:
                    pscpEnemyInfo.pfHealthForearmLeft -= lfDamage;
                    break;
                case 9:
                    pscpEnemyInfo.pfHealthForearmRight -= lfDamage;
                    break;
                case 10:
                    pscpEnemyInfo.pfHealthHandLeft -= lfDamage;
                    break;
                case 11:
                    pscpEnemyInfo.pfHealthHandRight -= lfDamage;
                    break;
                case 12:
                    pscpEnemyInfo.pfHealthThighRight -= lfDamage;
                    break;
                case 13:
                    pscpEnemyInfo.pfHealthThighLeft -= lfDamage;
                    break;
                case 14:
                    pscpEnemyInfo.pfHealthShinLeft -= lfDamage;
                    break;
                case 15:
                    pscpEnemyInfo.pfHealthShinRight -= lfDamage;
                    break;
                case 16:
                    pscpEnemyInfo.pfHealthFeetLeft -= lfDamage;
                    break;
                case 17:
                    pscpEnemyInfo.pfHealthFeetRight -= lfDamage;
                    break;
            }
            string lsTextAction = cscpSetRichText.metFindText(2, 1);
            string lsBodyPartName = cscpSetRichText.metFindText(1, llBodyPart);

            pscpEscreveAcoes.metDefaultText(lsTextName, lsTextStart + staticGameBusinessLogic.psGreenColorGood + lsTextAction + lsBodyPartName + "</color>"); //-- and hit 
        }
        else
        {
            string lsTextAction = cscpSetRichText.metFindText(2, 2);
            pscpEscreveAcoes.metDefaultText(lsTextName, lsTextStart + lsTextAction); //-- But missed
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
