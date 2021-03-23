using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpCriaBotoesAcao : MonoBehaviour
{
    const int TYPE_COMBAT = 1;
    const int TYPE_DIALOGUE = 2;

    const int MELEE_CODE = 0;
    const int FLEE_CODE = 1;
    const int HIDE_CODE = 2;

    public GameObject pobjBtnOpcoes;
    public GameObject pobjContent;
    public GameObject pobjTxtOpcoes;
    public Sprite[] pspIconesCombate;
    public Sprite[] pspIconesDialogo;
    public scpEnemyInfo pscpEnemyInfo;

    private GameObject cobjImgIcone;

    [Header("Combat Buttons")]
    private GameObject cobjMeleeButton;
    private GameObject cobjFleeButton;
    private GameObject cobjHideButton;

    private void Update()
    {
        MetGeradorBotoesCombate();
    }

    private void MetGeradorBotoesCombate()
    {
        MetCriaBotao(ref cobjMeleeButton, MELEE_CODE, 4, 1, TYPE_COMBAT);
        MetCriaBotao(ref cobjFleeButton, FLEE_CODE, 4, 2, TYPE_COMBAT);
        MetCriaBotao(ref cobjHideButton, HIDE_CODE, 4, 3, TYPE_COMBAT);
    }

    private void MetCriaBotao(ref GameObject parActionButton, int pariCodigoBotao, int pariLanguageGroup, int pariLanguageCode, int pariActionType)
    {
        if (parActionButton == null)
        {
            GameObject CloneCobjBtnOpcoes = Instantiate(pobjBtnOpcoes);
            parActionButton = CloneCobjBtnOpcoes;

            Image lImgSprite = CloneCobjBtnOpcoes.transform.Find("IconeBtn").gameObject.GetComponent<Image>();
            ScpSetTextos lscpSetTextos = CloneCobjBtnOpcoes.GetComponentInChildren<ScpSetTextos>();
            scpClickActionButton lscpClickActionButton = CloneCobjBtnOpcoes.GetComponent<scpClickActionButton>();

            //-- Set button text
            lscpSetTextos.piLanguageCode = pariLanguageCode;
            lscpSetTextos.piLanguageGroup = pariLanguageGroup;

            //-- Set Button Icon
            lImgSprite.sprite = pspIconesCombate[pariCodigoBotao];

            //-- Set Button Position
            CloneCobjBtnOpcoes.transform.GetComponent<RectTransform>().SetParent(pobjContent.gameObject.GetComponent<RectTransform>().transform);
            CloneCobjBtnOpcoes.GetComponent<RectTransform>().transform.localPosition = new Vector3(0.0f, 0.0f, 356.6f);
            CloneCobjBtnOpcoes.GetComponent<RectTransform>().transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

            //-- Set Button info
            lscpClickActionButton.plActionType = pariActionType;
            lscpClickActionButton.plActionCode = pariCodigoBotao;
            lscpClickActionButton.pscpEnemyInfo = pscpEnemyInfo;
        }
    }
}
