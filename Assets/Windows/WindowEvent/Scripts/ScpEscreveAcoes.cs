using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpEscreveAcoes : MonoBehaviour
{
    public GameObject pobjText;
    public GameObject pobjContent;

    private ScrollRect pscrollHistoric;

    private void Start()
    {
        pscrollHistoric = GameObject.Find("ScrollHistorico").GetComponent<ScrollRect>();
    }

    public void metDefaultText(string ParNomeInimigo, string ParTexto)
    {
        GameObject CloneOjbText = Instantiate(pobjText, pobjContent.transform);

        CloneOjbText.GetComponent<Text>().text = ParNomeInimigo + ": " + ParTexto;

        ScrollToBottom(pscrollHistoric);
    }

    public void ScrollToBottom(ScrollRect scrollRect)
    {
        Canvas.ForceUpdateCanvases();
        scrollRect.verticalScrollbar.value = 0f;
        Canvas.ForceUpdateCanvases();
        scrollRect.velocity = new Vector2(0f, 1000f);
    }
}
