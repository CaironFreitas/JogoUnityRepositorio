using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpSetRichText : MonoBehaviour
{
    private bool cbLinguaPortugues;
    private bool cbLinguaIngles;

    public string metFindText(int pariLanguageGroup, int pariLanguageCode)
    {
        cbLinguaPortugues = (PlayerPrefs.GetString("Idioma") == "Portugues");
        cbLinguaIngles = (PlayerPrefs.GetString("Idioma") == "English");

        switch (pariLanguageGroup)
        {
            case 1:
                return metMeleeHit(pariLanguageCode);
            case 2:
                return metCombatText(pariLanguageCode);
            case 3:
                return metPlayerText(pariLanguageCode);
            case 4:
                return metRoundInfo(pariLanguageCode);
            case 5:
                return metBodyPart(pariLanguageCode);
            case 6:
                return metBodyPartInjure(pariLanguageCode);
        }

        return "ERRO";
    }

    private string metSetText(string partxTextoPortugues, string partxTextoIngles)
    {
        if (cbLinguaPortugues) { return partxTextoPortugues; }
        if (cbLinguaIngles) { return partxTextoIngles; }
        return "";
    }

    //-- Group 1
    private string metMeleeHit(int pariLanguageCode) { 
        switch (pariLanguageCode)
        {
            case 1:
                return metSetText("a cabeça", "the head");
            case 2:
                return metSetText("o pescoço", "the neck");
            case 3:
                return metSetText("o peito", "the chest");
            case 4:
                return metSetText("o ombro esquerdo", "the left shoulder");
            case 5:
                return metSetText("o ombro direito", "the right shoulder");
            case 6:
                return metSetText("o braço esquerdo", "the left arm");
            case 7:
                return metSetText("o braço direito", "the right arm");
            case 8:
                return metSetText("o antebraço esquerdo", "the left forearm");
            case 9:
                return metSetText("o antebraço direito", "the right forearm");
            case 10:
                return metSetText("a mão esquerda", "the left hand");
            case 11:
                return metSetText("a mão direita", "the right hand");
            case 12:
                return metSetText("a coxa direita", "the right thigh");
            case 13:
                return metSetText("a coxa esquerda", "the left thigh");
            case 14:
                return metSetText("a canela esquerda", "the left shin");
            case 15:
                return metSetText("a canela direita", "the right shin");
            case 16:
                return metSetText("o pé esquerdo", "the left feet");
            case 17:
                return metSetText("o pé direito", "the right feet");
            default:
                return "ERROR";
        }
    }

    //-- Group 2
    private string metCombatText(int pariLanguageCode)
    {
        switch (pariLanguageCode)
        {
            case 1:
                return metSetText("E acertou ", "And hit ");
            case 2:
                return metSetText("Mas o inimigo se esquivou ", "But the enemy missed");
            case 3:
                return metSetText("Tentou atacar! ", "Tried to attack! ");
            case 4:
                return metSetText("Mas você se esquivou ", "But you missed");

            default:
                return "ERROR";

        }
    }

    //-- Group 3
    private string metPlayerText(int pariLanguageCode)
    {
        switch (pariLanguageCode)
        {
            case 1:
                return metSetText("Você", "You");
            default:
                return "ERROR";

        }
    }

    //-- Group 4
    private string metRoundInfo(int pariLanguageCode)
    {
        switch (pariLanguageCode)
        {
            case 1:
                return metSetText("concluído", "finished");
            default:
                return "ERROR";

        }
    }

    //-- Group 5
    private string metBodyPart(int pariLanguageCode)
    {
        switch (pariLanguageCode)
        {
            case 1:
                return metSetText("Cabeça", "Head");
            case 2:
                return metSetText("Pescoço", "Neck");
            case 3:
                return metSetText("Peito", "Chest");
            case 4:
                return metSetText("Ombro esquerdo", "Left shoulder");
            case 5:
                return metSetText("Ombro direito", "Right shoulder");
            case 6:
                return metSetText("Braço esquerdo", "Left arm");
            case 7:
                return metSetText("Braço direito", "Right arm");
            case 8:
                return metSetText("Antebraço esquerdo", "Left forearm");
            case 9:
                return metSetText("Antebraço direito", "Right forearm");
            case 10:
                return metSetText("Mão esquerda", "Left hand");
            case 11:
                return metSetText("Mão direita", "Right hand");
            case 12:
                return metSetText("Coxa direita", "Right thigh");
            case 13:
                return metSetText("Coxa esquerda", "Left thigh");
            case 14:
                return metSetText("Canela esquerda", "Left shin");
            case 15:
                return metSetText("Canela direita", "Right shin");
            case 16:
                return metSetText("Pé esquerdo", "Left feet");
            case 17:
                return metSetText("Pé direito", "Right feet");
            default:
                return "ERROR";
        }
    }

    //-- Group 6
    private string metBodyPartInjure(int pariLanguageCode)
    {
        switch (pariLanguageCode)
        {
            case 1:
                return staticGameBusinessLogic.psColorScratches + metSetText("Arranhões e/ou pequenas contusões", "Scratches and/or minor bruises") + "</color>";
            case 2:
                return staticGameBusinessLogic.psColorSuperficialInjury + metSetText( "Ferimento superficial", "Superficial injury") + "</color>";
            case 3:
                return staticGameBusinessLogic.psColorModerateInjury + metSetText("Ferimento moderado", "Moderate injury") + "</color>";
            case 4:
                return staticGameBusinessLogic.psColorInjury + metSetText("Ferimento", "Injury") + "</color>";
            case 5:
                return staticGameBusinessLogic.psColorSeriousInjury + metSetText("Ferimento grave", "Serious injury") + "</color>";
            case 6:
                return staticGameBusinessLogic.psColorVerySeriousInjury + metSetText("Ferimento muito grave", "Very serious injury") + "</color>";
            default:
                return "ERROR";
        }
    }
}