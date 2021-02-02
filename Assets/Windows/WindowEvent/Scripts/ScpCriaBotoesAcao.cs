using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpCriaBotoesAcao : MonoBehaviour
{
    const int TYPE_COMBAT = 1;
    const int TYPE_DIALOGUE = 2;

    public GameObject pobjBtnOpcoes;
    public GameObject pobjContent;
    public GameObject pobjTxtOpcoes;
    public Sprite[] pspIconesCombate;
    public Sprite[] pspIconesDialogo;

    private GameObject cobjImgIcone;
    private scpEnemyInfo pscpEnemyInfo;

    public void metStartEvent(scpEnemyInfo parScpEnemyInfo)
    {
        pscpEnemyInfo = parScpEnemyInfo;

        if (parScpEnemyInfo.piCombatOptions.GetUpperBound(0) > 0)
        {
            MetGeradorBotoesCombate(parScpEnemyInfo.piCombatOptions);
        }

        if (parScpEnemyInfo.piDialogueOptions.GetUpperBound(0) > 0)
        {
            MetGeradorBotoesDialogo(parScpEnemyInfo.piDialogueOptions);
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
                case 0: //-- Melee Combat
                    MetCriaBotao(llCodBotao, pspIconesCombate, 4, 1, TYPE_COMBAT);
                    break;
                case 1: //-- Flee
                    MetCriaBotao(llCodBotao, pspIconesCombate, 4, 2, TYPE_COMBAT);
                    break;
                case 2: //-- Hide
                    MetCriaBotao(llCodBotao, pspIconesCombate, 4, 3, TYPE_COMBAT);
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

    void MetCriaBotao(int pariCodigoBotao, Sprite[] parimgIcones, int pariLanguageGroup, int pariLanguageCode, int pariActionType)
    {
        GameObject CloneCobjBtnOpcoes = Instantiate(pobjBtnOpcoes);

        Image lImgSprite                           = CloneCobjBtnOpcoes.transform.Find("IconeBtn").gameObject.GetComponent<Image>();
        ScpSetTextos lscpSetTextos                 = CloneCobjBtnOpcoes.GetComponentInChildren<ScpSetTextos>();
        scpClickActionButton lscpClickActionButton = CloneCobjBtnOpcoes.GetComponent<scpClickActionButton>();

        //-- Set button text
        lscpSetTextos.piLanguageCode = pariLanguageCode;
        lscpSetTextos.piLanguageGroup = pariLanguageGroup;

        //-- Set Button Icon
        lImgSprite.sprite = parimgIcones[pariCodigoBotao];

        //-- Set Button Position
        CloneCobjBtnOpcoes.transform.GetComponent<RectTransform>().SetParent(pobjContent.gameObject.GetComponent<RectTransform>().transform);
        CloneCobjBtnOpcoes.GetComponent<RectTransform>().transform.localPosition = new Vector3(0.0f, 0.0f, 356.6f);
        CloneCobjBtnOpcoes.GetComponent<RectTransform>().transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        //-- Set Button info
        lscpClickActionButton.plActionType  = pariActionType;
        lscpClickActionButton.plActionCode  = pariCodigoBotao;
        lscpClickActionButton.pscpEnemyInfo = pscpEnemyInfo;

    }
}
