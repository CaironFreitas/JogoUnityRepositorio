using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpCriaBotoesAcao : MonoBehaviour
{

    public GameObject pobjBtnOpcoes;
    public GameObject pobjContent;
    public GameObject pobjTxtOpcoes;
    public Sprite[] pspIconesCombate;
    public Sprite[] pspIconesDialogo;

    private GameObject cobjImgIcone;

    public void metStartEvent(int[] pariCombatOptions, int[] pariDialogueOptions)
    {
        if (pariCombatOptions.GetUpperBound(0) > 0)
        {
            MetGeradorBotoesCombate(pariCombatOptions);
        }

        if (pariDialogueOptions.GetUpperBound(0) > 0)
        {
            MetGeradorBotoesDialogo(pariDialogueOptions);
        }
    }

    void MetGeradorBotoesCombate(int[] pariCombatOptions)
    {
        GameObject CloneCobjTxtOpcoes = Instantiate(pobjTxtOpcoes);

        CloneCobjTxtOpcoes.transform.GetComponent<RectTransform>().SetParent(pobjContent.gameObject.GetComponent<RectTransform>().transform);

        CloneCobjTxtOpcoes.GetComponent<RectTransform>().transform.localPosition = new Vector3(0.0f, 0.0f, 356.6f);
        CloneCobjTxtOpcoes.GetComponent<RectTransform>().transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        ScpSetTextos lscpSetTextos = CloneCobjTxtOpcoes.GetComponent<ScpSetTextos>();

        lscpSetTextos.piLanguageGroup = 5;
        lscpSetTextos.piLanguageCode = 1;

        for (int llCodBotao = 0; llCodBotao <= pariCombatOptions.GetUpperBound(0); llCodBotao++)
        {
            switch (llCodBotao)
            {
                case 0:
                    MetCriaBotao(llCodBotao, pspIconesCombate, 4, 1);
                    break;
                case 1:
                    MetCriaBotao(llCodBotao, pspIconesCombate, 4, 2);
                    break;
                case 2:
                    MetCriaBotao(llCodBotao, pspIconesCombate, 4, 3);
                    break;
            }
        }
    }

    void MetGeradorBotoesDialogo(int[] pariCriaOpcoes)
    {
        GameObject CloneCobjTxtOpcoes = Instantiate(pobjTxtOpcoes);

        CloneCobjTxtOpcoes.transform.GetComponent<RectTransform>().SetParent(pobjContent.gameObject.GetComponent<RectTransform>().transform);

        CloneCobjTxtOpcoes.GetComponent<RectTransform>().transform.localPosition = new Vector3(0.0f, 0.0f, 356.6f);
        CloneCobjTxtOpcoes.GetComponent<RectTransform>().transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        ScpSetTextos lscpSetTextos = CloneCobjTxtOpcoes.GetComponent<ScpSetTextos>();

        lscpSetTextos.piLanguageGroup = 5;
        lscpSetTextos.piLanguageCode = 2;

        for (int llCodBotao = 0; llCodBotao <= 1; llCodBotao++)
        {
            /*switch (llCodBotao)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    MetCriaBotao(llCodBotao, pspIconesDialogo);
                    break;
            }*/
        }
    }

    void MetCriaBotao(int pariCodigoBotao, Sprite[] parimgIcones, int pariLanguageGroup, int pariLanguageCode)
    {
        GameObject CloneCobjBtnOpcoes = Instantiate(pobjBtnOpcoes);

        ScpSetTextos lscpSetTextos = CloneCobjBtnOpcoes.GetComponentInChildren<ScpSetTextos>();
        Image lImgSprite           = CloneCobjBtnOpcoes.transform.Find("IconeBtn").gameObject.GetComponent<Image>();

        lscpSetTextos.piLanguageCode = pariLanguageCode;
        lscpSetTextos.piLanguageGroup = pariLanguageGroup;

        lImgSprite.sprite = parimgIcones[pariCodigoBotao];

        CloneCobjBtnOpcoes.transform.GetComponent<RectTransform>().SetParent(pobjContent.gameObject.GetComponent<RectTransform>().transform);

        CloneCobjBtnOpcoes.GetComponent<RectTransform>().transform.localPosition = new Vector3(0.0f, 0.0f, 356.6f);
        CloneCobjBtnOpcoes.GetComponent<RectTransform>().transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
