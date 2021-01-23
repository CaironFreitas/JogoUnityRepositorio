using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpCriaBotoesAcao : MonoBehaviour
{

    public GameObject cobBtnOpcoes;
    public GameObject cobContent;
    public GameObject cobTxtOpcoes;
    public Sprite[] cspIconesCombate;
    public Sprite[] cspIconesDialogo;

    private GameObject cobjImgIcone;

    private string[] cstrTxtOpcoesCombate = new string[4];
    private string[] cstrTxtOpcoesDialogo = new string[4];

    void Start()
    {
        cstrTxtOpcoesCombate[0] = "Atacar";
        cstrTxtOpcoesCombate[1] = "Fugir";
        cstrTxtOpcoesCombate[2] = "Tentar esconder";
        cstrTxtOpcoesCombate[3] = "Manter escondido";

        cstrTxtOpcoesDialogo[0] = "Abordagem amigável";
        cstrTxtOpcoesDialogo[1] = "Intimidar";

        int[] liCriaOpcoesCombate = {0, 1, 2, 3};
        int[] liCriaOpcoesDialogo = { 0, 1 };

        MetGeradorBotoesCombate(liCriaOpcoesCombate);
        MetGeradorBotoesDialogo(liCriaOpcoesDialogo);
    }

    void MetGeradorBotoesCombate(int[] pariCriaOpcoes)
    {
        GameObject CloneCobjTxtOpcoes = Instantiate(cobTxtOpcoes);

        CloneCobjTxtOpcoes.transform.GetComponent<RectTransform>().SetParent(cobContent.gameObject.GetComponent<RectTransform>().transform);

        CloneCobjTxtOpcoes.GetComponent<RectTransform>().transform.localPosition = new Vector3(0.0f, 0.0f, 356.6f);
        CloneCobjTxtOpcoes.GetComponent<RectTransform>().transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        CloneCobjTxtOpcoes.GetComponent<Text>().text = "<b>Combate</b>";

        for (int llCodBotao = 0; llCodBotao <= 3; llCodBotao++)
        {
            switch (llCodBotao)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    MetCriaBotao(llCodBotao, cstrTxtOpcoesCombate, cspIconesCombate);
                    break;
            }
        }
    }

    void MetGeradorBotoesDialogo(int[] pariCriaOpcoes)
    {
        GameObject CloneCobjTxtOpcoes = Instantiate(cobTxtOpcoes);

        CloneCobjTxtOpcoes.transform.GetComponent<RectTransform>().SetParent(cobContent.gameObject.GetComponent<RectTransform>().transform);

        CloneCobjTxtOpcoes.GetComponent<RectTransform>().transform.localPosition = new Vector3(0.0f, 0.0f, 356.6f);
        CloneCobjTxtOpcoes.GetComponent<RectTransform>().transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        CloneCobjTxtOpcoes.GetComponent<Text>().text = "<b>Dialogo</b>";

        for (int llCodBotao = 0; llCodBotao <= 1; llCodBotao++)
        {
            switch (llCodBotao)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    MetCriaBotao(llCodBotao, cstrTxtOpcoesDialogo, cspIconesDialogo);
                    break;
            }
        }
    }

    void MetCriaBotao(int pariCodigoBotao, string[] parsTxtOpcoes, Sprite[] parimgIcones)
    {
        GameObject CloneCobjBtnOpcoes = Instantiate(cobBtnOpcoes);
        Text ltxtOpcao = CloneCobjBtnOpcoes.GetComponentInChildren<Text>();
        Image lImgSprite = CloneCobjBtnOpcoes.transform.Find("IconeBtn").gameObject.GetComponent<Image>();

        ltxtOpcao.text = parsTxtOpcoes[pariCodigoBotao];
        lImgSprite.sprite = parimgIcones[pariCodigoBotao];

        CloneCobjBtnOpcoes.transform.GetComponent<RectTransform>().SetParent(cobContent.gameObject.GetComponent<RectTransform>().transform);

        CloneCobjBtnOpcoes.GetComponent<RectTransform>().transform.localPosition = new Vector3(0.0f, 0.0f, 356.6f);
        CloneCobjBtnOpcoes.GetComponent<RectTransform>().transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
