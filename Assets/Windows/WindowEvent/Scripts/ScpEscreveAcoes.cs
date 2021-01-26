using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpEscreveAcoes : MonoBehaviour
{
    [Multiline]
    public static string strTextBox;
    private Text TxtHistorico;

    // Start is called before the first frame update
    void Start()
    {
        TxtHistorico = this.gameObject.GetComponent<Text>();
    }
    private void FixedUpdate()
    {
        TxtHistorico.text = strTextBox;
    }

    public static void MetAdicionaLinhaDialogo(string ParNomeInimigo, string ParTexto)
    {
        strTextBox += ParNomeInimigo + ": " + ParTexto + "\n";
    }
}
