using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpEnemyActions : MonoBehaviour
{
    [Header("General Scripts (Automatic set)")]
    public scpEnemyInfo pscpEnemyInfo;
    public ScpEscreveAcoes pscpEscreveAcoes;

    private scpSetRichText cscpSetRichText;

    public void Start()
    {
        cscpSetRichText = this.gameObject.AddComponent(typeof(scpSetRichText)) as scpSetRichText;
    }

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
        long llSkillDiffDamage = 2;
        long llEnemyMelee = pscpEnemyInfo.plMelee;
        long llPlayerMelee = StaticPersonagem.plMelee;

        long EnemyHitChance = ((llEnemyMelee - llPlayerMelee) * llSkillDiff) + llDefaultHitChance;

        long llChance = Random.Range(0, 100);

        string lsTextStart = cscpSetRichText.metFindText(2, 3);//-- Try to attack

        if (llChance <= EnemyHitChance)
        {
            int llBodyPart = Random.Range(1, 17);
            float lfDamage = Random.Range(0, 6) + (llEnemyMelee * llSkillDiffDamage);

            switch (llBodyPart)
            {

                case 1:
                    StaticPersonagem.pfHealthHead -= lfDamage;
                    break;
                case 2:
                    StaticPersonagem.pfHealthNeck -= lfDamage;
                    break;
                case 3:
                    StaticPersonagem.pfHealthChest -= lfDamage;
                    break;
                case 4:
                    StaticPersonagem.pfHealthLeftShoulder -= lfDamage;
                    break;
                case 5:
                    StaticPersonagem.pfHealthRightShoulder -= lfDamage;
                    break;
                case 6:
                    StaticPersonagem.pfHealthLeftArm -= lfDamage;
                    break;
                case 7:
                    StaticPersonagem.pfHealthRightArm -= lfDamage;
                    break;
                case 8:
                    StaticPersonagem.pfHealthForearmLeft -= lfDamage;
                    break;
                case 9:
                    StaticPersonagem.pfHealthForearmRight -= lfDamage;
                    break;
                case 10:
                    StaticPersonagem.pfHealthHandLeft -= lfDamage;
                    break;
                case 11:
                    StaticPersonagem.pfHealthHandRight -= lfDamage;
                    break;
                case 12:
                    StaticPersonagem.pfHealthThighRight -= lfDamage;
                    break;
                case 13:
                    StaticPersonagem.pfHealthThighLeft -= lfDamage;
                    break;
                case 14:
                    StaticPersonagem.pfHealthShinLeft -= lfDamage;
                    break;
                case 15:
                    StaticPersonagem.pfHealthShinRight -= lfDamage;
                    break;
                case 16:
                    StaticPersonagem.pfHealthFeetLeft -= lfDamage;
                    break;
                case 17:
                    StaticPersonagem.pfHealthFeetRight -= lfDamage;
                    break;
            }
            string lsTextAction = cscpSetRichText.metFindText(2, 1); //-- And hit
            string lsBodyPartName = cscpSetRichText.metFindText(1, llBodyPart);

            pscpEscreveAcoes.metDefaultText(pscpEnemyInfo.psName, lsTextStart + staticGameBusinessLogic.psRedColorBad + lsTextAction + lsBodyPartName + "</color>");
        }
        else
        {
            string lsTextAction = cscpSetRichText.metFindText(2, 2); //-- But miss
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
