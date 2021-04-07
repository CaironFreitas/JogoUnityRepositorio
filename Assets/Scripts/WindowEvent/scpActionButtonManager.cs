using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpActionButtonManager : MonoBehaviour
{

    [Header("Button type Constants")]
    const int TYPE_COMBAT = 1;
    const int TYPE_MOVE = 2;

    [Header("Combat Constants")]
    const int MELEE_CODE = 0;
    const int FLEE_CODE = 1;
    const int HIDE_CODE = 2;

    [Header("Move Constants")]
    const int SNEAK_CODE = 0;
    const int WALK_CODE = 1;
    const int RUN_CODE = 2;

    [Header("Objects to instantiate and create")]
    public GameObject pobjBtnOpcoes;
    public GameObject pobjTxtOpcoes;

    [Header("Contents")]
    public GameObject pobjContent;

    [Header("Enemy info (set by triggering event window)")]
    public scpEnemyInfo pscpEnemyInfo;

    [Header("Button sprites")]
    public Sprite[] pspIconesCombate;
    public Sprite[] pspIconesMove;

    [Header("Combat Buttons")]
    private GameObject cobjMeleeButton;
    private GameObject cobjFleeButton;
    private GameObject cobjHideButton;

    [Header("Move Buttons")]
    private GameObject cobjSneakButton;
    private GameObject cobjWalkButton;
    private GameObject cobjRunButton;

    private void Start()
    {
        pscpEnemyInfo = staticWindowEvent.pscpEnemyInfo;
    }

    private void Update()
    {
        MetCombatButtonsGenerator();
        MetMoveButtonsGenerator();
    }

    private void MetCombatButtonsGenerator()
    {
        bool lbVeryNearDistance = staticWindowEvent.plDistance > 1;

        MetCriaBotao(ref cobjMeleeButton, MELEE_CODE, 4, 1, TYPE_COMBAT, pspIconesCombate, lbVeryNearDistance);
        MetCriaBotao(ref cobjFleeButton, FLEE_CODE, 4, 2, TYPE_COMBAT, pspIconesCombate, false);
        MetCriaBotao(ref cobjHideButton, HIDE_CODE, 4, 3, TYPE_COMBAT, pspIconesCombate, false);
    }

    private void MetMoveButtonsGenerator()
    {
        bool lbVeryNearDistance = staticWindowEvent.plDistance <= 1;

        MetCriaBotao(ref cobjSneakButton, SNEAK_CODE, 8, 1, TYPE_MOVE, pspIconesMove, lbVeryNearDistance);
        MetCriaBotao(ref cobjWalkButton, WALK_CODE, 8, 2, TYPE_MOVE, pspIconesMove, lbVeryNearDistance);
        MetCriaBotao(ref cobjRunButton, RUN_CODE, 8, 3, TYPE_MOVE, pspIconesMove, lbVeryNearDistance);
    }

    private void MetCriaBotao(ref GameObject parActionButton, int pariCodigoBotao, int pariLanguageGroup, int pariLanguageCode, int pariActionType, Sprite[] parspIcones, bool parbDestroyCondition)
    {
        if (parbDestroyCondition)
        {
            if (parActionButton != null)
            {
                Destroy(parActionButton);
            }
        }
        else
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
                lImgSprite.sprite = parspIcones[pariCodigoBotao];

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
}
