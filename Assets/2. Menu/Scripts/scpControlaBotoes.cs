using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpControlaBotoes : MonoBehaviour
{
    public GameObject cgoBotaoNovoJogo;
    public GameObject cgoBotaoOpcoes;

    private void FixedUpdate()
    {
        cgoBotaoNovoJogo.GetComponent<Button>().interactable = (GameObject.FindGameObjectsWithTag("JanelaCriaPersonagem").GetUpperBound(0) == -1);
        cgoBotaoOpcoes.GetComponent<Button>().interactable = (GameObject.FindGameObjectsWithTag("JanelaOpcoesMenu").GetUpperBound(0) == -1);
    }
}
