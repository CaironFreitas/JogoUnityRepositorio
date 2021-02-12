using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scpAddDecPoints : MonoBehaviour
{
    public long plSkillPoints;
    public long plMeleePoints = 1;
    public long plRangePoints = 1;
    public long plAthleticsPoints = 1;
    public long plSneakPoints = 1;

    private void Start()
    {
        plSkillPoints = staticGameBusinessLogic.plStartSkillPoints;
    }

    private void metAddPoint(ref long parlSkillPoint)
    {
        if (plSkillPoints > 0 && plSkillPoints <= staticGameBusinessLogic.plStartSkillPoints)
        {
            parlSkillPoint++;
            plSkillPoints--;
        }
    }

    private void metDecPoint(ref long parlSkillPoint)
    {
        if (parlSkillPoint > 1)
        {
            parlSkillPoint--;
            plSkillPoints++;
        }
    }

    public void metStartGame()
    {
        StaticPersonagem.plMelee = plMeleePoints;
        StaticPersonagem.plRange = plRangePoints;
        StaticPersonagem.plAthletics = plAthleticsPoints;
        StaticPersonagem.plSneak = plSneakPoints;

        SceneManager.LoadScene("Gameplay");
    }

    public void metAddMelee()
    {
        metAddPoint(ref plMeleePoints);
    }

    public void metAddRange()
    {
        metAddPoint(ref plRangePoints);
    }

    public void metAddAthletics()
    {
        metAddPoint(ref plAthleticsPoints);
    }

    public void metAddSneak()
    {
        metAddPoint(ref plSneakPoints);
    }

    public void metDecMelee()
    {
        metDecPoint(ref plMeleePoints);
    }

    public void metDecRange()
    {
        metDecPoint(ref plRangePoints);
    }

    public void metDecAthletics()
    {
        metDecPoint(ref plAthleticsPoints);
    }

    public void metDecSneak()
    {
        metDecPoint(ref plSneakPoints);
    }
}
