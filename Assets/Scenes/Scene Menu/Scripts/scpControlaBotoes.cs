using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpControlaBotoes : MonoBehaviour
{
    public GameObject cgoBotaoNovoJogo;

    private void FixedUpdate()
    {
        cgoBotaoNovoJogo.GetComponent<Button>().interactable = (GameObject.FindGameObjectsWithTag("JanelaCriaPersonagem").GetUpperBound(0) == -1);
       
    }
}
