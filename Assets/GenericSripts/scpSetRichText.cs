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
                return metSetText("Mas errou o ataque ", "But missed the atack ");
            case 3:
                return metSetText("Tentou atacar! ", "Tried to attack! ");
           
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
}